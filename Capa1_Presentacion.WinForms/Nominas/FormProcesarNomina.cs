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

namespace Capa1_Presentacion.WinForms.Nominas
{
    public partial class FormProcesarNomina : Form
    {
        private GestionarPeriodoNominaServicio periodoServicio;
        private GestionarEmpleadoServicio empleadoServicio;
        private GestionarContratoServicio contratoServicio;
        private GestionarIncidenciaLaboralServicio incidenciaLaboralServicio;
        private GestionarAfpServicio afpServicio;
        private GestionarBoletaDePagoServicio boletaDePagoServicio;
        private ProcesarNominaServicio procesarNominaServicio;


        private List<PeriodoDeNomina> listaPeriodo;
        private List<IncidenciaLaboral> listaIncidenciasLaborales;
        private List<Contrato> listaContratos;
        private List<BoletaDePago> listaBoletasDePago;
        private List<Afp> listaAfp;
        private List<Empleado> listaEmpleados;


        private Nomina nomina;

        public FormProcesarNomina()
        {
            InitializeComponent();
            periodoServicio = new GestionarPeriodoNominaServicio();
            empleadoServicio =  new GestionarEmpleadoServicio();
            contratoServicio = new GestionarContratoServicio();
            incidenciaLaboralServicio = new GestionarIncidenciaLaboralServicio();
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
                listaPeriodo = periodoServicio.obtenerListaPeriodo();
                comboBoxListaPeriodo.Items.Clear();
                foreach (PeriodoDeNomina item in listaPeriodo)
                {
                    comboBoxListaPeriodo.Items.Add(item.Descripcion);
                }
               comboBoxListaPeriodo.Text = listaPeriodo[0].Descripcion;
            }
            catch (Exception err)
            {

                throw err;
            }
          

        }

       
     

