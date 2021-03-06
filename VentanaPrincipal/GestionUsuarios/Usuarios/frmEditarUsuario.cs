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
using GGNoTeam_V5.Recursos.Validaciones;

namespace GGNoTeam_V5.VentanaPrincipal.Usuarios
{
    public partial class frmEditarUsuario : Form
    {
        private List<String> ListaTiposUsuarios = new List<String>();
        private frmGestionUsuarios ventanaPadre = null;

        private LoginWS.LoginWSClient _daoCliente;
        private LoginWS.persona persona;

        //Modificar usuario
        public frmEditarUsuario(LoginWS.persona usuario, Color indicadorVentana, frmGestionUsuarios ventana)
        {
            InitializeComponent();
            cambiarTema();        
            cargarDatos(usuario);
            persona = usuario;
            _daoCliente = new LoginWS.LoginWSClient();    
            panelIndicadorVentana.BackColor = indicadorVentana;
            ventanaPadre = ventana;
            lblTitulo.Text = "MODIFICAR USUARIO";
            btnSiguiente.Text = "Actualizar";
        }


        //Agregar usuario
        public frmEditarUsuario(Color indicadorVentana, frmGestionUsuarios ventana)
        {
            InitializeComponent();
            cambiarTema();
            _daoCliente = new LoginWS.LoginWSClient();
            panelIndicadorVentana.BackColor = indicadorVentana;
            ventanaPadre = ventana;
            lblTitulo.Text = "INSERTAR USUARIO";
            btnSiguiente.Text = "Insertar";
            cargarTiposUsuarios();
            comboBoxTipoUsuario.SelectedIndex = 2;
        }


        private void cargarTiposUsuarios()
        {
            ListaTiposUsuarios.Add("Administrador");
            ListaTiposUsuarios.Add("Usuario");
            ListaTiposUsuarios.Add("Inactivo");

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

            //boxContraseña.Texts = persona.contraseña;
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
            boxItinerario.BackColor = boxID.BackColor;
            boxItinerario.BorderColor = boxID.BackColor;
            Global.pintarTxtBoxOscuro(ref boxCodigo);
            Global.pintarTxtBoxOscuro(ref boxNombres);
            Global.pintarTxtBoxOscuro(ref boxApellidos);
            Global.pintarTxtBoxOscuro(ref boxCorreo);            
            Global.pintarComboBoxOscuro(ref comboBoxTipoUsuario);
            Global.pintarTxtBoxOscuro(ref boxContraseña);                     
            Global.pintarBtnOscuro(ref btnSiguiente);
        }

        public void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro_2;
            boxID.BackColor = Color.DarkGray;
            boxID.BorderColor = boxID.BackColor;
            boxItinerario.BackColor = boxID.BackColor;
            boxItinerario.BorderColor = boxID.BackColor;
            Global.pintarTxtBoxClaro(ref boxCodigo);
            Global.pintarTxtBoxClaro(ref boxNombres);
            Global.pintarTxtBoxClaro(ref boxApellidos);
            Global.pintarTxtBoxClaro(ref boxCorreo);            
            Global.pintarComboBoxClaro(ref comboBoxTipoUsuario);    
            Global.pintarTxtBoxClaro(ref boxContraseña);                 
            Global.pintarBtnClaro(ref btnSiguiente);
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
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
            int valido = -1;
            boxContraseña.Texts = boxContraseña.Texts.Trim();

            valido = ValidarTextBox.NumeroEntero(boxCodigo, "El código",15);
            if (valido != 0) return;
            valido = ValidarTextBox.NoNumerico(boxNombres, "El nombre",45);
            if (valido != 0) return;
            valido = ValidarTextBox.NoNumerico(boxApellidos, "El apellido",45);
            if (valido != 0) return;
            valido = ValidarTextBox.correo(boxCorreo, "El correo", 45);
            if (valido != 0) return;            
            valido = ValidarTextBox.cadenaGrande(boxContraseña, "La contraseña", 15);
            if (valido != 0) return;            
            

            int validez = -1;

            if (boxID.Texts == "")
            {
                cargarDatos_2();
                validez = _daoCliente.insertarPersona(persona);
                if (validez > 0)
                {   
                    Program.acccionGlobal.fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    Program.acccionGlobal.hora = DateTime.Now.ToString("HH:mm:ss");
                    Program.acccionGlobal.idObjeto = validez;
                    Program.acccionGlobal.tablaReferenciada = "Persona";
                    Program.acccionGlobal.tipoAccion = "Insertar";
                    Program._daoAcciones.insertarAccion(Program.acccionGlobal);
                    MessageBox.Show("Se insertó correctamente al usuario.");

                } else
                {
                    
                    MessageBox.Show("No se ha insertado correctamente al usuario. Ya debe de existir en la base de datos.");
                }
            }
            else
            {
                cargarDatos();
                validez = _daoCliente.modificarPersona(persona);
                if(validez == 1)
                {
                    Program.acccionGlobal.fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    Program.acccionGlobal.hora = DateTime.Now.ToString("HH:mm:ss");
                    Program.acccionGlobal.idObjeto = persona.idPersona;
                    Program.acccionGlobal.tablaReferenciada = "Persona";
                    Program.acccionGlobal.tipoAccion = "Modificar";
                    Program._daoAcciones.insertarAccion(Program.acccionGlobal);
                    MessageBox.Show("Se ha modificado correctamente al usuario seleccionado.");
                } else
                {
                    MessageBox.Show("Hubo un error al modificar al usuario. Intente nuevamente.");
                }
                
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
            persona.validacion = "";
            persona.tipoUsuario = comboBoxTipoUsuario.SelectedIndex + 1;            
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
            persona.validacion = "";
            persona.tipoUsuario = comboBoxTipoUsuario.SelectedIndex + 1;            
        }
    }
}
