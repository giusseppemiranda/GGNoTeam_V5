
namespace GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Emisor
{
    partial class frmBusquedaEmisor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEmisores = new System.Windows.Forms.Label();
            this.dgvEmisores = new System.Windows.Forms.DataGridView();
            this.codigoOriginador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreOriginador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiguiente = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.btnCancelar = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmisores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmisores
            // 
            this.lblEmisores.AutoSize = true;
            this.lblEmisores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmisores.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEmisores.Location = new System.Drawing.Point(23, 18);
            this.lblEmisores.Name = "lblEmisores";
            this.lblEmisores.Size = new System.Drawing.Size(90, 25);
            this.lblEmisores.TabIndex = 129;
            this.lblEmisores.Text = "Emisores";
            // 
            // dgvEmisores
            // 
            this.dgvEmisores.AllowUserToAddRows = false;
            this.dgvEmisores.AllowUserToDeleteRows = false;
            this.dgvEmisores.AllowUserToResizeColumns = false;
            this.dgvEmisores.AllowUserToResizeRows = false;
            this.dgvEmisores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmisores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmisores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmisores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmisores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmisores.ColumnHeadersHeight = 25;
            this.dgvEmisores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoOriginador,
            this.nombreOriginador});
            this.dgvEmisores.EnableHeadersVisualStyles = false;
            this.dgvEmisores.Location = new System.Drawing.Point(17, 61);
            this.dgvEmisores.MultiSelect = false;
            this.dgvEmisores.Name = "dgvEmisores";
            this.dgvEmisores.ReadOnly = true;
            this.dgvEmisores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvEmisores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmisores.RowTemplate.Height = 25;
            this.dgvEmisores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmisores.Size = new System.Drawing.Size(345, 223);
            this.dgvEmisores.TabIndex = 130;
            this.dgvEmisores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEmisores_CellFormatting);
            // 
            // codigoOriginador
            // 
            this.codigoOriginador.HeaderText = "Código";
            this.codigoOriginador.Name = "codigoOriginador";
            this.codigoOriginador.ReadOnly = true;
            this.codigoOriginador.Width = 68;
            // 
            // nombreOriginador
            // 
            this.nombreOriginador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreOriginador.HeaderText = "Nombre";
            this.nombreOriginador.Name = "nombreOriginador";
            this.nombreOriginador.ReadOnly = true;
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
            this.btnSiguiente.Location = new System.Drawing.Point(261, 286);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(112, 47);
            this.btnSiguiente.TabIndex = 133;
            this.btnSiguiente.Text = "Aceptar";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(28, 287);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 47);
            this.btnCancelar.TabIndex = 132;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBusquedaEmisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 356);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvEmisores);
            this.Controls.Add(this.lblEmisores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusquedaEmisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusquedaEmisor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmisores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmisores;
        private System.Windows.Forms.DataGridView dgvEmisores;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoOriginador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreOriginador;
        private Recursos.UserControls.GGButton btnSiguiente;
        private Recursos.UserControls.GGButton btnCancelar;
    }
}