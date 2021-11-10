
namespace Capa1_Presentacion.WinForms.Nominas
{
    partial class FormNominaPrincipal
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
            this.buttonProcesar = new System.Windows.Forms.Button();
            this.buttonRegistrarPeriodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProcesar
            // 
            this.buttonProcesar.Location = new System.Drawing.Point(97, 119);
            this.buttonProcesar.Name = "buttonProcesar";
            this.buttonProcesar.Size = new System.Drawing.Size(109, 157);
            this.buttonProcesar.TabIndex = 0;
            this.buttonProcesar.Text = "PROCESAR";
            this.buttonProcesar.UseVisualStyleBackColor = true;
            this.buttonProcesar.Click += new System.EventHandler(this.buttonProcesar_Click);
            // 
            // buttonRegistrarPeriodo
            // 
            this.buttonRegistrarPeriodo.Location = new System.Drawing.Point(297, 119);
            this.buttonRegistrarPeriodo.Name = "buttonRegistrarPeriodo";
            this.buttonRegistrarPeriodo.Size = new System.Drawing.Size(109, 157);
            this.buttonRegistrarPeriodo.TabIndex = 1;
            this.buttonRegistrarPeriodo.Text = "REGISTRAR PERIODO";
            this.buttonRegistrarPeriodo.UseVisualStyleBackColor = true;
            this.buttonRegistrarPeriodo.Click += new System.EventHandler(this.buttonRegistrarPeriodo_Click);
            // 
            // FormNominaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRegistrarPeriodo);
            this.Controls.Add(this.buttonProcesar);
            this.Name = "FormNominaPrincipal";
            this.Text = "FormNominaPrinciapl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProcesar;
        private System.Windows.Forms.Button buttonRegistrarPeriodo;
    }
}