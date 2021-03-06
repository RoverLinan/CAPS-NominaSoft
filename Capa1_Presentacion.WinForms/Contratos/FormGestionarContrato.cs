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
           


            try
            {

                if (panelGeneralInfo.Visible)
                {
                    panelGeneralInfo.Visible = false;
                }

                string dni = textBoxDniEmpleado.Text.Trim();

                if (dni.All(char.IsDigit))
                {
                    if(dni.Length == 8)
                    {
                        Empleado empleadoAux = empleadoServicio.buscarEmpleadoPorDni(dni);
                        if(empleadoAux != null)
                        {
                            this.empleado = empleadoAux;
                            cargarDatosEmpleado(empleadoAux);
                            buttonActualizar.Visible = false;
                            panelGeneralInfo.Visible = true;
                            listaAfp = afpServicio.obtenerListaAfp();
                        }
                        else
                        {
                            MessageBox.Show("No existe un empleado asociado al DNI: " + dni);
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("Atencion: El DNI debe ser de 8 caracteres " );
                    }
                  
                }
                else
                {
                    MessageBox.Show("Atencion: Solo se permiten NUMEROS en el DNI");
                }

              

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

            try
            {
                this.contrato = contratoServicio.buscarContratoVigentePorIdEmpleado(empleado.Empleado_id);
                if(this.contrato != null && this.contrato.EstaVigente())
                {
                    
                    cargarDatosContratoVigente(this.contrato);
                    panelInfoContrato.Visible = true;
                    buttonCrearContrato.Enabled = false;
                    buttonEditarContrato.Enabled = true;
                    buttonGuardarContrato.Visible = false;
                    buttonGuardarContrato.Enabled = false;
                    buttonCancelarContrato.Enabled = true;


                }
                else
                {
                    MessageBox.Show(this, "Mensaje: No tiene contratos vigentes ");
         
                    buttonCrearContrato.Enabled = true;
                    buttonEditarContrato.Enabled = false;
                    buttonCancelarContrato.Enabled = false;
                    panelInfoContrato.Visible = false;


                }
                

            }
            catch (Exception err)
            {

                MessageBox.Show(this, "Mensaje: " + err.Message);

               
            }
         
            

        }


        private void cargarDatosContratoVigente(Contrato contrato)
        {



            labelIdContrato.Text = "ID: "+ contrato.Contrato_id;
            dateTimeInicio.Value = contrato.Fechainicio;
            dateTimeFin.Value = contrato.Fechafin;
            textBoxPuesto.Text = contrato.Puesto;
            textBoxHorasSemana.Text = contrato.Horasporsemana.ToString();
            textBoxPagoHora.Text = contrato.Pagoporhora.ToString();

            if (contrato.Tieneasignacionfamiliar)
            {
                checkBoxSi.Checked = true;
            }
            else
            {
                checkBoxNo.Checked = true;
            }
            
            contrato.Afp = afpServicio.buscarAfpPorId(contrato.Afp.Afp_id);
            comboBoxAfp.Text = contrato.Afp.Nombre;


            desactivarControles();

        }

        private void buttonCrearContrato_Click(object sender, EventArgs e)
        {
            panelInfoContrato.Visible = true;
            buttonGuardarContrato.Visible = true;
            buttonGuardarContrato.Enabled = true;
            buttonActualizar.Visible = false;
            buttonActualizar.Enabled = false;
            cargarListaAfp();
            limpiarDatos();
            activarControles();
        }


     

        private void buttonGuardarContrato_Click(object sender, EventArgs e)
        {

                
          
            try
            {
                Contrato contratoAux = new Contrato();
                contratoAux.Contrato_id = "CON" + GenerarNumeroAleatorio.ObtenerNumeroAleatorio();
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

                string mensaje;
                if (validarCamposEntrada(out mensaje))
                {

                    contratoAux.Horasporsemana = int.Parse(textBoxHorasSemana.Text);
                    contratoAux.Pagoporhora = double.Parse(textBoxPagoHora.Text);
                    contratoAux.Cancelado = false;





                    
                    if (contratoAux.ValidarContrato(out mensaje))
                    {

                        contratoAux.Empleado = this.empleado;
                        contratoServicio.guardarContrato(contratoAux);

                        MessageBox.Show(this, "Contrato creado correctamente");
                        panelGeneralInfo.Visible = false;
                        this.contrato = null;
                        this.empleado = null;

                    }
                    else
                    {
                        MessageBox.Show(this, mensaje);
                    }




                }
                else
                {
                    MessageBox.Show(this, mensaje);
                }




            }
            catch (Exception err)
            {

                MessageBox.Show(this,"Mensaje: " + err.Message);
            }

        }


        private  void cargarListaAfp()
        {

            comboBoxAfp.Items.Clear();
            foreach (Afp item in listaAfp)
            {
                comboBoxAfp.Items.Add(item.Nombre);
            
            }

       
        }

        private void limpiarDatos()
        {
            labelIdContrato.Text = "";
            dateTimeInicio.Value = DateTime.Now;
            dateTimeFin.Value = DateTime.Now;
            textBoxPuesto.Text = "";
            textBoxHorasSemana.Text = "";
            textBoxPagoHora.Text = "";
            checkBoxSi.Checked = false;
            checkBoxNo.Checked = false;
            comboBoxAfp.Text = "Seleccione";
        }


        private void desactivarControles()
        {

            labelIdContrato.Enabled = false;
            dateTimeInicio.Enabled = false;
            dateTimeFin.Enabled = false;
            textBoxPuesto.Enabled = false;
            textBoxHorasSemana.Enabled = false;
            textBoxPagoHora.Enabled = false;
            checkBoxSi.Enabled = false;
            checkBoxNo.Enabled = false;
            comboBoxAfp.Enabled = false;
        }


        private void activarControles()
        {

            dateTimeInicio.Enabled = true;
            dateTimeFin.Enabled = true;
            textBoxPuesto.Enabled = true;
            textBoxHorasSemana.Enabled = true;
            textBoxPagoHora.Enabled = true;
            checkBoxSi.Enabled = true;
            checkBoxNo.Enabled = true;
            comboBoxAfp.Enabled = true;
        }

        private void checkBoxSi_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNo.Checked = false;
        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSi.Checked = false;
        }

        private void buttonCancelarContrato_Click(object sender, EventArgs e)
        {
            try
            {
                if (contrato != null)
                {
                    contratoServicio.cancelarContrato(this.contrato.Contrato_id);
                    limpiarDatos();
                    buttonCancelarContrato.Enabled = false;
                    buttonGuardarContrato.Visible = false;
                    MessageBox.Show(this, "mensaje:  contrato cancelado correctamente");
                    panelInfoContrato.Visible = false;
                    buttonCrearContrato.Enabled = true;
                    buttonEditarContrato.Enabled = false;
                }



                   
            }
            catch (Exception err)
            {
                MessageBox.Show("Atencion: " + err.Message);

            }
           


        }

        private void buttonEditarContrato_Click(object sender, EventArgs e)
        {
            activarControles();
            cargarListaAfp();
            buttonActualizar.Enabled = true;
            buttonActualizar.Visible = true;

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                Contrato contratoAux = this.contrato;
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


                string mensaje;
                if (validarCamposEntrada(out mensaje))
                {

                    contratoAux.Horasporsemana = int.Parse(textBoxHorasSemana.Text);
                    contratoAux.Pagoporhora = double.Parse(textBoxPagoHora.Text);
                    contratoAux.Cancelado = false;

                  
                    if(contratoAux.ValidarContrato(out mensaje))
                    {

                        contratoServicio.actualizarContrato(contratoAux);
                        MessageBox.Show(this, "El contrato se actualizado correctamente");
                        panelGeneralInfo.Visible = false;
                        this.contrato = null;
                        this.empleado = null;
                        limpiarDatos();
                        buttonActualizar.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show(this, mensaje);
                    }

                }
                else 
                {
                    MessageBox.Show(this, mensaje);
                }

                

            }
            catch (Exception err)
            {

                MessageBox.Show(this, "Mensaje: " + err.Message);
            }
        }

        private bool validarCamposEntrada(out String mensaje)
        {
            bool validar = true;
            mensaje = "Porfavor corriga lo siguiente: \n";
            int numeroHoras = 0;
            if (!int.TryParse(textBoxHorasSemana.Text,out numeroHoras))
            {
                validar = false;
                mensaje += "* Solo se permiten numeros y enteros en horas por semana\n";
            }

            if (!checkBoxSi.Checked && !checkBoxNo.Checked)
            {
                validar = false;
                mensaje += "* Porfavor seleccione una opcion en Asignacion Familiar\n";
            }



            double numeroPagoHora = 0;
            if (!double.TryParse(textBoxPagoHora.Text,out numeroPagoHora))
            {
               validar = false;
                mensaje += "* Solo se permiten numeros en pagos por hora\n";
            }

            if(textBoxPuesto.Text.Trim().Length < 4)
            {
               validar = false;
                mensaje += "* Porfavor ingrese un nombre de  puesto correcto";
            }

          
           
            return validar;

        }
    }
}
