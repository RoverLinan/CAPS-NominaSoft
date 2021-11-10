namespace Capa1_Presentacion.WinForms.Nominas
{
    partial class FormBuscarNomina
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
            this.textBoxDescripcionNomina = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewListaNominas = new System.Windows.Forms.DataGridView();
            this.idNomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaNominas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDescripcionNomina
            // 
            this.textBoxDescripcionNomina.Location = new System.Drawing.Point(117, 77);
            this.textBoxDescripcionNomina.Name = "textBoxDescripcionNomina";
            this.textBoxDescripcionNomina.Size = new System.Drawing.Size(297, 20);
            this.textBoxDescripcionNomina.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(436, 75);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(145, 23);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR NOMINA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese descripción de nómina:";
            // 
            // dataGridViewListaNominas
            // 
            this.dataGridViewListaNominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaNominas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNomina,
            this.descripcion,
            this.fecha});
            this.dataGridViewListaNominas.Location = new System.Drawing.Point(81, 162);
            this.dataGridViewListaNominas.Name = "dataGridViewListaNominas";
            this.dataGridViewListaNominas.Size = new System.Drawing.Size(569, 271);
            this.dataGridViewListaNominas.TabIndex = 4;
            // 
            // idNomina
            // 
            this.idNomina.HeaderText = "ID NOMINA";
            this.idNomina.Name = "idNomina";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 300;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista de resultados";
            // 
            // FormBuscarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewListaNominas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxDescripcionNomina);
            this.Name = "FormBuscarNomina";
            this.Text = "FormBuscarNomina";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaNominas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescripcionNomina;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewListaNominas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Label label3;
    }
}