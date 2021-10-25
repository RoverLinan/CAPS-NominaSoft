
namespace Capa1_Presentacion.WinForms.Empleados
{
    partial class FormEmpleadoPrincipal
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
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelInfoSesion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(70, 77);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(143, 173);
            this.buttonRegistrar.TabIndex = 0;
            this.buttonRegistrar.Text = "REGISTRAR";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 173);
            this.button2.TabIndex = 1;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 173);
            this.button3.TabIndex = 2;
            this.button3.Text = "EDITAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelInfoSesion
            // 
            this.labelInfoSesion.AutoSize = true;
            this.labelInfoSesion.Location = new System.Drawing.Point(67, 22);
            this.labelInfoSesion.Name = "labelInfoSesion";
            this.labelInfoSesion.Size = new System.Drawing.Size(95, 13);
            this.labelInfoSesion.TabIndex = 3;
            this.labelInfoSesion.Text = "Informacion sesion";
            // 
            // FormEmpleadoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 351);
            this.Controls.Add(this.labelInfoSesion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonRegistrar);
            this.Name = "FormEmpleadoPrincipal";
            this.Text = "FormEmpleadoPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelInfoSesion;
    }
}