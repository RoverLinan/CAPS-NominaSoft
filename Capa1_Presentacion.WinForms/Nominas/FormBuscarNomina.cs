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
    public partial class FormBuscarNomina : Form
    {
        private Nomina nomina;
        private ProcesarNominaServicio procesarNominaServicio;
        private List<Nomina> listaNominas;
        public FormBuscarNomina(Nomina nomina)
        {
            this.nomina = nomina;
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.listaNominas = new List<Nomina>();

                string descripcion = textBoxDescripcionNomina.Text;
                this.listaNominas = procesarNominaServicio.buscarPorDescripcion(descripcion);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
