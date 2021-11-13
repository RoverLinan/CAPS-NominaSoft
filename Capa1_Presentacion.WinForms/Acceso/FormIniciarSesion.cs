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

       

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
          
     
            
              
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show(this);
                Visible = false;
                
            
         
            
        }
    }
}
