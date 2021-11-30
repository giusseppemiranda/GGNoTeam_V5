
namespace GGNoTeam_V5.VentanaPrincipal.Bandeja_de_Entrada
{
    partial class frmEnviarMensaje
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
            this.txtBoxDestinatario = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.txtBoxAsunto = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnviar = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnAdjuntarArchivo = new FontAwesome.Sharp.IconButton();
            this.btnAdjuntarImagen = new FontAwesome.Sharp.IconButton();
            this.btnDeleteMessage = new FontAwesome.Sharp.IconButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.openFiles = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxDestinatario
            // 
            this.txtBoxDestinatario.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxDestinatario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBoxDestinatario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBoxDestinatario.BorderSize = 2;
            this.txtBoxDestinatario.Enabled = false;
            this.txtBoxDestinatario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBoxDestinatario.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxDestinatario.IsFocused = false;
            this.txtBoxDestinatario.Location = new System.Drawing.Point(12, 31);
            this.txtBoxDestinatario.MaxLength = 32767;
            this.txtBoxDestinatario.Multiline = false;
            this.txtBoxDestinatario.Name = "txtBoxDestinatario";
            this.txtBoxDestinatario.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxDestinatario.PasswordChar = false;
            this.txtBoxDestinatario.Size = new System.Drawing.Size(776, 32);
            this.txtBoxDestinatario.TabIndex = 0;
            this.txtBoxDestinatario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxDestinatario.Texts = "Para";
            this.txtBoxDestinatario.UnderlinedStyle = false;
            // 
            // txtBoxAsunto
            // 
            this.txtBoxAsunto.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxAsunto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBoxAsunto.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBoxAsunto.BorderSize = 2;
            this.txtBoxAsunto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBoxAsunto.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxAsunto.IsFocused = false;
            this.txtBoxAsunto.Location = new System.Drawing.Point(12, 69);
            this.txtBoxAsunto.MaxLength = 32767;
            this.txtBoxAsunto.Multiline = false;
            this.txtBoxAsunto.Name = "txtBoxAsunto";
            this.txtBoxAsunto.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxAsunto.PasswordChar = false;
            this.txtBoxAsunto.Size = new System.Drawing.Size(776, 32);
            this.txtBoxAsunto.TabIndex = 1;
            this.txtBoxAsunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxAsunto.Texts = "Asunto";
            this.txtBoxAsunto.UnderlinedStyle = false;
            this.txtBoxAsunto.Enter += new System.EventHandler(this.txtBoxAsunto_Enter);
            this.txtBoxAsunto.Leave += new System.EventHandler(this.txtBoxAsunto_Leave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 223);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEnviar.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEnviar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEnviar.BorderRadius = 8;
            this.btnEnviar.BorderSize = 0;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(12, 390);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(128, 44);
            this.btnEnviar.TabIndex = 18;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextColor = System.Drawing.Color.White;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(12, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(143, 15);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Enviar mensajes directos";
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
            this.btnCerrar.Location = new System.Drawing.Point(774, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAdjuntarArchivo
            // 
            this.btnAdjuntarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdjuntarArchivo.FlatAppearance.BorderSize = 0;
            this.btnAdjuntarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjuntarArchivo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAdjuntarArchivo.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnAdjuntarArchivo.IconColor = System.Drawing.Color.DimGray;
            this.btnAdjuntarArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdjuntarArchivo.IconSize = 30;
            this.btnAdjuntarArchivo.Location = new System.Drawing.Point(346, 390);
            this.btnAdjuntarArchivo.Name = "btnAdjuntarArchivo";
            this.btnAdjuntarArchivo.Size = new System.Drawing.Size(44, 44);
            this.btnAdjuntarArchivo.TabIndex = 19;
            this.btnAdjuntarArchivo.UseVisualStyleBackColor = true;
            this.btnAdjuntarArchivo.Click += new System.EventHandler(this.btnAdjuntarArchivo_Click);
            // 
            // btnAdjuntarImagen
            // 
            this.btnAdjuntarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdjuntarImagen.FlatAppearance.BorderSize = 0;
            this.btnAdjuntarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjuntarImagen.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAdjuntarImagen.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.btnAdjuntarImagen.IconColor = System.Drawing.Color.DimGray;
            this.btnAdjuntarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdjuntarImagen.IconSize = 30;
            this.btnAdjuntarImagen.Location = new System.Drawing.Point(396, 390);
            this.btnAdjuntarImagen.Name = "btnAdjuntarImagen";
            this.btnAdjuntarImagen.Size = new System.Drawing.Size(44, 44);
            this.btnAdjuntarImagen.TabIndex = 21;
            this.btnAdjuntarImagen.UseVisualStyleBackColor = true;
            this.btnAdjuntarImagen.Click += new System.EventHandler(this.btnAdjuntarImagen_Click);
            // 
            // btnDeleteMessage
            // 
            this.btnDeleteMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMessage.FlatAppearance.BorderSize = 0;
            this.btnDeleteMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMessage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteMessage.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteMessage.IconColor = System.Drawing.Color.DimGray;
            this.btnDeleteMessage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteMessage.IconSize = 30;
            this.btnDeleteMessage.Location = new System.Drawing.Point(744, 390);
            this.btnDeleteMessage.Name = "btnDeleteMessage";
            this.btnDeleteMessage.Size = new System.Drawing.Size(44, 44);
            this.btnDeleteMessage.TabIndex = 24;
            this.btnDeleteMessage.UseVisualStyleBackColor = true;
            this.btnDeleteMessage.Click += new System.EventHandler(this.btnDeleteMessage_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 336);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(776, 44);
            this.richTextBox2.TabIndex = 25;
            this.richTextBox2.Text = "";
            // 
            // openFiles
            // 
            this.openFiles.FileName = "openFileDialog1";
            // 
            // frmEnviarMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnDeleteMessage);
            this.Controls.Add(this.btnAdjuntarImagen);
            this.Controls.Add(this.btnAdjuntarArchivo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtBoxAsunto);
            this.Controls.Add(this.txtBoxDestinatario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnviarMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEnviarMensaje";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Recursos.UserControls.GGTextBox txtBoxDestinatario;
        private Recursos.UserControls.GGTextBox txtBoxAsunto;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private Recursos.UserControls.GGButton btnEnviar;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnAdjuntarArchivo;
        private FontAwesome.Sharp.IconButton btnAdjuntarImagen;
        private FontAwesome.Sharp.IconButton btnDeleteMessage;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.OpenFileDialog openFiles;
    }
}