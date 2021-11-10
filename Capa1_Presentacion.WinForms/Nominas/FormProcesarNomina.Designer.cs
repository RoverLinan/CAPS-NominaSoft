
namespace Capa1_Presentacion.WinForms.Nominas
{
    partial class FormProcesarNomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxListaNomina = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonBuscarNomina = new System.Windows.Forms.Button();
            this.buttonCrearNomina = new System.Windows.Forms.Button();
            this.panelInformacionNomina = new System.Windows.Forms.Panel();
            this.textBoxTotalNetoPagar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxTotalRetenciones = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxTotalIngresos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTotalGenerados = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewListaPagos = new System.Windows.Forms.DataGridView();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIngresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRetenciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netoPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescripcionNomina = new System.Windows.Forms.TextBox();
            this.buttonGenerarNomina = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicioNomina = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSeleccionPeriodo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelIdPeriodo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panelInformacionNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPagos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelSeleccionPeriodo.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxListaNomina
            // 
            this.comboBoxListaNomina.FormattingEnabled = true;
            this.comboBoxListaNomina.Location = new System.Drawing.Point(19, 53);
            this.comboBoxListaNomina.Name = "comboBoxListaNomina";
            this.comboBoxListaNomina.Size = new System.Drawing.Size(424, 21);
            this.comboBoxListaNomina.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione un periodo de nómina";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "PROCESAR NOMINA";
            // 
            // buttonBuscarNomina
            // 
            this.buttonBuscarNomina.Location = new System.Drawing.Point(236, 72);
            this.buttonBuscarNomina.Name = "buttonBuscarNomina";
            this.buttonBuscarNomina.Size = new System.Drawing.Size(116, 23);
            this.buttonBuscarNomina.TabIndex = 22;
            this.buttonBuscarNomina.Text = "Buscar";
            this.buttonBuscarNomina.UseVisualStyleBackColor = true;
            this.buttonBuscarNomina.Click += new System.EventHandler(this.buttonBuscarNomina_Click);
            // 
            // buttonCrearNomina
            // 
            this.buttonCrearNomina.Location = new System.Drawing.Point(84, 72);
            this.buttonCrearNomina.Name = "buttonCrearNomina";
            this.buttonCrearNomina.Size = new System.Drawing.Size(116, 23);
            this.buttonCrearNomina.TabIndex = 23;
            this.buttonCrearNomina.Text = "Crear";
            this.buttonCrearNomina.UseVisualStyleBackColor = true;
            this.buttonCrearNomina.Click += new System.EventHandler(this.buttonCrearNomina_Click);
            // 
            // panelInformacionNomina
            // 
            this.panelInformacionNomina.Controls.Add(this.textBoxTotalNetoPagar);
            this.panelInformacionNomina.Controls.Add(this.label15);
            this.panelInformacionNomina.Controls.Add(this.textBoxTotalRetenciones);
            this.panelInformacionNomina.Controls.Add(this.label14);
            this.panelInformacionNomina.Controls.Add(this.textBoxTotalIngresos);
            this.panelInformacionNomina.Controls.Add(this.label13);
            this.panelInformacionNomina.Controls.Add(this.textBoxTotalGenerados);
            this.panelInformacionNomina.Controls.Add(this.label12);
            this.panelInformacionNomina.Controls.Add(this.label11);
            this.panelInformacionNomina.Controls.Add(this.dataGridViewListaPagos);
            this.panelInformacionNomina.Controls.Add(this.label1);
            this.panelInformacionNomina.Controls.Add(this.textBoxDescripcionNomina);
            this.panelInformacionNomina.Controls.Add(this.buttonGenerarNomina);
            this.panelInformacionNomina.Controls.Add(this.label3);
            this.panelInformacionNomina.Controls.Add(this.dateTimePickerFechaInicioNomina);
            this.panelInformacionNomina.Location = new System.Drawing.Point(84, 301);
            this.panelInformacionNomina.Name = "panelInformacionNomina";
            this.panelInformacionNomina.Size = new System.Drawing.Size(1021, 495);
            this.panelInformacionNomina.TabIndex = 24;
            // 
            // textBoxTotalNetoPagar
            // 
            this.textBoxTotalNetoPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalNetoPagar.Location = new System.Drawing.Point(172, 427);
            this.textBoxTotalNetoPagar.Name = "textBoxTotalNetoPagar";
            this.textBoxTotalNetoPagar.Size = new System.Drawing.Size(103, 31);
            this.textBoxTotalNetoPagar.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 436);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Total neto a pagar de nomina:";
            // 
            // textBoxTotalRetenciones
            // 
            this.textBoxTotalRetenciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalRetenciones.Location = new System.Drawing.Point(734, 377);
            this.textBoxTotalRetenciones.Name = "textBoxTotalRetenciones";
            this.textBoxTotalRetenciones.Size = new System.Drawing.Size(108, 31);
            this.textBoxTotalRetenciones.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(584, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Total retenciones de nómina:";
            // 
            // textBoxTotalIngresos
            // 
            this.textBoxTotalIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalIngresos.Location = new System.Drawing.Point(416, 377);
            this.textBoxTotalIngresos.Name = "textBoxTotalIngresos";
            this.textBoxTotalIngresos.Size = new System.Drawing.Size(108, 31);
            this.textBoxTotalIngresos.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(282, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Total ingresos de nómina:";
            // 
            // textBoxTotalGenerados
            // 
            this.textBoxTotalGenerados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalGenerados.Location = new System.Drawing.Point(142, 377);
            this.textBoxTotalGenerados.Name = "textBoxTotalGenerados";
            this.textBoxTotalGenerados.Size = new System.Drawing.Size(103, 31);
            this.textBoxTotalGenerados.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Total pagos generados:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Pagos generados";
            // 
            // dataGridViewListaPagos
            // 
            this.dataGridViewListaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.idContrato,
            this.nombresApellidos,
            this.puesto,
            this.totalIngresos,
            this.totalRetenciones,
            this.netoPagar});
            this.dataGridViewListaPagos.Location = new System.Drawing.Point(16, 137);
            this.dataGridViewListaPagos.Name = "dataGridViewListaPagos";
            this.dataGridViewListaPagos.Size = new System.Drawing.Size(983, 216);
            this.dataGridViewListaPagos.TabIndex = 4;
            // 
            // idEmpleado
            // 
            this.idEmpleado.HeaderText = "ID EMPLEADO";
            this.idEmpleado.Name = "idEmpleado";
            // 
            // idContrato
            // 
            this.idContrato.HeaderText = "ID CONTRATO";
            this.idContrato.Name = "idContrato";
            // 
            // nombresApellidos
            // 
            this.nombresApellidos.HeaderText = "NOMBRES Y APELLIDOS";
            this.nombresApellidos.Name = "nombresApellidos";
            this.nombresApellidos.Width = 300;
            // 
            // puesto
            // 
            this.puesto.HeaderText = "PUESTO";
            this.puesto.Name = "puesto";
            this.puesto.Width = 150;
            // 
            // totalIngresos
            // 
            this.totalIngresos.HeaderText = "TOTAL INGRESOS";
            this.totalIngresos.Name = "totalIngresos";
            // 
            // totalRetenciones
            // 
            this.totalRetenciones.HeaderText = "TOTAL RETENCIONES";
            this.totalRetenciones.Name = "totalRetenciones";
            // 
            // netoPagar
            // 
            this.netoPagar.HeaderText = "NETO A PAGAR";
            this.netoPagar.Name = "netoPagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción de nómina";
            // 
            // textBoxDescripcionNomina
            // 
            this.textBoxDescripcionNomina.Location = new System.Drawing.Point(17, 77);
            this.textBoxDescripcionNomina.Name = "textBoxDescripcionNomina";
            this.textBoxDescripcionNomina.Size = new System.Drawing.Size(475, 20);
            this.textBoxDescripcionNomina.TabIndex = 2;
            // 
            // buttonGenerarNomina
            // 
            this.buttonGenerarNomina.Location = new System.Drawing.Point(509, 77);
            this.buttonGenerarNomina.Name = "buttonGenerarNomina";
            this.buttonGenerarNomina.Size = new System.Drawing.Size(135, 23);
            this.buttonGenerarNomina.TabIndex = 2;
            this.buttonGenerarNomina.Text = "Generar nómina";
            this.buttonGenerarNomina.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha";
            // 
            // dateTimePickerFechaInicioNomina
            // 
            this.dateTimePickerFechaInicioNomina.Location = new System.Drawing.Point(16, 24);
            this.dateTimePickerFechaInicioNomina.Name = "dateTimePickerFechaInicioNomina";
            this.dateTimePickerFechaInicioNomina.Size = new System.Drawing.Size(273, 20);
            this.dateTimePickerFechaInicioNomina.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonCancelar);
            this.flowLayoutPanel1.Controls.Add(this.buttonGuardar);
            this.flowLayoutPanel1.Controls.Add(this.buttonCerrar);
            this.flowLayoutPanel1.Controls.Add(this.buttonEliminar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(86, 819);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1021, 32);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(943, 3);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 0;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(862, 3);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(781, 3);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 3;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(700, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Información de nómina";
            // 
            // panelSeleccionPeriodo
            // 
            this.panelSeleccionPeriodo.Controls.Add(this.label10);
            this.panelSeleccionPeriodo.Controls.Add(this.flowLayoutPanel2);
            this.panelSeleccionPeriodo.Controls.Add(this.comboBoxListaNomina);
            this.panelSeleccionPeriodo.Controls.Add(this.label2);
            this.panelSeleccionPeriodo.Location = new System.Drawing.Point(84, 145);
            this.panelSeleccionPeriodo.Name = "panelSeleccionPeriodo";
            this.panelSeleccionPeriodo.Size = new System.Drawing.Size(1017, 122);
            this.panelSeleccionPeriodo.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(461, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "---->";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(528, 10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(471, 109);
            this.flowLayoutPanel2.TabIndex = 5;
            this.flowLayoutPanel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelIdPeriodo);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 27);
            this.panel3.TabIndex = 0;
            // 
            // labelIdPeriodo
            // 
            this.labelIdPeriodo.AutoSize = true;
            this.labelIdPeriodo.Location = new System.Drawing.Point(104, 6);
            this.labelIdPeriodo.Name = "labelIdPeriodo";
            this.labelIdPeriodo.Size = new System.Drawing.Size(43, 13);
            this.labelIdPeriodo.TabIndex = 1;
            this.labelIdPeriodo.Text = "654654";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Identificador: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePickerFechaInicio);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(3, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(468, 29);
            this.panel4.TabIndex = 1;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(108, 5);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(331, 20);
            this.dateTimePickerFechaInicio.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha inicio:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dateTimePickerFechaFin);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(3, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(468, 29);
            this.panel5.TabIndex = 2;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(109, 6);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(331, 20);
            this.dateTimePickerFechaFin.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fecha fin:";
            // 
            // FormProcesarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 962);
            this.Controls.Add(this.panelSeleccionPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelInformacionNomina);
            this.Controls.Add(this.buttonCrearNomina);
            this.Controls.Add(this.buttonBuscarNomina);
            this.Controls.Add(this.label8);
            this.Name = "FormProcesarNomina";
            this.Text = "FormNominaPrincipal";
            this.panelInformacionNomina.ResumeLayout(false);
            this.panelInformacionNomina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPagos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelSeleccionPeriodo.ResumeLayout(false);
            this.panelSeleccionPeriodo.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxListaNomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonBuscarNomina;
        private System.Windows.Forms.Button buttonCrearNomina;
        private System.Windows.Forms.Panel panelInformacionNomina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicioNomina;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonGenerarNomina;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSeleccionPeriodo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelIdPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTotalNetoPagar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxTotalRetenciones;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxTotalIngresos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxTotalGenerados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewListaPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRetenciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn netoPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescripcionNomina;
        private System.Windows.Forms.Label label10;
    }
}