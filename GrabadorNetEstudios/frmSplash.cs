using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabadorNetEstudios
{
    public partial class frmSplash : Form
    {
        public string mensajeError { get; set; }

        public frmSplash()
        {
            InitializeComponent();
        }

        public frmSplash(string tituloSplash)
        {
            InitializeComponent();
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork2);

            backgroundWorker.RunWorkerAsync();

            if (!string.IsNullOrEmpty(tituloSplash))
            {
                this.lblTitulo.Text = tituloSplash;
            }

        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            pbSplash.Increment(1);

            if (pbSplash.Value >= 100)
            {
                timerSplash.Stop();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                //Helper.DirectoryDelete(Helper.GetPATHESTLOCAL);
                //Helper.DirectoryCopy(Helper.GetPATHEST, Helper.GetPATHESTLOCAL, true);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                mensajeError += string.IsNullOrEmpty(mensajeError) ?  ex.Message : Environment.NewLine;
            }


        }

        private void backgroundWorker_DoWork2(object sender, DoWorkEventArgs e)
        {
            try
            {
                //Helper.GetUsuario();
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                mensajeError += string.IsNullOrEmpty(mensajeError) ? ex.Message : Environment.NewLine;
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbSplash.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timerSplash.Stop();
            if (e.Cancelled == true)
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pbSplash.Value = 100;
                Thread.Sleep(3000);
            }

            this.Close();
        }
    }
}
