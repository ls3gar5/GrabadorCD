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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
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
            this.CODCLI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(532, 356);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(98, 33);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Burn It!!!";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(256, 327);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(371, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proceso...";
            // 
            // cmbGrabadora
            // 
            this.cmbGrabadora.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrabadora.FormattingEnabled = true;
            this.cmbGrabadora.Location = new System.Drawing.Point(256, 237);
            this.cmbGrabadora.Name = "cmbGrabadora";
            this.cmbGrabadora.Size = new System.Drawing.Size(266, 21);
            this.cmbGrabadora.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(625, 327);
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
            this.cmbVelo.Location = new System.Drawing.Point(532, 237);
            this.cmbVelo.Name = "cmbVelo";
            this.cmbVelo.Size = new System.Drawing.Size(97, 21);
            this.cmbVelo.TabIndex = 6;
            // 
            // labelMediaType
            // 
            this.labelMediaType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMediaType.Location = new System.Drawing.Point(321, 266);
            this.labelMediaType.Name = "labelMediaType";
            this.labelMediaType.Size = new System.Drawing.Size(358, 19);
            this.labelMediaType.TabIndex = 14;
            this.labelMediaType.Text = "Dispositivo....";
            // 
            // labelTotalSize
            // 
            this.labelTotalSize.Location = new System.Drawing.Point(529, 266);
            this.labelTotalSize.Name = "labelTotalSize";
            this.labelTotalSize.Size = new System.Drawing.Size(55, 13);
            this.labelTotalSize.TabIndex = 12;
            this.labelTotalSize.Text = "totalSize";
            // 
            // checkBoxQuickFormat
            // 
            this.checkBoxQuickFormat.AutoSize = true;
            this.checkBoxQuickFormat.Checked = true;
            this.checkBoxQuickFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxQuickFormat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxQuickFormat.Location = new System.Drawing.Point(256, 393);
            this.checkBoxQuickFormat.Name = "checkBoxQuickFormat";
            this.checkBoxQuickFormat.Size = new System.Drawing.Size(102, 17);
            this.checkBoxQuickFormat.TabIndex = 16;
            this.checkBoxQuickFormat.Text = "Quick Format";
            this.checkBoxQuickFormat.UseVisualStyleBackColor = true;
            // 
            // buttonFormat
            // 
            this.buttonFormat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormat.Location = new System.Drawing.Point(256, 356);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(88, 29);
            this.buttonFormat.TabIndex = 17;
            this.buttonFormat.Text = "&Format Disc";
            this.buttonFormat.UseVisualStyleBackColor = true;
            this.buttonFormat.Click += new System.EventHandler(this.buttonFormat_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(256, 261);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExpulsarCD
            // 
            this.btnExpulsarCD.Location = new System.Drawing.Point(400, 356);
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
            this.dgDatosModulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modulo,
            this.Descrip});
            this.dgDatosModulos.Location = new System.Drawing.Point(9, 59);
            this.dgDatosModulos.MultiSelect = false;
            this.dgDatosModulos.Name = "dgDatosModulos";
            this.dgDatosModulos.ReadOnly = true;
            this.dgDatosModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatosModulos.ShowEditingIcon = false;
            this.dgDatosModulos.Size = new System.Drawing.Size(240, 352);
            this.dgDatosModulos.TabIndex = 20;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(507, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(162, 33);
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
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODCLI,
            this.NOMBRE});
            this.dgDatos.Location = new System.Drawing.Point(259, 59);
            this.dgDatos.MultiSelect = false;
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.RowTemplate.ReadOnly = true;
            this.dgDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.ShowEditingIcon = false;
            this.dgDatos.Size = new System.Drawing.Size(410, 158);
            this.dgDatos.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(365, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 21);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CODCLI
            // 
            this.CODCLI.DataPropertyName = "CODCLI";
            this.CODCLI.HeaderText = "Usuario";
            this.CODCLI.Name = "CODCLI";
            this.CODCLI.ReadOnly = true;
            this.CODCLI.Width = 80;
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBRE.DataPropertyName = "NOMBRE";
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // Modulo
            // 
            this.Modulo.DataPropertyName = "Modulo";
            this.Modulo.HeaderText = "Modulo";
            this.Modulo.Name = "Modulo";
            this.Modulo.ReadOnly = true;
            this.Modulo.Width = 50;
            // 
            // Descrip
            // 
            this.Descrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descrip.DataPropertyName = "Descrip";
            this.Descrip.HeaderText = "Descripción";
            this.Descrip.Name = "Descrip";
            this.Descrip.ReadOnly = true;
            // 
            // frmGrabadoraCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(691, 433);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgDatosModulos);
            this.Controls.Add(this.btnExpulsarCD);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.buttonFormat);
            this.Controls.Add(this.checkBoxQuickFormat);
            this.Controls.Add(this.labelMediaType);
            this.Controls.Add(this.labelTotalSize);
            this.Controls.Add(this.cmbVelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGrabadora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGrabar);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGrabadoraCD";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burn It!!!!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCLI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip;
    }
}

