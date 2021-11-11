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
            dgvPersonas.Rows.Clear();
            Global.pintarDGV(ref dgvPersonas, btnListarUsuarios.BackColor);
            LoginWS.persona[] usuarios = _daoListar.listarUsuarios();
            if (usuarios != null)
            {
                lista = usuarios;
                colocarEnDGV(usuarios);
            }
            else
            {

            }
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            Global.pintarDGV(ref dgvPersonas, btnListarAdministradores.BackColor);
            dgvPersonas.Rows.Clear();
            LoginWS.persona[] administradores = _daoListar.listarAdministradores();
            if (administradores != null)
            {
                lista = administradores;
                colocarEnDGV(administradores);
            }
            else
            {

            }
        }

        private void colocarEnDGV(LoginWS.persona[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                dgvPersonas.Rows.Add(lista[i].idPersona, lista[i].codigo, lista[i].nombre, lista[i].apellidos, lista[i].correo, lista[i].itinerario.idItineraio, lista[i].tipoUsuario, lista[i].contraseña, lista[i].validacion, lista[i].rol);
            }
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Global.pintarDGV(ref dgvPersonas, btnListarPersonas.BackColor);
            dgvPersonas.Rows.Clear();
            LoginWS.persona[] noUsuarios = _daoListar.listarNoUsuarios();
            if (noUsuarios != null)
            {
                lista = noUsuarios;
                colocarEnDGV(noUsuarios);
            }
            else
            {

            }

                    
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            _daoListar.eliminarPersona(lista[dgvPersonas.CurrentRow.Index].idPersona, lista[dgvPersonas.CurrentRow.Index].itinerario.idItineraio);
            //MessageBox.Show("¿Está seguro que desea eliminar a la persona?", MessageBoxButtons.OKCancel);
        }



        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            dgvColorActivo = dgvPersonas.GridColor;
            desactivarBotones();
            frmEditarUsuario editarUsuarios = new frmEditarUsuario(lista[dgvPersonas.CurrentRow.Index], btnActualizarUsuario.BackColor, this);
            editarUsuarios.ShowDialog();
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
            if (txtBoxBusqueda.Texts != "Ingrese el nombre o el código del usuario:")
            {
                Global.pintarDGV(ref dgvPersonas, Color.SlateBlue);
                dgvPersonas.Rows.Clear();
                LoginWS.persona[] buscar = _daoListar.listarPorCodNom(txtBoxBusqueda.Texts);
                if (buscar != null)
                {

                    colocarEnDGV(buscar);
                }
                else
                {

                }
            }
        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.Rows != null)
            {
                frmTareasPendientes tareas = new frmTareasPendientes(lista[dgvPersonas.CurrentRow.Index]);
                tareas.ShowDialog();
            }
        }

        private void txtBoxBusqueda_Enter(object sender, EventArgs e)
        {
            txtBoxBusqueda.Texts = "";
        }

        private void txtBoxBusqueda_Leave(object sender, EventArgs e)
        {
            //txtBoxBusqueda.Texts = "Ingrese el nombre o el código del usuario:";
        }
    }
}
