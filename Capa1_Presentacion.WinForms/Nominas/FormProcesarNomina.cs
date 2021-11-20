using Capa2_Aplicacion.Servicios;
using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa1_Presentacion.WinForms.Nominas
{
    public partial class FormProcesarNomina : Form
    {
        private readonly GestionarPeriodoNominaServicio periodoServicio;
        private readonly GestionarContratoServicio contratoServicio;
        private readonly ProcesarNominaServicio procesarNominaServicio;
        
      
       


        private Nomina Nomina { get; set; }
        private List<PeriodoDeNomina> ListaPeriodo { get; set; }
        private List<Contrato> ListaContratos { get; set; }





        public FormProcesarNomina()
        {
            InitializeComponent();
            periodoServicio = new GestionarPeriodoNominaServicio();
 
            contratoServicio = new GestionarContratoServicio();
   
            procesarNominaServicio = new ProcesarNominaServicio();

            panelSeleccionPeriodo.Visible = false;
            panelInformacionNomina.Visible = false;
            flowLayoutPanelPeriodo.Visible = false;
            dateTimePickerFechaInicioNomina.Enabled = false;
            dateTimePickerFechaFin.Enabled = false;
            dateTimePickerFechaInicio.Enabled = false;
            buttonCerrar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonGuardar.Enabled = false;
            buttonCancelar.Enabled = false;

        }

        private void cargarListaPeriodo()
        {
            try
            {
                ListaPeriodo = periodoServicio.obtenerListaPeriodo();
            }

            catch (Exception err)
            {

                MessageBox.Show("Atencion: " + err.Message);
            }

            if (ListaPeriodo.Count > 0)
            {
                comboBoxListaPeriodo.Items.Clear();
                foreach (PeriodoDeNomina item in ListaPeriodo)
                {
                    comboBoxListaPeriodo.Items.Add(item.Descripcion);
                }
                comboBoxListaPeriodo.Text = ListaPeriodo[0].Descripcion;
            }
            else
            {
                MessageBox.Show("No hay periodos disponibles");
            }
                

        }

       
     

        private void buttonBuscarNomina_Click(object sender, EventArgs e)
        {

            Nomina = null;
            FormBuscarNomina formBuscar = new FormBuscarNomina();

           
            if (formBuscar.ShowDialog() == DialogResult.OK)
            {
                Nomina = formBuscar.Nomina;
                cargarListaPeriodo();
                comboBoxListaPeriodo.Text = Nomina.Periodo.Descripcion.ToString();
                generarPagosBoleta();


                panelSeleccionPeriodo.Visible = true;
                panelInformacionNomina.Visible = true;
                buttonCerrar.Visible = true;
                buttonEliminar.Visible = true;
                buttonCerrar.Enabled = true;
                buttonEliminar.Enabled = true;


                buttonGenerarNomina.Enabled = false;
                buttonGuardar.Enabled = false;
                buttonCancelar.Enabled = false;
                buttonCrearNomina.Enabled = false;
                buttonBuscarNomina.Enabled = false;

                textBoxTotalGenerados.Enabled = false;
                textBoxTotalIngresos.Enabled = false;
                textBoxTotalRetenciones.Enabled = false;
                textBoxTotalNetoPagar.Enabled = false;
                textBoxDescripcionNomina.Enabled = false;
                dataGridViewListaPagos.Enabled = false;
                comboBoxListaPeriodo.Enabled = false;

            }
           




        }

        private void buttonCrearNomina_Click(object sender, EventArgs e)
        {

            try
            {
                cargarListaPeriodo();


                panelSeleccionPeriodo.Visible = true;
                panelInformacionNomina.Visible = true;
                buttonCerrar.Enabled = false;
                buttonEliminar.Enabled = false;


                buttonGenerarNomina.Enabled = true;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonCrearNomina.Enabled = false;
                buttonBuscarNomina.Enabled = false;

                textBoxTotalGenerados.Enabled = false;
                textBoxTotalIngresos.Enabled = false;
                textBoxTotalRetenciones.Enabled = false;
                textBoxTotalNetoPagar.Enabled = false;
                textBoxDescripcionNomina.Enabled = true;
                dataGridViewListaPagos.Enabled = false;
                comboBoxListaPeriodo.Enabled = true;



            } 
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
          
        }

    

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBoxListaPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            if(buscarPeriodo() != null)
            {
                PeriodoDeNomina periodo = buscarPeriodo();
                flowLayoutPanelPeriodo.Visible = true;
                labelIdPeriodo.Text = periodo.Periodo_id;
                dateTimePickerFechaInicio.Value = periodo.Fechainicio;
                dateTimePickerFechaFin.Value = periodo.Fechafin;
            }
            else
            {
                MessageBox.Show("nombre de periodo no encontrado");
            }
            
        }



        private PeriodoDeNomina buscarPeriodo()
        {
            
                PeriodoDeNomina periodo = null;
                foreach (PeriodoDeNomina item in ListaPeriodo)
                {
                    if (item.Descripcion.Equals(comboBoxListaPeriodo.Text))
                    {
                        periodo = item;
                       
                        break;
                    }
                }

                return periodo;
        }

        private void buttonGenerarNomina_Click(object sender, EventArgs e)
        {

            
                Nomina = new Nomina();
                generarNomina();
   
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Nomina.Nomina_id = "NOM" + GenerarNumeroAleatorio.ObtenerNumeroAleatorio();
                Nomina.Fecha = DateTime.Now;

               
                if(textBoxDescripcionNomina.Text.Trim().Length > 5)
                {
                    string mensaje;
                    if (Nomina.ValidarNomina(out mensaje))
                    {
                        Nomina.Descripcion = textBoxDescripcionNomina.Text.ToUpper();
                        Nomina.Cerrada = false;



                        procesarNominaServicio.guardar(Nomina);
                        MessageBox.Show("Se guardo la Nómina");

                        buttonGenerarNomina.Enabled = false;
                        buttonGuardar.Enabled = false;
                        buttonCancelar.Enabled = false;
                        buttonCrearNomina.Enabled = true;
                        buttonBuscarNomina.Enabled = true;

                        panelSeleccionPeriodo.Visible = false;
                        panelInformacionNomina.Visible = false;

                        limpiarDatosNomina();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                   
                } else
                {
                    MessageBox.Show("Porfavor ingrese una descripcion MAYOR A 5 CARACTERES");
                }
               



            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }


      

        private void generarNomina()
        {


            try
            {
                ListaContratos = contratoServicio.obtenerContratos();

                if (ListaContratos.Count > 0)
                {


                    List<Contrato> listaContratosFiltrada = ContratosFiltrados();


                    if (listaContratosFiltrada.Count > 0)
                    {
                        
                        Nomina.BoletaDePagos = CrearBoletas(listaContratosFiltrada);
                        Nomina.Periodo = buscarPeriodo();
                        //cuando se busque una nomina, se continuara desde este punto porque ya tenemos la nomina,periodo y boletas.
                        generarPagosBoleta();

                    }
                    else
                    {

                        MessageBox.Show("No hay contratos con incidencias para este periodo");
                    }


                }
                else
                {
                    MessageBox.Show("Aun no ha registrado ningun contrato en el sistema");
                }

            }
            catch (Exception err)
            {

                MessageBox.Show("Error interno: " + err.Message);
            }
            
            
            
        }


        private List<Contrato> ContratosFiltrados()
        {
            List<Contrato> listaContratosFiltrada = new List<Contrato>();
            List<IncidenciaLaboral> listaIncidenciasFiltrada;

            foreach (Contrato contrato in ListaContratos)
            {
                listaIncidenciasFiltrada = new List<IncidenciaLaboral>();
                foreach (IncidenciaLaboral incidencia in contrato.Incidencias)
                {

                    if (buscarPeriodo() != null && incidencia.Periodo.Periodo_id.Equals(buscarPeriodo().Periodo_id))
                    {
                        listaIncidenciasFiltrada.Add(incidencia);
                    }
                }

                if (listaIncidenciasFiltrada.Count > 0)
                {
                    contrato.Incidencias = listaIncidenciasFiltrada;
                    listaContratosFiltrada.Add(contrato);
                }
            }

            return listaContratosFiltrada;
        }



        private List<BoletaDePago> CrearBoletas(List<Contrato> listaContratosFiltrada)
        {
            List<BoletaDePago> boletas = new List<BoletaDePago>();
            foreach (Contrato contrato in listaContratosFiltrada)
            {

                BoletaDePago boleta = new BoletaDePago
                {
                    Contrato = contrato,
                    Nomina = Nomina
                };
                boletas.Add(boleta);

            }

            return boletas;

        }

        private void generarPagosBoleta()
        {



            dataGridViewListaPagos.Rows.Clear();
            dataGridViewListaPagos.Rows.Add(Nomina.BoletaDePagos.Count);
            int rowEscribir = 0;
            foreach (BoletaDePago boleta in Nomina.BoletaDePagos)
            {


                calcularDatosBoleta(boleta);
                dataGridViewListaPagos.Rows[rowEscribir].Cells[0].Value = boleta.Contrato.Empleado.Empleado_id;
                dataGridViewListaPagos.Rows[rowEscribir].Cells[1].Value = boleta.Contrato.Contrato_id;
                dataGridViewListaPagos.Rows[rowEscribir].Cells[2].Value = boleta.Contrato.Empleado.Nombres + " " + boleta.Contrato.Empleado.Apellidos;
                dataGridViewListaPagos.Rows[rowEscribir].Cells[3].Value = boleta.Contrato.Puesto;
                dataGridViewListaPagos.Rows[rowEscribir].Cells[4].Value = boleta.CalcularTotalIngresos().ToString();
                dataGridViewListaPagos.Rows[rowEscribir].Cells[5].Value = boleta.CalcularTotalRetenciones().ToString();
                dataGridViewListaPagos.Rows[rowEscribir].Cells[6].Value = boleta.CalcularNetoAPagar().ToString();

                rowEscribir++;
            }


            calcularTotalesNomina();


        }


        public void calcularTotalesNomina()
        {

            //generar datos nomina

            textBoxTotalGenerados.Text = Nomina.BoletaDePagos.Count.ToString();
            textBoxTotalIngresos.Text = Nomina.calcularTotalIngresosNomina().ToString();
            textBoxTotalRetenciones.Text = Nomina.calcularTotalRetencionesNomina().ToString();
            textBoxTotalNetoPagar.Text = Nomina.calcularTotalSueldoNetoNomina().ToString();

        }

        private void calcularDatosBoleta(BoletaDePago boleta)
        {
            boleta.CalcularSueldoBasico();
            boleta.CalcularMontoAsignacionFamiliar();
            boleta.CalcularMontoPorHorasExtras();
            boleta.CalcularRegimenPensionario();
            boleta.CalcularMontoHorasFalta();
          
        }



        private void limpiarDatosNomina()
        {
            dataGridViewListaPagos.Rows.Clear();
            textBoxDescripcionNomina.Text = "";
            textBoxTotalGenerados.Text = "";
            textBoxTotalIngresos.Text = "";
            textBoxTotalRetenciones.Text = "";
            textBoxTotalNetoPagar.Text = "";
            Nomina = null;

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Está seguro de cerrar la Nómina. Si cierra la Nómina no se podrán \nmodificar los pagos generados de la Nómina ni eliminar la Nómina", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    procesarNominaServicio.cerrar(Nomina);
                    limpiarDatosNomina();
                    buttonEliminar.Enabled = false;
                    buttonCerrar.Enabled = false;
                    buttonCrearNomina.Enabled = true;
                    buttonBuscarNomina.Enabled = true;
                    MessageBox.Show("Se cerró la Nómina y se podrán enviar las boletas de pago a los empleados");
                }
                
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está seguro de eliminar la Nómina. Si elimina la Nómina también de eliminaran los pagos generados de la Nómina", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (!Nomina.Cerrada)
                    {

                        procesarNominaServicio.eliminar(this.Nomina);
                        limpiarDatosNomina();
                        buttonEliminar.Enabled = false;
                        buttonCerrar.Enabled = false;

                        buttonCrearNomina.Enabled = true;
                        buttonBuscarNomina.Enabled = true;
                        MessageBox.Show("Se elimino la nomina");

                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar la nomina por estar CERRADA");
                    }

            
                }
               
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                limpiarDatosNomina();
                buttonEliminar.Enabled = false;
                buttonCerrar.Enabled = false;

                buttonCrearNomina.Enabled = true;
                buttonBuscarNomina.Enabled = true;
            }
        }
    }
}
