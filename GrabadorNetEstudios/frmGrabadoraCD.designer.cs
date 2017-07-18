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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProceso = new System.Windows.Forms.Label();
            this.cmbGrabadora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVelo = new System.Windows.Forms.ComboBox();
            this.labelMediaType = new System.Windows.Forms.Label();
            this.labelTotalSize = new System.Windows.Forms.Label();
            this.checkBoxQuickFormat = new System.Windows.Forms.CheckBox();
            this.buttonFormat = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExpulsarCD = new System.Windows.Forms.Button();
            this.dgDatosModulos = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbPendientes = new System.Windows.Forms.RadioButton();
            this.rbBuscar = new System.Windows.Forms.RadioButton();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNroLlave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(309, 139);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(98, 33);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar CD";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(33, 110);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(371, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProceso.Location = new System.Drawing.Point(33, 80);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(64, 13);
            this.lblProceso.TabIndex = 3;
            this.lblProceso.Text = "Proceso...";
            // 
            // cmbGrabadora
            // 
            this.cmbGrabadora.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrabadora.FormattingEnabled = true;
            this.cmbGrabadora.Location = new System.Drawing.Point(33, 20);
            this.cmbGrabadora.Name = "cmbGrabadora";
            this.cmbGrabadora.Size = new System.Drawing.Size(266, 21);
            this.cmbGrabadora.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(402, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "%..";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbVelo
            // 
            this.cmbVelo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVelo.FormattingEnabled = true;
            this.cmbVelo.Location = new System.Drawing.Point(309, 20);
            this.cmbVelo.Name = "cmbVelo";
            this.cmbVelo.Size = new System.Drawing.Size(97, 21);
            this.cmbVelo.TabIndex = 6;
            // 
            // labelMediaType
            // 
            this.labelMediaType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMediaType.Location = new System.Drawing.Point(98, 49);
            this.labelMediaType.Name = "labelMediaType";
            this.labelMediaType.Size = new System.Drawing.Size(358, 19);
            this.labelMediaType.TabIndex = 14;
            this.labelMediaType.Text = "Dispositivo....";
            // 
            // labelTotalSize
            // 
            this.labelTotalSize.Location = new System.Drawing.Point(306, 49);
            this.labelTotalSize.Name = "labelTotalSize";
            this.labelTotalSize.Size = new System.Drawing.Size(55, 13);
            this.labelTotalSize.TabIndex = 12;
            // 
            // checkBoxQuickFormat
            // 
            this.checkBoxQuickFormat.AutoSize = true;
            this.checkBoxQuickFormat.Checked = true;
            this.checkBoxQuickFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxQuickFormat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxQuickFormat.Location = new System.Drawing.Point(33, 176);
            this.checkBoxQuickFormat.Name = "checkBoxQuickFormat";
            this.checkBoxQuickFormat.Size = new System.Drawing.Size(102, 17);
            this.checkBoxQuickFormat.TabIndex = 16;
            this.checkBoxQuickFormat.Text = "Quick Format";
            this.checkBoxQuickFormat.UseVisualStyleBackColor = true;
            // 
            // buttonFormat
            // 
            this.buttonFormat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormat.Location = new System.Drawing.Point(33, 139);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(88, 29);
            this.buttonFormat.TabIndex = 17;
            this.buttonFormat.Text = "&Format Disc";
            this.buttonFormat.UseVisualStyleBackColor = true;
            this.buttonFormat.Click += new System.EventHandler(this.buttonFormat_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(33, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExpulsarCD
            // 
            this.btnExpulsarCD.Location = new System.Drawing.Point(177, 139);
            this.btnExpulsarCD.Name = "btnExpulsarCD";
            this.btnExpulsarCD.Size = new System.Drawing.Size(88, 33);
            this.btnExpulsarCD.TabIndex = 19;
            this.btnExpulsarCD.Text = "Expulsar CD";
            this.btnExpulsarCD.UseVisualStyleBackColor = true;
            this.btnExpulsarCD.Click += new System.EventHandler(this.btnExpulsarCD_Click);
            // 
            // dgDatosModulos
            // 
            this.dgDatosModulos.AllowUserToAddRows = false;
            this.dgDatosModulos.AllowUserToDeleteRows = false;
            this.dgDatosModulos.AllowUserToResizeRows = false;
            this.dgDatosModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatosModulos.Location = new System.Drawing.Point(9, 90);
            this.dgDatosModulos.MultiSelect = false;
            this.dgDatosModulos.Name = "dgDatosModulos";
            this.dgDatosModulos.ReadOnly = true;
            this.dgDatosModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatosModulos.ShowEditingIcon = false;
            this.dgDatosModulos.Size = new System.Drawing.Size(244, 392);
            this.dgDatosModulos.TabIndex = 20;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(282, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(177, 21);
            this.btnLoad.TabIndex = 21;
            this.btnLoad.Text = "Vericar Nuevos Usuarios";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AllowUserToResizeRows = false;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(259, 90);
            this.dgDatos.MultiSelect = false;
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.ShowEditingIcon = false;
            this.dgDatos.Size = new System.Drawing.Size(482, 213);
            this.dgDatos.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(124, 53);
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
            this.btnBuscar.Location = new System.Drawing.Point(230, 53);
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
            this.rbPendientes.Location = new System.Drawing.Point(35, 22);
            this.rbPendientes.Name = "rbPendientes";
            this.rbPendientes.Size = new System.Drawing.Size(87, 17);
            this.rbPendientes.TabIndex = 25;
            this.rbPendientes.TabStop = true;
            this.rbPendientes.Text = "Pendientes";
            this.rbPendientes.UseVisualStyleBackColor = true;
            this.rbPendientes.CheckedChanged += new System.EventHandler(this.rbPendientes_CheckedChanged);
            // 
            // rbBuscar
            // 
            this.rbBuscar.AutoSize = true;
            this.rbBuscar.Location = new System.Drawing.Point(35, 55);
            this.rbBuscar.Name = "rbBuscar";
            this.rbBuscar.Size = new System.Drawing.Size(81, 17);
            this.rbBuscar.TabIndex = 26;
            this.rbBuscar.Text = "Individual";
            this.rbBuscar.UseVisualStyleBackColor = true;
            this.rbBuscar.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(124, 20);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 21);
            this.btnBorrar.TabIndex = 27;
            this.btnBorrar.Text = "Borrar Seleccionados";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGrabadora);
            this.groupBox1.Controls.Add(this.btnGrabar);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.lblProceso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbVelo);
            this.groupBox1.Controls.Add(this.labelTotalSize);
            this.groupBox1.Controls.Add(this.labelMediaType);
            this.groupBox1.Controls.Add(this.checkBoxQuickFormat);
            this.groupBox1.Controls.Add(this.btnExpulsarCD);
            this.groupBox1.Controls.Add(this.buttonFormat);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Location = new System.Drawing.Point(262, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 198);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gradora";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.rbBuscar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.rbPendientes);
            this.groupBox2.Location = new System.Drawing.Point(259, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 83);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tareas";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(9, 25);
            this.txtNombre.MaxLength = 6;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 21);
            this.txtNombre.TabIndex = 30;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNroLlave
            // 
            this.txtNroLlave.Enabled = false;
            this.txtNroLlave.Location = new System.Drawing.Point(9, 63);
            this.txtNroLlave.MaxLength = 6;
            this.txtNroLlave.Name = "txtNroLlave";
            this.txtNroLlave.Size = new System.Drawing.Size(100, 21);
            this.txtNroLlave.TabIndex = 31;
            this.txtNroLlave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nro. Llave:";
            // 
            // frmGrabadoraCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(753, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNroLlave);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgDatos);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.ComboBox cmbGrabadora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVelo;
        private System.Windows.Forms.Label labelMediaType;
        private System.Windows.Forms.Label labelTotalSize;
        private System.Windows.Forms.CheckBox checkBoxQuickFormat;
        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExpulsarCD;
        private System.Windows.Forms.DataGridView dgDatosModulos;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.RadioButton rbPendientes;
        private System.Windows.Forms.RadioButton rbBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNroLlave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

