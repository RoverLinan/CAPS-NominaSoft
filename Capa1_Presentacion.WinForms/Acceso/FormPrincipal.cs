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
        private Usuario usuarioLocal;
        public FormPrincipal(Usuario  usuario)
        {
            InitializeComponent();
            usuarioLocal = usuario;
        }

        private void buttonEmpleado_Click(object sender, System.EventArgs e)
        {
            FormEmpleadoPrincipal formEmpleado = new FormEmpleadoPrincipal();
            formEmpleado.Show();

        }

        private void buttonContrato_Click(object sender, System.EventArgs e)
        {
            FormContratoPrincipal formContrato = new FormContratoPrincipal();
            formContrato.Show();
        }

        private void buttonNomina_Click(object sender, System.EventArgs e)
        {
            FormNominaPrincipal formNominaPrincipal = new FormNominaPrincipal();
            formNominaPrincipal.Show();

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
