using System;
using System.Windows.Forms;

namespace GGNoTeam_V5
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static AccionesWS.accion acccionGlobal = new AccionesWS.accion();
        public static AccionesWS.AccionesWSClient _daoAcciones = new AccionesWS.AccionesWSClient();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
