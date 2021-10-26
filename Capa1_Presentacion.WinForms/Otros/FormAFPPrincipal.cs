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

namespace Capa1_Presentacion.WinForms.Otros
{
    public partial class FormAFPPrincipal : Form
    {
        private GestionarAfpServicio gestionarAfpServicio;
        public FormAFPPrincipal()
        {
            InitializeComponent();
            gestionarAfpServicio = new GestionarAfpServicio();
            
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarAfp formRegistrarAfp = new FormRegistrarAfp();
            formRegistrarAfp.ShowDialog(this);
        }


        private void cargarListaAfp()
        {
            List<Afp> listaAfp;
            try
            {
                listaAfp = gestionarAfpServicio.obtenerListaAfp();
                int rowEscribir = 0;
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(listaAfp.Count);

                foreach (Afp item in listaAfp)
                {
                    dataGridView1.Rows[rowEscribir].Cells[0].Value = item.Afp_id;
                    dataGridView1.Rows[rowEscribir].Cells[1].Value = item.Nombre;
                    dataGridView1.Rows[rowEscribir].Cells[2].Value = item.Porcentajedescuento;
                    rowEscribir++;

                }
            }
            catch (Exception err)
            {

                MessageBox.Show(this, err.Message);
            }
            

           
          

        }

        private void buttonCargarAfp_Click(object sender, EventArgs e)
        {
            cargarListaAfp();
        }
    }
}
