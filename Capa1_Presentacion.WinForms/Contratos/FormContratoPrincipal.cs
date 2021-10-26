﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa1_Presentacion.WinForms.Otros;

namespace Capa1_Presentacion.WinForms.Contratos
{
    public partial class FormContratoPrincipal : Form
    {
        public FormContratoPrincipal()
        {
            InitializeComponent();
        }

        private void buttonGestionar_Click(object sender, EventArgs e)
        {
            FormGestionarContrato formGestionar = new FormGestionarContrato();
            formGestionar.ShowDialog(this);
        }

        private void buttonIncidenciaLabo_Click(object sender, EventArgs e)
        {
            FormRegistrarIncidencia formRegistrarIncidencia = new FormRegistrarIncidencia();
            formRegistrarIncidencia.ShowDialog(this);
        }
    }
}
