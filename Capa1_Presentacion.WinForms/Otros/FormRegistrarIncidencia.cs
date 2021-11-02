using Capa2_Aplicacion.Servicios;
using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa1_Presentacion.WinForms.Otros
{
    public partial class FormRegistrarIncidencia : Form
    {
        private GestionarPeriodoNominaServicio periodoServicio;
        private GestionarEmpleadoServicio empleadoServicio;
        private GestionarIncidenciaLaboralServicio incidenciaLaboralServicio;
        private GestionarContratoServicio contratoServicio;
        private List<PeriodoDeNomina> listaPeriodo;
        private Empleado empleado;
        private Contrato contrato;

        public FormRegistrarIncidencia()
        {
            InitializeComponent();
            periodoServicio = new GestionarPeriodoNominaServicio();
            incidenciaLaboralServicio = new GestionarIncidenciaLaboralServicio();
            empleadoServicio = new GestionarEmpleadoServicio();
            contratoServicio = new GestionarContratoServicio();
            listaPeriodo = periodoServicio.obtenerListaPeriodo();
            cargarListaPeriodo();
        }

        private void cargarDatosContrato()
        {
            try
            {
                labelIdContrato.Text = this.contrato.Contrato_id;
                if (this.contrato.EstaVigente())
                {
                    labelEstado.Text = "Vigente";
                }
                labelFecha.Text = this.contrato.Fechafin.ToShortDateString();
            }
            catch (Exception err)
            {

                MessageBox.Show(this, "Mensaje: " + err.Message);
            }
        }

        private void cargarListaPeriodo()
        {

            comboBoxPeriodo.Items.Clear();
            foreach (PeriodoDeNomina item in listaPeriodo)
            {
                comboBoxPeriodo.Items.Add(item.Descripcion);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncidenciaLaboral incidenciaLaboral = new IncidenciaLaboral();
            foreach (PeriodoDeNomina item in listaPeriodo)
            {
                if (comboBoxPeriodo.Text.Equals(item.Descripcion))
                {
                    incidenciaLaboral.Periodo = item;
                    break;
                }
            }
            incidenciaLaboral.Totalhorasdefalta = Convert.ToInt32(textBox2.Text);
            incidenciaLaboral.Totalhorasextras = Convert.ToInt32(textBox3.Text);
            incidenciaLaboral.Contrato = this.contrato;
            try
            {
                incidenciaLaboralServicio.guardar(incidenciaLaboral);
                MessageBox.Show(this, "Se completo el registro exitoso.");
                this.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Error: " + err.Message);
            }
        }

        private void buttonBuscarEmpleado_Click_1(object sender, EventArgs e)
        {
            string dni = textBox1.Text.Trim();
            try
            {

                Empleado empleadoAux = empleadoServicio.buscarEmpleadoPorDni(dni);
                this.empleado = empleadoAux;
                Contrato contratoAux = contratoServicio.buscarContratoVigentePorIdEmpleado("EMP" + this.empleado.Dni);
                this.contrato = contratoAux;
                cargarDatosContrato();
            }
            catch (Exception err)
            {

                MessageBox.Show(this, "Mensaje: " + err.Message);
            }
        }
    }
}
