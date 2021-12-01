
namespace GGNoTeam_V5.Login
{
    partial class frmOlvidePassword
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
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgAFPIntegra = new System.Windows.Forms.PictureBox();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.txtboxUser = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.btnSiguiente = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.lblIDCorreo = new System.Windows.Forms.Label();
            this.btnCancelar = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.lblUsuarioNoEncontrado = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAFPIntegra)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Gainsboro;
            this.panelControl.Controls.Add(this.btnTemaOscuro);
            this.panelControl.Controls.Add(this.btnCerrar);
            this.panelControl.Controls.Add(this.btnMinimizar);
            this.panelControl.Controls.Add(this.lblTitulo);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(311, 23);
            this.panelControl.TabIndex = 0;
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
            this.btnTemaOscuro.TabIndex = 7;
            this.btnTemaOscuro.UseVisualStyleBackColor = true;
            this.btnTemaOscuro.Click += new System.EventHandler(this.btnTemaOscuro_Click);
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
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(10, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 15);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Recuperar contraseña";
            // 
            // imgAFPIntegra
            // 
            this.imgAFPIntegra.Image = global::GGNoTeam_V5.Properties.Resources.image;
            this.imgAFPIntegra.Location = new System.Drawing.Point(30, 49);
            this.imgAFPIntegra.Name = "imgAFPIntegra";
            this.imgAFPIntegra.Size = new System.Drawing.Size(251, 110);
            this.imgAFPIntegra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAFPIntegra.TabIndex = 2;
            this.imgAFPIntegra.TabStop = false;
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIndicaciones.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIndicaciones.Location = new System.Drawing.Point(32, 205);
            this.lblIndicaciones.MaximumSize = new System.Drawing.Size(251, 110);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(251, 60);
            this.lblIndicaciones.TabIndex = 16;
            this.lblIndicaciones.Text = "Para poder recuperar tu cuenta debes introducir tu correo electrónico o tu ID de " +
    "usuario.  Si ocurre algún error comuniquese al AFPINTEGRALP2@gmail.com.";
            this.lblIndicaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtboxUser
            // 
            this.txtboxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxUser.BackColor = System.Drawing.Color.White;
            this.txtboxUser.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtboxUser.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtboxUser.BorderSize = 2;
            this.txtboxUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtboxUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxUser.IsFocused = false;
            this.txtboxUser.Location = new System.Drawing.Point(32, 334);
            this.txtboxUser.MaxLength = 32767;
            this.txtboxUser.Multiline = false;
            this.txtboxUser.Name = "txtboxUser";
            this.txtboxUser.Padding = new System.Windows.Forms.Padding(6);
            this.txtboxUser.PasswordChar = false;
            this.txtboxUser.Size = new System.Drawing.Size(251, 30);
            this.txtboxUser.TabIndex = 17;
            this.txtboxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxUser.Texts = "";
            this.txtboxUser.UnderlinedStyle = true;
            this.txtboxUser.Enter += new System.EventHandler(this.txtboxUser_Enter);
            this.txtboxUser.Leave += new System.EventHandler(this.txtboxUser_Leave);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSiguiente.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSiguiente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSiguiente.BorderRadius = 8;
            this.btnSiguiente.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(199, 396);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(84, 47);
            this.btnSiguiente.TabIndex = 18;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblIDCorreo
            // 
            this.lblIDCorreo.AutoSize = true;
            this.lblIDCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIDCorreo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIDCorreo.Location = new System.Drawing.Point(30, 316);
            this.lblIDCorreo.Name = "lblIDCorreo";
            this.lblIDCorreo.Size = new System.Drawing.Size(167, 15);
            this.lblIDCorreo.TabIndex = 19;
            this.lblIDCorreo.Text = "Ingrese su código de usuario:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SlateGray;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.SlateGray;
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 8;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(109, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 47);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblUsuarioNoEncontrado
            // 
            this.lblUsuarioNoEncontrado.AutoSize = true;
            this.lblUsuarioNoEncontrado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioNoEncontrado.ForeColor = System.Drawing.Color.IndianRed;
            this.lblUsuarioNoEncontrado.Location = new System.Drawing.Point(30, 367);
            this.lblUsuarioNoEncontrado.MaximumSize = new System.Drawing.Size(214, 43);
            this.lblUsuarioNoEncontrado.Name = "lblUsuarioNoEncontrado";
            this.lblUsuarioNoEncontrado.Size = new System.Drawing.Size(177, 15);
            this.lblUsuarioNoEncontrado.TabIndex = 21;
            this.lblUsuarioNoEncontrado.Text = "El código ingresado no existen.";
            this.lblUsuarioNoEncontrado.Visible = false;
            // 
            // frmOlvidePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 486);
            this.Controls.Add(this.lblUsuarioNoEncontrado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblIDCorreo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtboxUser);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.imgAFPIntegra);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOlvidePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOlvidePassword";
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAFPIntegra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.PictureBox imgAFPIntegra;
        private System.Windows.Forms.Label lblIndicaciones;
        private Recursos.UserControls.GGTextBox txtboxUser;
        private Recursos.UserControls.GGButton btnSiguiente;
        private System.Windows.Forms.Label lblIDCorreo;
        private Recursos.UserControls.GGButton btnCancelar;
        private System.Windows.Forms.Label lblUsuarioNoEncontrado;
        private FontAwesome.Sharp.IconButton btnTemaOscuro;
    }
}