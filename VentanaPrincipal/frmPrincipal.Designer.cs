
namespace GGNoTeam_V5.VentanaPrincipal
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnTemaOscuro = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.btnSignOut = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnBandejaEntrada = new FontAwesome.Sharp.IconButton();
            this.btnOriginadorInstrumento = new FontAwesome.Sharp.IconButton();
            this.btnMonitoreoOrdenes = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnTEALPHA = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelControl.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.DarkGray;
            this.panelControl.Controls.Add(this.btnMinimizar);
            this.panelControl.Controls.Add(this.btnTemaOscuro);
            this.panelControl.Controls.Add(this.lblTitulo);
            this.panelControl.Controls.Add(this.btnCerrar);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1024, 29);
            this.panelControl.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 20;
            this.btnMinimizar.Location = new System.Drawing.Point(966, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnMinimizar.Size = new System.Drawing.Size(29, 29);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnTemaOscuro
            // 
            this.btnTemaOscuro.FlatAppearance.BorderSize = 0;
            this.btnTemaOscuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemaOscuro.IconChar = FontAwesome.Sharp.IconChar.Adjust;
            this.btnTemaOscuro.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnTemaOscuro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTemaOscuro.IconSize = 20;
            this.btnTemaOscuro.Location = new System.Drawing.Point(496, 0);
            this.btnTemaOscuro.Name = "btnTemaOscuro";
            this.btnTemaOscuro.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnTemaOscuro.Size = new System.Drawing.Size(29, 29);
            this.btnTemaOscuro.TabIndex = 6;
            this.btnTemaOscuro.UseVisualStyleBackColor = true;
            this.btnTemaOscuro.Click += new System.EventHandler(this.btnTemaOscuro_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(12, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 15);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Gestión de Riesgos y control de usuarios";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(995, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(29, 29);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.White;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelCentral.Location = new System.Drawing.Point(43, 29);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(981, 547);
            this.panelCentral.TabIndex = 4;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSignOut.IconColor = System.Drawing.Color.Black;
            this.btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignOut.IconSize = 24;
            this.btnSignOut.Location = new System.Drawing.Point(0, 504);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(43, 43);
            this.btnSignOut.TabIndex = 26;
            this.btnSignOut.Tag = "Cerrar sesión          ";
            this.btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            this.btnSignOut.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnSignOut.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Silver;
            this.panelMenu.Controls.Add(this.btnBandejaEntrada);
            this.panelMenu.Controls.Add(this.btnOriginadorInstrumento);
            this.panelMenu.Controls.Add(this.btnMonitoreoOrdenes);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Controls.Add(this.btnTEALPHA);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnSignOut);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 29);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(43, 547);
            this.panelMenu.TabIndex = 5;
            this.panelMenu.Visible = false;
            this.panelMenu.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.panelMenu.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnBandejaEntrada
            // 
            this.btnBandejaEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBandejaEntrada.FlatAppearance.BorderSize = 0;
            this.btnBandejaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBandejaEntrada.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpenText;
            this.btnBandejaEntrada.IconColor = System.Drawing.Color.Black;
            this.btnBandejaEntrada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBandejaEntrada.IconSize = 24;
            this.btnBandejaEntrada.Location = new System.Drawing.Point(0, 258);
            this.btnBandejaEntrada.Name = "btnBandejaEntrada";
            this.btnBandejaEntrada.Size = new System.Drawing.Size(43, 43);
            this.btnBandejaEntrada.TabIndex = 32;
            this.btnBandejaEntrada.Tag = "Bandeja de entrada";
            this.btnBandejaEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBandejaEntrada.UseVisualStyleBackColor = true;
            this.btnBandejaEntrada.Click += new System.EventHandler(this.btnBandejaEntrada_Click);
            this.btnBandejaEntrada.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnBandejaEntrada.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnOriginadorInstrumento
            // 
            this.btnOriginadorInstrumento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOriginadorInstrumento.FlatAppearance.BorderSize = 0;
            this.btnOriginadorInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOriginadorInstrumento.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnOriginadorInstrumento.IconColor = System.Drawing.Color.Black;
            this.btnOriginadorInstrumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOriginadorInstrumento.IconSize = 30;
            this.btnOriginadorInstrumento.Location = new System.Drawing.Point(0, 215);
            this.btnOriginadorInstrumento.Name = "btnOriginadorInstrumento";
            this.btnOriginadorInstrumento.Size = new System.Drawing.Size(43, 43);
            this.btnOriginadorInstrumento.TabIndex = 31;
            this.btnOriginadorInstrumento.Tag = "Instrumentos y Originadores";
            this.btnOriginadorInstrumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOriginadorInstrumento.UseVisualStyleBackColor = true;
            this.btnOriginadorInstrumento.Click += new System.EventHandler(this.btnOriginadorInstrumento_Click);
            this.btnOriginadorInstrumento.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnOriginadorInstrumento.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnMonitoreoOrdenes
            // 
            this.btnMonitoreoOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonitoreoOrdenes.FlatAppearance.BorderSize = 0;
            this.btnMonitoreoOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitoreoOrdenes.IconChar = FontAwesome.Sharp.IconChar.WatchmanMonitoring;
            this.btnMonitoreoOrdenes.IconColor = System.Drawing.Color.Black;
            this.btnMonitoreoOrdenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMonitoreoOrdenes.IconSize = 30;
            this.btnMonitoreoOrdenes.Location = new System.Drawing.Point(0, 172);
            this.btnMonitoreoOrdenes.Name = "btnMonitoreoOrdenes";
            this.btnMonitoreoOrdenes.Size = new System.Drawing.Size(43, 43);
            this.btnMonitoreoOrdenes.TabIndex = 30;
            this.btnMonitoreoOrdenes.Tag = "Monitoreo de Ordenes";
            this.btnMonitoreoOrdenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonitoreoOrdenes.UseVisualStyleBackColor = true;
            this.btnMonitoreoOrdenes.Click += new System.EventHandler(this.btnMonitoreoOrdenes_Click);
            this.btnMonitoreoOrdenes.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnMonitoreoOrdenes.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.Black;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 24;
            this.btnMenu.Location = new System.Drawing.Point(0, 129);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(43, 43);
            this.btnMenu.TabIndex = 25;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnTEALPHA
            // 
            this.btnTEALPHA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTEALPHA.FlatAppearance.BorderSize = 0;
            this.btnTEALPHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTEALPHA.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnTEALPHA.IconColor = System.Drawing.Color.Black;
            this.btnTEALPHA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTEALPHA.IconSize = 24;
            this.btnTEALPHA.Location = new System.Drawing.Point(0, 86);
            this.btnTEALPHA.Name = "btnTEALPHA";
            this.btnTEALPHA.Size = new System.Drawing.Size(43, 43);
            this.btnTEALPHA.TabIndex = 29;
            this.btnTEALPHA.Tag = "Tracking Error vs Alpha";
            this.btnTEALPHA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTEALPHA.UseVisualStyleBackColor = true;
            this.btnTEALPHA.Click += new System.EventHandler(this.btnTEALPHA_Click);
            this.btnTEALPHA.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnTEALPHA.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 24;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 43);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(43, 43);
            this.btnUsuarios.TabIndex = 27;
            this.btnUsuarios.Tag = "Gestion de usuarios    ";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnHome.IconColor = System.Drawing.Color.Black;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 24;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(43, 43);
            this.btnHome.TabIndex = 28;
            this.btnHome.Tag = "Tareas diarias         ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.ControlBox = false;
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private FontAwesome.Sharp.IconButton btnTemaOscuro;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panelCentral;
        private FontAwesome.Sharp.IconButton btnSignOut;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnBandejaEntrada;
        private FontAwesome.Sharp.IconButton btnOriginadorInstrumento;
        private FontAwesome.Sharp.IconButton btnMonitoreoOrdenes;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnTEALPHA;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnHome;
    }
}