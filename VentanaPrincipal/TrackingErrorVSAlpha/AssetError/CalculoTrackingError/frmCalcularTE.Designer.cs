
namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.AssetError.CalculoTrackingError
{
    partial class frmCalcularTE
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.btnConsultarRegistros = new FontAwesome.Sharp.IconButton();
            this.lblTE = new System.Windows.Forms.Label();
            this.lblFondo_1 = new System.Windows.Forms.Label();
            this.lblFondo_2 = new System.Windows.Forms.Label();
            this.lblFondo_3 = new System.Windows.Forms.Label();
            this.dgvAssetError = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fondo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wgt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackingError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxFondo_3 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.boxFondo_2 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.boxFondo_1 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(6, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 28);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Calculo Tracking Error";
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(11, 65);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(222, 20);
            this.dateInicial.TabIndex = 20;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicial.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaInicial.Location = new System.Drawing.Point(8, 47);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(77, 15);
            this.lblFechaInicial.TabIndex = 22;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // btnConsultarRegistros
            // 
            this.btnConsultarRegistros.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsultarRegistros.FlatAppearance.BorderSize = 0;
            this.btnConsultarRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarRegistros.ForeColor = System.Drawing.Color.White;
            this.btnConsultarRegistros.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConsultarRegistros.IconColor = System.Drawing.Color.White;
            this.btnConsultarRegistros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultarRegistros.IconSize = 32;
            this.btnConsultarRegistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarRegistros.Location = new System.Drawing.Point(239, 47);
            this.btnConsultarRegistros.Name = "btnConsultarRegistros";
            this.btnConsultarRegistros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultarRegistros.Size = new System.Drawing.Size(178, 38);
            this.btnConsultarRegistros.TabIndex = 38;
            this.btnConsultarRegistros.Text = "Consultar Registros";
            this.btnConsultarRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarRegistros.UseVisualStyleBackColor = false;
            this.btnConsultarRegistros.Click += new System.EventHandler(this.btnConsultarRegistros_Click);
            // 
            // lblTE
            // 
            this.lblTE.AutoSize = true;
            this.lblTE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTE.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTE.Location = new System.Drawing.Point(34, 443);
            this.lblTE.Name = "lblTE";
            this.lblTE.Size = new System.Drawing.Size(148, 15);
            this.lblTE.TabIndex = 41;
            this.lblTE.Text = "Valores de Tracking Error:";
            // 
            // lblFondo_1
            // 
            this.lblFondo_1.AutoSize = true;
            this.lblFondo_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFondo_1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFondo_1.Location = new System.Drawing.Point(318, 418);
            this.lblFondo_1.Name = "lblFondo_1";
            this.lblFondo_1.Size = new System.Drawing.Size(59, 15);
            this.lblFondo_1.TabIndex = 42;
            this.lblFondo_1.Text = "FONDO 1";
            // 
            // lblFondo_2
            // 
            this.lblFondo_2.AutoSize = true;
            this.lblFondo_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFondo_2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFondo_2.Location = new System.Drawing.Point(511, 418);
            this.lblFondo_2.Name = "lblFondo_2";
            this.lblFondo_2.Size = new System.Drawing.Size(59, 15);
            this.lblFondo_2.TabIndex = 43;
            this.lblFondo_2.Text = "FONDO 2";
            // 
            // lblFondo_3
            // 
            this.lblFondo_3.AutoSize = true;
            this.lblFondo_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFondo_3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFondo_3.Location = new System.Drawing.Point(690, 418);
            this.lblFondo_3.Name = "lblFondo_3";
            this.lblFondo_3.Size = new System.Drawing.Size(59, 15);
            this.lblFondo_3.TabIndex = 44;
            this.lblFondo_3.Text = "FONDO 3";
            this.lblFondo_3.Click += new System.EventHandler(this.lblFondo_3_Click);
            // 
            // dgvAssetError
            // 
            this.dgvAssetError.AllowUserToAddRows = false;
            this.dgvAssetError.AllowUserToDeleteRows = false;
            this.dgvAssetError.AllowUserToResizeColumns = false;
            this.dgvAssetError.AllowUserToResizeRows = false;
            this.dgvAssetError.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAssetError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssetError.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssetError.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssetError.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssetError.ColumnHeadersHeight = 25;
            this.dgvAssetError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.Fondo,
            this.Nombre,
            this.wgt,
            this.TotalRisk,
            this.TrackingError});
            this.dgvAssetError.EnableHeadersVisualStyles = false;
            this.dgvAssetError.Location = new System.Drawing.Point(11, 91);
            this.dgvAssetError.MultiSelect = false;
            this.dgvAssetError.Name = "dgvAssetError";
            this.dgvAssetError.ReadOnly = true;
            this.dgvAssetError.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvAssetError.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssetError.RowTemplate.Height = 25;
            this.dgvAssetError.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssetError.Size = new System.Drawing.Size(952, 324);
            this.dgvAssetError.TabIndex = 51;
            this.dgvAssetError.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAssetError_CellFormatting);
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 62;
            // 
            // Fondo
            // 
            this.Fondo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fondo.HeaderText = "Fondo";
            this.Fondo.Name = "Fondo";
            this.Fondo.ReadOnly = true;
            this.Fondo.Width = 64;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 76;
            // 
            // wgt
            // 
            this.wgt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wgt.HeaderText = "% WGT";
            this.wgt.Name = "wgt";
            this.wgt.ReadOnly = true;
            this.wgt.Width = 71;
            // 
            // TotalRisk
            // 
            this.TotalRisk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalRisk.HeaderText = "Total Risk";
            this.TotalRisk.Name = "TotalRisk";
            this.TotalRisk.ReadOnly = true;
            this.TotalRisk.Width = 83;
            // 
            // TrackingError
            // 
            this.TrackingError.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrackingError.HeaderText = "Tracking Error";
            this.TrackingError.Name = "TrackingError";
            this.TrackingError.ReadOnly = true;
            // 
            // boxFondo_3
            // 
            this.boxFondo_3.BackColor = System.Drawing.SystemColors.Window;
            this.boxFondo_3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.boxFondo_3.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.boxFondo_3.BorderSize = 2;
            this.boxFondo_3.Enabled = false;
            this.boxFondo_3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.boxFondo_3.ForeColor = System.Drawing.Color.DimGray;
            this.boxFondo_3.IsFocused = false;
            this.boxFondo_3.Location = new System.Drawing.Point(657, 436);
            this.boxFondo_3.MaxLength = 32767;
            this.boxFondo_3.Multiline = false;
            this.boxFondo_3.Name = "boxFondo_3";
            this.boxFondo_3.Padding = new System.Windows.Forms.Padding(7);
            this.boxFondo_3.PasswordChar = false;
            this.boxFondo_3.Size = new System.Drawing.Size(125, 32);
            this.boxFondo_3.TabIndex = 47;
            this.boxFondo_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxFondo_3.Texts = "";
            this.boxFondo_3.UnderlinedStyle = false;
            this.boxFondo_3._TextChanged += new System.EventHandler(this.ggTextBox3__TextChanged);
            // 
            // boxFondo_2
            // 
            this.boxFondo_2.BackColor = System.Drawing.SystemColors.Window;
            this.boxFondo_2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.boxFondo_2.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.boxFondo_2.BorderSize = 2;
            this.boxFondo_2.Enabled = false;
            this.boxFondo_2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.boxFondo_2.ForeColor = System.Drawing.Color.DimGray;
            this.boxFondo_2.IsFocused = false;
            this.boxFondo_2.Location = new System.Drawing.Point(475, 436);
            this.boxFondo_2.MaxLength = 32767;
            this.boxFondo_2.Multiline = false;
            this.boxFondo_2.Name = "boxFondo_2";
            this.boxFondo_2.Padding = new System.Windows.Forms.Padding(7);
            this.boxFondo_2.PasswordChar = false;
            this.boxFondo_2.Size = new System.Drawing.Size(125, 32);
            this.boxFondo_2.TabIndex = 46;
            this.boxFondo_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxFondo_2.Texts = "";
            this.boxFondo_2.UnderlinedStyle = false;
            // 
            // boxFondo_1
            // 
            this.boxFondo_1.BackColor = System.Drawing.SystemColors.Window;
            this.boxFondo_1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.boxFondo_1.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.boxFondo_1.BorderSize = 2;
            this.boxFondo_1.Enabled = false;
            this.boxFondo_1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.boxFondo_1.ForeColor = System.Drawing.Color.DimGray;
            this.boxFondo_1.IsFocused = false;
            this.boxFondo_1.Location = new System.Drawing.Point(283, 436);
            this.boxFondo_1.MaxLength = 32767;
            this.boxFondo_1.Multiline = false;
            this.boxFondo_1.Name = "boxFondo_1";
            this.boxFondo_1.Padding = new System.Windows.Forms.Padding(7);
            this.boxFondo_1.PasswordChar = false;
            this.boxFondo_1.Size = new System.Drawing.Size(125, 32);
            this.boxFondo_1.TabIndex = 45;
            this.boxFondo_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxFondo_1.Texts = "";
            this.boxFondo_1.UnderlinedStyle = false;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExportar.IconColor = System.Drawing.Color.White;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.IconSize = 32;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(820, 428);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExportar.Size = new System.Drawing.Size(134, 38);
            this.btnExportar.TabIndex = 54;
            this.btnExportar.Text = "Exportar a .csv";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmCalcularTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 478);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvAssetError);
            this.Controls.Add(this.boxFondo_3);
            this.Controls.Add(this.boxFondo_2);
            this.Controls.Add(this.boxFondo_1);
            this.Controls.Add(this.lblFondo_3);
            this.Controls.Add(this.lblFondo_2);
            this.Controls.Add(this.lblFondo_1);
            this.Controls.Add(this.lblTE);
            this.Controls.Add(this.btnConsultarRegistros);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalcularTE";
            this.Text = "frmDataValorCuota";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private FontAwesome.Sharp.IconButton btnConsultarRegistros;
        private System.Windows.Forms.Label lblTE;
        private System.Windows.Forms.Label lblFondo_1;
        private System.Windows.Forms.Label lblFondo_2;
        private System.Windows.Forms.Label lblFondo_3;
        private Recursos.UserControls.GGTextBox boxFondo_1;
        private Recursos.UserControls.GGTextBox boxFondo_2;
        private Recursos.UserControls.GGTextBox boxFondo_3;
        private System.Windows.Forms.DataGridView dgvAssetError;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fondo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn wgt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRisk;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackingError;
        private FontAwesome.Sharp.IconButton btnExportar;
    }
}