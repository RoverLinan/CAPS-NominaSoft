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
    public partial class FormBuscarNomina : Form
    {
        private Nomina nomina;
        private ProcesarNominaServicio procesarNominaServicio;
        private List<Nomina> listaNominas;
        public FormBuscarNomina(Nomina nomina)
        {
            this.nomina = nomina;
            procesarNominaServicio = new ProcesarNominaServicio();
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.listaNominas = new List<Nomina>();

                string descripcion = textBoxDescripcionNomina.Text;
                this.listaNominas = procesarNominaServicio.buscarNominaPorDescripcion(descripcion);

                dataGridViewListaNominas.Rows.Clear();
                dataGridViewListaNominas.Rows.Add(this.listaNominas.Count);
                int rowEscribir = 0;
                foreach (Nomina nomina in this.listaNominas)
                {

                    dataGridViewListaNominas.Rows[rowEscribir].Cells[0].Value = nomina.Nomina_id;
                    dataGridViewListaNominas.Rows[rowEscribir].Cells[1].Value = nomina.Fecha;
                    dataGridViewListaNominas.Rows[rowEscribir].Cells[2].Value = nomina.Descripcion;
                    rowEscribir++;
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void dataGridViewListaNominas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

           // string nomina_id = (string)dataGridViewListaNominas.CurrentRow.Cells[0].Value;

            this.DialogResult = DialogResult.OK;


        }
    }
}
