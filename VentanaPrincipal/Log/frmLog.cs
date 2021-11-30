using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.Log
{
    public partial class frmLog : Form
    {
        private AccionesWS.AccionesWSClient _daoAcciones;
        public frmLog()
        {
            InitializeComponent();
            _daoAcciones = new AccionesWS.AccionesWSClient();
            dateInicial.Value = DateTime.Now.AddDays(-7);
            dgvLog.AutoGenerateColumns = false;
        }
        private void btnConsultarRegistros_Click(object sender, EventArgs e)
        {
            dgvLog.DataSource=new BindingList<AccionesWS.accion>(_daoAcciones.listarAccionesPorFechas(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd")).ToList());
        }
        private void agregarAccion()
        {
            //
        }
    }
}
