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
    public partial class FormRegistrarAfp : Form
    {

        private GestionarAfpServicio afpServicio;

        public FormRegistrarAfp()
        {
            InitializeComponent();
            afpServicio = new GestionarAfpServicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Afp afp = new Afp();
            afp.Nombre = textBoxNombre.Text;
            afp.Porcentajedescuento = Convert.ToDouble(textBoxPorcentajeDescuento.Text);

            try
            {
                afpServicio.guardarAfp(afp);
                MessageBox.Show(this, "Se completo el registro exitoso.");
                this.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Error: " + err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
