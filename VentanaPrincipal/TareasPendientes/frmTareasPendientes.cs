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
            iniciarTema();
            
            _daoTareasDiarias = new TareasDiariasWS.TareasDiariasWSClient();
            _daoPersona = new LoginWS.LoginWSClient();
            user = _daoPersona.listarPorCodExacto(Int32.Parse(persona.codigo))[0];
            
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            Global.pintarDGV(ref dgvTareasPendientes, this.btnAgregarTarea.BackColor);

            if (persona.itinerario.listaTarea != null)
            {
                colocarEnDGV(user.itinerario.listaTarea);                
            }
            else
            {
                dgvTareasPendientes.DataSource = null;
            }           
        }

        private void colocarEnDGV(LoginWS.tarea[] lista)
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

        public frmTareasPendientes(LoginWS.persona persona)
        {
            InitializeComponent();
            iniciarTema();
            btnSalir.Visible = true;
            colocarEnDGV(persona.itinerario.listaTarea);
            if (!Global.TemaOscuro)
            {
                this.BackColor = Global.FrmOscuro_2;
            }
            else
            {
                this.BackColor = Global.FrmClaro_2;
            }
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
            txtboxTarea.BackColor = Global.TxtboxOscuro_Back;
        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;
            txtboxTarea.BackColor = Global.TxtboxClaro_Back;
        }

        private void dgvTareasPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxTarea__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxTarea_Enter(object sender, EventArgs e)
        {
            txtboxTarea.Texts = "";
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string tarea = txtboxTarea.Texts;
            TareasDiariasWS.tarea task = new TareasDiariasWS.tarea();

            if (tarea != "" && tarea != "                                                    Ingrese la tarea a agregar.")
            {

                txtboxTarea.Texts = "";
                task.descripcion = tarea;
                task.estado = true;
                task.fidItinerario = user.itinerario.idItineraio;
                task.horaEst = DateTime.Now.ToString("HH:mm:ss");
                task.plazo = 12;

                dgvTareasPendientes.Rows.Add(_daoTareasDiarias.insertarTarea(task), task.descripcion, task.horaEst, task.plazo, "Incompleto");              
            }


        }

        private void btnTareaCompleta_Click(object sender, EventArgs e)
        {
            TareasDiariasWS.tarea task = new TareasDiariasWS.tarea();
            if (dgvTareasPendientes.CurrentRow != null)
            {
                task.idTarea = (int)dgvTareasPendientes.Rows[dgvTareasPendientes.CurrentRow.Index].Cells[0].Value;
                task.descripcion = dgvTareasPendientes.Rows[dgvTareasPendientes.CurrentRow.Index].Cells[1].Value.ToString();
                task.horaEst = dgvTareasPendientes.Rows[dgvTareasPendientes.CurrentRow.Index].Cells[2].Value.ToString();
                task.plazo = (int)dgvTareasPendientes.Rows[dgvTareasPendientes.CurrentRow.Index].Cells[3].Value;                
                if (dgvTareasPendientes.Rows[dgvTareasPendientes.CurrentRow.Index].Cells[4].Value.ToString() == "Incompleto")
                {
                    dgvTareasPendientes.Rows[dgvTareasPendientes.CurrentRow.Index].Cells[4].Value = "Completo";
                    task.estado = true;
                }
                else
                {
                    dgvTareasPendientes.Rows[dgvTareasPendientes.CurrentRow.Index].Cells[4].Value = "Incompleto";
                    task.estado = false;
                }
                _daoTareasDiarias.modificarTarea(task);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtboxTarea_Leave(object sender, EventArgs e)
        {
            //txtboxTarea.Texts = "                                                    Ingrese la tarea a agregar.";
        }
    }
}
