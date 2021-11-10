
namespace GGNoTeam_V5.VentanaPrincipal.TareasPendientes.Tareas
{
    partial class frmEditarTarea
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.comboBoxEstado = new GGNoTeam_V5.Recursos.UserControls.GGComboBox();
            this.lblIndicación = new System.Windows.Forms.Label();
            this.boxPlazo = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.boxHora = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.boxDescripcion = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.boxID = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.btnCancelar = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.btnSiguiente = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEstado.Location = new System.Drawing.Point(44, 244);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 15);
            this.lblEstado.TabIndex = 44;
            this.lblEstado.Text = "Estado:";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPlazo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPlazo.Location = new System.Drawing.Point(43, 195);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(88, 15);
            this.lblPlazo.TabIndex = 43;
            this.lblPlazo.Text = "Plazo (en días):";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHora.Location = new System.Drawing.Point(43, 151);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(87, 15);
            this.lblHora.TabIndex = 42;
            this.lblHora.Text = "Hora creación:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDescripcion.Location = new System.Drawing.Point(44, 107);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(75, 15);
            this.lblDescripcion.TabIndex = 41;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblID.Location = new System.Drawing.Point(44, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 15);
            this.lblID.TabIndex = 40;
            this.lblID.Text = "ID Tarea:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Usuario",
            "No usuario"});
            this.comboBoxEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxEstado.BorderColor = System.Drawing.Color.DodgerBlue;
            this.comboBoxEstado.BorderSize = 2;
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEstado.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxEstado.IconColor = System.Drawing.Color.DodgerBlue;
            this.comboBoxEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxEstado.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxEstado.Location = new System.Drawing.Point(158, 232);
            this.comboBoxEstado.MinimumSize = new System.Drawing.Size(171, 26);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxEstado.Size = new System.Drawing.Size(214, 28);
            this.comboBoxEstado.TabIndex = 57;
            this.comboBoxEstado.Texts = "";
            // 
            // lblIndicación
            // 
            this.lblIndicación.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIndicación.AutoSize = true;
            this.lblIndicación.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIndicación.ForeColor = System.Drawing.Color.Tomato;
            this.lblIndicación.Location = new System.Drawing.Point(155, 34);
            this.lblIndicación.Name = "lblIndicación";
            this.lblIndicación.Size = new System.Drawing.Size(234, 15);
            this.lblIndicación.TabIndex = 56;
            this.lblIndicación.Text = "El campo ID se genera automaticamente.";
            // 
            // boxPlazo
            // 
            this.boxPlazo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxPlazo.BackColor = System.Drawing.SystemColors.Window;
            this.boxPlazo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.boxPlazo.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.boxPlazo.BorderSize = 2;
            this.boxPlazo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.boxPlazo.ForeColor = System.Drawing.Color.DimGray;
            this.boxPlazo.IsFocused = false;
            this.boxPlazo.Location = new System.Drawing.Point(158, 184);
            this.boxPlazo.MaxLength = 32767;
            this.boxPlazo.Multiline = false;
            this.boxPlazo.Name = "boxPlazo";
            this.boxPlazo.Padding = new System.Windows.Forms.Padding(6);
            this.boxPlazo.PasswordChar = false;
            this.boxPlazo.Size = new System.Drawing.Size(214, 30);
            this.boxPlazo.TabIndex = 55;
            this.boxPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxPlazo.Texts = "";
            this.boxPlazo.UnderlinedStyle = true;
            // 
            // boxHora
            // 
            this.boxHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxHora.BackColor = System.Drawing.SystemColors.Window;
            this.boxHora.BorderColor = System.Drawing.Color.DodgerBlue;
            this.boxHora.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.boxHora.BorderSize = 2;
            this.boxHora.Enabled = false;
            this.boxHora.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.boxHora.ForeColor = System.Drawing.Color.DimGray;
            this.boxHora.IsFocused = false;
            this.boxHora.Location = new System.Drawing.Point(158, 140);
            this.boxHora.MaxLength = 32767;
            this.boxHora.Multiline = false;
            this.boxHora.Name = "boxHora";
            this.boxHora.Padding = new System.Windows.Forms.Padding(6);
            this.boxHora.PasswordChar = false;
            this.boxHora.Size = new System.Drawing.Size(214, 30);
            this.boxHora.TabIndex = 54;
            this.boxHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxHora.Texts = "";
            this.boxHora.UnderlinedStyle = true;
            // 
            // boxDescripcion
            // 
            this.boxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.boxDescripcion.BorderColor = System.Drawing.Color.DodgerBlue;
            this.boxDescripcion.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.boxDescripcion.BorderSize = 2;
            this.boxDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.boxDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.boxDescripcion.IsFocused = false;
            this.boxDescripcion.Location = new System.Drawing.Point(158, 96);
            this.boxDescripcion.MaxLength = 32767;
            this.boxDescripcion.Multiline = false;
            this.boxDescripcion.Name = "boxDescripcion";
            this.boxDescripcion.Padding = new System.Windows.Forms.Padding(6);
            this.boxDescripcion.PasswordChar = false;
            this.boxDescripcion.Size = new System.Drawing.Size(214, 30);
            this.boxDescripcion.TabIndex = 53;
            this.boxDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxDescripcion.Texts = "";
            this.boxDescripcion.UnderlinedStyle = true;
            // 
            // boxID
            // 
            this.boxID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxID.BackColor = System.Drawing.SystemColors.Window;
            this.boxID.BorderColor = System.Drawing.Color.Tomato;
            this.boxID.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.boxID.BorderSize = 2;
            this.boxID.Enabled = false;
            this.boxID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.boxID.ForeColor = System.Drawing.Color.DimGray;
            this.boxID.IsFocused = false;
            this.boxID.Location = new System.Drawing.Point(158, 52);
            this.boxID.MaxLength = 32767;
            this.boxID.Multiline = false;
            this.boxID.Name = "boxID";
            this.boxID.Padding = new System.Windows.Forms.Padding(6);
            this.boxID.PasswordChar = false;
            this.boxID.Size = new System.Drawing.Size(214, 30);
            this.boxID.TabIndex = 52;
            this.boxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxID.Texts = "";
            this.boxID.UnderlinedStyle = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(194, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 47);
            this.btnCancelar.TabIndex = 59;
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
            this.btnSiguiente.Location = new System.Drawing.Point(288, 291);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(84, 47);
            this.btnSiguiente.TabIndex = 58;
            this.btnSiguiente.Text = "Aceptar";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // frmEditarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 360);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.lblIndicación);
            this.Controls.Add(this.boxPlazo);
            this.Controls.Add(this.boxHora);
            this.Controls.Add(this.boxDescripcion);
            this.Controls.Add(this.boxID);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPlazo);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarTarea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblID;
        private Recursos.UserControls.GGComboBox comboBoxEstado;
        private System.Windows.Forms.Label lblIndicación;
        private Recursos.UserControls.GGTextBox boxPlazo;
        private Recursos.UserControls.GGTextBox boxHora;
        private Recursos.UserControls.GGTextBox boxDescripcion;
        private Recursos.UserControls.GGTextBox boxID;
        private Recursos.UserControls.GGButton btnCancelar;
        private Recursos.UserControls.GGButton btnSiguiente;
    }
}