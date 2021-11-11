﻿
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
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(433, 54);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Calculo Tracking Error";
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(22, 125);
            this.dateInicial.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(440, 31);
            this.dateInicial.TabIndex = 20;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicial.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaInicial.Location = new System.Drawing.Point(16, 90);
            this.lblFechaInicial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(162, 32);
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
            this.dgvDataValorCuota.EnableHeadersVisualStyles = false;
            this.dgvDataValorCuota.Location = new System.Drawing.Point(22, 175);
            this.dgvDataValorCuota.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvDataValorCuota.MultiSelect = false;
            this.dgvDataValorCuota.Name = "dgvDataValorCuota";
            this.dgvDataValorCuota.ReadOnly = true;
            this.dgvDataValorCuota.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDataValorCuota.RowHeadersWidth = 82;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvDataValorCuota.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataValorCuota.RowTemplate.Height = 25;
            this.dgvDataValorCuota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataValorCuota.Size = new System.Drawing.Size(1904, 623);
            this.dgvDataValorCuota.TabIndex = 40;
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
            this.btnConsultarRegistros.Location = new System.Drawing.Point(478, 90);
            this.btnConsultarRegistros.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConsultarRegistros.Name = "btnConsultarRegistros";
            this.btnConsultarRegistros.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConsultarRegistros.Size = new System.Drawing.Size(356, 73);
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
            this.lblTE.Location = new System.Drawing.Point(68, 852);
            this.lblTE.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTE.Name = "lblTE";
            this.lblTE.Size = new System.Drawing.Size(310, 32);
            this.lblTE.TabIndex = 41;
            this.lblTE.Text = "Valores de Tracking Error:";
            // 
            // lblFondo_1
            // 
            this.lblFondo_1.AutoSize = true;
            this.lblFondo_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFondo_1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFondo_1.Location = new System.Drawing.Point(636, 804);
            this.lblFondo_1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFondo_1.Name = "lblFondo_1";
            this.lblFondo_1.Size = new System.Drawing.Size(121, 32);
            this.lblFondo_1.TabIndex = 42;
            this.lblFondo_1.Text = "FONDO 1";
            // 
            // lblFondo_2
            // 
            this.lblFondo_2.AutoSize = true;
            this.lblFondo_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFondo_2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFondo_2.Location = new System.Drawing.Point(1022, 804);
            this.lblFondo_2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFondo_2.Name = "lblFondo_2";
            this.lblFondo_2.Size = new System.Drawing.Size(121, 32);
            this.lblFondo_2.TabIndex = 43;
            this.lblFondo_2.Text = "FONDO 2";
            // 
            // lblFondo_3
            // 
            this.lblFondo_3.AutoSize = true;
            this.lblFondo_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFondo_3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFondo_3.Location = new System.Drawing.Point(1380, 804);
            this.lblFondo_3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFondo_3.Name = "lblFondo_3";
            this.lblFondo_3.Size = new System.Drawing.Size(121, 32);
            this.lblFondo_3.TabIndex = 44;
            this.lblFondo_3.Text = "FONDO 3";
            this.lblFondo_3.Visible = false;
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
            this.ggTextBox1.Location = new System.Drawing.Point(566, 838);
            this.ggTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ggTextBox1.MaxLength = 32767;
            this.ggTextBox1.Multiline = false;
            this.ggTextBox1.Name = "ggTextBox1";
            this.ggTextBox1.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.ggTextBox1.PasswordChar = false;
            this.ggTextBox1.Size = new System.Drawing.Size(250, 63);
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
            this.ggTextBox2.Location = new System.Drawing.Point(950, 838);
            this.ggTextBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ggTextBox2.MaxLength = 32767;
            this.ggTextBox2.Multiline = false;
            this.ggTextBox2.Name = "ggTextBox2";
            this.ggTextBox2.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.ggTextBox2.PasswordChar = false;
            this.ggTextBox2.Size = new System.Drawing.Size(250, 63);
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
            this.ggTextBox3.Location = new System.Drawing.Point(1314, 838);
            this.ggTextBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ggTextBox3.MaxLength = 32767;
            this.ggTextBox3.Multiline = false;
            this.ggTextBox3.Name = "ggTextBox3";
            this.ggTextBox3.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.ggTextBox3.PasswordChar = false;
            this.ggTextBox3.Size = new System.Drawing.Size(250, 63);
            this.ggTextBox3.TabIndex = 47;
            this.ggTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ggTextBox3.Texts = "";
            this.ggTextBox3.UnderlinedStyle = false;
            this.ggTextBox3.Visible = false;
            // 
            // frmCalcularTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1962, 919);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmCalcularTE";
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
        private System.Windows.Forms.Label lblTE;
        private System.Windows.Forms.Label lblFondo_1;
        private System.Windows.Forms.Label lblFondo_2;
        private System.Windows.Forms.Label lblFondo_3;
        private Recursos.UserControls.GGTextBox ggTextBox1;
        private Recursos.UserControls.GGTextBox ggTextBox2;
        private Recursos.UserControls.GGTextBox ggTextBox3;
    }
}