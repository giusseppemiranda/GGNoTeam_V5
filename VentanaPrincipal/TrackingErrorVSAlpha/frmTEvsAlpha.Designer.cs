
namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha
{
    partial class frmTEvsAlpha
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
            this.panelCentral = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.openFileDialogBuscarCSV = new System.Windows.Forms.OpenFileDialog();
            this.btnAssetError = new FontAwesome.Sharp.IconButton();
            this.btnDataValorCuota = new FontAwesome.Sharp.IconButton();
            this.btnTrackingErrorvsAlfa = new FontAwesome.Sharp.IconButton();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.lblDescripcion);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCentral.Location = new System.Drawing.Point(0, 75);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(981, 478);
            this.panelCentral.TabIndex = 0;
            this.panelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentral_Paint);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDescripcion.Location = new System.Drawing.Point(313, 166);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(408, 28);
            this.lblDescripcion.TabIndex = 44;
            this.lblDescripcion.Text = "Seleccione una de las opciones disponible";
            // 
            // openFileDialogBuscarCSV
            // 
            this.openFileDialogBuscarCSV.FileName = "openFileDialog1";
            this.openFileDialogBuscarCSV.Filter = "Archivos CSV (*.csv)|*.csv";
            // 
            // btnAssetError
            // 
            this.btnAssetError.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAssetError.FlatAppearance.BorderSize = 0;
            this.btnAssetError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssetError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAssetError.ForeColor = System.Drawing.Color.White;
            this.btnAssetError.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnAssetError.IconColor = System.Drawing.Color.White;
            this.btnAssetError.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssetError.IconSize = 32;
            this.btnAssetError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssetError.Location = new System.Drawing.Point(685, 12);
            this.btnAssetError.Name = "btnAssetError";
            this.btnAssetError.Size = new System.Drawing.Size(256, 53);
            this.btnAssetError.TabIndex = 39;
            this.btnAssetError.Text = "Asset Error";
            this.btnAssetError.UseVisualStyleBackColor = false;
            this.btnAssetError.Click += new System.EventHandler(this.btnAssetError_Click);
            // 
            // btnDataValorCuota
            // 
            this.btnDataValorCuota.BackColor = System.Drawing.Color.OliveDrab;
            this.btnDataValorCuota.FlatAppearance.BorderSize = 0;
            this.btnDataValorCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataValorCuota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDataValorCuota.ForeColor = System.Drawing.Color.White;
            this.btnDataValorCuota.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnDataValorCuota.IconColor = System.Drawing.Color.White;
            this.btnDataValorCuota.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDataValorCuota.IconSize = 32;
            this.btnDataValorCuota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataValorCuota.Location = new System.Drawing.Point(374, 12);
            this.btnDataValorCuota.Name = "btnDataValorCuota";
            this.btnDataValorCuota.Size = new System.Drawing.Size(256, 53);
            this.btnDataValorCuota.TabIndex = 38;
            this.btnDataValorCuota.Text = "Data Valor Cuota";
            this.btnDataValorCuota.UseVisualStyleBackColor = false;
            this.btnDataValorCuota.Click += new System.EventHandler(this.btnDataValorCuota_Click);
            // 
            // btnTrackingErrorvsAlfa
            // 
            this.btnTrackingErrorvsAlfa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnTrackingErrorvsAlfa.FlatAppearance.BorderSize = 0;
            this.btnTrackingErrorvsAlfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackingErrorvsAlfa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTrackingErrorvsAlfa.ForeColor = System.Drawing.Color.White;
            this.btnTrackingErrorvsAlfa.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnTrackingErrorvsAlfa.IconColor = System.Drawing.Color.White;
            this.btnTrackingErrorvsAlfa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrackingErrorvsAlfa.IconSize = 32;
            this.btnTrackingErrorvsAlfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrackingErrorvsAlfa.Location = new System.Drawing.Point(52, 12);
            this.btnTrackingErrorvsAlfa.Name = "btnTrackingErrorvsAlfa";
            this.btnTrackingErrorvsAlfa.Size = new System.Drawing.Size(256, 53);
            this.btnTrackingErrorvsAlfa.TabIndex = 37;
            this.btnTrackingErrorvsAlfa.Text = "Tracking Error vs Alfa";
            this.btnTrackingErrorvsAlfa.UseVisualStyleBackColor = false;
            this.btnTrackingErrorvsAlfa.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // frmTEvsAlpha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.btnAssetError);
            this.Controls.Add(this.btnDataValorCuota);
            this.Controls.Add(this.btnTrackingErrorvsAlfa);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTEvsAlpha";
            this.Text = "frmTEvsAlpha";
            this.Load += new System.EventHandler(this.frmTEvsAlpha_Load);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.OpenFileDialog openFileDialogBuscarCSV;
        private FontAwesome.Sharp.IconButton btnTrackingErrorvsAlfa;
        private FontAwesome.Sharp.IconButton btnDataValorCuota;
        private FontAwesome.Sharp.IconButton btnAssetError;
        private System.Windows.Forms.Label lblDescripcion;
    }
}