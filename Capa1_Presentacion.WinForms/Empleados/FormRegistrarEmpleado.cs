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

namespace Capa1_Presentacion.WinForms.Empleados
{
    public partial class FormRegistrarEmpleado : Form
    {
        private GestionarEmpleadoServicio empleadoServicio;
        public FormRegistrarEmpleado()
        {
            InitializeComponent();
            empleadoServicio = new GestionarEmpleadoServicio();
        }

        private void buttonGuardarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombres = textBoxNombres.Text;
            empleado.Apellidos = textBoxApellidos.Text;
            empleado.Dni = textBoxDni.Text.Trim();
            empleado.Fechanacimiento = dateTimeNacimiento.Value;
            empleado.Telefono = textBoxTelefono.Text.Trim();
            empleado.Correo = textBoxCorreo.Text;
            empleado.Direccion = textBoxDireccion.Text;

            try
            {
                empleadoServicio.guardarEmpleado(empleado);
                MessageBox.Show(this, "Se completo el registro exitoso.");
                this.Dispose();
            }
            catch (Exception err)
            {

                MessageBox.Show(this, "Error: " + err.Message);
            }
           

            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
