using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GGNoTeam_V5.Recursos.UserControls;
using FontAwesome.Sharp;
using GGNoTeam_V5.Recursos.CustomDGV;

namespace GGNoTeam_V5.Recursos.UserControls
{
    static class Global
    {
        private static bool _temaOscuro = false;

        //Control box Oscuro
        private static Color _frmOscuro = Color.FromArgb(45, 45, 45);
        private static Color _frmOscuro_2 = Color.FromArgb(60, 60, 60);
        private static Color _panelControlOscuro = Color.Black;
        private static Color _lblTituloOscuro = Color.White;
        private static Color _btnTemaOscuro_Back = _panelControlOscuro;
        private static Color _btnTemaOscuro_Icon = Color.White;
        private static Color _btnCerrarOscuro_Back = _panelControlOscuro;
        private static Color _btnCerrarOscuro_Icon = Color.White;
        private static Color _btnMinimizarOscuro_Back = _panelControlOscuro;
        private static Color _btnMinimizarOscuro_Icon = Color.White;

        //Control Box Claro
        private static Color _frmClaro = Color.WhiteSmoke;
        private static Color _frmClaro_2 = Color.FromArgb(217, 217, 217);
        private static Color _panelControlClaro = Color.DarkGray;
        private static Color _lblTituloClaro = Color.MidnightBlue;
        private static Color _btnTemaClaro_Back = _panelControlClaro;
        private static Color _btnTemaClaro_Icon = Color.MidnightBlue;
        private static Color _btnCerrarClaro_Back = _panelControlClaro;
        private static Color _btnCerrarClaro_Icon = Color.MidnightBlue;
        private static Color _btnMinimizarClaro_Back = _panelControlClaro;
        private static Color _btnMinimizarClaro_Icon = Color.MidnightBlue;

        //Menu Deslizante Oscuro
        private static Color _panelMenuOscuro = Color.FromArgb(15, 15, 15);
        private static Color _btnMenuOscuro_Back = _panelMenuOscuro;
        private static Color _btnMenuOscuro_Icon = Color.White;


        //Menu Deslizante Claro
        private static Color _panelMenuClaro = Color.Silver;
        private static Color _btnMenuClaro_Back = _panelMenuClaro;
        private static Color _btnMenuClaro_Icon = Color.MidnightBlue; 


        //ToolBox Oscuro
        private static Color _txtboxOscuro_Back = _frmOscuro;
        private static Color _txtboxOscuro_BorderFocus = Color.MediumOrchid;
        private static Color _txtboxOscuro_Border = Color.DodgerBlue;
        private static Color _btnOscuro = Color.DodgerBlue;
        private static Color _linkOscuro = Color.Aquamarine;

        //ToolBox Oscuro
        private static Color _txtboxClaro_Back = _frmClaro;
        private static Color _txtboxClaro_BorderFocus = Color.MidnightBlue;
        private static Color _txtboxClaro_Border = Color.DodgerBlue;
        private static Color _btnClaro = Color.DeepSkyBlue;
        private static Color _linkClaro = Color.Blue;
        
