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
        private GestionInstrumentosOriginadoresWS.emisor[] emisoresAux;
        private int m, mx, my;

        public frmBusquedaEmisor()
        {
            InitializeComponent();
        }

        public frmBusquedaEmisor(frmRegistroOriginador frmorig, GestionInstrumentosOriginadoresWS.emisor[] emisores)
        {
            InitializeComponent();
            dgvEmisores.AutoGenerateColumns = false;
            dgvEmisores.setDataSource1(new BindingList<GestionInstrumentosOriginadoresWS.emisor>(emisores.ToList()));
            emisoresAux = emisores;
            origAux = frmorig;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            origAux.cargarEmisor(emisoresAux[dgvEmisores.CurrentRow.Index]);
            MessageBox.Show("Emisor asignado correctamente!");
            this.Dispose();
        }

        private void dgvEmisores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionInstrumentosOriginadoresWS.emisor emi = (GestionInstrumentosOriginadoresWS.emisor)dgvEmisores.Rows[e.RowIndex].DataBoundItem;
            dgvEmisores.Rows[e.RowIndex].Cells[0].Value = emi.codigoEmisor;
            dgvEmisores.Rows[e.RowIndex].Cells[1].Value = emi.nombre;
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
