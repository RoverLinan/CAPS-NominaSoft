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
            listaPeriodo = periodoServicio.obtenerListaPeriodo();
            panelSeleccionPeriodo.Visible = true;
            cargarListaPeriodo();
        }

        private void cargarListaPeriodo()
        {

            comboBoxListaNomina.Items.Clear();
            foreach (PeriodoDeNomina item in listaPeriodo)
            {
                comboBoxListaNomina.Items.Add(item.Descripcion);
            }

        }

       
     

        private void buttonBuscarNomina_Click(object sender, EventArgs e)
        {

            FormBuscarNomina formBuscar = new FormBuscarNomina();
            formBuscar.ShowDialog();




        }

        private void buttonCrearNomina_Click(object sender, EventArgs e)
        {
            panelSeleccionPeriodo.Visible = true;
            panelInformacionNomina.Visible = false;
            if (listaPeriodo.Count == 0)
            {
                buttonCerrar.Visible = false;
                buttonGuardar.Visible = false;
                buttonEliminar.Visible = false;

            }
        }
    }
}
