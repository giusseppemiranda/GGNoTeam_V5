using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Emisor;
using GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Instrumento;
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

namespace GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores
{
    public partial class frmGestionOriginadoresInstrumentos : Form
    {
        private frmPrincipal ventanaPadre = null;
        private GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient _daoInstOrig;
        private GestionInstrumentosOriginadoresWS.instrumento[] instrumentos;
        private GestionInstrumentosOriginadoresWS.originador[] originadores;
        private GestionInstrumentosOriginadoresWS.emisor[] emisores;
        private GestionInstrumentosOriginadoresWS.originador origAux;
        private GestionInstrumentosOriginadoresWS.originador origAux2;
        private GestionInstrumentosOriginadoresWS.emisor emiAux;
        private string[] nombresOrig;
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
            dgvInstrumentosOriginadores.DataSource = null;
            if (comboTipo.SelectedItem.ToString() == "Originador") {
                originadores = _daoInstOrig.buscarUnOriginadorPorCodigo(txtboxbusqueda.Texts);
                configurarColumnas();
                if (originadores != null)
                {
                    dgvInstrumentosOriginadores.DataSource = new BindingList<GestionInstrumentosOriginadoresWS.originador>(originadores.ToList());
                    cargarNombresEmis();


                }
                else MessageBox.Show("No se encontraron resultados");
            }
            else if (comboTipo.SelectedItem.ToString() == "Instrumento")
            {
                instrumentos=_daoInstOrig.listarInstrumentoXcodigo(txtboxbusqueda.Texts);
                configurarColumnas();
                if (instrumentos != null)
                {
                    dgvInstrumentosOriginadores.DataSource = new BindingList<GestionInstrumentosOriginadoresWS.instrumento>(instrumentos.ToList());
                    cargarNombresOrig();
                    
                }
                else MessageBox.Show("No se encontraron resultados");

            }
            else if (comboTipo.SelectedItem.ToString() == "Emisor")
            {
                emisores = _daoInstOrig.listarEmisoresPorNombreCodigo(txtboxbusqueda.Texts); 
                configurarColumnas();
                if (emisores != null)
                {
                    dgvInstrumentosOriginadores.DataSource = new BindingList<GestionInstrumentosOriginadoresWS.emisor>(emisores.ToList());
                    
                }
                else MessageBox.Show("No se encontraron resultados");
            }


        }

        private void cargarNombresOrig()
        {
            int i = 0;
            while (true)
            {
                if (i==instrumentos.Length) break;
                origAux2 = _daoInstOrig.buscarOrigId(instrumentos[i].fidOriginador);
                dgvInstrumentosOriginadores.Rows[i].Cells[17].Value = origAux2.codigoOriginador;
                i++;
            }
                
            
        }

        private void cargarNombresEmis()
        {
            int i = 0;
            while (true)
            {
                if (i == originadores.Length) break;
                emiAux = _daoInstOrig.BuscarUnEmisorPorID(originadores[i].fidEmisor);
                dgvInstrumentosOriginadores.Rows[i].Cells[4].Value = emiAux.codigoEmisor;
                dgvInstrumentosOriginadores.Rows[i].Cells[5].Value = emiAux.nombre;
                i++;
            }


        }

