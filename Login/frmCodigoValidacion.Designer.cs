
namespace GGNoTeam_V5.Login
{
    partial class frmCodigoValidacion
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cod_1 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.cod_2 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.cod_3 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.cod_4 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.btnCancelar = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.btnSiguiente = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.lblCodigoIncorrecto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAFPIntegra)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Gainsboro;
            this.panelControl.Controls.Add(this.btnTemaOscuro);
            this.panelControl.Controls.Add(this.lblTitulo);
            this.panelControl.Controls.Add(this.btnMinimizar);
            this.panelControl.Controls.Add(this.btnCerrar);
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
            this.btnTemaOscuro.TabIndex = 8;
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
            this.lblTitulo.Size = new System.Drawing.Size(84, 15);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Validar codigo";
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
            this.btnCerrar.TabIndex = 4;
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
            this.imgAFPIntegra.TabIndex = 2;
            this.imgAFPIntegra.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 182);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(251, 110);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(249, 60);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Texto Texto Texto Texto Texto Texto Texto Texto Texto Texto Texto Texto Texto Tex" +
    "to Texto Texto Texto Texto Texto Texto Texto Texto Texto Texto ";
            // 
            // cod_1
            // 
            this.cod_1.BackColor = System.Drawing.SystemColors.Window;
            this.cod_1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cod_1.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.cod_1.BorderSize = 2;
            this.cod_1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cod_1.ForeColor = System.Drawing.Color.DimGray;
            this.cod_1.IsFocused = false;
            this.cod_1.Location = new System.Drawing.Point(64, 297);
            this.cod_1.MaxLength = 1;
            this.cod_1.Multiline = false;
            this.cod_1.Name = "cod_1";
            this.cod_1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cod_1.PasswordChar = false;
            this.cod_1.Size = new System.Drawing.Size(30, 30);
            this.cod_1.TabIndex = 17;
            this.cod_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cod_1.Texts = "";
            this.cod_1.UnderlinedStyle = false;
            this.cod_1._TextChanged += new System.EventHandler(this.cod_1__TextChanged);
            this.cod_1.Leave += new System.EventHandler(this.cod_1_Leave);
            // 
            // cod_2
            // 
            this.cod_2.BackColor = System.Drawing.SystemColors.Window;
            this.cod_2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cod_2.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.cod_2.BorderSize = 2;
            this.cod_2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cod_2.ForeColor = System.Drawing.Color.DimGray;
            this.cod_2.IsFocused = false;
            this.cod_2.Location = new System.Drawing.Point(111, 297);
            this.cod_2.MaxLength = 1;
            this.cod_2.Multiline = false;
            this.cod_2.Name = "cod_2";
            this.cod_2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cod_2.PasswordChar = false;
            this.cod_2.Size = new System.Drawing.Size(30, 30);
            this.cod_2.TabIndex = 18;
            this.cod_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cod_2.Texts = "";
            this.cod_2.UnderlinedStyle = false;
            this.cod_2._TextChanged += new System.EventHandler(this.cod_2__TextChanged);
            this.cod_2.Leave += new System.EventHandler(this.cod_2_Leave);
            // 
            // cod_3
            // 
            this.cod_3.BackColor = System.Drawing.SystemColors.Window;
            this.cod_3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cod_3.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.cod_3.BorderSize = 2;
            this.cod_3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cod_3.ForeColor = System.Drawing.Color.DimGray;
            this.cod_3.IsFocused = false;
            this.cod_3.Location = new System.Drawing.Point(159, 297);
            this.cod_3.MaxLength = 1;
            this.cod_3.Multiline = false;
            this.cod_3.Name = "cod_3";
            this.cod_3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cod_3.PasswordChar = false;
            this.cod_3.Size = new System.Drawing.Size(30, 30);
            this.cod_3.TabIndex = 19;
            this.cod_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cod_3.Texts = "";
            this.cod_3.UnderlinedStyle = false;
            this.cod_3._TextChanged += new System.EventHandler(this.cod_3__TextChanged);
            this.cod_3.Leave += new System.EventHandler(this.cod_3_Leave);
            // 
            // cod_4
            // 
            this.cod_4.BackColor = System.Drawing.SystemColors.Window;
            this.cod_4.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cod_4.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.cod_4.BorderSize = 2;
            this.cod_4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cod_4.ForeColor = System.Drawing.Color.DimGray;
            this.cod_4.IsFocused = false;
            this.cod_4.Location = new System.Drawing.Point(206, 297);
            this.cod_4.MaxLength = 1;
            this.cod_4.Multiline = false;
            this.cod_4.Name = "cod_4";
            this.cod_4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cod_4.PasswordChar = false;
            this.cod_4.Size = new System.Drawing.Size(30, 30);
            this.cod_4.TabIndex = 20;
            this.cod_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cod_4.Texts = "";
            this.cod_4.UnderlinedStyle = false;
            this.cod_4.Leave += new System.EventHandler(this.cod_4_Leave);
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
            this.btnCancelar.TabIndex = 22;
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
            this.btnSiguiente.TabIndex = 21;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblCodigoIncorrecto
            // 
            this.lblCodigoIncorrecto.AutoSize = true;
            this.lblCodigoIncorrecto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigoIncorrecto.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCodigoIncorrecto.Location = new System.Drawing.Point(30, 343);
            this.lblCodigoIncorrecto.MaximumSize = new System.Drawing.Size(214, 43);
            this.lblCodigoIncorrecto.Name = "lblCodigoIncorrecto";
            this.lblCodigoIncorrecto.Size = new System.Drawing.Size(199, 15);
            this.lblCodigoIncorrecto.TabIndex = 23;
            this.lblCodigoIncorrecto.Text = "El código ingresado no es correcto.";
            this.lblCodigoIncorrecto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(30, 279);
            this.label1.MaximumSize = new System.Drawing.Size(251, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ingrese el código de 4 dígitos:";
            // 
            // frmCodigoValidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigoIncorrecto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.cod_4);
            this.Controls.Add(this.cod_3);
            this.Controls.Add(this.cod_2);
            this.Controls.Add(this.cod_1);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.imgAFPIntegra);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCodigoValidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCodigoValidacion";
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
        private System.Windows.Forms.Label lblDescripcion;
        private Recursos.UserControls.GGTextBox cod_1;
        private Recursos.UserControls.GGTextBox cod_2;
        private Recursos.UserControls.GGTextBox cod_3;
        private Recursos.UserControls.GGTextBox cod_4;
        private Recursos.UserControls.GGButton btnCancelar;
        private Recursos.UserControls.GGButton btnSiguiente;
        private System.Windows.Forms.Label lblCodigoIncorrecto;
        private FontAwesome.Sharp.IconButton btnTemaOscuro;
        private System.Windows.Forms.Label label1;
    }
}