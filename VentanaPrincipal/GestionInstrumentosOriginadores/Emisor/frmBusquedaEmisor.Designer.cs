
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEmisores = new System.Windows.Forms.Label();
            this.dgvEmisores = new GGNoTeam_V5.Recursos.CustomDGV.ProgressDataGridView();
            this.codigoOriginador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreOriginador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiguiente = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.btnCancelar = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmisores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmisores
            // 
            this.lblEmisores.AutoSize = true;
            this.lblEmisores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmisores.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEmisores.Location = new System.Drawing.Point(23, 29);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmisores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmisores.ColumnHeadersHeight = 25;
            this.dgvEmisores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoOriginador,
            this.nombreOriginador});
            this.dgvEmisores.EnableHeadersVisualStyles = false;
            this.dgvEmisores.Location = new System.Drawing.Point(28, 58);
            this.dgvEmisores.MultiSelect = false;
            this.dgvEmisores.Name = "dgvEmisores";
            this.dgvEmisores.ReadOnly = true;
            this.dgvEmisores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvEmisores.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 26);
            this.panel1.TabIndex = 134;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // frmBusquedaEmisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 356);
            this.Controls.Add(this.panel1);
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
        private Recursos.CustomDGV.ProgressDataGridView dgvEmisores;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoOriginador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreOriginador;
        private Recursos.UserControls.GGButton btnSiguiente;
        private Recursos.UserControls.GGButton btnCancelar;
        private System.Windows.Forms.Panel panel1;
    }
}