using System;
using System.Windows.Forms;
using Grabador;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using Datos;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using Holistor.Proteccion;

namespace GrabadorNetEstudios
{
    public partial class frmGrabadoraCD : Form
    {
        Grabador.Grabador oG;
        string[,] ulista;
        List<UsuarioDTO> currentPendienes;
        List<UsuarioDTO> currentIndividual;

        FileSystemWatcher m_Watcher;
        public delegate void AddText(string text);
        public AddText addTextToLabel;

        private const string mensajeArchivo = "Hubo cambios en el master del Servidor. Verifique";


        public frmGrabadoraCD()
        {

            InitializeComponent();

            currentPendienes = new List<UsuarioDTO>();
            currentIndividual = new List<UsuarioDTO>();

            oG = new Grabador.Grabador();
            oG.finalizo += new Grabador.Grabador.FinalizoHandler(oG_finalizo);
            oG.progreso += new Grabador.Grabador.ProgresoHandler(oG_progreso);

            dgDatos.SelectionChanged += DgDatos_SelectionChanged;
            
            SplashStart();

            //Carga de los datos
            if (Helper.Usuarios != null && Helper.Usuarios.Count > 0)
            {
                currentPendienes.AddRange(Helper.Usuarios.OrderBy(o => o.CODCLI));
                currentPendienes.Add(new UsuarioDTO()
                {
                    CHLOCK = "215A-41725",
                    CODCLI = "00999998",
                    LSISTEM = "12/14/19/24",
                    MPRTWIN = "LLAVE=[41725]\r\n",
                    NOMBRE = "DUMMY PRUEBA 1",
                    IDDESITEM = 1
                });
                currentPendienes.Add(new UsuarioDTO()
                {
                    CHLOCK = "207C-11051",
                    CODCLI = "00999999",
                    LSISTEM = "19",
                    MPRTWIN = "LLAVE=[11051]\r\n",
                    NOMBRE = "DUMMY PRUEBA 2",
                    IDDESITEM = 2
                });

                SetGrillaUsuario(currentPendienes);
            }

            m_Watcher = new FileSystemWatcher(Helper.GetPATHEST);
            m_Watcher.Filter = "*.*";
            m_Watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite;
            m_Watcher.IncludeSubdirectories = true;
            m_Watcher.EnableRaisingEvents = true;

            m_Watcher.Changed += M_Watcher_Changed;
            m_Watcher.Deleted += M_Watcher_Deleted;
            m_Watcher.Created += M_Watcher_Created;
            m_Watcher.Renamed += M_Watcher_Renamed;

            addTextToLabel = new AddText(AddTextToLabelMethod);
        }


        private void AddTextToLabelMethod(string text)
        {
            this.lblProceso.Text = text;
        }


