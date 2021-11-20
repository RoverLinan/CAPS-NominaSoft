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
        private readonly GestionarPeriodoNominaServicio periodoServicio;
        private readonly GestionarEmpleadoServicio empleadoServicio;
        private readonly GestionarIncidenciaLaboralServicio incidenciaLaboralServicio;
        private readonly GestionarContratoServicio contratoServicio;

        private List<PeriodoDeNomina> ListaPeriodo { get; set; }
        private Empleado Empleado { get; set; }
        private Contrato Contrato { get; set; }

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
           
            labelIdContrato.Text = Contrato.Contrato_id;
            if (Contrato.EstaVigente())
            {
                labelEstado.Text = "Vigente";
            }
            labelFecha.Text = Contrato.Fechafin.ToShortDateString();
            panelIngresoHoras.Visible = true;
            cargarListaPeriodo();
           
        }

        private void cargarListaPeriodo()
        {
            try
            {
                ListaPeriodo = periodoServicio.obtenerListaPeriodo();
            }
            catch (Exception err)
            {

                MessageBox.Show("Error interno: " + err.Message);
            }

            if (ListaPeriodo.Count > 0)
            {
                comboBoxPeriodo.Items.Clear();

                foreach (PeriodoDeNomina item in ListaPeriodo)
                {
                    comboBoxPeriodo.Items.Add(item.Descripcion);

                }
                comboBoxPeriodo.Text = ListaPeriodo[0].Descripcion;

            }
            else
            {
                MessageBox.Show(this, "No hay periodos disponibles");
            }
               
             
          


        }

        private void Guardar_Click(object sender, EventArgs e)
        {

          
            
            try
            {
                IncidenciaLaboral incidenciaLaboral = new IncidenciaLaboral();


                incidenciaLaboral.Periodo = buscarPeriodo();
                string horaExtra = textBoxTotalHorasExtras.Text;
                string horaFalta = textBoxTotalHorasFalta.Text;


                if (validarDatos(horaExtra, horaFalta) && incidenciaLaboral.Periodo != null)
                {

                    incidenciaLaboral.Incidencia_id =  DateTime.Now.Millisecond * DateTime.Now.Second;
                    incidenciaLaboral.Totalhorasdefalta = Convert.ToInt32(horaExtra);
                    incidenciaLaboral.Totalhorasextras = Convert.ToInt32(horaFalta);
                    incidenciaLaboral.Contrato = Contrato;

                    if (textBoxDniEmpleado.Text.Equals(Empleado.Dni))
                    {
                        incidenciaLaboralServicio.guardar(incidenciaLaboral);
                        MessageBox.Show(this, "Se completo el registro exitoso.");
                        this.Dispose();
                    }
                    else
                    {
                     
                        MessageBox.Show(this, "* DNI no coincide con el empleado que busco");
                    }


                }
                else {

                    MessageBox.Show(this,"Porfavor ingrese datos correctos");
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Error: " + err.Message);
            }
        }




        bool validarDatos(string horaExtra, string horaFalta)
        {
            

            if ((horaExtra.Trim().Length > 0 && horaFalta.Trim().Length > 0) && (esSoloDigitos(horaExtra) && esSoloDigitos(horaFalta)))
            {
                return true;
            }

            return false; 
        }



        private void buttonBuscarEmpleado_Click_1(object sender, EventArgs e)
        {
          
            
            try
            {
                string dni = textBoxDniEmpleado.Text.Trim();
                if (esSoloDigitos(dni))
                {
                    Empleado empleadoAux = empleadoServicio.buscarEmpleadoPorDni(dni);
                    this.Empleado = empleadoAux;
                    Contrato contratoAux = contratoServicio.buscarContratoVigentePorIdEmpleado("EMP" + this.Empleado.Dni);
                    this.Contrato = contratoAux;
                    cargarDatosContrato();
                }
                else
                {
                    MessageBox.Show("Porfavor ingrese solo numeros");
                }
               
            }
            catch (Exception err)
            {

                MessageBox.Show(this, "Mensaje: " + err.Message);
            }
        }

        PeriodoDeNomina buscarPeriodo()
        {

           
            foreach (PeriodoDeNomina item in ListaPeriodo)
            {
                if (comboBoxPeriodo.Text.Equals(item.Descripcion))
                {
                    return item;
            
                }
            }
            return null;

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
