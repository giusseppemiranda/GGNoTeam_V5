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
using GGNoTeam_V5.VentanaPrincipal.TareasPendientes.Tareas;

namespace GGNoTeam_V5.VentanaPrincipal
{
    public partial class frmTareasPendientes : Form
    {
        private frmPrincipal ventanaPadre = null;
        private LoginWS.persona user;
        private LoginWS.LoginWSClient _daoPersona;
        private TareasDiariasWS.TareasDiariasWSClient _daoTareasDiarias;

        public frmTareasPendientes(frmPrincipal ventana, LoginWS.persona persona)
        {
            InitializeComponent();
            cambiarTema();

            _daoTareasDiarias = new TareasDiariasWS.TareasDiariasWSClient();
            _daoPersona = new LoginWS.LoginWSClient();
            persona = _daoPersona.listarPorCodExacto(Int32.Parse(persona.codigo))[0];
            user = persona;
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            Global.pintarDGV(ref dgvTareasPendientes, Color.DarkSalmon);

            if (persona.itinerario.listaTarea != null)
            {
                colocarEnDGV(user.itinerario.listaTarea);
            }
            else
            {
                dgvTareasPendientes.DataSource = null;
            }
        }

        public frmTareasPendientes(LoginWS.persona persona)
        {
            InitializeComponent();
            cambiarTema();
            btnSalir.Visible = true;
            colocarEnDGV(persona.itinerario.listaTarea);
            user = persona;
            Global.pintarDGV(ref dgvTareasPendientes, Color.DarkSalmon);

            if (!Global.TemaOscuro)
            {
                this.BackColor = Global.FrmOscuro_2;
            }
            else
            {
                this.BackColor = Global.FrmClaro_2;
            }
        }

        private void colocarEnDGV(LoginWS.tarea[] lista)
        {
            if (lista != null)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    if (lista[i].estado == true)
                    {
                        dgvTareasPendientes.Rows.Add(lista[i].idTarea, lista[i].descripcion, lista[i].horaEst, lista[i].plazo, "Completo");
                    }
                    else
                    {
                        dgvTareasPendientes.Rows.Add(lista[i].idTarea, lista[i].descripcion, lista[i].horaEst, lista[i].plazo, "Incompleto");
                    }
                }
            }
        }

        public void actualizarDGV()
        {
            user = _daoPersona.listarPorCodExacto(Int32.Parse(user.codigo))[0];
            dgvTareasPendientes.Rows.Clear();
            colocarEnDGV(user.itinerario.listaTarea);
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

        private void dgvTareasPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            frmEditarTarea ventanaAgregar = new frmEditarTarea(this, user.itinerario.idItineraio);
            ventanaAgregar.ShowDialog();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmTareasPendientes_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareasPendientes.CurrentRow != null)
            {
                DialogResult r = MessageBox.Show("Está seguro que desea eliminar la tarea seleccionada?", "Eliminar botones", MessageBoxButtons.OKCancel);

                if (r == DialogResult.OK)
                {
                    int idTarea = (int)dgvTareasPendientes.Rows[dgvTareasPendientes.CurrentRow.Index].Cells[0].Value;
                    int validez = _daoTareasDiarias.eliminarTarea(idTarea);
                    if (validez == 1)
                    {
                        MessageBox.Show("La tarea ha sido eliminada con éxito");
                        this.actualizarDGV();
                    }
                    else
                    {
                        MessageBox.Show("No se ha eliminado la tarea");
                    }
                }
            }
        }
        

        private void btnModificarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareasPendientes.CurrentRow != null)
            {
                frmEditarTarea ventanaModificar = new frmEditarTarea(this, user.itinerario.listaTarea[dgvTareasPendientes.CurrentRow.Index]);
                ventanaModificar.ShowDialog();
            }
        }
    }
}
