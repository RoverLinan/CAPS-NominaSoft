using System.Windows.Forms;
using Capa3_Dominio.Entidades;
using Capa1_Presentacion.WinForms.Empleados;
using Capa1_Presentacion.WinForms.Contratos;

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
    }
}
