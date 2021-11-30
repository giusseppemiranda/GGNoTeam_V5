
namespace GGNoTeam_V5.VentanaPrincipal.Bandeja_de_Entrada
{
    partial class frmGmail
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
            this.panelMensaje = new System.Windows.Forms.Panel();
            this.lblNumeroMensaje = new System.Windows.Forms.Label();
            this.msgDate = new System.Windows.Forms.Label();
            this.msgAsunto = new System.Windows.Forms.Label();
            this.msgFrom = new System.Windows.Forms.Label();
            this.lblCuerpoMSG = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnBefore = new FontAwesome.Sharp.IconButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMensaje
            // 
            this.panelMensaje.Controls.Add(this.richTextBox1);
            this.panelMensaje.Controls.Add(this.lblNumeroMensaje);
            this.panelMensaje.Controls.Add(this.msgDate);
            this.panelMensaje.Controls.Add(this.msgAsunto);
            this.panelMensaje.Controls.Add(this.msgFrom);
            this.panelMensaje.Controls.Add(this.lblCuerpoMSG);
            this.panelMensaje.Controls.Add(this.lblFecha);
            this.panelMensaje.Controls.Add(this.lblAsunto);
            this.panelMensaje.Controls.Add(this.lblFrom);
            this.panelMensaje.Location = new System.Drawing.Point(49, 0);
            this.panelMensaje.Name = "panelMensaje";
            this.panelMensaje.Size = new System.Drawing.Size(881, 547);
            this.panelMensaje.TabIndex = 0;
            // 
            // lblNumeroMensaje
            // 
            this.lblNumeroMensaje.AutoSize = true;
            this.lblNumeroMensaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMensaje.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNumeroMensaje.Location = new System.Drawing.Point(818, 123);
            this.lblNumeroMensaje.Name = "lblNumeroMensaje";
            this.lblNumeroMensaje.Size = new System.Drawing.Size(38, 17);
            this.lblNumeroMensaje.TabIndex = 24;
            this.lblNumeroMensaje.Text = "# / #";
            // 
            // msgDate
            // 
            this.msgDate.AutoSize = true;
            this.msgDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.msgDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgDate.ForeColor = System.Drawing.Color.DimGray;
            this.msgDate.Location = new System.Drawing.Point(178, 75);
            this.msgDate.Name = "msgDate";
            this.msgDate.Size = new System.Drawing.Size(112, 17);
            this.msgDate.TabIndex = 22;
            this.msgDate.Text = "-FECHA Y HORA-";
            // 
            // msgAsunto
            // 
            this.msgAsunto.AutoSize = true;
            this.msgAsunto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.msgAsunto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgAsunto.ForeColor = System.Drawing.Color.DimGray;
            this.msgAsunto.Location = new System.Drawing.Point(178, 48);
            this.msgAsunto.Name = "msgAsunto";
            this.msgAsunto.Size = new System.Drawing.Size(71, 17);
            this.msgAsunto.TabIndex = 21;
            this.msgAsunto.Text = "-ASUNTO-";
            // 
            // msgFrom
            // 
            this.msgFrom.AutoSize = true;
            this.msgFrom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.msgFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgFrom.ForeColor = System.Drawing.Color.DimGray;
            this.msgFrom.Location = new System.Drawing.Point(178, 18);
            this.msgFrom.Name = "msgFrom";
            this.msgFrom.Size = new System.Drawing.Size(55, 17);
            this.msgFrom.TabIndex = 20;
            this.msgFrom.Text = "-FROM-";
            // 
            // lblCuerpoMSG
            // 
            this.lblCuerpoMSG.AutoSize = true;
            this.lblCuerpoMSG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuerpoMSG.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCuerpoMSG.Location = new System.Drawing.Point(3, 105);
            this.lblCuerpoMSG.Name = "lblCuerpoMSG";
            this.lblCuerpoMSG.Size = new System.Drawing.Size(117, 17);
            this.lblCuerpoMSG.TabIndex = 19;
            this.lblCuerpoMSG.Text = "Mensaje recibido:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFecha.Location = new System.Drawing.Point(3, 75);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(99, 17);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha enviada:";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAsunto.Location = new System.Drawing.Point(3, 48);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(56, 17);
            this.lblAsunto.TabIndex = 17;
            this.lblAsunto.Text = "Asunto:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFrom.Location = new System.Drawing.Point(3, 18);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(142, 17);
            this.lblFrom.TabIndex = 16;
            this.lblFrom.Text = "Mensaje enviado por:";
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnNext.IconColor = System.Drawing.Color.Black;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.Location = new System.Drawing.Point(936, 235);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(44, 67);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.FlatAppearance.BorderSize = 0;
            this.btnBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBefore.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btnBefore.IconColor = System.Drawing.Color.Black;
            this.btnBefore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBefore.Location = new System.Drawing.Point(-1, 235);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(44, 67);
            this.btnBefore.TabIndex = 2;
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 143);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(881, 404);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // frmGmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 547);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panelMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGmail";
            this.Text = "frmGmail";
            this.panelMensaje.ResumeLayout(false);
            this.panelMensaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMensaje;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnBefore;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label msgDate;
        private System.Windows.Forms.Label msgAsunto;
        private System.Windows.Forms.Label msgFrom;
        private System.Windows.Forms.Label lblCuerpoMSG;
        private System.Windows.Forms.Label lblNumeroMensaje;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}