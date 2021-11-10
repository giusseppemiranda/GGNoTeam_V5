
namespace GGNoTeam_V5
{
    partial class frmLogin
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
            this.btnTemaOscuro = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.imgAFPIntegra = new System.Windows.Forms.PictureBox();
            this.lblCredencialesIncorrectas = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPasswordOlvidada = new System.Windows.Forms.LinkLabel();
            this.txtboxPassword = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.txtboxUsername = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAFPIntegra)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.DarkGray;
            this.panelControl.Controls.Add(this.btnTemaOscuro);
            this.panelControl.Controls.Add(this.lblTitulo);
            this.panelControl.Controls.Add(this.btnMinimizar);
            this.panelControl.Controls.Add(this.btnCerrar);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(311, 23);
            this.panelControl.TabIndex = 0;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // btnTemaOscuro
            // 
            this.btnTemaOscuro.FlatAppearance.BorderSize = 0;
            this.btnTemaOscuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemaOscuro.IconChar = FontAwesome.Sharp.IconChar.Adjust;
            this.btnTemaOscuro.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnTemaOscuro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTemaOscuro.IconSize = 16;
            this.btnTemaOscuro.Location = new System.Drawing.Point(144, 0);
            this.btnTemaOscuro.Name = "btnTemaOscuro";
            this.btnTemaOscuro.Size = new System.Drawing.Size(23, 23);
            this.btnTemaOscuro.TabIndex = 4;
            this.btnTemaOscuro.UseVisualStyleBackColor = true;
            this.btnTemaOscuro.Click += new System.EventHandler(this.btnTemaOscuro_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(10, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(78, 15);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Iniciar sesión";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 16;
            this.btnMinimizar.Location = new System.Drawing.Point(260, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 23);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(286, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // imgAFPIntegra
            // 
            this.imgAFPIntegra.Image = global::GGNoTeam_V5.Properties.Resources.image;
            this.imgAFPIntegra.Location = new System.Drawing.Point(30, 49);
            this.imgAFPIntegra.Name = "imgAFPIntegra";
            this.imgAFPIntegra.Size = new System.Drawing.Size(251, 110);
            this.imgAFPIntegra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAFPIntegra.TabIndex = 1;
            this.imgAFPIntegra.TabStop = false;
            this.imgAFPIntegra.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCredencialesIncorrectas
            // 
            this.lblCredencialesIncorrectas.AutoSize = true;
            this.lblCredencialesIncorrectas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCredencialesIncorrectas.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCredencialesIncorrectas.Location = new System.Drawing.Point(27, 318);
            this.lblCredencialesIncorrectas.MaximumSize = new System.Drawing.Size(251, 80);
            this.lblCredencialesIncorrectas.Name = "lblCredencialesIncorrectas";
            this.lblCredencialesIncorrectas.Size = new System.Drawing.Size(243, 45);
            this.lblCredencialesIncorrectas.TabIndex = 18;
            this.lblCredencialesIncorrectas.Text = "No es posible ingresar con las credenciales ingresadas. Intente nuevamente o comu" +
    "niquese con un administrador.";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIniciarSesion.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIniciarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIniciarSesion.BorderRadius = 8;
            this.btnIniciarSesion.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(88, 374);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(128, 44);
            this.btnIniciarSesion.TabIndex = 17;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.TextColor = System.Drawing.Color.White;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPassword.Location = new System.Drawing.Point(27, 267);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 15);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUser.Location = new System.Drawing.Point(27, 208);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(66, 15);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "ID usuario:";
            // 
            // lblPasswordOlvidada
            // 
            this.lblPasswordOlvidada.AutoSize = true;
            this.lblPasswordOlvidada.LinkColor = System.Drawing.Color.Blue;
            this.lblPasswordOlvidada.Location = new System.Drawing.Point(85, 429);
            this.lblPasswordOlvidada.Name = "lblPasswordOlvidada";
            this.lblPasswordOlvidada.Size = new System.Drawing.Size(131, 13);
            this.lblPasswordOlvidada.TabIndex = 14;
            this.lblPasswordOlvidada.TabStop = true;
            this.lblPasswordOlvidada.Text = "¿Olvidaste tu contraseña?";
            this.lblPasswordOlvidada.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPasswordOlvidada_LinkClicked);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxPassword.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtboxPassword.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtboxPassword.BorderSize = 2;
            this.txtboxPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtboxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxPassword.IsFocused = false;
            this.txtboxPassword.Location = new System.Drawing.Point(30, 285);
            this.txtboxPassword.MaxLength = 32767;
            this.txtboxPassword.Multiline = false;
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Padding = new System.Windows.Forms.Padding(6);
            this.txtboxPassword.PasswordChar = true;
            this.txtboxPassword.Size = new System.Drawing.Size(251, 30);
            this.txtboxPassword.TabIndex = 13;
            this.txtboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxPassword.Texts = "";
            this.txtboxPassword.UnderlinedStyle = true;
            this.txtboxPassword.Enter += new System.EventHandler(this.txtboxPassword_Enter);
            this.txtboxPassword.Leave += new System.EventHandler(this.txtboxPassword_Leave);
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxUsername.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtboxUsername.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtboxUsername.BorderSize = 2;
            this.txtboxUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtboxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxUsername.IsFocused = false;
            this.txtboxUsername.Location = new System.Drawing.Point(30, 226);
            this.txtboxUsername.MaxLength = 32767;
            this.txtboxUsername.Multiline = false;
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Padding = new System.Windows.Forms.Padding(6);
            this.txtboxUsername.PasswordChar = false;
            this.txtboxUsername.Size = new System.Drawing.Size(251, 30);
            this.txtboxUsername.TabIndex = 12;
            this.txtboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxUsername.Texts = "";
            this.txtboxUsername.UnderlinedStyle = true;
            this.txtboxUsername.Enter += new System.EventHandler(this.txtboxUsername_Enter);
            this.txtboxUsername.Leave += new System.EventHandler(this.txtboxUsername_Leave);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 486);
            this.ControlBox = false;
            this.Controls.Add(this.lblCredencialesIncorrectas);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPasswordOlvidada);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.imgAFPIntegra);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAFPIntegra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.PictureBox imgAFPIntegra;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCredencialesIncorrectas;
        private Recursos.UserControls.GGButton btnIniciarSesion;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.LinkLabel lblPasswordOlvidada;
        private Recursos.UserControls.GGTextBox txtboxPassword;
        private Recursos.UserControls.GGTextBox txtboxUsername;
        private FontAwesome.Sharp.IconButton btnTemaOscuro;
    }
}