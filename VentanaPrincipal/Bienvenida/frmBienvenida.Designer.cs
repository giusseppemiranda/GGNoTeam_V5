
namespace GGNoTeam_V5.VentanaPrincipal
{
    partial class frmBienvenida
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
            this.components = new System.ComponentModel.Container();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.imgUsuario = new GGNoTeam_V5.Recursos.UserControls.GGCirculaPictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnContinuar = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.imgAFPIntegra = new System.Windows.Forms.PictureBox();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAFPIntegra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFecha.Location = new System.Drawing.Point(98, 384);
            this.lblFecha.MaximumSize = new System.Drawing.Size(386, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(366, 64);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "domingo 24 de septiembre del 2931";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHora.Location = new System.Drawing.Point(219, 346);
            this.lblHora.MaximumSize = new System.Drawing.Size(214, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(137, 32);
            this.lblHora.TabIndex = 32;
            this.lblHora.Text = "HH:MM:SS";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgUsuario
            // 
            this.imgUsuario.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.imgUsuario.BorderColor = System.Drawing.Color.MidnightBlue;
            this.imgUsuario.BorderColor2 = System.Drawing.Color.SkyBlue;
            this.imgUsuario.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.imgUsuario.BorderSize = 3;
            this.imgUsuario.GradientAngle = 50F;
            this.imgUsuario.Image = global::GGNoTeam_V5.Properties.Resources.User_2;
            this.imgUsuario.Location = new System.Drawing.Point(687, 51);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(145, 145);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUsuario.TabIndex = 31;
            this.imgUsuario.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBienvenida.Location = new System.Drawing.Point(588, 288);
            this.lblBienvenida.MaximumSize = new System.Drawing.Size(407, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(331, 90);
            this.lblBienvenida.TabIndex = 30;
            this.lblBienvenida.Text = "AFP Integra te da la bienvenia al sistema integrado de Gestión de Riesgos e Inver" +
    "siones.";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnContinuar.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnContinuar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnContinuar.BorderRadius = 8;
            this.btnContinuar.BorderSize = 0;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(687, 419);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(145, 59);
            this.btnContinuar.TabIndex = 29;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.TextColor = System.Drawing.Color.White;
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNombreUsuario.Location = new System.Drawing.Point(552, 219);
            this.lblNombreUsuario.MaximumSize = new System.Drawing.Size(407, 30);
            this.lblNombreUsuario.MinimumSize = new System.Drawing.Size(407, 30);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(407, 30);
            this.lblNombreUsuario.TabIndex = 28;
            this.lblNombreUsuario.Text = "Nombre1 Nombre2 Apellido1 Apellido2";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgAFPIntegra
            // 
            this.imgAFPIntegra.Image = global::GGNoTeam_V5.Properties.Resources.image;
            this.imgAFPIntegra.Location = new System.Drawing.Point(80, 96);
            this.imgAFPIntegra.Name = "imgAFPIntegra";
            this.imgAFPIntegra.Size = new System.Drawing.Size(406, 190);
            this.imgAFPIntegra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAFPIntegra.TabIndex = 27;
            this.imgAFPIntegra.TabStop = false;
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.imgUsuario);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.imgAFPIntegra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBienvenida";
            this.Text = "frmBienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAFPIntegra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private Recursos.UserControls.GGCirculaPictureBox imgUsuario;
        private System.Windows.Forms.Label lblBienvenida;
        private Recursos.UserControls.GGButton btnContinuar;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox imgAFPIntegra;
        private System.Windows.Forms.Timer horaFecha;
    }
}