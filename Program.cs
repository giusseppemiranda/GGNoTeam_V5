using GGNoTeam_V5.Recursos;
using GGNoTeam_V5.Recursos.PantallaDeCarga;
using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            
            //Global_LoadingForm.Show();

        }
    }
}
