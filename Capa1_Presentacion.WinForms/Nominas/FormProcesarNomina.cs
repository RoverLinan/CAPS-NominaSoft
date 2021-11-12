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

            panelSeleccionPeriodo.Visible = false;
            panelInformacionNomina.Visible = false;
            flowLayoutPanelPeriodo.Visible = false;
            dateTimePickerFechaInicioNomina.Enabled = false;
            buttonCerrar.Visible = false;
            buttonGuardar.Visible = false;
            buttonEliminar.Visible = false;

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
            Nomina nomina = null;

            FormBuscarNomina formBuscar = new FormBuscarNomina(nomina);
            formBuscar.ShowDialog();

            if(nomina != null)
            {

            }




        }

        private void buttonCrearNomina_Click(object sender, EventArgs e)
        {

            try
            {
                cargarListaPeriodo();
               
                panelSeleccionPeriodo.Visible = true;
                panelInformacionNomina.Visible = true;
              


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
            PeriodoDeNomina periodo = null;
            foreach (PeriodoDeNomina item in listaPeriodo)
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
                this.nomina.Fecha = new DateTime();
                this.nomina.Descripcion = textBoxDescripcionNomina.Text.ToUpper();
                this.nomina.Cerrada = false;


            }
            catch (Exception)
            {

                throw;
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

                if(listaIncidenciasFiltrada.Count > 0)
                {
                    listaContratosFiltrada.Add(contrato);
                }
            }

            if(listaContratosFiltrada.Count > 0)
            {

                foreach (Contrato contrato in listaContratosFiltrada)
                {

                    BoletaDePago boleta = new BoletaDePago();
                    boleta.Contrato = contrato;
                    boleta.Nomina = this.nomina;
                    this.nomina.BoletaDePagos.Add(boleta);

                }

                this.nomina.Periodo = buscarPeriodo(comboBoxListaPeriodo.Text);

                generarPagosBoleta();

            }
            else
            {
                throw new Exception("No hay contratos con incidencias para este periodo");
            }

        }


        private void generarPagosBoleta()
        {



            dataGridViewListaPagos.Rows.Clear();
            dataGridViewListaPagos.Rows.Add(this.nomina.BoletaDePagos.Count);
            int rowEscribir = 0;
            foreach (BoletaDePago boleta in this.nomina.BoletaDePagos)
            {



                dataGridViewListaPagos.Rows[rowEscribir].Cells[0].Value = boleta.Contrato.Empleado.Empleado_id;
                dataGridViewListaPagos.Rows[rowEscribir].Cells[1].Value = boleta.Contrato.Contrato_id;
                dataGridViewListaPagos.Rows[rowEscribir].Cells[2].Value = boleta.Contrato.Empleado.Nombres + " " + boleta.Contrato.Empleado.Apellidos;
                dataGridViewListaPagos.Rows[rowEscribir].Cells[3].Value = boleta.Contrato.Puesto;
                dataGridViewListaPagos.Rows[rowEscribir].Cells[4].Value = boleta.CalcularTotalIngresos();
                dataGridViewListaPagos.Rows[rowEscribir].Cells[5].Value = boleta.CalcularTotalRetenciones();
                dataGridViewListaPagos.Rows[rowEscribir].Cells[6].Value = boleta.CalcularNetoAPagar();

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


    }
}
