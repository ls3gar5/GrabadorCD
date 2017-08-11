using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabadorNetEstudios
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new frmGrabadoraCD());
            }catch (IndexOutOfRangeException ex)
            {
                var mensa = ex.Message;
            }
            catch (Exception ex)
            {
                var mensa = ex.Message;
            }
            
        }
    }
}
