using GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Instrumento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Originador
{
    public partial class frmBusquedaOrig : Form
    {
        private frmRegistroInstrumento instAux;
        private GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient _daoInst;
        private GestionInstrumentosOriginadoresWS.originador[] originadores;
        private int m, mx, my;

        public frmBusquedaOrig()
        {
            InitializeComponent();
            _daoInst = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
        }

        public frmBusquedaOrig(frmRegistroInstrumento frminst,GestionInstrumentosOriginadoresWS.originador[] originadoresParam)
        {
            InitializeComponent();
            _daoInst = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            originadores = originadoresParam;
            dgvOriginadores.AutoGenerateColumns = false;
            dgvOriginadores.DataSource = originadores;            
            instAux = frminst;
        }

        private void dgvOriginadores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionInstrumentosOriginadoresWS.originador orig = (GestionInstrumentosOriginadoresWS.originador)dgvOriginadores.Rows[e.RowIndex].DataBoundItem;
            dgvOriginadores.Rows[e.RowIndex].Cells[0].Value = orig.codigoOriginador;
            dgvOriginadores.Rows[e.RowIndex].Cells[1].Value = orig.nombreOriginador;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            instAux.cargarOriginador(originadores[dgvOriginadores.CurrentRow.Index]);
            MessageBox.Show("Se asignó el originador correctamente");
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void cerrar()
        {
            this.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
