
namespace GGNoTeam_V5.Login
{
    partial class frmCambiarPassword
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
            this.lblFirstPassword = new System.Windows.Forms.Label();
            this.lblSecondPassword = new System.Windows.Forms.Label();
            this.lblPasswordIncorrecto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCancelar = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.btnSiguiente = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.txtboxSegundaPassword = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.txtboxPrimeraPassword = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
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
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnTemaOscuro.TabIndex = 9;
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
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(10, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(117, 15);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Cambiar Contraseña";
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
            // lblFirstPassword
            // 
            this.lblFirstPassword.AutoSize = true;
            this.lblFirstPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFirstPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFirstPassword.Location = new System.Drawing.Point(30, 237);
            this.lblFirstPassword.Name = "lblFirstPassword";
            this.lblFirstPassword.Size = new System.Drawing.Size(232, 15);
            this.lblFirstPassword.TabIndex = 17;
            this.lblFirstPassword.Text = "Ingrese contraseña (Máx. 15 caracteres):";
            // 
            // lblSecondPassword
            // 
            this.lblSecondPassword.AutoSize = true;
            this.lblSecondPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecondPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSecondPassword.Location = new System.Drawing.Point(30, 311);
            this.lblSecondPassword.Name = "lblSecondPassword";
            this.lblSecondPassword.Size = new System.Drawing.Size(122, 15);
            this.lblSecondPassword.TabIndex = 19;
            this.lblSecondPassword.Text = "Repita la contraseña:";
            // 
            // lblPasswordIncorrecto
            // 
            this.lblPasswordIncorrecto.AutoSize = true;
            this.lblPasswordIncorrecto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPasswordIncorrecto.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPasswordIncorrecto.Location = new System.Drawing.Point(30, 362);
            this.lblPasswordIncorrecto.MaximumSize = new System.Drawing.Size(214, 43);
            this.lblPasswordIncorrecto.Name = "lblPasswordIncorrecto";
            this.lblPasswordIncorrecto.Size = new System.Drawing.Size(152, 15);
            this.lblPasswordIncorrecto.TabIndex = 24;
            this.lblPasswordIncorrecto.Text = "La contraseña no coincide.";
            this.lblPasswordIncorrecto.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 190);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(251, 110);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(239, 30);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "Para reestablecer su credencial de acceso escriba una nueva contraseña.";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
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
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnSiguiente.TabIndex = 25;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // txtboxSegundaPassword
            // 
            this.txtboxSegundaPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSegundaPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxSegundaPassword.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtboxSegundaPassword.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtboxSegundaPassword.BorderSize = 2;
            this.txtboxSegundaPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtboxSegundaPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxSegundaPassword.IsFocused = false;
            this.txtboxSegundaPassword.Location = new System.Drawing.Point(30, 329);
            this.txtboxSegundaPassword.MaxLength = 15;
            this.txtboxSegundaPassword.Multiline = false;
            this.txtboxSegundaPassword.Name = "txtboxSegundaPassword";
            this.txtboxSegundaPassword.Padding = new System.Windows.Forms.Padding(6);
            this.txtboxSegundaPassword.PasswordChar = true;
            this.txtboxSegundaPassword.Size = new System.Drawing.Size(251, 30);
            this.txtboxSegundaPassword.TabIndex = 18;
            this.txtboxSegundaPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxSegundaPassword.Texts = "";
            this.txtboxSegundaPassword.UnderlinedStyle = true;
            // 
            // txtboxPrimeraPassword
            // 
            this.txtboxPrimeraPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxPrimeraPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxPrimeraPassword.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtboxPrimeraPassword.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtboxPrimeraPassword.BorderSize = 2;
            this.txtboxPrimeraPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtboxPrimeraPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxPrimeraPassword.IsFocused = false;
            this.txtboxPrimeraPassword.Location = new System.Drawing.Point(30, 255);
            this.txtboxPrimeraPassword.MaxLength = 15;
            this.txtboxPrimeraPassword.Multiline = false;
            this.txtboxPrimeraPassword.Name = "txtboxPrimeraPassword";
            this.txtboxPrimeraPassword.Padding = new System.Windows.Forms.Padding(6);
            this.txtboxPrimeraPassword.PasswordChar = true;
            this.txtboxPrimeraPassword.Size = new System.Drawing.Size(251, 30);
            this.txtboxPrimeraPassword.TabIndex = 16;
            this.txtboxPrimeraPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxPrimeraPassword.Texts = "";
            this.txtboxPrimeraPassword.UnderlinedStyle = true;
            // 
            // frmCambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 486);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblPasswordIncorrecto);
            this.Controls.Add(this.lblSecondPassword);
            this.Controls.Add(this.txtboxSegundaPassword);
            this.Controls.Add(this.lblFirstPassword);
            this.Controls.Add(this.txtboxPrimeraPassword);
            this.Controls.Add(this.imgAFPIntegra);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCambiarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCambiarPassword";
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
        private System.Windows.Forms.Label lblFirstPassword;
        private Recursos.UserControls.GGTextBox txtboxPrimeraPassword;
        private System.Windows.Forms.Label lblSecondPassword;
        private Recursos.UserControls.GGTextBox txtboxSegundaPassword;
        private System.Windows.Forms.Label lblPasswordIncorrecto;
        private Recursos.UserControls.GGButton btnCancelar;
        private Recursos.UserControls.GGButton btnSiguiente;
        private System.Windows.Forms.Label lblDescripcion;
        private FontAwesome.Sharp.IconButton btnTemaOscuro;
    }
}