        private void buttonBuscarNomina_Click(object sender, EventArgs e)
        {

            this.nomina = null;
            FormBuscarNomina formBuscar = new FormBuscarNomina();

           
            if (formBuscar.ShowDialog() == DialogResult.OK)
            {
                this.nomina = formBuscar.Nomina;
                cargarListaPeriodo();
                comboBoxListaPeriodo.Text = this.nomina.Periodo.Descripcion.ToString();
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
            Console.WriteLine("se cambio de selection" + comboBoxListaPeriodo.Text);


            PeriodoDeNomina periodo = buscarPeriodo(comboBoxListaPeriodo.Text);

            flowLayoutPanelPeriodo.Visible = true;
            labelIdPeriodo.Text = periodo.Periodo_id;
            dateTimePickerFechaInicio.Value = periodo.Fechainicio;
            dateTimePickerFechaFin.Value = periodo.Fechafin;



        }



        private PeriodoDeNomina buscarPeriodo(String descripcion)
        {
            try
            {
                PeriodoDeNomina periodo = null;
                foreach (PeriodoDeNomina item in listaPeriodo)
                {
                    if (item.Descripcion.Equals(comboBoxListaPeriodo.Text))
                    {
                        periodo = item;
                        break;
                    }
                }

                if(periodo == null)
                {
                    throw new Exception("Periodo incorrecto");
                }

                return periodo;
            }
            catch (Exception err)
            {

                throw err;
            }
           
        }

        private void buttonGenerarNomina_Click(object sender, EventArgs e)
        {

            try
            {
                this.nomina = new Nomina();
                // generarNominaMetodoUno();
                generarNominaMetodoDos();
              
           
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
           

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                this.nomina.Nomina_id = "NOM" + new Random().Next(1000, 9999);
                this.nomina.Fecha = DateTime.Now;
                if(textBoxDescripcionNomina.Text.Trim().Length < 5)
                {
                    throw new Exception("Porfavor ingrese una descripcion de nomina mayor a 5 caracteres");
                }
                this.nomina.Descripcion = textBoxDescripcionNomina.Text.ToUpper();
                this.nomina.Cerrada = false;

                procesarNominaServicio.guardar(this.nomina);
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
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }


      


        private void generarNominaMetodoUno()
        {
            

            PeriodoDeNomina periodoDeNomina = buscarPeriodo(comboBoxListaPeriodo.Text);
            this.nomina.Periodo = periodoDeNomina;



            if (periodoDeNomina != null)
            {
                this.listaIncidenciasLaborales = incidenciaLaboralServicio.obtenerPorIdPeriodo(periodoDeNomina.Periodo_id);

                if (this.listaIncidenciasLaborales.Count > 0)
                {

                    foreach (IncidenciaLaboral item in listaIncidenciasLaborales)
                    {

                        // buscamos contrato para asignarle la incidencia
                        item.Periodo = periodoDeNomina;
                        Contrato contrato = contratoServicio.buscarPorId(item.Contrato.Contrato_id);
                        item.Contrato = contrato;
                        contrato.Incidencias.Add(item);

                        //buscamos empleado y afp
                        Empleado empleado = empleadoServicio.buscarEmpleadoPorId(contrato.Empleado.Empleado_id);
                        Afp afp = afpServicio.buscarAfpPorId(contrato.Afp.Afp_id);

                        contrato.Afp = afp;
                        contrato.Empleado = empleado;

                        this.listaContratos.Add(contrato);

                        BoletaDePago boletaDePago = new BoletaDePago();
                        boletaDePago.Contrato = contrato;
                        boletaDePago.Nomina = this.nomina;


                        // agregamos la boleta a la nomina para hacer los calculos
                        nomina.BoletaDePagos.Add(boletaDePago);

                    }


                }
                else
                {
                    throw new Exception("No existen incidencias para este periodo");
                }

            }
        }

        private void generarNominaMetodoDos()
        {
            this.listaContratos = contratoServicio.obtenerContratos();

            try
            {

                List<Contrato> listaContratosFiltrada = new List<Contrato>();
                List<IncidenciaLaboral> listaIncidenciasFiltrada;

                foreach (Contrato contrato in this.listaContratos)
                {
                    listaIncidenciasFiltrada = new List<IncidenciaLaboral>();
                    foreach (IncidenciaLaboral incidencia in contrato.Incidencias)
                    {

                        if (incidencia.Periodo.Periodo_id.Equals(buscarPeriodo(comboBoxListaPeriodo.Text).Periodo_id))
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

                if (listaContratosFiltrada.Count > 0)
                {

                    foreach (Contrato contrato in listaContratosFiltrada)
                    {

                        BoletaDePago boleta = new BoletaDePago();
                        boleta.Contrato = contrato;
                        boleta.Nomina = this.nomina;
                        this.nomina.BoletaDePagos.Add(boleta);

                    }

                    this.nomina.Periodo = buscarPeriodo(comboBoxListaPeriodo.Text);
                    //cuando se busque una nomina, se continuara desde este punto porque ya tenemos la nomina,periodo y boletas.
                    generarPagosBoleta();

                }
                else
                {
                    throw new Exception("No hay contratos con incidencias para este periodo");
                }


            }
            catch (Exception err)
            {

                throw err;
            }
            

        }


        private void generarPagosBoleta()
        {



            dataGridViewListaPagos.Rows.Clear();
            dataGridViewListaPagos.Rows.Add(this.nomina.BoletaDePagos.Count);
            int rowEscribir = 0;
            foreach (BoletaDePago boleta in this.nomina.BoletaDePagos)
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

            textBoxTotalGenerados.Text = this.nomina.BoletaDePagos.Count.ToString();
            textBoxTotalIngresos.Text = this.nomina.calcularTotalIngresosNomina().ToString();
            textBoxTotalRetenciones.Text = this.nomina.calcularTotalRetencionesNomina().ToString();
            textBoxTotalNetoPagar.Text = this.nomina.calcularTotalSueldoNetoNomina().ToString();

        }

        private void calcularDatosBoleta(BoletaDePago boleta)
        {
            boleta.CalcularSueldoBasico();
            boleta.CalcularMontoAsignacionFamiliar();
            boleta.CalcularMontoPorHorasExtras();
            boleta.CalcularRegimenPensionario();
            boleta.CalcularMontoHorasFalta();
          
        }




        private void cargarDatosDeNominaBuscada()
        {

            








        }

        private void limpiarDatosNomina()
        {
            dataGridViewListaPagos.Rows.Clear();
            textBoxDescripcionNomina.Text = "";
            textBoxTotalGenerados.Text = "";
            textBoxTotalIngresos.Text = "";
            textBoxTotalRetenciones.Text = "";
            textBoxTotalNetoPagar.Text = "";
            this.nomina = null;

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Está seguro de cerrar la Nómina. Si cierra la Nómina no se podrán \nmodificar los pagos generados de la Nómina ni eliminar la Nómina", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    procesarNominaServicio.cerrar(this.nomina);
                    limpiarDatosNomina();
                    buttonEliminar.Enabled = false;
                    buttonCerrar.Enabled = false;
                    buttonCrearNomina.Enabled = true;
                    buttonBuscarNomina.Enabled = true;
                    MessageBox.Show("Se cerró la Nómina y se podrán enviar las boletas de pago a los empleados");
                }
                else
                {
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

                    procesarNominaServicio.eliminar(this.nomina);
                    limpiarDatosNomina();
                    buttonEliminar.Enabled = false;
                    buttonCerrar.Enabled = false;

                    buttonCrearNomina.Enabled = true;
                    buttonBuscarNomina.Enabled = true;
                    MessageBox.Show("Se elimino la nomina");
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
