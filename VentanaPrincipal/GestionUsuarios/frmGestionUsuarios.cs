using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.Usuarios;

namespace GGNoTeam_V5.VentanaPrincipal
{
    public partial class frmGestionUsuarios : Form
    {
        private Color dgvColorActivo;
        private frmPrincipal ventanaPadre = null;

        private LoginWS.persona usuario;
        private LoginWS.LoginWSClient _daoListar;
        private LoginWS.persona[] lista;

        public frmGestionUsuarios(frmPrincipal ventana, LoginWS.persona persona)
        {
            InitializeComponent();
            iniciarTema();
            _daoListar = new LoginWS.LoginWSClient();
            dgvPersonas.AutoGenerateColumns = false;
            usuario = persona;
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            Global.pintarDGV(ref dgvPersonas, btnListarPersonas.BackColor);
            //dataEjemplo();
        }


        private void iniciarTema()
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
            Global.pintarTxtBoxOscuro(ref txtBoxBusqueda);
            Global.pintarBtnOscuro(ref btnBuscar);
        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;
            Global.pintarTxtBoxClaro(ref txtBoxBusqueda);
            Global.pintarBtnClaro(ref btnBuscar);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dgvPersonas.comenzarHilo();
            LoginWS.persona[] usuarios = _daoListar.listarUsuarios();

            lista = usuarios;
            colocarEnDGV(usuarios);

            Global.pintarDGV(ref dgvPersonas, btnListarUsuarios.BackColor);
            this.Cursor = Cursors.Default;
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dgvPersonas.comenzarHilo();
            LoginWS.persona[] administradores = _daoListar.listarAdministradores();

            lista = administradores;
            colocarEnDGV(administradores);

            Global.pintarDGV(ref dgvPersonas, btnListarAdministradores.BackColor);
            this.Cursor = Cursors.Default;
        }

        private void colocarEnDGV(LoginWS.persona[] lista)
        {
            dgvPersonas.setDataSource1(lista);
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dgvPersonas.comenzarHilo();
            LoginWS.persona[] noUsuarios = _daoListar.listarNoUsuarios();
            lista = noUsuarios;
            colocarEnDGV(noUsuarios);
            Global.pintarDGV(ref dgvPersonas, btnListarPersonas.BackColor);
            this.Cursor = Cursors.Default;
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int resultadoEliminacion = -1;
            if (dgvPersonas.CurrentRow != null)
            {

                var result = MessageBox.Show("¿Está seguro que desea eliminar a la persona?", "Eliminar persona", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    resultadoEliminacion = _daoListar.eliminarPersona(lista[dgvPersonas.CurrentRow.Index].idPersona, lista[dgvPersonas.CurrentRow.Index].itinerario.idItineraio);
                    if (resultadoEliminacion == 1)
                    {
                        MessageBox.Show("Se ha eliminado correctamente al usuario");
                        this.btnPersona_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar al usuario");
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }


        }



        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.CurrentRow != null)
            {
                dgvColorActivo = dgvPersonas.GridColor;
                desactivarBotones();

                frmEditarUsuario editarUsuarios = new frmEditarUsuario(lista[dgvPersonas.CurrentRow.Index], btnActualizarUsuario.BackColor, this);
                editarUsuarios.ShowDialog();
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            dgvColorActivo = dgvPersonas.GridColor;
            desactivarBotones();
            frmEditarUsuario crearUsuario = new frmEditarUsuario(btnAgregarUsuario.BackColor, this);
            crearUsuario.ShowDialog();
        }

        public void desactivarBotones()
        {
            Global.pintarDGV(ref dgvPersonas, Color.Black);
        }

        public void activarBotones()
        {
            Global.pintarDGV(ref dgvPersonas, dgvColorActivo);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dgvPersonas.comenzarHilo();
            Global.pintarDGV(ref dgvPersonas, Color.SlateBlue);
            lista = _daoListar.listarPorCodNom(txtBoxBusqueda.Texts);
            if (lista != null)
            {

                colocarEnDGV(lista);
            }
            else
            {

            }
            this.Cursor = Cursors.Default;
        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.CurrentRow != null)
            {
                frmTareasPendientes tareas = new frmTareasPendientes(lista[dgvPersonas.CurrentRow.Index], usuario);
                tareas.ShowDialog();
            }
        }



        private void dgvPersonas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            LoginWS.persona user = (LoginWS.persona)dgvPersonas.Rows[e.RowIndex].DataBoundItem;

            dgvPersonas.Rows[e.RowIndex].Cells[0].Value = user.idPersona;
            dgvPersonas.Rows[e.RowIndex].Cells[1].Value = user.codigo;
            dgvPersonas.Rows[e.RowIndex].Cells[2].Value = user.nombre;
            dgvPersonas.Rows[e.RowIndex].Cells[3].Value = user.apellidos;
            dgvPersonas.Rows[e.RowIndex].Cells[4].Value = user.correo;
            dgvPersonas.Rows[e.RowIndex].Cells[5].Value = user.contraseña;
            dgvPersonas.Rows[e.RowIndex].Cells[6].Value = user.validacion;
            dgvPersonas.Rows[e.RowIndex].Cells[7].Value = user.rol;
        }
    }
}
