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

namespace Capa1_Presentacion.WinForms.Nominas
{
    public partial class FormRegistrarPeriodoDeNomina : Form
    {

        private GestionarPeriodoNominaServicio periodoNominaServicio;
        public FormRegistrarPeriodoDeNomina()
        {
            InitializeComponent();
            periodoNominaServicio = new GestionarPeriodoNominaServicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeriodoDeNomina periodoNomina = new PeriodoDeNomina();
            periodoNomina.Descripcion = textBox1.Text;
            periodoNomina.Fechainicio = dateTimePicker1.Value;
            periodoNomina.Fechafin = dateTimePicker2.Value;

            try
            {




                periodoNominaServicio.guardarPeriodoDeNomina(periodoNomina);
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
