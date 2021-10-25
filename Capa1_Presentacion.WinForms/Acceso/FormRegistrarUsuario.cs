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

namespace Capa1_Presentacion.WinForms.Acceso
{   
    public partial class FormRegistrarUsuario : Form
    {
        private GestionarUsuarioServicio usuarioServicio;
        public FormRegistrarUsuario()
        {
            InitializeComponent();
            usuarioServicio = new GestionarUsuarioServicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = textBoxDNI.Text.Trim();
            string username = textBoxUser.Text.Trim();
            string password = textBoxPass.Text.Trim();
            string rol = textBoxRol.Text.Trim();


            if(dni.Length > 0 && username.Length > 0 && password.Length > 0)
            {
                Usuario usuario = new Usuario();
                usuario.Username = username;
                usuario.Password = password;
                usuario.FechaCreacion = DateTime.Now;
                usuario.Rol = rol;

                bool completado = false;
                try
                {
                    completado = usuarioServicio.guardar(usuario);
                    if (completado)
                    {
                        MessageBox.Show(this, "Registro completado");
                        this.Dispose();
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(this, "Error al registrar el usuario: "+ err.Message);
                }

               
               
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