        private void dgvInstrumentosOriginadores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (comboTipo.SelectedItem.ToString())
            {
                case "Originador":
                    
                        try {
                            GestionInstrumentosOriginadoresWS.originador orig = (GestionInstrumentosOriginadoresWS.originador)dgvInstrumentosOriginadores.Rows[e.RowIndex].DataBoundItem;
                            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[0].Value = orig.idOriginador;
                            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[1].Value = orig.codigoOriginador;
                            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[2].Value = orig.nombreOriginador;
                            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[3].Value = orig.sectorGics;
                        }
                        catch (Exception ex) { }
                    break;

                case "Instrumento":
                    
                        try { 
                        GestionInstrumentosOriginadoresWS.instrumento inst = (GestionInstrumentosOriginadoresWS.instrumento)dgvInstrumentosOriginadores.Rows[e.RowIndex].DataBoundItem;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[0].Value = inst.idInstrumento;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[1].Value = inst.codigoSBS;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[2].Value = inst.codigoISIN;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[3].Value = inst.codigoID059;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[4].Value = inst.clasificacionErr;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[5].Value = inst.fechaRegistro;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[6].Value = inst.fechaVencimiento;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[7].Value = inst.limiteAplicable;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[8].Value = inst.ratingEncajeSistema;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[9].Value = inst.ratingEncaje;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[10].Value = inst.ratingUnificado;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[11].Value = inst.ratingUnificadoLocal;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[12].Value = inst.factorRiesgo;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[13].Value = inst.score;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[14].Value = inst.moodys;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[15].Value = inst.fechaMoodys;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[16].Value = inst.fechaUltimaClasificacion;
                        }
                        catch (Exception ex) { }
                    break;

                case "Emisor":
                    try
                    {
                        GestionInstrumentosOriginadoresWS.emisor emi = (GestionInstrumentosOriginadoresWS.emisor)dgvInstrumentosOriginadores.Rows[e.RowIndex].DataBoundItem;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[0].Value = emi.idEmisor;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[1].Value = emi.codigoEmisor;
                        dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[2].Value = emi.nombre;
                    }
                        catch(Exception ex) { }
                    break;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInstrumentosOriginadores.SelectedRows.Count > 0)
            {
                if (comboTipo.SelectedItem.ToString() == "Originador")
                {
                    _daoInstOrig.buscarUnOriginadorPorCodigo(originadores[dgvInstrumentosOriginadores.CurrentRow.Index].codigoOriginador);
                }
                else if (comboTipo.SelectedItem.ToString() == "Instrumento")
                {
                    _daoInstOrig.eliminarInstrumento(instrumentos[dgvInstrumentosOriginadores.CurrentRow.Index].idInstrumento);
                }
                else if (comboTipo.SelectedItem.ToString() == "Emisor")
                {
                    _daoInstOrig.listarEmisores();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvInstrumentosOriginadores.SelectedRows.Count > 0) {
                switch (comboTipo.SelectedItem.ToString())
                {
                    case "Originador":
                        {
                            if (dgvInstrumentosOriginadores.CurrentRow != null)
                            {
                                frmRegistroOriginador registrarOrig = new frmRegistroOriginador(originadores[dgvInstrumentosOriginadores.CurrentRow.Index]);
                                registrarOrig.ShowDialog();
                            }

                            break;
                        }

                    case "Instrumento":
                        {
                            if (dgvInstrumentosOriginadores.CurrentRow != null)
                            {
                                frmRegistroInstrumento registrarinst = new frmRegistroInstrumento(instrumentos[dgvInstrumentosOriginadores.CurrentRow.Index]);
                                registrarinst.ShowDialog();
                            }

                            break;
                        }

                    case "Emisor":
                        {
                            if (dgvInstrumentosOriginadores.CurrentRow.Index != null)
                            {
                                frmRegistroEmisor registrarinst = new frmRegistroEmisor(emisores[dgvInstrumentosOriginadores.CurrentRow.Index]);
                                registrarinst.ShowDialog();
                            }

                            break;
                        }
                }
                this.btnBuscar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila");
            }
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvInstrumentosOriginadores.SelectedRows.Count > 0)
            {
                if (comboTipo.SelectedItem.ToString() == "Originador")
                {
                    frmRegistroOriginador registrarOrig = new frmRegistroOriginador();
                    registrarOrig.ShowDialog();
                }
                else if (comboTipo.SelectedItem.ToString() == "Instrumento")
                {
                    frmRegistroInstrumento registrarInst = new frmRegistroInstrumento();
                    registrarInst.ShowDialog();
                }
                else if (comboTipo.SelectedItem.ToString() == "Emisor")
                {
                    frmRegistroEmisor registrarEmi = new frmRegistroEmisor();
                    registrarEmi.ShowDialog();
                }
                this.btnBuscar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila");
            }


        }
        private void configurarColumnas()
        {
            dgvInstrumentosOriginadores.Columns.Clear();
            if (comboTipo.SelectedItem.ToString() == "Originador")
            {
                dgvInstrumentosOriginadores.Columns.Add("idOriginador", "ID");
                dgvInstrumentosOriginadores.Columns.Add("codigoOriginador", "Código originador");
                dgvInstrumentosOriginadores.Columns.Add("nombreOriginador", "Nombre");
                dgvInstrumentosOriginadores.Columns.Add("sectorGics", "Sector");
                dgvInstrumentosOriginadores.Columns.Add("codEmi", "Codigo de emisor asociado");
                dgvInstrumentosOriginadores.Columns.Add("nombreEmi", "Nombre de emisor asociado");
                dgvInstrumentosOriginadores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvInstrumentosOriginadores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvInstrumentosOriginadores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvInstrumentosOriginadores.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvInstrumentosOriginadores.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvInstrumentosOriginadores.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else if (comboTipo.SelectedItem.ToString() == "Instrumento")
            {
                dgvInstrumentosOriginadores.Columns.Add("idInstrumento", "ID");
                dgvInstrumentosOriginadores.Columns.Add("codigoSBS", "Código SBS");
                dgvInstrumentosOriginadores.Columns.Add("codigoISIN", "Código ISIN");
                dgvInstrumentosOriginadores.Columns.Add("codigoID059", "ID059");
                dgvInstrumentosOriginadores.Columns.Add("clasificacionErr", "Clasifiación local");
                dgvInstrumentosOriginadores.Columns.Add("fechaRegistro", "Fecha de Registro");
                dgvInstrumentosOriginadores.Columns.Add("fechaVencimiento", "Fecha de Vencimiento");
                dgvInstrumentosOriginadores.Columns.Add("limiteAplicable", "Limite Aplicable");
                dgvInstrumentosOriginadores.Columns.Add("ratingEncajeSistema", "Rating Encaje Sistema");
                dgvInstrumentosOriginadores.Columns.Add("ratingEncaje", "Rating Encaje");
                dgvInstrumentosOriginadores.Columns.Add("ratingUnificado", "Rating unificado");
                dgvInstrumentosOriginadores.Columns.Add("ratingUnificadoLocal", "Rating unificado local");
                dgvInstrumentosOriginadores.Columns.Add("factorRiesgo", "Factor riesgo");
                dgvInstrumentosOriginadores.Columns.Add("score", "Score");
                dgvInstrumentosOriginadores.Columns.Add("moodys", "Moodys");
                dgvInstrumentosOriginadores.Columns.Add("fechaMoodys", "Fecha Moodys");
                dgvInstrumentosOriginadores.Columns.Add("fechaUltimaClasificacion", "Fecha Ultima Clasificacion");
                dgvInstrumentosOriginadores.Columns.Add("codOrig", "Codigo de originador asociado");

            }
            else if (comboTipo.SelectedItem.ToString() == "Emisor")
            {
                dgvInstrumentosOriginadores.Columns.Add("idEmisor", "ID");
                dgvInstrumentosOriginadores.Columns.Add("codigoEmisor", "Código Emisor");
                dgvInstrumentosOriginadores.Columns.Add("nombreEmisor", "Nombre Emisor");
                dgvInstrumentosOriginadores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvInstrumentosOriginadores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvInstrumentosOriginadores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void btnAsociado_Click(object sender, EventArgs e)
        {
            if (dgvInstrumentosOriginadores.SelectedRows.Count > 0)
            {
                if (comboTipo.SelectedItem.ToString() == "Originador")
                {
                    frmRegistroOriginador registrarOrig = new frmRegistroOriginador();
                    registrarOrig.ShowDialog();
                }
                else if (comboTipo.SelectedItem.ToString() == "Instrumento")
                {
                    frmRegistroInstrumento registrarInst = new frmRegistroInstrumento();
                    registrarInst.ShowDialog();
                }
                else if (comboTipo.SelectedItem.ToString() == "Emisor")
                {
                    frmRegistroEmisor registrarEmi = new frmRegistroEmisor();
                    registrarEmi.ShowDialog();
                }
                this.btnBuscar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila");
            }
        }
    }
}
