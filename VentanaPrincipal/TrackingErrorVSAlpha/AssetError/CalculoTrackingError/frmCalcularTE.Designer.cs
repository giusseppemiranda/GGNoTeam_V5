
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
            this.dgvDataValorCuota = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fondo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patrimonio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarRegistros = new FontAwesome.Sharp.IconButton();
            this.lblTE = new System.Windows.Forms.Label();
            this.lblFondo_1 = new System.Windows.Forms.Label();
            this.lblFondo_2 = new System.Windows.Forms.Label();
            this.lblFondo_3 = new System.Windows.Forms.Label();
            this.ggTextBox1 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.ggTextBox2 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.ggTextBox3 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataValorCuota)).BeginInit();
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
            // dgvDataValorCuota
            // 
            this.dgvDataValorCuota.AllowUserToAddRows = false;
            this.dgvDataValorCuota.AllowUserToDeleteRows = false;
            this.dgvDataValorCuota.AllowUserToResizeColumns = false;
            this.dgvDataValorCuota.AllowUserToResizeRows = false;
            this.dgvDataValorCuota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDataValorCuota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataValorCuota.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDataValorCuota.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataValorCuota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataValorCuota.ColumnHeadersHeight = 25;
            this.dgvDataValorCuota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.AFP,
            this.Fondo,
            this.Patrimonio,
            this.Cuotas,
            this.ValorCuota});
            this.dgvDataValorCuota.EnableHeadersVisualStyles = false;
            this.dgvDataValorCuota.Location = new System.Drawing.Point(11, 91);
            this.dgvDataValorCuota.MultiSelect = false;
            this.dgvDataValorCuota.Name = "dgvDataValorCuota";
            this.dgvDataValorCuota.ReadOnly = true;
            this.dgvDataValorCuota.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvDataValorCuota.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataValorCuota.RowTemplate.Height = 25;
            this.dgvDataValorCuota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataValorCuota.Size = new System.Drawing.Size(952, 324);
            this.dgvDataValorCuota.TabIndex = 40;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 62;
            // 
            // AFP
            // 
            this.AFP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AFP.HeaderText = "AFP";
            this.AFP.Name = "AFP";
            this.AFP.ReadOnly = true;
            this.AFP.Width = 51;
            // 
            // Fondo
            // 
            this.Fondo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fondo.HeaderText = "Fondo";
            this.Fondo.Name = "Fondo";
            this.Fondo.ReadOnly = true;
            this.Fondo.Width = 64;
            // 
            // Patrimonio
            // 
            this.Patrimonio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Patrimonio.HeaderText = "Patrimonio";
            this.Patrimonio.Name = "Patrimonio";
            this.Patrimonio.ReadOnly = true;
            this.Patrimonio.Width = 91;
            // 
            // Cuotas
            // 
            this.Cuotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cuotas.HeaderText = "Cuota";
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            this.Cuotas.Width = 62;
            // 
            // ValorCuota
            // 
            this.ValorCuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorCuota.HeaderText = "Valor Cuota";
            this.ValorCuota.Name = "ValorCuota";
            this.ValorCuota.ReadOnly = true;
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
            // 
            // ggTextBox1
            // 
            this.ggTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.ggTextBox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ggTextBox1.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.ggTextBox1.BorderSize = 2;
            this.ggTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ggTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.ggTextBox1.IsFocused = false;
            this.ggTextBox1.Location = new System.Drawing.Point(283, 436);
            this.ggTextBox1.MaxLength = 32767;
            this.ggTextBox1.Multiline = false;
            this.ggTextBox1.Name = "ggTextBox1";
            this.ggTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.ggTextBox1.PasswordChar = false;
            this.ggTextBox1.Size = new System.Drawing.Size(125, 32);
            this.ggTextBox1.TabIndex = 45;
            this.ggTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ggTextBox1.Texts = "";
            this.ggTextBox1.UnderlinedStyle = false;
            // 
            // ggTextBox2
            // 
            this.ggTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.ggTextBox2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ggTextBox2.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.ggTextBox2.BorderSize = 2;
            this.ggTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ggTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.ggTextBox2.IsFocused = false;
            this.ggTextBox2.Location = new System.Drawing.Point(475, 436);
            this.ggTextBox2.MaxLength = 32767;
            this.ggTextBox2.Multiline = false;
            this.ggTextBox2.Name = "ggTextBox2";
            this.ggTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.ggTextBox2.PasswordChar = false;
            this.ggTextBox2.Size = new System.Drawing.Size(125, 32);
            this.ggTextBox2.TabIndex = 46;
            this.ggTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ggTextBox2.Texts = "";
            this.ggTextBox2.UnderlinedStyle = false;
            // 
            // ggTextBox3
            // 
            this.ggTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.ggTextBox3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ggTextBox3.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.ggTextBox3.BorderSize = 2;
            this.ggTextBox3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ggTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.ggTextBox3.IsFocused = false;
            this.ggTextBox3.Location = new System.Drawing.Point(657, 436);
            this.ggTextBox3.MaxLength = 32767;
            this.ggTextBox3.Multiline = false;
            this.ggTextBox3.Name = "ggTextBox3";
            this.ggTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.ggTextBox3.PasswordChar = false;
            this.ggTextBox3.Size = new System.Drawing.Size(125, 32);
            this.ggTextBox3.TabIndex = 47;
            this.ggTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ggTextBox3.Texts = "";
            this.ggTextBox3.UnderlinedStyle = false;
            // 
            // frmDataValorCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 478);
            this.Controls.Add(this.ggTextBox3);
            this.Controls.Add(this.ggTextBox2);
            this.Controls.Add(this.ggTextBox1);
            this.Controls.Add(this.lblFondo_3);
            this.Controls.Add(this.lblFondo_2);
            this.Controls.Add(this.lblFondo_1);
            this.Controls.Add(this.lblTE);
            this.Controls.Add(this.dgvDataValorCuota);
            this.Controls.Add(this.btnConsultarRegistros);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDataValorCuota";
            this.Text = "frmDataValorCuota";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataValorCuota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private FontAwesome.Sharp.IconButton btnConsultarRegistros;
        private System.Windows.Forms.DataGridView dgvDataValorCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fondo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patrimonio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCuota;
        private System.Windows.Forms.Label lblTE;
        private System.Windows.Forms.Label lblFondo_1;
        private System.Windows.Forms.Label lblFondo_2;
        private System.Windows.Forms.Label lblFondo_3;
        private Recursos.UserControls.GGTextBox ggTextBox1;
        private Recursos.UserControls.GGTextBox ggTextBox2;
        private Recursos.UserControls.GGTextBox ggTextBox3;
    }
}