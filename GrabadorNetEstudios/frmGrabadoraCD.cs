using System;
using System.Windows.Forms;
using Grabador;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using Datos;
using System.Threading;


namespace GrabadorNetEstudios
{
    public partial class frmGrabadoraCD : Form
    {
        Grabador.Grabador oG;
        string[,] ulista;
        List<UsuarioDTO> currentUsuarios;


        public frmGrabadoraCD()
        {

            InitializeComponent();

            currentUsuarios = new List<UsuarioDTO>();

            oG = new Grabador.Grabador();
            //ME SUSCRIVO A LOS EVENTOS PARA INFORMAR EN EL FORM
            oG.finalizo += new Grabador.Grabador.FinalizoHandler(oG_finalizo);
            oG.progreso += new Grabador.Grabador.ProgresoHandler(oG_progreso);

            SplashStart();
            
        }

        void SplashStart()
        {
            var oFrm = new frmSplash(Resources.TituloInicialSplash);
            oFrm.ShowDialog();
            
            //Carga de los datos
            currentUsuarios.AddRange(Helper.Usuarios);
            SetDataSourseGrillaUsuario(currentUsuarios);
        }

        void oG_finalizo(bool lExito)
        {
            if (lExito == true)
            {
                MessageBox.Show(Resources.ProcesoFinalizado);
            }
            else
                MessageBox.Show(Resources.ErrorProceso);
        }

        void oG_progreso(int porcentaje, string tarea)
        {
            if (tarea == Resources.RealizandoGrabacion)
            {
                progressBar1.Value = porcentaje + 1;
                this.label2.Text = (porcentaje + 1).ToString();
            }
            else if (tarea.Trim() != string.Empty)
            {
                label1.Text = tarea;
                this.label2.Text = porcentaje.ToString();
                progressBar1.Value = porcentaje;
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

                try
                {
                    var velocidades = this.oG.GetWriteSpeed(id);

                    for (int i = 0; i < velocidades.GetLength(0); i++)
                    {
                        this.cmbVelo.Items.Insert(i, velocidades[i]);
                    }

                    this.cmbVelo.SelectedIndex = 0;
                }
                catch
                {
                    cmbVelo.Enabled = false;
                }

                this.labelMediaType.Text = oG.DatosDisco(id);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!this.verificar())
            {
                return;
            }

            try
            {
                var currenUser = (UsuarioDTO)this.dgDatos.CurrentRow.DataBoundItem;





                var id = this.ulista[this.cmbGrabadora.SelectedIndex, 0];
                this.labelMediaType.Text = oG.DatosDisco(id);
                //oG.Grabar(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool verificar()
        {
            if (this.cmbGrabadora.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un dispositivo");
                return false;
            }

            if (!oG.ValidarDiscoVacio(this.ulista[this.cmbGrabadora.SelectedIndex, 0]))
            {
                MessageBox.Show("No hay CD en blanco!!!!");
                return false;
            }

            if (!oG.ValidarCapacidadDisco(this.ulista[this.cmbGrabadora.SelectedIndex, 0]))
            {
                MessageBox.Show("No tiene Capacidad el CD!!!!!");
                return false;
            }

            //Fija de pruba
            if (!oG.AgregarCarpeta("C:\\Reportes"))
            {
                MessageBox.Show("No existe el direcitorio seleccionado !!!!!");
                return false;
            }

            //Fija de pruba
            if (!oG.AgregarArchivo("C:\\Reportes\\Aviso.rdl"))
            {
                MessageBox.Show("No existe el direcitorio seleccionado !!!!!");
                return false;
            }

            return true;

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
            if (this.cmbGrabadora.SelectedIndex == -1)
            {
                return;
            }

            if (!oG.ValidarCapacidadDisco(this.ulista[this.cmbGrabadora.SelectedIndex, 0]))
            {
                MessageBox.Show("ValCapacidadMedia - No tiene Capacidad el CD!!!!!");
                return;
            }

            try
            {
                this.oG.BorrarDisco(this.ulista[this.cmbGrabadora.SelectedIndex, 0], this.checkBoxQuickFormat.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            var listaFaltante = Helper.Usuarios.Where(w => !this.currentUsuarios.Any(c => c.CODCLI == w.CODCLI)).ToList();

            if (listaFaltante.Count == 0)
            {
                MessageBox.Show("No hay usuarios nuevos", "Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            currentUsuarios.AddRange(listaFaltante);

            SetDataSourseGrillaUsuario(currentUsuarios);
            MessageBox.Show("Se actulizaco la lista. Hay " + currentUsuarios.Count.ToString() + " usuarios nuevos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int nro;
            Int32.TryParse(this.textBox1.Text, out nro);
            if (nro > 0)
            {
                var usu = Helper.SearchUsuario(nro);
                if (usu.Count == 0)
                {
                    MessageBox.Show("Usuario inexistente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var modulosUsuario = usu.First().LSISTEM.Split('/').ToList();
                var modulos = Helper.Modulos.Where(w => modulosUsuario.Contains(w.Modulo)).ToList();

                SetDataSourseGrillaUsuario(usu);
                SetDataSouerseGrillaModulo(modulos);

            }
        }

        private void SetDataSourseGrillaUsuario(List<UsuarioDTO> usu)
        {
            dgDatos.DataSource = usu;
        }

        private void SetDataSouerseGrillaModulo(List<ModuloDTO> mod)
        {
            dgDatosModulos.AutoGenerateColumns = false;
            dgDatosModulos.AllowUserToAddRows = false;
            dgDatosModulos.AllowUserToDeleteRows = false;
            dgDatosModulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDatosModulos.DataSource = mod;
            dgDatosModulos.ReadOnly = true;

            dgDatosModulos.Columns.Add("Modulo", "Modulo");
            dgDatosModulos.Columns["Modulo"].DataPropertyName = "Modulo";
            dgDatosModulos.Columns["Modulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgDatosModulos.Columns.Add("Descrip", "Descripción");
            dgDatosModulos.Columns["Descrip"].DataPropertyName = "Descrip";
            dgDatosModulos.Columns["Descrip"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        


        //private void SetGrilla(DataTable datos, DataTable datosu)
        //{
        //    dgDatosModulos.AutoGenerateColumns = false;
        //    dgDatosModulos.AllowUserToAddRows = false;
        //    dgDatosModulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgDatosModulos.DataSource = datos.DefaultView;
        //    dgDatosModulos.Columns.Clear();
        //    dgDatosModulos.Columns.Add("Modulo", "Modulo");
        //    dgDatosModulos.Columns["Modulo"].DataPropertyName = "Modulo";
        //    dgDatosModulos.Columns.Add("Descrip", "Descripción");
        //    dgDatosModulos.Columns["Descrip"].DataPropertyName = "Descrip";


        //    dgDatos.AutoGenerateColumns = false;
        //    dgDatos.AllowUserToAddRows = false;
        //    dgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgDatos.DataSource = datosu.DefaultView;
        //    dgDatos.Columns.Clear();
        //    dgDatos.Columns.Add("CODCLI", "Usuario");
        //    dgDatos.Columns["CODCLI"].DataPropertyName = "CODCLI";
        //    dgDatos.Columns.Add("NOMBRE", "Nombre");
        //    dgDatos.Columns["NOMBRE"].DataPropertyName = "NOMBRE";
        //}
    }
}

