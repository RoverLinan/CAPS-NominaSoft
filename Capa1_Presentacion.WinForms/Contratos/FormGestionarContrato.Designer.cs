
namespace Capa1_Presentacion.WinForms.Contratos
{
    partial class FormGestionarContrato
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarEmpleado = new System.Windows.Forms.Button();
            this.panelInfoEmpleado = new System.Windows.Forms.Panel();
            this.labelDirecc = new System.Windows.Forms.Label();
            this.labelFechaNac = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelCorreoEmpleado = new System.Windows.Forms.Label();
            this.labelNombreApellidEmpleado = new System.Windows.Forms.Label();
            this.labelIdEmpleado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelInfoContrato = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxPagoHora = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxHorasSemana = new System.Windows.Forms.TextBox();
            this.checkBoxSi = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxAfp = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPuesto = new System.Windows.Forms.TextBox();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCrearContrato = new System.Windows.Forms.Button();
            this.buttonEditarContrato = new System.Windows.Forms.Button();
            this.buttonCancelarContrato = new System.Windows.Forms.Button();
            this.buttonGuardarContrato = new System.Windows.Forms.Button();
            this.panelGeneralInfo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxNo = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInfoEmpleado.SuspendLayout();
            this.panelInfoContrato.SuspendLayout();
            this.panelGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDniEmpleado
            // 
            this.textBoxDniEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDniEmpleado.Location = new System.Drawing.Point(33, 47);
            this.textBoxDniEmpleado.Name = "textBoxDniEmpleado";
            this.textBoxDniEmpleado.Size = new System.Drawing.Size(200, 26);
            this.textBoxDniEmpleado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI del empleado";
            // 
            // buttonBuscarEmpleado
            // 
            this.buttonBuscarEmpleado.Location = new System.Drawing.Point(245, 48);
            this.buttonBuscarEmpleado.Name = "buttonBuscarEmpleado";
            this.buttonBuscarEmpleado.Size = new System.Drawing.Size(116, 23);
            this.buttonBuscarEmpleado.TabIndex = 2;
            this.buttonBuscarEmpleado.Text = "Buscar";
            this.buttonBuscarEmpleado.UseVisualStyleBackColor = true;
            this.buttonBuscarEmpleado.Click += new System.EventHandler(this.buttonBuscarEmpleado_Click);
            // 
            // panelInfoEmpleado
            // 
            this.panelInfoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfoEmpleado.Controls.Add(this.pictureBox1);
            this.panelInfoEmpleado.Controls.Add(this.label8);
            this.panelInfoEmpleado.Controls.Add(this.label7);
            this.panelInfoEmpleado.Controls.Add(this.label6);
            this.panelInfoEmpleado.Controls.Add(this.label5);
            this.panelInfoEmpleado.Controls.Add(this.labelDirecc);
            this.panelInfoEmpleado.Controls.Add(this.labelFechaNac);
            this.panelInfoEmpleado.Controls.Add(this.label10);
            this.panelInfoEmpleado.Controls.Add(this.labelTelefono);
            this.panelInfoEmpleado.Controls.Add(this.labelCorreoEmpleado);
            this.panelInfoEmpleado.Controls.Add(this.labelNombreApellidEmpleado);
            this.panelInfoEmpleado.Controls.Add(this.labelIdEmpleado);
            this.panelInfoEmpleado.Controls.Add(this.label4);
            this.panelInfoEmpleado.Location = new System.Drawing.Point(36, 72);
            this.panelInfoEmpleado.Name = "panelInfoEmpleado";
            this.panelInfoEmpleado.Size = new System.Drawing.Size(435, 385);
            this.panelInfoEmpleado.TabIndex = 3;
            // 
            // labelDirecc
            // 
            this.labelDirecc.AutoSize = true;
            this.labelDirecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirecc.Location = new System.Drawing.Point(154, 291);
            this.labelDirecc.Name = "labelDirecc";
            this.labelDirecc.Size = new System.Drawing.Size(207, 16);
            this.labelDirecc.TabIndex = 10;
            this.labelDirecc.Text = "Jr. San fracisco. Mz N San andres";
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaNac.Location = new System.Drawing.Point(152, 314);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(80, 18);
            this.labelFechaNac.TabIndex = 8;
            this.labelFechaNac.Text = "25/05/1996";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Fecha nacimiento:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(154, 265);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(78, 16);
            this.labelTelefono.TabIndex = 6;
            this.labelTelefono.Text = "9760578722";
            // 
            // labelCorreoEmpleado
            // 
            this.labelCorreoEmpleado.AutoSize = true;
            this.labelCorreoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoEmpleado.Location = new System.Drawing.Point(154, 236);
            this.labelCorreoEmpleado.Name = "labelCorreoEmpleado";
            this.labelCorreoEmpleado.Size = new System.Drawing.Size(114, 16);
            this.labelCorreoEmpleado.TabIndex = 5;
            this.labelCorreoEmpleado.Text = "roverlb@live.com";
            // 
            // labelNombreApellidEmpleado
            // 
            this.labelNombreApellidEmpleado.AutoSize = true;
            this.labelNombreApellidEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreApellidEmpleado.Location = new System.Drawing.Point(153, 209);
            this.labelNombreApellidEmpleado.Name = "labelNombreApellidEmpleado";
            this.labelNombreApellidEmpleado.Size = new System.Drawing.Size(178, 24);
            this.labelNombreApellidEmpleado.TabIndex = 3;
            this.labelNombreApellidEmpleado.Text = "Roger Liñan Burgos";
            // 
            // labelIdEmpleado
            // 
            this.labelIdEmpleado.AutoSize = true;
            this.labelIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdEmpleado.Location = new System.Drawing.Point(154, 187);
            this.labelIdEmpleado.Name = "labelIdEmpleado";
            this.labelIdEmpleado.Size = new System.Drawing.Size(48, 18);
            this.labelIdEmpleado.TabIndex = 1;
            this.labelIdEmpleado.Text = "16546";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // panelInfoContrato
            // 
            this.panelInfoContrato.Controls.Add(this.label9);
            this.panelInfoContrato.Controls.Add(this.buttonGuardarContrato);
            this.panelInfoContrato.Controls.Add(this.checkBoxNo);
            this.panelInfoContrato.Controls.Add(this.label18);
            this.panelInfoContrato.Controls.Add(this.label17);
            this.panelInfoContrato.Controls.Add(this.textBoxPagoHora);
            this.panelInfoContrato.Controls.Add(this.label16);
            this.panelInfoContrato.Controls.Add(this.textBoxHorasSemana);
            this.panelInfoContrato.Controls.Add(this.checkBoxSi);
            this.panelInfoContrato.Controls.Add(this.label15);
            this.panelInfoContrato.Controls.Add(this.comboBoxAfp);
            this.panelInfoContrato.Controls.Add(this.label14);
            this.panelInfoContrato.Controls.Add(this.textBoxPuesto);
            this.panelInfoContrato.Controls.Add(this.dateTimeFin);
            this.panelInfoContrato.Controls.Add(this.label13);
            this.panelInfoContrato.Controls.Add(this.dateTimeInicio);
            this.panelInfoContrato.Controls.Add(this.label11);
            this.panelInfoContrato.Location = new System.Drawing.Point(600, 105);
            this.panelInfoContrato.Name = "panelInfoContrato";
            this.panelInfoContrato.Size = new System.Drawing.Size(470, 352);
            this.panelInfoContrato.TabIndex = 4;
            this.panelInfoContrato.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(26, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "ID: 545";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(256, 212);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Pago por hora";
            // 
            // textBoxPagoHora
            // 
            this.textBoxPagoHora.Location = new System.Drawing.Point(258, 228);
            this.textBoxPagoHora.Name = "textBoxPagoHora";
            this.textBoxPagoHora.Size = new System.Drawing.Size(121, 20);
            this.textBoxPagoHora.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Horas contratas por semana";
            // 
            // textBoxHorasSemana
            // 
            this.textBoxHorasSemana.Location = new System.Drawing.Point(27, 228);
            this.textBoxHorasSemana.Name = "textBoxHorasSemana";
            this.textBoxHorasSemana.Size = new System.Drawing.Size(192, 20);
            this.textBoxHorasSemana.TabIndex = 10;
            // 
            // checkBoxSi
            // 
            this.checkBoxSi.AutoSize = true;
            this.checkBoxSi.Location = new System.Drawing.Point(27, 178);
            this.checkBoxSi.Name = "checkBoxSi";
            this.checkBoxSi.Size = new System.Drawing.Size(35, 17);
            this.checkBoxSi.TabIndex = 9;
            this.checkBoxSi.Text = "Si";
            this.checkBoxSi.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(256, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "AFP";
            // 
            // comboBoxAfp
            // 
            this.comboBoxAfp.FormattingEnabled = true;
            this.comboBoxAfp.Location = new System.Drawing.Point(259, 123);
            this.comboBoxAfp.Name = "comboBoxAfp";
            this.comboBoxAfp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAfp.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Puesto";
            // 
            // textBoxPuesto
            // 
            this.textBoxPuesto.Location = new System.Drawing.Point(27, 125);
            this.textBoxPuesto.Name = "textBoxPuesto";
            this.textBoxPuesto.Size = new System.Drawing.Size(192, 20);
            this.textBoxPuesto.TabIndex = 5;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(258, 72);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFin.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Fecha fin";
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(27, 72);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(192, 20);
            this.dateTimeInicio.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fecha inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Información del empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contrato";
            // 
            // buttonCrearContrato
            // 
            this.buttonCrearContrato.Location = new System.Drawing.Point(627, 72);
            this.buttonCrearContrato.Name = "buttonCrearContrato";
            this.buttonCrearContrato.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearContrato.TabIndex = 7;
            this.buttonCrearContrato.Text = "Crear";
            this.buttonCrearContrato.UseVisualStyleBackColor = true;
            this.buttonCrearContrato.Click += new System.EventHandler(this.buttonCrearContrato_Click);
            // 
            // buttonEditarContrato
            // 
            this.buttonEditarContrato.Enabled = false;
            this.buttonEditarContrato.Location = new System.Drawing.Point(805, 72);
            this.buttonEditarContrato.Name = "buttonEditarContrato";
            this.buttonEditarContrato.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarContrato.TabIndex = 8;
            this.buttonEditarContrato.Text = "Editar";
            this.buttonEditarContrato.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarContrato
            // 
            this.buttonCancelarContrato.Enabled = false;
            this.buttonCancelarContrato.Location = new System.Drawing.Point(980, 72);
            this.buttonCancelarContrato.Name = "buttonCancelarContrato";
            this.buttonCancelarContrato.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarContrato.TabIndex = 9;
            this.buttonCancelarContrato.Text = "Cancelar";
            this.buttonCancelarContrato.UseVisualStyleBackColor = true;
            // 
            // buttonGuardarContrato
            // 
            this.buttonGuardarContrato.Location = new System.Drawing.Point(333, 322);
            this.buttonGuardarContrato.Name = "buttonGuardarContrato";
            this.buttonGuardarContrato.Size = new System.Drawing.Size(122, 23);
            this.buttonGuardarContrato.TabIndex = 10;
            this.buttonGuardarContrato.Text = "Guardar";
            this.buttonGuardarContrato.UseVisualStyleBackColor = true;
            this.buttonGuardarContrato.Visible = false;
            // 
            // panelGeneralInfo
            // 
            this.panelGeneralInfo.Controls.Add(this.label2);
            this.panelGeneralInfo.Controls.Add(this.panelInfoEmpleado);
            this.panelGeneralInfo.Controls.Add(this.buttonCancelarContrato);
            this.panelGeneralInfo.Controls.Add(this.panelInfoContrato);
            this.panelGeneralInfo.Controls.Add(this.label3);
            this.panelGeneralInfo.Controls.Add(this.buttonCrearContrato);
            this.panelGeneralInfo.Controls.Add(this.buttonEditarContrato);
            this.panelGeneralInfo.Location = new System.Drawing.Point(33, 107);
            this.panelGeneralInfo.Name = "panelGeneralInfo";
            this.panelGeneralInfo.Size = new System.Drawing.Size(1160, 516);
            this.panelGeneralInfo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombres/Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dirección:";
            // 
            // checkBoxNo
            // 
            this.checkBoxNo.AutoSize = true;
            this.checkBoxNo.Location = new System.Drawing.Point(69, 178);
            this.checkBoxNo.Name = "checkBoxNo";
            this.checkBoxNo.Size = new System.Drawing.Size(40, 17);
            this.checkBoxNo.TabIndex = 15;
            this.checkBoxNo.Text = "No";
            this.checkBoxNo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Asignación familiar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Capa1_Presentacion.WinForms.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(117, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormGestionarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1226, 635);
            this.Controls.Add(this.panelGeneralInfo);
            this.Controls.Add(this.buttonBuscarEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDniEmpleado);
            this.Name = "FormGestionarContrato";
            this.Text = "FormGestionarContrato";
            this.panelInfoEmpleado.ResumeLayout(false);
            this.panelInfoEmpleado.PerformLayout();
            this.panelInfoContrato.ResumeLayout(false);
            this.panelInfoContrato.PerformLayout();
            this.panelGeneralInfo.ResumeLayout(false);
            this.panelGeneralInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDniEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarEmpleado;
        private System.Windows.Forms.Panel panelInfoEmpleado;
        private System.Windows.Forms.Label labelDirecc;
        private System.Windows.Forms.Label labelFechaNac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelCorreoEmpleado;
        private System.Windows.Forms.Label labelNombreApellidEmpleado;
        private System.Windows.Forms.Label labelIdEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelInfoContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCrearContrato;
        private System.Windows.Forms.Button buttonEditarContrato;
        private System.Windows.Forms.Button buttonCancelarContrato;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxPagoHora;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxHorasSemana;
        private System.Windows.Forms.CheckBox checkBoxSi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxAfp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPuesto;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonGuardarContrato;
        private System.Windows.Forms.Panel panelGeneralInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxNo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}