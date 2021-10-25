using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa2_Aplicacion.Servicios;
using Capa3_Dominio.Entidades;

namespace Capa1_Presentacion.WinForms.Acceso
{
    public partial class FormIniciarSesion : Form
    {
        private GestionarUsuarioServicio usuarioServicio;
        public FormIniciarSesion()
        {
            InitializeComponent();
            usuarioServicio = new GestionarUsuarioServicio();
        }

        private void labelRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario formRegistrarUsuario = new FormRegistrarUsuario();
            
            formRegistrarUsuario.ShowDialog();
        
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Trim();
            string password = textPassword.Text.Trim();
            Usuario usuario  = null;
            try
            {
                usuario = usuarioServicio.iniciarSesion(username, password);
                SesionSingleton sesion = SesionSingleton.getInstance();
                sesion.SetUsuario(usuario);
                FormPrincipal formPrincipal = new FormPrincipal(usuario);
                this.Visible = false;
                formPrincipal.Show();
                
            }
            catch (Exception err)
            {
                textPassword.Text = "";
                MessageBox.Show(this,"Error de credenciales \n" + err.Message);
            }
         
            
        }
    }
}
