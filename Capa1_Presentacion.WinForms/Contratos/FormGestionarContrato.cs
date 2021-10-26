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

namespace Capa1_Presentacion.WinForms.Contratos
{
    public partial class FormGestionarContrato : Form
    {
        private GestionarEmpleadoServicio empleadoServicio;
        public FormGestionarContrato()
        {
            InitializeComponent();
            panelGeneralInfo.Visible = false;
            empleadoServicio = new GestionarEmpleadoServicio();
        }

        private void buttonBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (panelGeneralInfo.Visible)
            {
                panelGeneralInfo.Visible = false;
            }
            string dni = textBoxDniEmpleado.Text.Trim();
            try
            {   
                
                Empleado empleado = empleadoServicio.buscarEmpleadoPorDni(dni);
                cargarDatosEmpleado(empleado);
                panelGeneralInfo.Visible = true;

            }
            catch (Exception err)
            {

                MessageBox.Show(this, "Mensaje: " + err.Message);
            }
           
        }

        private void cargarDatosEmpleado(Empleado empleado)
        {

            labelIdEmpleado.Text = empleado.Empleado_id;
            labelNombreApellidEmpleado.Text = empleado.Apellidos + ", " + empleado.Nombres;
            labelCorreoEmpleado.Text = empleado.Correo;
            labelTelefono.Text = empleado.Telefono;
            labelDirecc.Text = empleado.Direccion;
            labelFechaNac.Text = empleado.Fechanacimiento.ToShortDateString();

        }

        private void buttonCrearContrato_Click(object sender, EventArgs e)
        {
            panelInfoContrato.Visible = true;
        }


        private void cargarDatosContrato()
        {

        }
    }
}
