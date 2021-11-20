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
        private readonly ProcesarNominaServicio procesarNominaServicio;
       
        public FormBuscarNomina()
        {
            
            procesarNominaServicio = new ProcesarNominaServicio();
            InitializeComponent();
        }
        /// <summary>
        /// REFACTORIZADO 
        /// </summary>
        public Nomina Nomina { get; set; }
        private List<Nomina> ListaNominas { get; set; }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ListaNominas = new List<Nomina>();


                string descripcionBusqueda = textBoxDescripcionNomina.Text;
                ListaNominas = procesarNominaServicio.buscarNominaPorDescripcion(descripcionBusqueda);

                dataGridViewListaNominas.Rows.Clear();
                if (ListaNominas.Count > 0)
                {
                    dataGridViewListaNominas.Rows.Add(ListaNominas.Count);
                    int rowEscribir = 0;
                    foreach (Nomina nominaItem in ListaNominas)
                    {

                        dataGridViewListaNominas.Rows[rowEscribir].Cells[0].Value = nominaItem.Nomina_id;
                        dataGridViewListaNominas.Rows[rowEscribir].Cells[1].Value = nominaItem.Descripcion;
                        dataGridViewListaNominas.Rows[rowEscribir].Cells[2].Value = nominaItem.Fecha;
                        rowEscribir++;
                    }
                }
                else
                {
                    MessageBox.Show("No hay concidencias para la DESCRIPCION: " + descripcionBusqueda);
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
                
                if(ListaNominas != null)
                {
                    foreach (Nomina nominaItem in ListaNominas)
                    {
                        if (nominaItem.Nomina_id.Equals(nomina_id))
                        {
                            Nomina = nominaItem;
                            break;
                        }
                    }

                    if (Nomina != null)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
                
                
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
         
            

        }
    }
}
