using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa3_Dominio.Entidades;

namespace Capa1_Presentacion.WinForms.Empleados
{
    public partial class FormEmpleadoPrincipal : Form
    {
        public FormEmpleadoPrincipal()
        {
            InitializeComponent();
            cargarDatosSesion();
        }



        private void cargarDatosSesion()
        {
            /// cargamos los datos del sigleton que se almacena al iniciar sesion
            SesionSingleton sesion = SesionSingleton.getInstance();
            Usuario usuario = sesion.GetUsuario();

            labelInfoSesion.Text = "informacion: "  + usuario.Rol + " "+ usuario.Id; 

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarEmpleado formRegistrar = new FormRegistrarEmpleado();
            formRegistrar.ShowDialog(this);
        }
    }
}
