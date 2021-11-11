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
        
        }

        private void cargarListaPeriodo()
        {
            listaPeriodo = periodoServicio.obtenerListaPeriodo();
            comboBoxListaPeriodo.Items.Clear();
            foreach (PeriodoDeNomina item in listaPeriodo)
            {
                comboBoxListaPeriodo.Items.Add(item.Descripcion);
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
            
            if (listaPeriodo.Count == 0)
            {
                
                buttonCerrar.Visible = false;
                buttonGuardar.Visible = false;
                buttonEliminar.Visible = false;
                MessageBox.Show(this, "No hay periodos disponibles");
            }
            else
            {
                panelSeleccionPeriodo.Visible = true;
                cargarListaPeriodo();
          

            }
        }

        private void comboBoxListaPeriodo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBoxListaPeriodo = (ComboBox)sender;

            Console.WriteLine("se cambio de selection" + comboBoxListaPeriodo.SelectedIndex);
        }
    }
}
