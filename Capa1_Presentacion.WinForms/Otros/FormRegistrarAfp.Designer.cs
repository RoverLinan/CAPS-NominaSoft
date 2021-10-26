namespace Capa1_Presentacion.WinForms.Otros
{
    partial class FormRegistrarAfp
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
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPorcentajeDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombreAfp = new System.Windows.Forms.TextBox();
            this.textBoxIdAfp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(151, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "REGISTRO DE AFP";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(291, 281);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(181, 281);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 17;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Porcentaje Descuento";
            // 
            // textBoxPorcentajeDescuento
            // 
            this.textBoxPorcentajeDescuento.Location = new System.Drawing.Point(128, 205);
            this.textBoxPorcentajeDescuento.Name = "textBoxPorcentajeDescuento";
            this.textBoxPorcentajeDescuento.Size = new System.Drawing.Size(238, 20);
            this.textBoxPorcentajeDescuento.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre";
            // 
            // textBoxNombreAfp
            // 
            this.textBoxNombreAfp.Location = new System.Drawing.Point(128, 152);
            this.textBoxNombreAfp.Name = "textBoxNombreAfp";
            this.textBoxNombreAfp.Size = new System.Drawing.Size(238, 20);
            this.textBoxNombreAfp.TabIndex = 20;
            // 
            // textBoxIdAfp
            // 
            this.textBoxIdAfp.Location = new System.Drawing.Point(128, 106);
            this.textBoxIdAfp.Name = "textBoxIdAfp";
            this.textBoxIdAfp.Size = new System.Drawing.Size(238, 20);
            this.textBoxIdAfp.TabIndex = 24;
            // 
            // FormRegistrarAfp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 379);
            this.Controls.Add(this.textBoxIdAfp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPorcentajeDescuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombreAfp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistrarAfp";
            this.Text = "FormRegistrarAfp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPorcentajeDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombreAfp;
        private System.Windows.Forms.TextBox textBoxIdAfp;
    }
}