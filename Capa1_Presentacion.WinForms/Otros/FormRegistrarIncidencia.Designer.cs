
namespace Capa1_Presentacion.WinForms.Otros
{
    partial class FormRegistrarIncidencia
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
            this.textBoxDniEmpleado = new System.Windows.Forms.TextBox();
            this.comboBoxPeriodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTotalHorasFalta = new System.Windows.Forms.TextBox();
            this.textBoxTotalHorasExtras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelIngresoHoras = new System.Windows.Forms.Panel();
            this.buttonGuardarIncidencia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelIdContrato = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBuscarEmpleado = new System.Windows.Forms.Button();
            this.panelIngresoHoras.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDniEmpleado
            // 
            this.textBoxDniEmpleado.Location = new System.Drawing.Point(29, 37);
            this.textBoxDniEmpleado.Name = "textBoxDniEmpleado";
            this.textBoxDniEmpleado.Size = new System.Drawing.Size(175, 20);
            this.textBoxDniEmpleado.TabIndex = 0;
            // 
            // comboBoxPeriodo
            // 
            this.comboBoxPeriodo.FormattingEnabled = true;
            this.comboBoxPeriodo.Location = new System.Drawing.Point(20, 255);
            this.comboBoxPeriodo.Name = "comboBoxPeriodo";
            this.comboBoxPeriodo.Size = new System.Drawing.Size(257, 21);
            this.comboBoxPeriodo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Periodo de nomina";
            // 
            // textBoxTotalHorasFalta
            // 
            this.textBoxTotalHorasFalta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTotalHorasFalta.Location = new System.Drawing.Point(43, 342);
            this.textBoxTotalHorasFalta.Name = "textBoxTotalHorasFalta";
            this.textBoxTotalHorasFalta.Size = new System.Drawing.Size(163, 20);
            this.textBoxTotalHorasFalta.TabIndex = 4;
            // 
            // textBoxTotalHorasExtras
            // 
            this.textBoxTotalHorasExtras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTotalHorasExtras.Location = new System.Drawing.Point(43, 393);
            this.textBoxTotalHorasExtras.Name = "textBoxTotalHorasExtras";
            this.textBoxTotalHorasExtras.Size = new System.Drawing.Size(163, 20);
            this.textBoxTotalHorasExtras.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total de horas de falta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total de horas extras";
            // 
            // panelIngresoHoras
            // 
            this.panelIngresoHoras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelIngresoHoras.Controls.Add(this.buttonGuardarIncidencia);
            this.panelIngresoHoras.Controls.Add(this.textBoxTotalHorasExtras);
            this.panelIngresoHoras.Controls.Add(this.label4);
            this.panelIngresoHoras.Controls.Add(this.textBoxTotalHorasFalta);
            this.panelIngresoHoras.Controls.Add(this.panel2);
            this.panelIngresoHoras.Controls.Add(this.label3);
            this.panelIngresoHoras.Controls.Add(this.label2);
            this.panelIngresoHoras.Controls.Add(this.comboBoxPeriodo);
            this.panelIngresoHoras.Location = new System.Drawing.Point(29, 77);
            this.panelIngresoHoras.Name = "panelIngresoHoras";
            this.panelIngresoHoras.Size = new System.Drawing.Size(303, 505);
            this.panelIngresoHoras.TabIndex = 8;
            // 
            // buttonGuardarIncidencia
            // 
            this.buttonGuardarIncidencia.Location = new System.Drawing.Point(72, 460);
            this.buttonGuardarIncidencia.Name = "buttonGuardarIncidencia";
            this.buttonGuardarIncidencia.Size = new System.Drawing.Size(163, 32);
            this.buttonGuardarIncidencia.TabIndex = 8;
            this.buttonGuardarIncidencia.Text = "Guardar incidencia";
            this.buttonGuardarIncidencia.UseVisualStyleBackColor = true;
            this.buttonGuardarIncidencia.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelFecha);
            this.panel2.Controls.Add(this.labelEstado);
            this.panel2.Controls.Add(this.labelIdContrato);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(20, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 162);
            this.panel2.TabIndex = 9;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(98, 73);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(12, 18);
            this.labelFecha.TabIndex = 9;
            this.labelFecha.Text = " ";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(82, 105);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(10, 16);
            this.labelEstado.TabIndex = 8;
            this.labelEstado.Text = " ";
            // 
            // labelIdContrato
            // 
            this.labelIdContrato.AutoSize = true;
            this.labelIdContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdContrato.Location = new System.Drawing.Point(85, 33);
            this.labelIdContrato.Name = "labelIdContrato";
            this.labelIdContrato.Size = new System.Drawing.Size(12, 18);
            this.labelIdContrato.TabIndex = 6;
            this.labelIdContrato.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Contrato:";
            // 
            // buttonBuscarEmpleado
            // 
            this.buttonBuscarEmpleado.Location = new System.Drawing.Point(210, 35);
            this.buttonBuscarEmpleado.Name = "buttonBuscarEmpleado";
            this.buttonBuscarEmpleado.Size = new System.Drawing.Size(76, 23);
            this.buttonBuscarEmpleado.TabIndex = 10;
            this.buttonBuscarEmpleado.Text = "Buscar";
            this.buttonBuscarEmpleado.UseVisualStyleBackColor = true;
            this.buttonBuscarEmpleado.Click += new System.EventHandler(this.buttonBuscarEmpleado_Click_1);
            // 
            // FormRegistrarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 640);
            this.Controls.Add(this.buttonBuscarEmpleado);
            this.Controls.Add(this.panelIngresoHoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDniEmpleado);
            this.Name = "FormRegistrarIncidencia";
            this.Text = "FormRegistrarIncidencia";
            this.panelIngresoHoras.ResumeLayout(false);
            this.panelIngresoHoras.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDniEmpleado;
        private System.Windows.Forms.ComboBox comboBoxPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTotalHorasFalta;
        private System.Windows.Forms.TextBox textBoxTotalHorasExtras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelIngresoHoras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGuardarIncidencia;
        private System.Windows.Forms.Button buttonBuscarEmpleado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelIdContrato;
        private System.Windows.Forms.Label labelFecha;
    }
}