        public static bool TemaOscuro { get => _temaOscuro; set => _temaOscuro = value; }
        public static Color FrmOscuro { get => _frmOscuro; set => _frmOscuro = value; }
        public static Color PanelControlOscuro { get => _panelControlOscuro; set => _panelControlOscuro = value; }
        public static Color LblTituloOscuro { get => _lblTituloOscuro; set => _lblTituloOscuro = value; }
        public static Color BtnTemaOscuro_Back { get => _btnTemaOscuro_Back; set => _btnTemaOscuro_Back = value; }
        public static Color BtnTemaOscuro_Icon { get => _btnTemaOscuro_Icon; set => _btnTemaOscuro_Icon = value; }
        public static Color BtnCerrarOscuro_Back { get => _btnCerrarOscuro_Back; set => _btnCerrarOscuro_Back = value; }
        public static Color BtnCerrarOscuro_Icon { get => _btnCerrarOscuro_Icon; set => _btnCerrarOscuro_Icon = value; }
        public static Color BtnMinimizarOscuro_Back { get => _btnMinimizarOscuro_Back; set => _btnMinimizarOscuro_Back = value; }
        public static Color BtnMinimizarOscuro_Icon { get => _btnMinimizarOscuro_Icon; set => _btnMinimizarOscuro_Icon = value; }
        public static Color FrmClaro { get => _frmClaro; set => _frmClaro = value; }
        public static Color PanelControlClaro { get => _panelControlClaro; set => _panelControlClaro = value; }
        public static Color LblTituloClaro { get => _lblTituloClaro; set => _lblTituloClaro = value; }
        public static Color BtnTemaClaro_Back { get => _btnTemaClaro_Back; set => _btnTemaClaro_Back = value; }
        public static Color BtnTemaClaro_Icon { get => _btnTemaClaro_Icon; set => _btnTemaClaro_Icon = value; }
        public static Color BtnCerrarClaro_Back { get => _btnCerrarClaro_Back; set => _btnCerrarClaro_Back = value; }
        public static Color BtnCerrarClaro_Icon { get => _btnCerrarClaro_Icon; set => _btnCerrarClaro_Icon = value; }
        public static Color BtnMinimizarClaro_Back { get => _btnMinimizarClaro_Back; set => _btnMinimizarClaro_Back = value; }
        public static Color BtnMinimizarClaro_Icon { get => _btnMinimizarClaro_Icon; set => _btnMinimizarClaro_Icon = value; }
        public static Color TxtboxOscuro_Back { get => _txtboxOscuro_Back; set => _txtboxOscuro_Back = value; }
        public static Color TxtboxOscuro_BorderFocus { get => _txtboxOscuro_BorderFocus; set => _txtboxOscuro_BorderFocus = value; }
        public static Color BtnOscuro { get => _btnOscuro; set => _btnOscuro = value; }
        public static Color LinkOscuro { get => _linkOscuro; set => _linkOscuro = value; }
        public static Color TxtboxClaro_Back { get => _txtboxClaro_Back; set => _txtboxClaro_Back = value; }
        public static Color TxtboxClaro_BorderFocus { get => _txtboxClaro_BorderFocus; set => _txtboxClaro_BorderFocus = value; }
        public static Color BtnClaro { get => _btnClaro; set => _btnClaro = value; }
        public static Color LinkClaro { get => _linkClaro; set => _linkClaro = value; }
        public static Color TxtboxOscuro_Border { get => _txtboxOscuro_Border; set => _txtboxOscuro_Border = value; }
        public static Color TxtboxClaro_Border { get => _txtboxClaro_Border; set => _txtboxClaro_Border = value; }
        public static Color PanelMenuOscuro { get => _panelMenuOscuro; set => _panelMenuOscuro = value; }
        public static Color PanelMenuClaro { get => _panelMenuClaro; set => _panelMenuClaro = value; }
        public static Color BtnMenuClaro_Back { get => _btnMenuClaro_Back; set => _btnMenuClaro_Back = value; }
        public static Color BtnMenuClaro_Icon { get => _btnMenuClaro_Icon; set => _btnMenuClaro_Icon = value; }
        public static Color BtnMenuOscuro_Back { get => _btnMenuOscuro_Back; set => _btnMenuOscuro_Back = value; }
        public static Color BtnMenuOscuro_Icon { get => _btnMenuOscuro_Icon; set => _btnMenuOscuro_Icon = value; }
        public static Color FrmOscuro_2 { get => _frmOscuro_2; set => _frmOscuro_2 = value; }
        public static Color FrmClaro_2 { get => _frmClaro_2; set => _frmClaro_2 = value; }

        public static void pintarControlBoxOscuro(ref Panel panel, ref Label titulo, ref IconButton btnCerrar, ref IconButton btnMinimizar, ref IconButton btnTema)
        {            
            panel.BackColor = PanelControlOscuro;
            titulo.ForeColor = LblTituloOscuro;
            btnTema.BackColor = PanelControlOscuro;
            btnTema.IconColor = BtnTemaOscuro_Icon;
            btnMinimizar.BackColor = PanelControlOscuro;
            btnMinimizar.IconColor = BtnMinimizarOscuro_Icon;
            btnCerrar.BackColor = PanelControlOscuro;
            btnCerrar.IconColor = BtnCerrarOscuro_Icon;
        }

