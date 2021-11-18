using GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Originador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Emisor
{
    public partial class frmBusquedaEmisor : Form
    {
        private frmRegistroOriginador origAux;
        private GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient _daoOrig;
        private GestionInstrumentosOriginadoresWS.emisor[] emisores;
        public frmBusquedaEmisor()
        {
            InitializeComponent();
        }

        public frmBusquedaEmisor(frmRegistroOriginador orig, String codigo)
        {
            InitializeComponent();
            emisores = _daoOrig.listarEmisores(); //REEMPLZAR POR LISTAR POR NOMBRECODIGo
            dgvEmisores.AutoGenerateColumns = false;
            dgvEmisores.DataSource = emisores;
            origAux = orig;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            origAux.cargarEmisor(emisores[dgvEmisores.CurrentRow.Index]);
        }

        private void dgvEmisores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionInstrumentosOriginadoresWS.emisor emi = (GestionInstrumentosOriginadoresWS.emisor)dgvEmisores.Rows[e.RowIndex].DataBoundItem;
            dgvEmisores.Rows[e.RowIndex].Cells[0].Value = emi.codigo;
            dgvEmisores.Rows[e.RowIndex].Cells[1].Value = emi.nombre;
        }
    }
}
