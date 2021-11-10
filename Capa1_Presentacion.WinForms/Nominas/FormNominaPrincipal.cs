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
    public partial class FormNominaPrincipal : Form
    {
        public FormNominaPrincipal()
        {
            InitializeComponent();
        }

        private void buttonProcesar_Click(object sender, EventArgs e)
        {
            FormProcesarNomina formProcesarNomina = new FormProcesarNomina();
            formProcesarNomina.ShowDialog(this);
        }

        private void buttonRegistrarPeriodo_Click(object sender, EventArgs e)
        {
            FormRegistrarPeriodoDeNomina formRegistrarPeriodoDeNomina = new FormRegistrarPeriodoDeNomina();
            formRegistrarPeriodoDeNomina.ShowDialog(this);
        }

    
    }
}
