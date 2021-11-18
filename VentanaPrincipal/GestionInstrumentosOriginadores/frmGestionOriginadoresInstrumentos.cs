using GGNoTeam_V5.Recursos.UserControls;
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

namespace GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores
{
    public partial class frmGestionOriginadoresInstrumentos : Form
    {
        private frmPrincipal ventanaPadre = null;
        private GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient _daoInstOrig;
        private GestionInstrumentosOriginadoresWS.instrumento[] instrumentos;
        private GestionInstrumentosOriginadoresWS.originador[] originadores;
        public frmGestionOriginadoresInstrumentos(frmPrincipal ventana)
        {
            InitializeComponent();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            dgvInstrumentosOriginadores.AutoGenerateColumns = false;
            _daoInstOrig = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            cargarComboBoxEleccion();
            cambiarTema();
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
            Global.pintarTxtBoxOscuro(ref txtboxbusqueda);
            Global.pintarBtnOscuro(ref btnBuscar);
        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;
            Global.pintarTxtBoxClaro(ref txtboxbusqueda);
            Global.pintarBtnClaro(ref btnBuscar);
        }

        private void cargarComboBoxEleccion()
        {
            comboTipo.Items.Add("Emisor");
            comboTipo.Items.Add("Instrumento");
            comboTipo.Items.Add("Originador");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (comboTipo.SelectedItem.ToString() == "Originador") {
                _daoInstOrig.buscarUnOriginadorPorCodigo(Int32.Parse(txtboxbusqueda.Texts));
            }
            else if (comboTipo.SelectedItem.ToString() == "Instrumento")
            {
                instrumentos=_daoInstOrig.listarInstrumentoXcodigo("");
                dgvInstrumentosOriginadores.DataSource = instrumentos;
            }


        }

        private void dgvInstrumentosOriginadores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionInstrumentosOriginadoresWS.instrumento inst = (GestionInstrumentosOriginadoresWS.instrumento)dgvInstrumentosOriginadores.Rows[e.RowIndex].DataBoundItem;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[0].Value = inst.idInstrumento;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[1].Value = inst.codigoSBS;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[2].Value = inst.codigoISIN;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[3].Value = inst.clasificacionErr;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[4].Value = inst.fechaVencimiento;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[5].Value = inst.situacionInstrumento;

            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[6].Value = inst.situacionCartera;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[7].Value = inst.tipoOperacion;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[8].Value = inst.limiteAplicable;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[9].Value = inst.leyAplicable;

            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[10].Value = inst.ratingEncajeSistema;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[11].Value = inst.ratingEncaje;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[12].Value = inst.ratingUnificado;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[13].Value = inst.ratingUnificadoLocal;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[14].Value = inst.factorRiesgo;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[15].Value = inst.score;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[16].Value = inst.moodys;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[17].Value = inst.fechaMoodys;
            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[18].Value = inst.fechaUltimaClasificacion;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _daoInstOrig.eliminarInstrumento(Int32.Parse(dgvInstrumentosOriginadores.CurrentRow.Cells[0].Value.ToString()));
            
            if (comboTipo.SelectedItem.ToString() == "Originador")
            {
                _daoInstOrig.buscarUnOriginadorPorCodigo(Int32.Parse(txtboxbusqueda.Texts));
            }
            else if (comboTipo.SelectedItem.ToString() == "Instrumento")
            {
                instrumentos = _daoInstOrig.listarInstrumentoXcodigo(txtboxbusqueda.Texts);
                dgvInstrumentosOriginadores.DataSource = instrumentos;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmRegistroInstrumento editarUsuarios = new frmRegistroInstrumento();
            //instrumentos[dgvInstrumentosOriginadores.CurrentRow.Index]
            editarUsuarios.ShowDialog();
        }
    }
}
