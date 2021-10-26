
namespace Capa1_Presentacion.WinForms.Otros
{
    partial class FormAFPPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idafp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAfp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoAfp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procesarNominaServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCargarAfp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesarNominaServicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(51, 107);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(136, 175);
            this.buttonRegistrar.TabIndex = 0;
            this.buttonRegistrar.Text = "REGISTRAR";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idafp,
            this.nombreAfp,
            this.descuentoAfp});
            this.dataGridView1.Location = new System.Drawing.Point(409, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 175);
            this.dataGridView1.TabIndex = 1;
            // 
            // idafp
            // 
            this.idafp.HeaderText = "ID";
            this.idafp.Name = "idafp";
            this.idafp.ReadOnly = true;
            // 
            // nombreAfp
            // 
            this.nombreAfp.HeaderText = "NOMBRE";
            this.nombreAfp.Name = "nombreAfp";
            this.nombreAfp.ReadOnly = true;
            // 
            // descuentoAfp
            // 
            this.descuentoAfp.HeaderText = "DESCUENTO";
            this.descuentoAfp.Name = "descuentoAfp";
            this.descuentoAfp.ReadOnly = true;
            // 
            // procesarNominaServicioBindingSource
            // 
            this.procesarNominaServicioBindingSource.DataSource = typeof(Capa2_Aplicacion.Servicios.ProcesarNominaServicio);
            // 
            // buttonCargarAfp
            // 
            this.buttonCargarAfp.Location = new System.Drawing.Point(409, 75);
            this.buttonCargarAfp.Name = "buttonCargarAfp";
            this.buttonCargarAfp.Size = new System.Drawing.Size(124, 26);
            this.buttonCargarAfp.TabIndex = 2;
            this.buttonCargarAfp.Text = "Listar AFP";
            this.buttonCargarAfp.UseVisualStyleBackColor = true;
            this.buttonCargarAfp.Click += new System.EventHandler(this.buttonCargarAfp_Click);
            // 
            // FormAFPPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCargarAfp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRegistrar);
            this.Name = "FormAFPPrincipal";
            this.Text = "FormAFPPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesarNominaServicioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.BindingSource procesarNominaServicioBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idafp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAfp;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoAfp;
        private System.Windows.Forms.Button buttonCargarAfp;
    }
}