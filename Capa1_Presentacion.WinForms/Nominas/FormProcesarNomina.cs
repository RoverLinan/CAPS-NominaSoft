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

namespace Capa1_Presentacion.WinForms.Nominas
{
    public partial class FormProcesarNomina : Form
    {
        private GestionarPeriodoNominaServicio periodoServicio;
        private GestionarEmpleadoServicio empleadoServicio;
        private GestionarContratoServicio contratoServicio;
        private GestionarIncidenciaLaboralServicio incidenciaLaboralServicio;
        private GestionarAfpServicio afpServicio;
        private GestionarBoletaDePagoServicio boletaDePagoServicio;


        private List<PeriodoDeNomina> listaPeriodo;
        private List<IncidenciaLaboral> listaIncidenciasLaborales;
        private List<Contrato> listaContratos;
        private List<BoletaDePago> listaBoletasDePago;
        private List<Afp> listaAfp;
        private List<Empleado> listaEmpleados;


        public FormProcesarNomina()
        {
            InitializeComponent();
            periodoServicio = new GestionarPeriodoNominaServicio();
            empleadoServicio =  new GestionarEmpleadoServicio();
            contratoServicio = new GestionarContratoServicio();
            incidenciaLaboralServicio = new GestionarIncidenciaLaboralServicio();

            panelSeleccionPeriodo.Visible = false;
            panelInformacionNomina.Visible = false;
            flowLayoutPanelPeriodo.Visible = false;
            dateTimePickerFechaInicioNomina.Enabled = false;
            buttonCerrar.Visible = false;
            buttonGuardar.Visible = false;
            buttonEliminar.Visible = false;

        }

        private void cargarListaPeriodo()
        {
            try
            {
                listaPeriodo = periodoServicio.obtenerListaPeriodo();
                comboBoxListaPeriodo.Items.Clear();
                foreach (PeriodoDeNomina item in listaPeriodo)
                {
                    comboBoxListaPeriodo.Items.Add(item.Descripcion);
                }
               comboBoxListaPeriodo.Text = listaPeriodo[0].Descripcion;
            }
            catch (Exception err)
            {

                throw err;
            }
          

        }

       
     

        private void buttonBuscarNomina_Click(object sender, EventArgs e)
        {
            Nomina nomina = null;

            FormBuscarNomina formBuscar = new FormBuscarNomina(nomina);
            formBuscar.ShowDialog();

            if(nomina != null)
            {

            }




        }

        private void buttonCrearNomina_Click(object sender, EventArgs e)
        {

            try
            {
                cargarListaPeriodo();
               
                panelSeleccionPeriodo.Visible = true;
                panelInformacionNomina.Visible = true;
              


            } 
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
          
        }

    

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBoxListaPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("se cambio de selection" + comboBoxListaPeriodo.Text);


            PeriodoDeNomina periodo = buscarPeriodo(comboBoxListaPeriodo.Text);

            flowLayoutPanelPeriodo.Visible = true;
            labelIdPeriodo.Text = periodo.Periodo_id;
            dateTimePickerFechaInicio.Value = periodo.Fechainicio;
            dateTimePickerFechaFin.Value = periodo.Fechafin;



        }



        private PeriodoDeNomina buscarPeriodo(String descripcion)
        {   
            PeriodoDeNomina periodo = null;
            foreach (PeriodoDeNomina item in listaPeriodo)
            {
                if (item.Descripcion.Equals(comboBoxListaPeriodo.Text))
                {
                    periodo = item;
                    break;
                }
            }

            return periodo;
        }

        private void buttonGenerarNomina_Click(object sender, EventArgs e)
        {

            try
            {
                Nomina nomina = new Nomina
                {
                    Descripcion = textBoxDescripcionNomina.Text.ToUpper()
                };

                PeriodoDeNomina periodoDeNomina = buscarPeriodo(comboBoxListaPeriodo.Text);
                if(periodoDeNomina != null)
                {
                    this.listaIncidenciasLaborales = incidenciaLaboralServicio.obtenerPorIdPeriodo(periodoDeNomina.Periodo_id);

                    foreach (IncidenciaLaboral item in listaIncidenciasLaborales)
                    {
                        Console.WriteLine(item.Contrato.Contrato_id + "    >>>>>>>  "  + item.Periodo.Periodo_id);
                        item.Periodo = periodoDeNomina;
                        Contrato contrato = contratoServicio.buscarPorId(item.Contrato.Contrato_id);
                        item.Contrato = contrato;
                        contrato.Incidencias.Add(item);

                        //buscamos empleado y afp

                        

                        this.listaContratos.Add(contrato);
                    }
                    

                }
           
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
           

        }

    }
}
