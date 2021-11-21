﻿using GGNoTeam_V5.Recursos.UserControls;
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
                dgvInstrumentosOriginadores.DataSource = new BindingList<GestionInstrumentosOriginadoresWS.originador> (originadores.ToList());
            }
            else if (comboTipo.SelectedItem.ToString() == "Instrumento")
            {
                instrumentos=_daoInstOrig.listarInstrumentoXcodigo(txtboxbusqueda.Texts);
                configurarColumnas();
                dgvInstrumentosOriginadores.SuspendLayout();
                dgvInstrumentosOriginadores.DataSource = new BindingList<GestionInstrumentosOriginadoresWS.instrumento>(instrumentos.ToList());
                dgvInstrumentosOriginadores.ResumeLayout();

            }
            else if (comboTipo.SelectedItem.ToString() == "Emisor")
            {
                emisores = _daoInstOrig.listarEmisoresPorNombreCodigo(txtboxbusqueda.Texts); //implementar buscar por codigo
                configurarColumnas();
                dgvInstrumentosOriginadores.DataSource = new BindingList<GestionInstrumentosOriginadoresWS.emisor>(emisores.ToList()); ;
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
                            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[1].Value = orig.nombreOriginador;
                            dgvInstrumentosOriginadores.Rows[e.RowIndex].Cells[2].Value = orig.sectorGics;
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (comboTipo.SelectedItem.ToString() == "Originador")
            {
                if (dgvInstrumentosOriginadores.CurrentRow != null)
                {
                    frmRegistroOriginador registrarOrig = new frmRegistroOriginador(originadores[dgvInstrumentosOriginadores.CurrentRow.Index]);
                    registrarOrig.ShowDialog();
                }
            }
            else if (comboTipo.SelectedItem.ToString() == "Instrumento")
            {
                if (dgvInstrumentosOriginadores.CurrentRow != null)
                {
                    frmRegistroInstrumento registrarinst = new frmRegistroInstrumento(instrumentos[dgvInstrumentosOriginadores.CurrentRow.Index]);
                    registrarinst.ShowDialog();
                }
            }
            else if (comboTipo.SelectedItem.ToString() == "Emisor")
            {
                if (dgvInstrumentosOriginadores.CurrentRow.Index != null)
                {
                    frmRegistroEmisor registrarinst = new frmRegistroEmisor(emisores[dgvInstrumentosOriginadores.CurrentRow.Index]);
                    registrarinst.ShowDialog();
                }
            }
            this.btnBuscar_Click(sender, e);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
            this.btnBuscar_Click(sender,e);
        }
        private void configurarColumnas()
        {
            dgvInstrumentosOriginadores.Columns.Clear();
            if (comboTipo.SelectedItem.ToString() == "Originador")
            {
                dgvInstrumentosOriginadores.Columns.Add("idOriginador", "ID");
                dgvInstrumentosOriginadores.Columns.Add("nombreOriginador", "Nombre");
                dgvInstrumentosOriginadores.Columns.Add("sectorGics", "Sector");
                dgvInstrumentosOriginadores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvInstrumentosOriginadores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvInstrumentosOriginadores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

            private string obtenerNombreOrig(int idOrig)
            {
                origAux =_daoInstOrig.buscarOrigId(idOrig);
                return origAux.nombreOriginador;
            }
    }
}
