﻿
namespace Capa1_Presentacion.WinForms.Acceso
{
    partial class FormPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNomina = new System.Windows.Forms.Button();
            this.buttonContrato = new System.Windows.Forms.Button();
            this.buttonEmpleado = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNomina);
            this.panel1.Controls.Add(this.buttonContrato);
            this.panel1.Controls.Add(this.buttonEmpleado);
            this.panel1.Location = new System.Drawing.Point(-2, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 351);
            this.panel1.TabIndex = 0;
            // 
            // buttonNomina
            // 
            this.buttonNomina.Location = new System.Drawing.Point(776, 28);
            this.buttonNomina.Name = "buttonNomina";
            this.buttonNomina.Size = new System.Drawing.Size(129, 150);
            this.buttonNomina.TabIndex = 2;
            this.buttonNomina.Text = "NOMINAS";
            this.buttonNomina.UseVisualStyleBackColor = true;
            this.buttonNomina.Click += new System.EventHandler(this.buttonNomina_Click);
            // 
            // buttonContrato
            // 
            this.buttonContrato.Location = new System.Drawing.Point(456, 28);
            this.buttonContrato.Name = "buttonContrato";
            this.buttonContrato.Size = new System.Drawing.Size(129, 150);
            this.buttonContrato.TabIndex = 1;
            this.buttonContrato.Text = "CONTRATOS";
            this.buttonContrato.UseVisualStyleBackColor = true;
            this.buttonContrato.Click += new System.EventHandler(this.buttonContrato_Click);
            // 
            // buttonEmpleado
            // 
            this.buttonEmpleado.Location = new System.Drawing.Point(120, 28);
            this.buttonEmpleado.Name = "buttonEmpleado";
            this.buttonEmpleado.Size = new System.Drawing.Size(129, 150);
            this.buttonEmpleado.TabIndex = 0;
            this.buttonEmpleado.Text = "EMPLEADOS";
            this.buttonEmpleado.UseVisualStyleBackColor = true;
            this.buttonEmpleado.Click += new System.EventHandler(this.buttonEmpleado_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNomina;
        private System.Windows.Forms.Button buttonContrato;
        private System.Windows.Forms.Button buttonEmpleado;
    }
}