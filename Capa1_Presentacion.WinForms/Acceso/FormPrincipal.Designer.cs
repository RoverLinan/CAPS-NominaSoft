
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
            this.buttonAfp = new System.Windows.Forms.Button();
            this.buttonNomina = new System.Windows.Forms.Button();
            this.buttonContrato = new System.Windows.Forms.Button();
            this.buttonEmpleado = new System.Windows.Forms.Button();
            this.buttonProcesarNomina = new System.Windows.Forms.Button();
            this.buttonGestionarContrato = new System.Windows.Forms.Button();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelBienvenido);
            this.panel1.Controls.Add(this.buttonAfp);
            this.panel1.Controls.Add(this.buttonNomina);
            this.panel1.Controls.Add(this.buttonContrato);
            this.panel1.Controls.Add(this.buttonEmpleado);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 449);
            this.panel1.TabIndex = 0;
            // 
            // buttonAfp
            // 
            this.buttonAfp.BackColor = System.Drawing.Color.Transparent;
            this.buttonAfp.Location = new System.Drawing.Point(32, 259);
            this.buttonAfp.Name = "buttonAfp";
            this.buttonAfp.Size = new System.Drawing.Size(180, 33);
            this.buttonAfp.TabIndex = 3;
            this.buttonAfp.Text = "AFP";
            this.buttonAfp.UseVisualStyleBackColor = false;
            this.buttonAfp.Click += new System.EventHandler(this.buttonAfp_Click);
            // 
            // buttonNomina
            // 
            this.buttonNomina.BackColor = System.Drawing.Color.Transparent;
            this.buttonNomina.Location = new System.Drawing.Point(32, 210);
            this.buttonNomina.Name = "buttonNomina";
            this.buttonNomina.Size = new System.Drawing.Size(180, 33);
            this.buttonNomina.TabIndex = 2;
            this.buttonNomina.Text = "Registrar PERIODO NOMINA";
            this.buttonNomina.UseVisualStyleBackColor = false;
            this.buttonNomina.Click += new System.EventHandler(this.buttonNomina_Click);
            // 
            // buttonContrato
            // 
            this.buttonContrato.BackColor = System.Drawing.Color.Transparent;
            this.buttonContrato.Location = new System.Drawing.Point(32, 161);
            this.buttonContrato.Name = "buttonContrato";
            this.buttonContrato.Size = new System.Drawing.Size(180, 33);
            this.buttonContrato.TabIndex = 1;
            this.buttonContrato.Text = "Registrar INCIDENCIA";
            this.buttonContrato.UseVisualStyleBackColor = false;
            this.buttonContrato.Click += new System.EventHandler(this.buttonContrato_Click);
            // 
            // buttonEmpleado
            // 
            this.buttonEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.buttonEmpleado.Location = new System.Drawing.Point(32, 111);
            this.buttonEmpleado.Name = "buttonEmpleado";
            this.buttonEmpleado.Size = new System.Drawing.Size(180, 33);
            this.buttonEmpleado.TabIndex = 0;
            this.buttonEmpleado.Text = "Registrar EMPLEADOS";
            this.buttonEmpleado.UseVisualStyleBackColor = false;
            this.buttonEmpleado.Click += new System.EventHandler(this.buttonEmpleado_Click);
            // 
            // buttonProcesarNomina
            // 
            this.buttonProcesarNomina.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonProcesarNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcesarNomina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProcesarNomina.Location = new System.Drawing.Point(740, 245);
            this.buttonProcesarNomina.Name = "buttonProcesarNomina";
            this.buttonProcesarNomina.Size = new System.Drawing.Size(250, 77);
            this.buttonProcesarNomina.TabIndex = 5;
            this.buttonProcesarNomina.Text = "Procesar NOMINA";
            this.buttonProcesarNomina.UseVisualStyleBackColor = false;
            this.buttonProcesarNomina.Click += new System.EventHandler(this.buttonProcesarNomina_Click);
            // 
            // buttonGestionarContrato
            // 
            this.buttonGestionarContrato.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonGestionarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestionarContrato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGestionarContrato.Location = new System.Drawing.Point(740, 123);
            this.buttonGestionarContrato.Name = "buttonGestionarContrato";
            this.buttonGestionarContrato.Size = new System.Drawing.Size(250, 77);
            this.buttonGestionarContrato.TabIndex = 4;
            this.buttonGestionarContrato.Text = "Gestionar CONTRATO";
            this.buttonGestionarContrato.UseVisualStyleBackColor = false;
            this.buttonGestionarContrato.Click += new System.EventHandler(this.buttonGestionarContrato_Click);
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.Location = new System.Drawing.Point(27, 30);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(129, 25);
            this.labelBienvenido.TabIndex = 4;
            this.labelBienvenido.Text = "Bienvenido";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa1_Presentacion.WinForms.Properties.Resources.fondo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.buttonProcesarNomina);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGestionarContrato);
            this.DoubleBuffered = true;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNomina;
        private System.Windows.Forms.Button buttonContrato;
        private System.Windows.Forms.Button buttonEmpleado;
        private System.Windows.Forms.Button buttonAfp;
        private System.Windows.Forms.Button buttonProcesarNomina;
        private System.Windows.Forms.Button buttonGestionarContrato;
        private System.Windows.Forms.Label labelBienvenido;
    }
}