        public static void pintarControlBoxClaro(ref Panel panel, ref Label titulo, ref IconButton btnCerrar, ref IconButton btnMinimizar, ref IconButton btnTema)
        {            
            panel.BackColor = PanelControlClaro;
            titulo.ForeColor = LblTituloClaro;
            btnTema.BackColor = PanelControlClaro;
            btnTema.IconColor = BtnTemaClaro_Icon;
            btnMinimizar.BackColor = PanelControlClaro;
            btnMinimizar.IconColor = BtnMinimizarClaro_Icon;
            btnCerrar.BackColor = PanelControlClaro;
            btnCerrar.IconColor = BtnCerrarClaro_Icon;
        }

        public static void pintarTxtBoxOscuro(ref GGTextBox txtbox) {
            txtbox.BackColor = TxtboxOscuro_Back;
            txtbox.BorderColor = TxtboxOscuro_Border;
            txtbox.BorderFocusColor = TxtboxOscuro_BorderFocus;
        }

        public static void PintarTxtBoxClaro(ref GGTextBox txtbox)
        {
            txtbox.BackColor = TxtboxClaro_Back;
            txtbox.BorderColor = TxtboxClaro_Border;
            txtbox.BorderFocusColor = TxtboxClaro_BorderFocus;
        }

        public static void pintarBtnOscuro(ref GGButton btn)
        {
            btn.BackColor = BtnOscuro;
        }
        

        public static void pintarLinkOscuro(ref LinkLabel link)
        {
            link.LinkColor = Global.LinkOscuro;
        }

        public static void pintarTxtBoxClaro(ref GGTextBox txtbox)
        {
            txtbox.BackColor = TxtboxClaro_Back;
            txtbox.BorderColor = TxtboxClaro_Border;
            txtbox.BorderFocusColor = TxtboxClaro_BorderFocus;
        }

        public static void pintarComboBoxOscuro(ref GGComboBox comboBox)
        {
            comboBox.BackColor = TxtboxOscuro_Back;
            comboBox.BorderColor = TxtboxOscuro_Border;            
        }

        public static void pintarComboBoxClaro(ref GGComboBox comboBox)
        {
            comboBox.BackColor = TxtboxClaro_Back;
            comboBox.BorderColor = TxtboxOscuro_Border;
        }

        public static void pintarBtnClaro(ref GGButton btn)
        {
            btn.BackColor = BtnClaro;
        }

        public static void pintarLinkClaro(ref LinkLabel link)
        {
            link.LinkColor = Global.LinkClaro;
        }

        
        public static void pintarBotonMenuOscuro(ref IconButton boton)
        {
            boton.BackColor = PanelMenuOscuro;
            boton.IconColor = BtnMenuOscuro_Icon;
            boton.ForeColor = boton.IconColor;
        }

        public static void pintarBotonMenuClaro(ref IconButton boton)
        {
            boton.BackColor = PanelMenuClaro;
            boton.IconColor = BtnMenuClaro_Icon;
            boton.ForeColor = boton.IconColor;
        }

        public static void pintarMenuNavegacionOscuro(ref Panel panel, ref IconButton menu, ref IconButton signout, ref IconButton users, ref IconButton tasks, ref IconButton tealfa, ref IconButton monitor, ref IconButton originst, ref IconButton email)
        {
            panel.BackColor = PanelMenuOscuro;
            pintarBotonMenuOscuro(ref menu);
            pintarBotonMenuOscuro(ref signout);
            pintarBotonMenuOscuro(ref users);
            pintarBotonMenuOscuro(ref tasks);
            pintarBotonMenuOscuro(ref tealfa);
            pintarBotonMenuOscuro(ref monitor);
            pintarBotonMenuOscuro(ref originst);
            pintarBotonMenuOscuro(ref email);

        }

