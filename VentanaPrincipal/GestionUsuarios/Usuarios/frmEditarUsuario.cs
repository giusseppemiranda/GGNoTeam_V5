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

namespace GGNoTeam_V5.VentanaPrincipal.Usuarios
{
    public partial class frmEditarUsuario : Form
    {
        private List<String> ListaTiposUsuarios = new List<String>();
        private frmGestionUsuarios ventanaPadre = null;

        private LoginWS.LoginWSClient _daoCliente;
        private LoginWS.persona persona;

        public frmEditarUsuario(LoginWS.persona usuario, Color indicadorVentana, frmGestionUsuarios ventana)
        {
            InitializeComponent();
            cambiarTema();        
            cargarDatos(usuario);
            persona = usuario;
            _daoCliente = new LoginWS.LoginWSClient();    
            panelIndicadorVentana.BackColor = indicadorVentana;
            ventanaPadre = ventana;
            btnSiguiente.Text = "Actualizar";
        }


        public frmEditarUsuario(Color indicadorVentana, frmGestionUsuarios ventana)
        {
            InitializeComponent();
            cambiarTema();
            _daoCliente = new LoginWS.LoginWSClient();
            panelIndicadorVentana.BackColor = indicadorVentana;
            ventanaPadre = ventana;
            btnSiguiente.Text = "Insertar";
            cargarTiposUsuarios();
        }

        //
        //Modificar en base a la base de datos
        //
        private void cargarTiposUsuarios()
        {
            ListaTiposUsuarios.Add("Administrador");
            ListaTiposUsuarios.Add("Usuario");
            ListaTiposUsuarios.Add("No usuario");

            for(int i = 0; i < ListaTiposUsuarios.Count; i++)
            {
                comboBoxTipoUsuario.Items.Add(ListaTiposUsuarios[i]);
            }
        }

        private void cargarDatos(LoginWS.persona persona)
        {
            cargarTiposUsuarios();
            boxID.Texts = persona.idPersona.ToString();
            boxCodigo.Texts = persona.codigo;
            boxNombres.Texts = persona.nombre;
            boxApellidos.Texts = persona.apellidos;
            boxCorreo.Texts = persona.correo;
            boxItinerario.Texts = persona.itinerario.idItineraio.ToString();

            comboBoxTipoUsuario.SelectedIndex = persona.tipoUsuario - 1;

            boxContraseña.Texts = persona.contraseña;
            boxCodigoValidacion.Texts = persona.validacion;
            boxRol.Texts = persona.rol;

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

        public void activarTemaOscuro()
        {
            this.BackColor = Global.FrmOscuro_2;
            boxID.BackColor = Color.Black;
            boxID.BorderColor = boxID.BackColor;
            
            Global.pintarTxtBoxOscuro(ref boxCodigo);
            Global.pintarTxtBoxOscuro(ref boxNombres);
            Global.pintarTxtBoxOscuro(ref boxApellidos);
            Global.pintarTxtBoxOscuro(ref boxCorreo);
            Global.pintarTxtBoxOscuro(ref boxItinerario);
            Global.pintarComboBoxOscuro(ref comboBoxTipoUsuario);
            Global.pintarTxtBoxOscuro(ref boxContraseña);
            Global.pintarTxtBoxOscuro(ref boxCodigoValidacion);
            Global.pintarTxtBoxOscuro(ref boxRol);
            Global.pintarBtnOscuro(ref btnSiguiente);
        }

        public void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro_2;
            boxID.BackColor = Color.DarkGray;
            boxID.BorderColor = boxID.BackColor;
            Global.pintarTxtBoxClaro(ref boxCodigo);
            Global.pintarTxtBoxClaro(ref boxNombres);
            Global.pintarTxtBoxClaro(ref boxApellidos);
            Global.pintarTxtBoxClaro(ref boxCorreo);
            Global.pintarTxtBoxClaro(ref boxItinerario);
            Global.pintarComboBoxClaro(ref comboBoxTipoUsuario);    
            Global.pintarTxtBoxClaro(ref boxContraseña);
            Global.pintarTxtBoxClaro(ref boxCodigoValidacion);
            Global.pintarTxtBoxClaro(ref boxRol);
            Global.pintarBtnClaro(ref btnSiguiente);
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ventanaPadre.activarBotones();
            this.Dispose();
        }

        private void boxID__TextChanged(object sender, EventArgs e)
        {

        }

        private void boxID_Click(object sender, EventArgs e)
        {
            lblIndicación.Visible = true;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            ventanaPadre.activarBotones();
            
            if (boxID.Texts == "")
            {
                //persona.idPersona = Int32.Parse(boxID.Texts);
                cargarDatos_2();
                _daoCliente.insertarPersona(persona);
            } else
            {
                cargarDatos();
                _daoCliente.modificarPersona(persona);
            }
            
            this.Dispose();
        }
        private void cargarDatos_2()
        {
            persona = new LoginWS.persona();

            LoginWS.itinerario iti = new LoginWS.itinerario();
            iti.idItineraio = 0;
            persona.itinerario = iti;

            persona.idPersona = 0;
            persona.codigo = boxCodigo.Texts;
            persona.nombre = boxNombres.Texts;
            persona.apellidos = boxApellidos.Texts;
            persona.contraseña = boxContraseña.Texts;            
            persona.correo = boxCorreo.Texts;
            persona.validacion = boxCodigoValidacion.Texts.ToString();
            persona.tipoUsuario = comboBoxTipoUsuario.SelectedIndex + 1;
            persona.rol = boxRol.Texts;
        }

        private void cargarDatos()
        {
            //persona = new LoginWS.persona();
            //TareasDiariasWS            
            persona.codigo = boxCodigo.Texts;
            persona.nombre = boxNombres.Texts;
            persona.apellidos = boxApellidos.Texts;
            persona.contraseña = boxContraseña.Texts;
            persona.itinerario.idItineraio = Int32.Parse(boxItinerario.Texts);  
            persona.correo = boxCorreo.Texts;           
            persona.validacion = boxCodigoValidacion.Texts.ToString();
            persona.tipoUsuario = comboBoxTipoUsuario.SelectedIndex + 1;
            persona.rol = boxRol.Texts;
        }
    }
}
