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
        private GestionarContratoServicio contratoServicio;
        private GestionarEmpleadoServicio empleadoServicio;
        private GestionarAfpServicio afpServicio;
        private List<Afp> listaAfp;
        private Empleado empleado;
        private Contrato contrato;
        public FormGestionarContrato()
        {
            InitializeComponent();
            panelGeneralInfo.Visible = false;
            empleadoServicio = new GestionarEmpleadoServicio();
            contratoServicio = new GestionarContratoServicio();
            afpServicio = new GestionarAfpServicio();
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
                
                Empleado empleadoAux = empleadoServicio.buscarEmpleadoPorDni(dni);
                this.empleado = empleadoAux;
                cargarDatosEmpleado(empleadoAux);
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
            buttonGuardarContrato.Visible = true;
            cargarListaAfp();
        }


        private void cargarDatosContrato()
        {

        }

        private void buttonGuardarContrato_Click(object sender, EventArgs e)
        {

                
          
            try
            {
                Contrato contratoAux = new Contrato();
                contratoAux.Fechainicio = dateTimeInicio.Value;
                contratoAux.Fechafin = dateTimeFin.Value;
                contratoAux.Puesto = textBoxPuesto.Text;

                foreach (Afp item in listaAfp)
                {
                    if (comboBoxAfp.Text.Equals(item.Nombre))
                    {
                        contratoAux.Afp = item;
                        break;
                    }
                }

                if (checkBoxSi.Checked)
                {
                    contratoAux.Tieneasignacionfamiliar = true;
                }
                if (checkBoxNo.Checked)
                {
                    contratoAux.Tieneasignacionfamiliar = false;
                }

                contratoAux.Horasporsemana = int.Parse(textBoxHorasSemana.Text);
                contratoAux.Pagoporhora = double.Parse(textBoxHorasSemana.Text);

                contratoServicio.guardarContrato(contratoAux, this.empleado, contratoAux.Afp);

            }
            catch (Exception err)
            {

                MessageBox.Show(this,"Mensaje: " + err.Message);
            }

        }


        private  void cargarListaAfp()
        {
            listaAfp = afpServicio.obtenerListaAfp();

            
           
            foreach (Afp item in listaAfp)
            {
                comboBoxAfp.Items.Add(item.Nombre);
            
            }

       
        }

        private void checkBoxSi_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNo.Checked = false;
        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSi.Checked = false;
        }
    }
}
