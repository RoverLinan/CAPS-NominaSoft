using System.Windows.Forms;
using Capa3_Dominio.Entidades;
using Capa1_Presentacion.WinForms.Empleados;
using Capa1_Presentacion.WinForms.Contratos;
using Capa1_Presentacion.WinForms.Nominas;
using Capa1_Presentacion.WinForms.Otros;


namespace Capa1_Presentacion.WinForms.Acceso
{
    public partial class FormPrincipal : Form
    {
        
        public FormPrincipal()
        {
            InitializeComponent();
           
        }

        private void buttonEmpleado_Click(object sender, System.EventArgs e)
        {
            FormRegistrarEmpleado form = new FormRegistrarEmpleado();
            form.ShowDialog();

        }

        private void buttonContrato_Click(object sender, System.EventArgs e)
        {
            FormRegistrarIncidencia form = new FormRegistrarIncidencia();   
            form.Show();
        }

        private void buttonNomina_Click(object sender, System.EventArgs e)
        {
            FormRegistrarPeriodoDeNomina  form = new FormRegistrarPeriodoDeNomina();
            form.Show();

        }

        private void buttonAfp_Click(object sender, System.EventArgs e)
        {
            FormAFPPrincipal formAFPPrincipal = new FormAFPPrincipal();
            formAFPPrincipal.Show();
        }

        private void buttonGestionarContrato_Click(object sender, System.EventArgs e)
        {
            FormGestionarContrato formGestionar = new FormGestionarContrato();
            formGestionar.Show(this);
        }

        private void buttonProcesarNomina_Click(object sender, System.EventArgs e)
        {
            FormProcesarNomina formProcesar = new FormProcesarNomina();
            formProcesar.Show(this);
        }
    }
}
