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
        public frmBusquedaOrig()
        {
            InitializeComponent();
            _daoInst = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
        }

        public frmBusquedaOrig(frmRegistroInstrumento inst,String nombreCodigo)
        {
            InitializeComponent();
            _daoInst = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            originadores = _daoInst.buscarUnOriginadorPorCodigo(nombreCodigo);
            dgvOriginadores.DataSource = originadores;
            instAux = inst;
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
