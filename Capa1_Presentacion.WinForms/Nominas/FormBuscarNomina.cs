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
        public FormBuscarNomina()
        {
            
            procesarNominaServicio = new ProcesarNominaServicio();
            InitializeComponent();
        }

        public Nomina Nomina { get => nomina; set => nomina = value; }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.listaNominas = new List<Nomina>();

                string descripcion = textBoxDescripcionNomina.Text;
                this.listaNominas = procesarNominaServicio.buscarNominaPorDescripcion(descripcion);

                dataGridViewListaNominas.Rows.Clear();
                Console.WriteLine(" cantidad de nominas encontradas:  " + this.listaNominas.Count);
                dataGridViewListaNominas.Rows.Add(this.listaNominas.Count);
                int rowEscribir = 0;
                foreach (Nomina nomina in this.listaNominas)
                {

                    dataGridViewListaNominas.Rows[rowEscribir].Cells[0].Value = nomina.Nomina_id;
                    dataGridViewListaNominas.Rows[rowEscribir].Cells[1].Value = nomina.Descripcion;
                    dataGridViewListaNominas.Rows[rowEscribir].Cells[2].Value = nomina.Fecha;
                    rowEscribir++;
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

     

        private void dataGridViewListaNominas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string nomina_id = (string) dataGridViewListaNominas.CurrentRow.Cells[0].Value;
                
                foreach (Nomina nomina in this.listaNominas)
                {
                    if (nomina.Nomina_id.Equals(nomina_id))
                    {
                        this.Nomina = nomina;
                        Console.WriteLine(this.Nomina.Nomina_id);
                        break;
                    }
                }

                if(this.nomina != null)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else{
                    this.DialogResult = DialogResult.Cancel;
                }
                
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
         
            

        }
    }
}