        public static void pintarMenuNavegacionClaro(ref Panel panel, ref IconButton menu, ref IconButton signout, ref IconButton users, ref IconButton tasks, ref IconButton tealfa, ref IconButton monitor, ref IconButton originst, ref IconButton email)
        {
            panel.BackColor = PanelMenuClaro;
            pintarBotonMenuClaro(ref menu);
            pintarBotonMenuClaro(ref signout);
            pintarBotonMenuClaro(ref users);
            pintarBotonMenuClaro(ref tasks);
            pintarBotonMenuClaro(ref tealfa);
            pintarBotonMenuClaro(ref monitor);
            pintarBotonMenuClaro(ref originst);
            pintarBotonMenuClaro(ref email);
        }     

        public static Color aclararColor(Color color)
        {
            Byte red = color.R;
            Byte green = color.G;
            Byte blue = color.B;

            double porcentaje = 0.4;

            return Color.FromArgb(aclarar(red, porcentaje), aclarar(green, porcentaje), aclarar(blue, porcentaje));
        }

        public static Color oscurecerColor(Color color)
        {
            Byte red = color.R;
            Byte green = color.G;
            Byte blue = color.B;

            double porcentaje = 0.1;

            return Color.FromArgb(oscurecer(red, porcentaje), oscurecer(green, porcentaje), oscurecer(blue, porcentaje));
        }

        private static Byte aclarar(Byte color, double porcentaje)
        {

            return (Byte)Math.Min(255, color + 255 * porcentaje);
        }

        private static Byte oscurecer(Byte color, double porcentaje)
        {
            return (Byte)Math.Max(0, color - 255 * porcentaje);
        }

        public static void pintarDGV(ref ProgressDataGridView dgv, Color colorPrincipal)
        {
            
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle colHeadStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowHeadStyle = new System.Windows.Forms.DataGridViewCellStyle();

            double porcAclarar_background = 0.35;
            double porcAclarar_celda = porcAclarar_background - 0.1;

            Byte green = colorPrincipal.G;
            Byte blue = colorPrincipal.B;
            Byte red = colorPrincipal.R;

            Byte redOscuro = oscurecer(red, porcAclarar_background);
            Byte greenOscuro = oscurecer(green, porcAclarar_background);
            Byte blueOscuro = oscurecer(blue, porcAclarar_background);

            Byte redClaro_background = aclarar(red, porcAclarar_background);
            Byte greenClaro_background = aclarar(green, porcAclarar_background);
            Byte blueClaro_background = aclarar(blue, porcAclarar_background);

            Byte redClaro_celda = aclarar(red, porcAclarar_celda);
            Byte greenClaro_celda = aclarar(green, porcAclarar_celda);
            Byte blueClaro_celda = aclarar(blue, porcAclarar_celda);




            //RowsDefaultCellStyle
            rowStyle.BackColor = Color.FromArgb(redClaro_celda, greenClaro_celda, blueClaro_celda);
            rowStyle.SelectionBackColor = colorPrincipal;
            rowStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //ColumnHeadersDefaultStyle
            colHeadStyle.BackColor = Color.FromArgb(redOscuro, greenOscuro, blueOscuro);
            colHeadStyle.ForeColor = Color.White;
            colHeadStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            colHeadStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colHeadStyle.SelectionBackColor = colHeadStyle.BackColor;

            //RowHeadersDefaultStyle
            rowHeadStyle.BackColor = rowStyle.BackColor;            
            rowHeadStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rowHeadStyle.SelectionBackColor = rowHeadStyle.BackColor;
            rowHeadStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.BackgroundColor = Color.FromArgb(redClaro_background, greenClaro_background, blueClaro_background);
            dgv.GridColor = Color.FromArgb(red, green, blue);
            
            dgv.RowsDefaultCellStyle = rowStyle;
            dgv.ColumnHeadersDefaultCellStyle = colHeadStyle;
            dgv.RowHeadersDefaultCellStyle = rowHeadStyle;
            
            
        }
    }
}
