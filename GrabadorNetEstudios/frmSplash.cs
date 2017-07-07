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
        
        public frmSplash()
        {
            InitializeComponent();
        }

        public frmSplash(string tituloSplash)
        {
            InitializeComponent();

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
            Helper.GetUsuario();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbSplash.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timerSplash.Stop();
            pbSplash.Value = 100;
            Thread.Sleep(3000);
            this.Close();
        }
    }
}
