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
            panelIngresoHoras.Visible = false;
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
                panelIngresoHoras.Visible = true;
                cargarListaPeriodo();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void cargarListaPeriodo()
        {
            try
            {
                listaPeriodo = periodoServicio.obtenerListaPeriodo();
                comboBoxPeriodo.Items.Clear();
  
                foreach (PeriodoDeNomina item in listaPeriodo)
                {
                    comboBoxPeriodo.Items.Add(item.Descripcion);

                }
                comboBoxPeriodo.Text = listaPeriodo[0].Descripcion;
             
            }
            catch (Exception err)
            {

                throw err;
            }
           

        }

        private void buttonGuardarIncidencia_Click(object sender, EventArgs e)
        {

            
            
            try
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

                if(textBoxTotalHorasExtras.Text.Trim().Length > 0 && textBoxTotalHorasFalta.Text.Trim().Length > 0)
                {
                    
                    if (esSoloDigitos(textBoxTotalHorasFalta.Text) && esSoloDigitos(textBoxTotalHorasExtras.Text))
                    {
                        incidenciaLaboral.Totalhorasdefalta = Convert.ToInt32(textBoxTotalHorasFalta.Text);
                        incidenciaLaboral.Totalhorasextras = Convert.ToInt32(textBoxTotalHorasExtras.Text);
                        incidenciaLaboral.Contrato = this.contrato;

                        if (textBoxDniEmpleado.Text.Equals(empleado.Dni))
                        {
                            incidenciaLaboralServicio.guardar(incidenciaLaboral);
                            MessageBox.Show(this, "Se completo el registro exitoso.");
                            this.Dispose();
                        }
                        else
                        {
                            throw new Exception("DNI no coincide con el empleado que busco");
                        }

                    }
                    else
                    {
                        throw new Exception("Porfavor ingrese solo numeros");
                    }


                }
                else
                {
                    throw new Exception("Porfavor complete todos los cuadros");
                }

              
                
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Error: " + err.Message);
            }
        }

        private void buttonBuscarEmpleado_Click_1(object sender, EventArgs e)
        {
            string dni = textBoxDniEmpleado.Text.Trim();
            
            try
            {
                if (esSoloDigitos(dni))
                {
                    Empleado empleadoAux = empleadoServicio.buscarEmpleadoPorDni(dni);
                    this.empleado = empleadoAux;
                    Contrato contratoAux = contratoServicio.buscarContratoVigentePorIdEmpleado("EMP" + this.empleado.Dni);
                    this.contrato = contratoAux;
                    cargarDatosContrato();
                }
                else
                {
                    throw new Exception("Porfavor ingrese solo numeros");
                }
               
            }
            catch (Exception err)
            {

                MessageBox.Show(this, "Mensaje: " + err.Message);
            }
        }


        private bool esSoloDigitos(string cadena)
        {
            if (cadena.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }
    }
}
