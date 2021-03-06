using GGNoTeam_V5.Recursos.UserControls;
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
        private frmPrincipal ventanaPadre = null;
        private AccionesWS.accion[] acciones;
        private AccionesWS.AccionesWSClient _daoAcciones;
        public frmLog(frmPrincipal ventana)
        {
            InitializeComponent();
            ventanaPadre = ventana;

            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);

            Global.pintarDGV(ref dgvLog, Color.DarkSalmon);
            _daoAcciones = new AccionesWS.AccionesWSClient();
            dateInicial.Value = DateTime.Now.AddDays(-7);
            dgvLog.AutoGenerateColumns = false;
        }

        public void cambiarTema()
        {
            if (Global.TemaOscuro)
            {
                activarTemaClaro();
            }
            else
            {
                activarTemaOscuro();
            }
        }

        private void activarTemaOscuro()
        {
            this.BackColor = Global.FrmOscuro;
        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;
        }

        private void btnConsultarRegistros_Click(object sender, EventArgs e)
        {
            dgvLog.comenzarHilo();
            acciones = _daoAcciones.listarAccionesPorFechas(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"));
            dgvLog.setDataSource1(acciones);
        }

        private void dgvLog_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AccionesWS.accion acc = (AccionesWS.accion)dgvLog.Rows[e.RowIndex].DataBoundItem;

            dgvLog.Rows[e.RowIndex].Cells[0].Value = acc.idObjeto;
            dgvLog.Rows[e.RowIndex].Cells[1].Value = acc.nombreActor;
            dgvLog.Rows[e.RowIndex].Cells[2].Value = acc.tipoAccion;
            dgvLog.Rows[e.RowIndex].Cells[3].Value = acc.tablaReferenciada;
            dgvLog.Rows[e.RowIndex].Cells[4].Value = acc.fecha;
            dgvLog.Rows[e.RowIndex].Cells[5].Value = acc.hora;
        }
    }
}
