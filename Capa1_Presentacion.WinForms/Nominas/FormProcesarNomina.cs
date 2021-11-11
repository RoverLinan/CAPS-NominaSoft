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
        private List<PeriodoDeNomina> listaPeriodo;

        public FormProcesarNomina()
        {
            InitializeComponent();
            periodoServicio = new GestionarPeriodoNominaServicio();
            panelSeleccionPeriodo.Visible = false;
            panelInformacionNomina.Visible = false;
            flowLayoutPanelPeriodo.Visible = false;

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
                if (listaPeriodo == null)
                {

                }
                else
                {
                    panelSeleccionPeriodo.Visible = true;



                }
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
    }
}