        private void M_Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            m_Watcher.EnableRaisingEvents = false;
            this.lblProceso.Text += mensajeArchivo;
            MessageBox.Show(mensajeArchivo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void M_Watcher_Created(object sender, FileSystemEventArgs e)
        {
            m_Watcher.EnableRaisingEvents = false;

            if (lblProceso.InvokeRequired)
                lblProceso.Invoke(addTextToLabel, new object[] { mensajeArchivo });
            else
                lblProceso.Text = mensajeArchivo;

            MessageBox.Show(mensajeArchivo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void M_Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            m_Watcher.EnableRaisingEvents = false;

            if (lblProceso.InvokeRequired)
                lblProceso.Invoke(addTextToLabel, new object[] { mensajeArchivo });
            else
                lblProceso.Text = mensajeArchivo;

            MessageBox.Show(mensajeArchivo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void M_Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            m_Watcher.EnableRaisingEvents = false;

            if (lblProceso.InvokeRequired)
                lblProceso.Invoke(addTextToLabel, new object[] { mensajeArchivo });
            else
                lblProceso.Text = mensajeArchivo;

            MessageBox.Show(mensajeArchivo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void DgDatos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (((DataGridView)sender).SelectedRows.Count == 0 || ((DataGridView)sender).CurrentRow == null)
                    return;

                var usu = (UsuarioDTO)((DataGridView)sender).CurrentRow.DataBoundItem;
                SetGrillaModulo(usu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SplashStart()
        {
            try
            {
                var oFrm = new frmSplash(Resources.TituloInicialSplash);
                oFrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void oG_finalizo(bool lExito)
        {
            SetBottonsEnabled(true);
            m_Watcher.EnableRaisingEvents = true;

            if (lExito == true)
            {
                lblProceso.Text = string.Empty;
                this.label2.Text = string.Empty;
                progressBar1.Value = 0;
                var lista = false;

                if (this.rbPendientes.Checked)
                {
                    this.currentPendienes = this.currentPendienes.Where(w => !w.FECHACT.HasValue).OrderBy(o => o.CODCLI).ToList();
                    if (currentPendienes.Count>0)
                    {
                        lista = currentPendienes.Count >0;
                        SetGrillaUsuario(this.currentPendienes);
                    }
                }
                else if (this.rbIndividual.Checked)
                {
                    this.currentIndividual = this.currentIndividual.Where(w => !w.FECHACT.HasValue).OrderBy(o => o.CODCLI).ToList();
                    if (currentIndividual.Count>0)
                    {
                        lista = currentIndividual.Count > 0;
                        SetGrillaUsuario(this.currentIndividual);
                    }
                }

                if (lista)
                {
                    MessageBox.Show(Resources.ProcesoFinalizado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("¿Continúa con el siguiente suscripción?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        GrabarCD();
                    }
                }
                else
                {
                    MessageBox.Show("No hay mas Ususarios para grabar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show(Resources.ErrorProceso);
            }
        }

        void oG_progreso(int porcentaje, string tarea)
        {
            if (tarea == Resources.RealizandoGrabacion)
            {
                lblProceso.Text = tarea;
                progressBar1.Value = porcentaje + 1;
                this.label2.Text = (porcentaje + 1).ToString();
            }
            else if (tarea.Trim() != string.Empty)
            {
                lblProceso.Text = tarea;
                //this.label2.Text = porcentaje.ToString();
                //progressBar1.Value = porcentaje;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Carga del Dispositivo
                ulista = oG.GetDevices();

                if (ulista.GetLength(0) == 0)
                {
                    return;
                }

                for (int i = 0; i < this.ulista.GetLength(0); i++)
                {
                    this.cmbGrabadora.Items.Insert(i, this.ulista[i, 1]);
                }

                //Elije la primera gravadora en caso q tenga mas de una
                this.cmbGrabadora.SelectedIndex = 0;
                var id = this.ulista[this.cmbGrabadora.SelectedIndex, 0];

                //try
                //{
                //    var velocidades = this.oG.GetWriteSpeed(id);

                //    for (int i = 0; i < velocidades.GetLength(0); i++)
                //    {
                //        this.cmbVelo.Items.Insert(i, velocidades[i]);
                //    }

                //    this.cmbVelo.SelectedIndex = 0;
                //}
                //catch
                //{
                //    cmbVelo.Enabled = false;
                //}

                this.labelMediaType.Text = oG.DatosDisco(id);

                AgregarDirectorioFila(Helper.GetPATHESTLOCAL);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            m_Watcher.EnableRaisingEvents = false;
            GrabarCD();
        }

        private void AgregarDirectorioFila(string sourceDirName)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                oG.AgregarArchivo(file.FullName);
            }
            foreach (DirectoryInfo subdir in dirs)
            {
                oG.AgregarCarpeta(subdir.FullName);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            // Release the disc recorder items
            //
            this.oG.DescargarDispositivo(this.ulista[this.cmbGrabadora.SelectedIndex, 0]);
        }

        private void buttonFormat_Click(object sender, EventArgs e)
        {
            SetBottonsEnabled(false);
            if (this.cmbGrabadora.SelectedIndex == -1)
            {
                SetBottonsEnabled(true);
                return;
            }

            if (!oG.ValidarCapacidadDisco(this.ulista[this.cmbGrabadora.SelectedIndex, 0]))
            {
                MessageBox.Show("ValCapacidadMedia - No tiene Capacidad el CD!!!!!");
                SetBottonsEnabled(true);
                return;
            }

            try
            {
                this.oG.BorrarDisco(this.ulista[this.cmbGrabadora.SelectedIndex, 0], this.checkBoxQuickFormat.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SetBottonsEnabled(true);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.labelMediaType.Text = oG.DatosDisco(this.ulista[this.cmbGrabadora.SelectedIndex, 0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExpulsarCD_Click(object sender, EventArgs e)
        {
            try
            {
                this.oG.EjectDisc(this.ulista[this.cmbGrabadora.SelectedIndex, 0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //1- Obtengo nuevamente los usuarios
            var oFrm = new frmSplash(Resources.TituloVerificandoSplash);
            oFrm.ShowDialog();

            //2- La lista de diferencia
            var listaFaltante = Helper.Usuarios.Where(w => !this.currentPendienes.Any(c => c.CODCLI == w.CODCLI)).ToList();

            if (listaFaltante.Count == 0)
            {
                MessageBox.Show("No hay usuarios nuevos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            currentPendienes.AddRange(listaFaltante);

            SetGrillaUsuario(currentPendienes);
            MessageBox.Show("Se actulizaco la lista. Hay " + listaFaltante.Count.ToString() + " usuarios nuevos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int nro;
            Int32.TryParse(this.textBox1.Text, out nro);
            if (nro > 0)
            {
                try
                {
                    var usu = Helper.SearchUsuario(nro);
                    if (usu == null)
                    {
                        MessageBox.Show("Usuario inexistente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        this.currentIndividual.Add(usu);
                    }
                    
                    SetGrillaUsuario(currentIndividual);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rbPendientes_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
                return;

            SetLayOutBotton(true);
            SetGrillaUsuario(this.currentPendienes);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
                return;

            SetLayOutBotton(false);

            if (this.currentIndividual.Count == 0)
            {
                this.dgDatos.DataSource = null;
                this.dgDatosModulos.DataSource = null;
            }
            else
            {
                SetGrillaUsuario(this.currentIndividual);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.rbIndividual.Checked)
            {
                var listaEliminar = this.currentIndividual.Where(w => w.SELECCION).ToList();

                if (listaEliminar.Count == 0)
                {
                    return;
                }
                this.currentIndividual.RemoveAll(r => listaEliminar.Any(a => a.CODCLI == r.CODCLI));

                SetGrillaUsuario(this.currentIndividual);
            }
            else if (this.rbPendientes.Checked)
            {
                var listaEliminar = this.currentPendienes.Where(w => w.SELECCION).ToList();

                if (listaEliminar.Count == 0)
                {
                    return;
                }
                this.currentPendienes.RemoveAll(r => listaEliminar.Any(a => a.IDDESITEM == r.IDDESITEM));

                SetGrillaUsuario(this.currentPendienes);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void SetLayOutBotton(bool value)
        {
            if (!value)
            {
                this.textBox1.Focus();
            }
            else
            {
                this.textBox1.Text = string.Empty;
            }

            this.textBox1.Enabled = !value;
            this.btnBuscar.Enabled = !value;
            this.btnLoad.Enabled = value;
        }

        private void SetBottonsEnabled(bool v)
        {
            this.textBox1.Enabled = v;
            this.btnBuscar.Enabled = v;
            this.btnLoad.Enabled = v;
            this.btnBorrar.Enabled = v;
            this.rbIndividual.Enabled = v;
            this.rbPendientes.Enabled = v;

            this.cmbGrabadora.Enabled = v;
            this.btnRefresh.Enabled = v;
            this.buttonFormat.Enabled = v;
            this.checkBoxQuickFormat.Enabled = v;
            this.btnExpulsarCD.Enabled = v;
            this.btnGrabar.Enabled = v;
            this.btnVerificarLlave.Enabled = v;

            this.dgDatos.Enabled = v;
            this.dgDatosModulos.Enabled = v;
        }


        private void GrabarCD()
        {
            UsuarioDTO currentUser = new UsuarioDTO();

            try
            {
                SetBottonsEnabled(false);

                if (!this.verificar())
                {
                    SetBottonsEnabled(true);
                    return;
                }

                if (rbPendientes.Checked)
                {
                    currentUser = this.currentPendienes.Where(w => !w.FECHACT.HasValue).OrderBy(o => o.CODCLI).FirstOrDefault();
                }
                else
                {
                    currentUser = this.currentIndividual.Where(w => !w.FECHACT.HasValue).OrderBy(o => o.CODCLI).FirstOrDefault();
                }

                if (currentUser == null)
                {
                    throw new ArgumentNullException(Resources.ProcesoFinalizado);
                }
                else
                {
                    this.txtNombre.Text = currentUser.NOMBRE;
                    this.txtNroLlave.Text = currentUser.CHLOCK;
                    SetGrillaModulo(currentUser);

                    currentUser.FECHACT = DateTime.Now;
                }

                var id = this.ulista[this.cmbGrabadora.SelectedIndex, 0];
                this.labelMediaType.Text = oG.DatosDisco(id);

                var sourceDirName = string.Concat(Helper.GetPATHESTLOCAL, "Holiwin\\");

                Directory.Delete(sourceDirName, true);
                //Elimino de la collecion de grabacion
                oG.ElinimarCarpeta(sourceDirName);

                Directory.CreateDirectory(sourceDirName);
                //Genero el txt
                var pathHoliwin = string.Concat(sourceDirName, "HOLIWIN.SYS");
                var pathUsu = string.Concat(sourceDirName, currentUser.CODCLI + ".txt");
                File.WriteAllText(pathHoliwin, currentUser.MPRTWIN);
                File.WriteAllText(pathUsu, string.Empty);

                //Agrego de la collecion de grabacion
                if (oG.AgregarCarpeta(sourceDirName))
                {
                    oG.Grabar(id);
                }
                else
                {
                    MessageBox.Show("No se pudo grabar el Holiwin verifique las carpetas:" + sourceDirName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetBottonsEnabled(true);
                }
            }
            catch (ArgumentNullException aex)
            {
                MessageBox.Show(aex.Message);
                SetBottonsEnabled(true);
            }
            catch (Exception ex)
            {
                currentUser.FECHACT = DateTime.Now;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetBottonsEnabled(true);
            }
        }

        private bool verificar()
        {
            if (this.cmbGrabadora.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un dispositivo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!oG.ValidarDiscoVacio(this.ulista[this.cmbGrabadora.SelectedIndex, 0]))
            {
                MessageBox.Show("Verifique los siguientes posibles problemas:" + Environment.NewLine +
                    "- El CD ya se encuentra utilizado." + Environment.NewLine +
                    "- No se encuentra ningún CD disponible en la Grabadora." + Environment.NewLine +
                    "- El dispositivo no es grabadora de CD.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!oG.ValidarCapacidadDisco(this.ulista[this.cmbGrabadora.SelectedIndex, 0]))
            {
                MessageBox.Show("El directorio seleccionado tiene un tamaño superior a la capacidad de grabación del CD", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void SetGrillaModulo(UsuarioDTO usu)
        {
            if (Helper.Modulos == null || Helper.Modulos.Count == 0)
            {
                throw new Exception(Resources.ErrorNoExisteTablaModulo);
            }

            var modulosUsuario = usu.LSISTEM.Split('/').ToList();
            var modulos = Helper.Modulos.Where(w => modulosUsuario.Contains(w.Modulo)).ToList();

            dgDatosModulos.AutoGenerateColumns = false;
            dgDatosModulos.AllowUserToAddRows = false;
            dgDatosModulos.AllowUserToDeleteRows = false;
            dgDatosModulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDatosModulos.RowHeadersVisible = false;
            dgDatosModulos.ReadOnly = true;

            dgDatosModulos.DataSource = modulos;

            dgDatosModulos.Columns.Clear();
            dgDatosModulos.Columns.Add("Modulo", "Modulo");
            dgDatosModulos.Columns["Modulo"].DataPropertyName = "Modulo";
            dgDatosModulos.Columns["Modulo"].Width = 80;
            dgDatosModulos.Columns.Add("Descrip", "Descripción");
            dgDatosModulos.Columns["Descrip"].DataPropertyName = "Descrip";
            dgDatosModulos.Columns["Descrip"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void SetGrillaUsuario(List<UsuarioDTO> usu)
        {
            dgDatos.Columns.Clear();

            dgDatos.AutoGenerateColumns = false;
            dgDatos.AllowUserToAddRows = false;
            dgDatos.AllowUserToDeleteRows = false;
            dgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDatos.RowHeadersVisible = false;

            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn()
            {
                DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleCenter },
                DataPropertyName = "SELECCION",
                Width = 20
            };

            dgDatos.Columns.Insert(0, checkboxColumn);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn()
            {
                Width = 30,
                DefaultCellStyle = new DataGridViewCellStyle() { NullValue = null },
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Resizable = DataGridViewTriState.False
            };

            dgDatos.Columns.Insert(1, imageColumn);

            dgDatos.Columns.Add("CODCLI", "Usuario");
            dgDatos.Columns["CODCLI"].DataPropertyName = "CODCLI";
            dgDatos.Columns["CODCLI"].Width = 70;
            dgDatos.Columns["CODCLI"].ReadOnly = true;

            dgDatos.Columns.Add("NOMBRE", "Nombre");
            dgDatos.Columns["NOMBRE"].DataPropertyName = "NOMBRE";
            dgDatos.Columns["NOMBRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgDatos.Columns["NOMBRE"].ReadOnly = true;

            dgDatos.DataSource = usu;
            dgDatos.Refresh();
        }

        private void btnVerificarLlave_Click(object sender, EventArgs e)
        {
            this.txtLLaveUsb.Text = string.Empty;
            this.txtLLaveHoliwin.Text = string.Empty;
            this.txtLLaveSuscripcion.Text = string.Empty;
            this.pictureBoxLlave.Image = null;

            HKEY oHKey = new HKEY();
            Result oResult = oHKey.testHkey();

            if (oResult.lConectado)
            {
                this.txtLLaveUsb.Text = oResult.LoteSerie;
            }
            else
            {
                MessageBox.Show("No hay llave conectada. Verifique.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var usu = (UsuarioDTO)this.dgDatos.CurrentRow.DataBoundItem;

            this.txtLLaveSuscripcion.Text = usu.CHLOCK;

            var llaveHoliwin = usu.MPRTWIN.Split(new[] { '\r', '\n' }).FirstOrDefault();

            if (llaveHoliwin.IndexOf('[') > 0 && llaveHoliwin.IndexOf(']') > 0)
            {
                llaveHoliwin = llaveHoliwin.Substring(llaveHoliwin.IndexOf('[') + 1, llaveHoliwin.IndexOf(']') - llaveHoliwin.IndexOf('[') - 1);
            }

            this.txtLLaveHoliwin.Text = llaveHoliwin;

            var suscrip = txtLLaveSuscripcion.Text;
            var llaveUSB = txtLLaveUsb.Text;

            if (txtLLaveSuscripcion.Text.IndexOf('-') > 0)
            {
                suscrip = txtLLaveSuscripcion.Text.Substring(txtLLaveSuscripcion.Text.Length - (txtLLaveSuscripcion.Text.IndexOf('-') + 1));
            }

            if (txtLLaveUsb.Text.IndexOf('-') > 0)
            {
                llaveUSB = txtLLaveUsb.Text.Substring(txtLLaveUsb.Text.Length - (txtLLaveUsb.Text.IndexOf('-') + 1));
            }

            this.dgDatos.CurrentRow.Cells[1].Value = null;
            this.dgDatos.Refresh();

            if (suscrip.Equals(txtLLaveHoliwin.Text) && suscrip.Equals(llaveUSB))
            {
                this.pictureBoxLlave.Image = new System.Drawing.Bitmap(Resources.OkIcon);

                this.dgDatos.CurrentRow.Cells[1] = new DataGridViewImageCell()
                {
                    Style = new DataGridViewCellStyle()
                    {
                        BackColor = System.Drawing.Color.White,
                        ForeColor = System.Drawing.Color.White,
                    },
                    ImageLayout = DataGridViewImageCellLayout.Stretch,
                    Value = new System.Drawing.Bitmap(Resources.OkIcon)
                };
            }
            else
            {
                this.pictureBoxLlave.Image = new System.Drawing.Bitmap(Resources.Error);

                this.dgDatos.CurrentRow.Cells[1] = new DataGridViewImageCell()
                {
                    Style = new DataGridViewCellStyle()
                    {
                        BackColor = System.Drawing.Color.White,
                        ForeColor = System.Drawing.Color.White,
                    },
                    ImageLayout = DataGridViewImageCellLayout.Stretch,
                    Value = new System.Drawing.Bitmap(Resources.Error)
                };
            }

            this.dgDatos.Refresh();
        }
    }
}

