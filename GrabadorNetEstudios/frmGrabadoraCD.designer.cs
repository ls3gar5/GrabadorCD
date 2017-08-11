using System;

namespace GrabadorNetEstudios
{
    partial class frmGrabadoraCD
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrabadoraCD));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProceso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgDatosModulos = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbPendientes = new System.Windows.Forms.RadioButton();
            this.rbIndividual = new System.Windows.Forms.RadioButton();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroLlave = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbGrabadora = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.labelMediaType = new System.Windows.Forms.Label();
            this.checkBoxQuickFormat = new System.Windows.Forms.CheckBox();
            this.btnExpulsarCD = new System.Windows.Forms.Button();
            this.buttonFormat = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBoxLlave = new System.Windows.Forms.PictureBox();
            this.btnVerificarLlave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLLaveUsb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLLaveHoliwin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLLaveSuscripcion = new System.Windows.Forms.TextBox();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosModulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLlave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(579, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProceso.Location = new System.Drawing.Point(6, 87);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(97, 18);
            this.lblProceso.TabIndex = 3;
            this.lblProceso.Text = "Proceso...";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(586, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "%..";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgDatosModulos
            // 
            this.dgDatosModulos.AllowUserToAddRows = false;
            this.dgDatosModulos.AllowUserToDeleteRows = false;
            this.dgDatosModulos.AllowUserToResizeRows = false;
            this.dgDatosModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatosModulos.Location = new System.Drawing.Point(7, 69);
            this.dgDatosModulos.MultiSelect = false;
            this.dgDatosModulos.Name = "dgDatosModulos";
            this.dgDatosModulos.ReadOnly = true;
            this.dgDatosModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatosModulos.ShowEditingIcon = false;
            this.dgDatosModulos.Size = new System.Drawing.Size(244, 417);
            this.dgDatosModulos.TabIndex = 20;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(99, 18);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(177, 21);
            this.btnLoad.TabIndex = 21;
            this.btnLoad.Text = "Verificar Nuevos Usuarios";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(420, 18);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(526, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 21);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbPendientes
            // 
            this.rbPendientes.AutoSize = true;
            this.rbPendientes.Checked = true;
            this.rbPendientes.Location = new System.Drawing.Point(6, 20);
            this.rbPendientes.Name = "rbPendientes";
            this.rbPendientes.Size = new System.Drawing.Size(87, 17);
            this.rbPendientes.TabIndex = 25;
            this.rbPendientes.TabStop = true;
            this.rbPendientes.Text = "Pendientes";
            this.rbPendientes.UseVisualStyleBackColor = true;
            this.rbPendientes.CheckedChanged += new System.EventHandler(this.rbPendientes_CheckedChanged);
            // 
            // rbIndividual
            // 
            this.rbIndividual.AutoSize = true;
            this.rbIndividual.Location = new System.Drawing.Point(331, 20);
            this.rbIndividual.Name = "rbIndividual";
            this.rbIndividual.Size = new System.Drawing.Size(81, 17);
            this.rbIndividual.TabIndex = 26;
            this.rbIndividual.Text = "Individual";
            this.rbIndividual.UseVisualStyleBackColor = true;
            this.rbIndividual.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(673, 18);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 21);
            this.btnBorrar.TabIndex = 27;
            this.btnBorrar.Text = "Borrar Seleccionados";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNroLlave);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.lblProceso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(265, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 120);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceso Grabación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nro. Llave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre:";
            // 
            // txtNroLlave
            // 
            this.txtNroLlave.Enabled = false;
            this.txtNroLlave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroLlave.Location = new System.Drawing.Point(9, 33);
            this.txtNroLlave.MaxLength = 6;
            this.txtNroLlave.Name = "txtNroLlave";
            this.txtNroLlave.Size = new System.Drawing.Size(152, 22);
            this.txtNroLlave.TabIndex = 35;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(177, 33);
            this.txtNombre.MaxLength = 6;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(446, 22);
            this.txtNombre.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.rbIndividual);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.rbPendientes);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 51);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tareas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbGrabadora);
            this.groupBox3.Controls.Add(this.btnGrabar);
            this.groupBox3.Controls.Add(this.labelMediaType);
            this.groupBox3.Controls.Add(this.checkBoxQuickFormat);
            this.groupBox3.Controls.Add(this.btnExpulsarCD);
            this.groupBox3.Controls.Add(this.buttonFormat);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Location = new System.Drawing.Point(265, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(642, 104);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grabadora";
            // 
            // cmbGrabadora
            // 
            this.cmbGrabadora.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrabadora.FormattingEnabled = true;
            this.cmbGrabadora.Location = new System.Drawing.Point(14, 22);
            this.cmbGrabadora.Name = "cmbGrabadora";
            this.cmbGrabadora.Size = new System.Drawing.Size(266, 21);
            this.cmbGrabadora.TabIndex = 21;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(409, 64);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(98, 33);
            this.btnGrabar.TabIndex = 20;
            this.btnGrabar.Text = "Grabar CD";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // labelMediaType
            // 
            this.labelMediaType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMediaType.Location = new System.Drawing.Point(356, 23);
            this.labelMediaType.Name = "labelMediaType";
            this.labelMediaType.Size = new System.Drawing.Size(272, 19);
            this.labelMediaType.TabIndex = 22;
            this.labelMediaType.Text = "Dispositivo....";
            // 
            // checkBoxQuickFormat
            // 
            this.checkBoxQuickFormat.AutoSize = true;
            this.checkBoxQuickFormat.Checked = true;
            this.checkBoxQuickFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxQuickFormat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxQuickFormat.Location = new System.Drawing.Point(14, 71);
            this.checkBoxQuickFormat.Name = "checkBoxQuickFormat";
            this.checkBoxQuickFormat.Size = new System.Drawing.Size(102, 17);
            this.checkBoxQuickFormat.TabIndex = 23;
            this.checkBoxQuickFormat.Text = "Quick Format";
            this.checkBoxQuickFormat.UseVisualStyleBackColor = true;
            // 
            // btnExpulsarCD
            // 
            this.btnExpulsarCD.Location = new System.Drawing.Point(257, 64);
            this.btnExpulsarCD.Name = "btnExpulsarCD";
            this.btnExpulsarCD.Size = new System.Drawing.Size(88, 33);
            this.btnExpulsarCD.TabIndex = 26;
            this.btnExpulsarCD.Text = "Expulsar CD";
            this.btnExpulsarCD.UseVisualStyleBackColor = true;
            this.btnExpulsarCD.Click += new System.EventHandler(this.btnExpulsarCD_Click);
            // 
            // buttonFormat
            // 
            this.buttonFormat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormat.Location = new System.Drawing.Point(122, 64);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(88, 29);
            this.buttonFormat.TabIndex = 24;
            this.buttonFormat.Text = "&Format Disc";
            this.buttonFormat.UseVisualStyleBackColor = true;
            this.buttonFormat.Click += new System.EventHandler(this.buttonFormat_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(286, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 23);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxLlave);
            this.groupBox4.Controls.Add(this.btnVerificarLlave);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtLLaveUsb);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtLLaveHoliwin);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtLLaveSuscripcion);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(753, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 218);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control LLave";
            // 
            // pictureBoxLlave
            // 
            this.pictureBoxLlave.Location = new System.Drawing.Point(52, 176);
            this.pictureBoxLlave.Name = "pictureBoxLlave";
            this.pictureBoxLlave.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxLlave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLlave.TabIndex = 46;
            this.pictureBoxLlave.TabStop = false;
            // 
            // btnVerificarLlave
            // 
            this.btnVerificarLlave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarLlave.Location = new System.Drawing.Point(5, 154);
            this.btnVerificarLlave.Name = "btnVerificarLlave";
            this.btnVerificarLlave.Size = new System.Drawing.Size(140, 21);
            this.btnVerificarLlave.TabIndex = 39;
            this.btnVerificarLlave.Text = "Verificar LLave";
            this.btnVerificarLlave.UseVisualStyleBackColor = true;
            this.btnVerificarLlave.Click += new System.EventHandler(this.btnVerificarLlave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Llave USB";
            // 
            // txtLLaveUsb
            // 
            this.txtLLaveUsb.Enabled = false;
            this.txtLLaveUsb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLLaveUsb.Location = new System.Drawing.Point(5, 126);
            this.txtLLaveUsb.MaxLength = 6;
            this.txtLLaveUsb.Name = "txtLLaveUsb";
            this.txtLLaveUsb.Size = new System.Drawing.Size(140, 22);
            this.txtLLaveUsb.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Holiwin";
            // 
            // txtLLaveHoliwin
            // 
            this.txtLLaveHoliwin.Enabled = false;
            this.txtLLaveHoliwin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLLaveHoliwin.Location = new System.Drawing.Point(5, 85);
            this.txtLLaveHoliwin.MaxLength = 6;
            this.txtLLaveHoliwin.Name = "txtLLaveHoliwin";
            this.txtLLaveHoliwin.Size = new System.Drawing.Size(140, 22);
            this.txtLLaveHoliwin.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Suscripción";
            // 
            // txtLLaveSuscripcion
            // 
            this.txtLLaveSuscripcion.Enabled = false;
            this.txtLLaveSuscripcion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLLaveSuscripcion.Location = new System.Drawing.Point(5, 44);
            this.txtLLaveSuscripcion.MaxLength = 6;
            this.txtLLaveSuscripcion.Name = "txtLLaveSuscripcion";
            this.txtLLaveSuscripcion.Size = new System.Drawing.Size(140, 22);
            this.txtLLaveSuscripcion.TabIndex = 40;
            // 
            // dgDatos
            // 
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(274, 69);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.Size = new System.Drawing.Size(473, 212);
            this.dgDatos.TabIndex = 41;
            // 
            // frmGrabadoraCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(916, 536);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgDatosModulos);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGrabadoraCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burn It!!!!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosModulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLlave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgDatosModulos;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbPendientes;
        private System.Windows.Forms.RadioButton rbIndividual;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroLlave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbGrabadora;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label labelMediaType;
        private System.Windows.Forms.CheckBox checkBoxQuickFormat;
        private System.Windows.Forms.Button btnExpulsarCD;
        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnVerificarLlave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLLaveUsb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLLaveHoliwin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLLaveSuscripcion;
        private System.Windows.Forms.PictureBox pictureBoxLlave;
        private System.Windows.Forms.DataGridView dgDatos;
    }
}

