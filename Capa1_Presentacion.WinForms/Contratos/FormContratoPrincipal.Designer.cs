
namespace Capa1_Presentacion.WinForms.Contratos
{
    partial class FormContratoPrincipal
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
            this.buttonGestionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGestionar
            // 
            this.buttonGestionar.Location = new System.Drawing.Point(94, 94);
            this.buttonGestionar.Name = "buttonGestionar";
            this.buttonGestionar.Size = new System.Drawing.Size(148, 160);
            this.buttonGestionar.TabIndex = 0;
            this.buttonGestionar.Text = "GESTIONAR";
            this.buttonGestionar.UseVisualStyleBackColor = true;
            this.buttonGestionar.Click += new System.EventHandler(this.buttonGestionar_Click);
            // 
            // FormContratoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGestionar);
            this.Name = "FormContratoPrincipal";
            this.Text = "FormContratoPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGestionar;
    }
}