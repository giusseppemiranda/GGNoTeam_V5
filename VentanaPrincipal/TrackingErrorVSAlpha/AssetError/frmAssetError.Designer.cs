﻿
namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.AssetError
{
    partial class frmAssetError
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAssetError = new System.Windows.Forms.DataGridView();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnActualizarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnAgregarRegistros = new FontAwesome.Sharp.IconButton();
            this.btnConsultarRegistros = new FontAwesome.Sharp.IconButton();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fondo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wgt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetError)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssetError.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAssetError.ColumnHeadersHeight = 25;
            this.dgvAssetError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Fondo,
            this.Name,
            this.wgt,
            this.TotalRisk});
            this.dgvAssetError.EnableHeadersVisualStyles = false;
            this.dgvAssetError.Location = new System.Drawing.Point(11, 91);
            this.dgvAssetError.MultiSelect = false;
            this.dgvAssetError.Name = "dgvAssetError";
            this.dgvAssetError.ReadOnly = true;
            this.dgvAssetError.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvAssetError.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAssetError.RowTemplate.Height = 25;
            this.dgvAssetError.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssetError.Size = new System.Drawing.Size(952, 335);
            this.dgvAssetError.TabIndex = 50;
            // 
            // dateFinal
            // 
            this.dateFinal.Location = new System.Drawing.Point(276, 65);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(222, 20);
            this.dateFinal.TabIndex = 47;
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(11, 65);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(222, 20);
            this.dateInicial.TabIndex = 44;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicial.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaInicial.Location = new System.Drawing.Point(8, 47);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(77, 15);
            this.lblFechaInicial.TabIndex = 46;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaFinal.Location = new System.Drawing.Point(273, 47);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(70, 15);
            this.lblFechaFinal.TabIndex = 45;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(6, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(116, 28);
            this.lblTitulo.TabIndex = 43;
            this.lblTitulo.Text = "Asset Error";
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarRegistro.FlatAppearance.BorderSize = 0;
            this.btnEliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRegistro.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnEliminarRegistro.IconColor = System.Drawing.Color.White;
            this.btnEliminarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarRegistro.IconSize = 32;
            this.btnEliminarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(800, 432);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminarRegistro.Size = new System.Drawing.Size(163, 38);
            this.btnEliminarRegistro.TabIndex = 52;
            this.btnEliminarRegistro.Text = "Eliminar registro";
            this.btnEliminarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarRegistro.UseVisualStyleBackColor = false;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // btnActualizarRegistro
            // 
            this.btnActualizarRegistro.BackColor = System.Drawing.Color.Orange;
            this.btnActualizarRegistro.FlatAppearance.BorderSize = 0;
            this.btnActualizarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnActualizarRegistro.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnActualizarRegistro.IconColor = System.Drawing.Color.White;
            this.btnActualizarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarRegistro.IconSize = 32;
            this.btnActualizarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarRegistro.Location = new System.Drawing.Point(631, 432);
            this.btnActualizarRegistro.Name = "btnActualizarRegistro";
            this.btnActualizarRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActualizarRegistro.Size = new System.Drawing.Size(163, 38);
            this.btnActualizarRegistro.TabIndex = 51;
            this.btnActualizarRegistro.Text = "Modificar registro";
            this.btnActualizarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarRegistro.UseVisualStyleBackColor = false;
            this.btnActualizarRegistro.Click += new System.EventHandler(this.btnActualizarRegistro_Click);
            // 
            // btnAgregarRegistros
            // 
            this.btnAgregarRegistros.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarRegistros.FlatAppearance.BorderSize = 0;
            this.btnAgregarRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarRegistros.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRegistros.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarRegistros.IconColor = System.Drawing.Color.White;
            this.btnAgregarRegistros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarRegistros.IconSize = 32;
            this.btnAgregarRegistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRegistros.Location = new System.Drawing.Point(785, 47);
            this.btnAgregarRegistros.Name = "btnAgregarRegistros";
            this.btnAgregarRegistros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAgregarRegistros.Size = new System.Drawing.Size(178, 38);
            this.btnAgregarRegistros.TabIndex = 49;
            this.btnAgregarRegistros.Text = "Agregar Registro";
            this.btnAgregarRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarRegistros.UseVisualStyleBackColor = false;
            this.btnAgregarRegistros.Click += new System.EventHandler(this.btnAgregarRegistros_Click);
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
            this.btnConsultarRegistros.Location = new System.Drawing.Point(504, 47);
            this.btnConsultarRegistros.Name = "btnConsultarRegistros";
            this.btnConsultarRegistros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultarRegistros.Size = new System.Drawing.Size(178, 38);
            this.btnConsultarRegistros.TabIndex = 48;
            this.btnConsultarRegistros.Text = "Consultar Registros";
            this.btnConsultarRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarRegistros.UseVisualStyleBackColor = false;
            this.btnConsultarRegistros.Click += new System.EventHandler(this.btnConsultarRegistros_Click);
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 62;
            // 
            // Fondo
            // 
            this.Fondo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fondo.HeaderText = "Fondo";
            this.Fondo.Name = "Fondo";
            this.Fondo.ReadOnly = true;
            this.Fondo.Width = 64;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 63;
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
            this.TotalRisk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalRisk.HeaderText = "Total Risk";
            this.TotalRisk.Name = "TotalRisk";
            this.TotalRisk.ReadOnly = true;
            // 
            // frmAssetError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 478);
            this.Controls.Add(this.btnEliminarRegistro);
            this.Controls.Add(this.btnActualizarRegistro);
            this.Controls.Add(this.dgvAssetError);
            this.Controls.Add(this.btnAgregarRegistros);
            this.Controls.Add(this.btnConsultarRegistros);
            this.Controls.Add(this.dateFinal);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;           
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEliminarRegistro;
        private FontAwesome.Sharp.IconButton btnActualizarRegistro;
        private System.Windows.Forms.DataGridView dgvAssetError;
        private FontAwesome.Sharp.IconButton btnAgregarRegistros;
        private FontAwesome.Sharp.IconButton btnConsultarRegistros;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fondo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn wgt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRisk;
    }
}