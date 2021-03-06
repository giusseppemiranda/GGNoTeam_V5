
namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota
{
    partial class frmDataValorCuota
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVerCalculoAlfa = new FontAwesome.Sharp.IconButton();
            this.btnEliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnActualizarRegistro = new FontAwesome.Sharp.IconButton();
            this.dgvDataValorCuota = new Recursos.CustomDGV.ProgressDataGridView();
            this.idDVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fondo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patrimonio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarRegistros = new FontAwesome.Sharp.IconButton();
            this.btnConsultarRegistros = new FontAwesome.Sharp.IconButton();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblTitutlo = new System.Windows.Forms.Label();
            this.comboFondo = new GGNoTeam_V5.Recursos.UserControls.GGComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataValorCuota)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerCalculoAlfa
            // 
            this.btnVerCalculoAlfa.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnVerCalculoAlfa.FlatAppearance.BorderSize = 0;
            this.btnVerCalculoAlfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCalculoAlfa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerCalculoAlfa.ForeColor = System.Drawing.Color.White;
            this.btnVerCalculoAlfa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerCalculoAlfa.IconColor = System.Drawing.Color.White;
            this.btnVerCalculoAlfa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerCalculoAlfa.IconSize = 32;
            this.btnVerCalculoAlfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCalculoAlfa.Location = new System.Drawing.Point(11, 432);
            this.btnVerCalculoAlfa.Name = "btnVerCalculoAlfa";
            this.btnVerCalculoAlfa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVerCalculoAlfa.Size = new System.Drawing.Size(167, 38);
            this.btnVerCalculoAlfa.TabIndex = 65;
            this.btnVerCalculoAlfa.Text = "Ver Calculo Alpha";
            this.btnVerCalculoAlfa.UseVisualStyleBackColor = false;
            this.btnVerCalculoAlfa.Click += new System.EventHandler(this.btnVerCalculoAlfa_Click);
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
            this.btnEliminarRegistro.Location = new System.Drawing.Point(806, 432);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminarRegistro.Size = new System.Drawing.Size(163, 38);
            this.btnEliminarRegistro.TabIndex = 64;
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
            this.btnActualizarRegistro.Location = new System.Drawing.Point(637, 432);
            this.btnActualizarRegistro.Name = "btnActualizarRegistro";
            this.btnActualizarRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActualizarRegistro.Size = new System.Drawing.Size(163, 38);
            this.btnActualizarRegistro.TabIndex = 63;
            this.btnActualizarRegistro.Text = "Modificar registro";
            this.btnActualizarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarRegistro.UseVisualStyleBackColor = false;
            this.btnActualizarRegistro.Click += new System.EventHandler(this.btnActualizarRegistro_Click);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataValorCuota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDataValorCuota.ColumnHeadersHeight = 25;
            this.dgvDataValorCuota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDVC,
            this.fecha,
            this.nombreAFP,
            this.Fondo,
            this.patrimonio,
            this.cuotas,
            this.valorCuota});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataValorCuota.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDataValorCuota.EnableHeadersVisualStyles = false;
            this.dgvDataValorCuota.Location = new System.Drawing.Point(11, 91);
            this.dgvDataValorCuota.MultiSelect = false;
            this.dgvDataValorCuota.Name = "dgvDataValorCuota";
            this.dgvDataValorCuota.ReadOnly = true;
            this.dgvDataValorCuota.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDataValorCuota.RowHeadersWidth = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvDataValorCuota.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDataValorCuota.RowTemplate.Height = 25;
            this.dgvDataValorCuota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataValorCuota.Size = new System.Drawing.Size(958, 335);
            this.dgvDataValorCuota.TabIndex = 62;
            this.dgvDataValorCuota.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDataValorCuota_CellFormatting);
            // 
            // idDVC
            // 
            this.idDVC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDVC.HeaderText = "ID";
            this.idDVC.Name = "idDVC";
            this.idDVC.ReadOnly = true;
            this.idDVC.Width = 43;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 62;
            // 
            // nombreAFP
            // 
            this.nombreAFP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreAFP.HeaderText = "Nombre AFP";
            this.nombreAFP.Name = "nombreAFP";
            this.nombreAFP.ReadOnly = true;
            // 
            // Fondo
            // 
            this.Fondo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fondo.HeaderText = "Tipo fondo";
            this.Fondo.Name = "Fondo";
            this.Fondo.ReadOnly = true;
            this.Fondo.Width = 90;
            // 
            // patrimonio
            // 
            this.patrimonio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.patrimonio.HeaderText = "Patrimonio";
            this.patrimonio.Name = "patrimonio";
            this.patrimonio.ReadOnly = true;
            this.patrimonio.Width = 91;
            // 
            // cuotas
            // 
            this.cuotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cuotas.HeaderText = "Cuotas";
            this.cuotas.Name = "cuotas";
            this.cuotas.ReadOnly = true;
            this.cuotas.Width = 67;
            // 
            // valorCuota
            // 
            this.valorCuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorCuota.HeaderText = "Valor Cuota";
            this.valorCuota.Name = "valorCuota";
            this.valorCuota.ReadOnly = true;
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
            this.btnAgregarRegistros.Location = new System.Drawing.Point(468, 432);
            this.btnAgregarRegistros.Name = "btnAgregarRegistros";
            this.btnAgregarRegistros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAgregarRegistros.Size = new System.Drawing.Size(163, 38);
            this.btnAgregarRegistros.TabIndex = 61;
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
            this.btnConsultarRegistros.Location = new System.Drawing.Point(765, 47);
            this.btnConsultarRegistros.Name = "btnConsultarRegistros";
            this.btnConsultarRegistros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultarRegistros.Size = new System.Drawing.Size(204, 38);
            this.btnConsultarRegistros.TabIndex = 60;
            this.btnConsultarRegistros.Text = "Consultar Registros";
            this.btnConsultarRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarRegistros.UseVisualStyleBackColor = false;
            this.btnConsultarRegistros.Click += new System.EventHandler(this.btnConsultarRegistros_Click);
            // 
            // dateFinal
            // 
            this.dateFinal.Location = new System.Drawing.Point(216, 65);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(198, 20);
            this.dateFinal.TabIndex = 59;
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(11, 65);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(199, 20);
            this.dateInicial.TabIndex = 56;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicial.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaInicial.Location = new System.Drawing.Point(8, 47);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(77, 15);
            this.lblFechaInicial.TabIndex = 58;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaFinal.Location = new System.Drawing.Point(212, 47);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(70, 15);
            this.lblFechaFinal.TabIndex = 57;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblTitutlo
            // 
            this.lblTitutlo.AutoSize = true;
            this.lblTitutlo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitutlo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitutlo.Location = new System.Drawing.Point(6, 5);
            this.lblTitutlo.Name = "lblTitutlo";
            this.lblTitutlo.Size = new System.Drawing.Size(172, 28);
            this.lblTitutlo.TabIndex = 55;
            this.lblTitutlo.Text = "Data Valor Cuota";
            // 
            // comboFondo
            // 
            this.comboFondo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboFondo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboFondo.BorderSize = 1;
            this.comboFondo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboFondo.ForeColor = System.Drawing.Color.DimGray;
            this.comboFondo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboFondo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboFondo.ListTextColor = System.Drawing.Color.DimGray;
            this.comboFondo.Location = new System.Drawing.Point(559, 55);
            this.comboFondo.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboFondo.Name = "comboFondo";
            this.comboFondo.Padding = new System.Windows.Forms.Padding(1);
            this.comboFondo.Size = new System.Drawing.Size(200, 30);
            this.comboFondo.TabIndex = 66;
            this.comboFondo.Texts = "Fondo";
            this.comboFondo.OnSelectedIndexChanged += new System.EventHandler(this.comboFondo_OnSelectedIndexChanged);
            this.comboFondo.Load += new System.EventHandler(this.comboFondo_Load);
            // 
            // frmDataValorCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 478);
            this.Controls.Add(this.comboFondo);
            this.Controls.Add(this.btnVerCalculoAlfa);
            this.Controls.Add(this.btnEliminarRegistro);
            this.Controls.Add(this.btnActualizarRegistro);
            this.Controls.Add(this.dgvDataValorCuota);
            this.Controls.Add(this.btnAgregarRegistros);
            this.Controls.Add(this.btnConsultarRegistros);
            this.Controls.Add(this.dateFinal);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblTitutlo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDataValorCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDataValorCuota";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataValorCuota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVerCalculoAlfa;
        private FontAwesome.Sharp.IconButton btnEliminarRegistro;
        private FontAwesome.Sharp.IconButton btnActualizarRegistro;
        private Recursos.CustomDGV.ProgressDataGridView dgvDataValorCuota;
        private FontAwesome.Sharp.IconButton btnAgregarRegistros;
        private FontAwesome.Sharp.IconButton btnConsultarRegistros;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblTitutlo;
        private Recursos.UserControls.GGComboBox comboFondo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fondo;
        private System.Windows.Forms.DataGridViewTextBoxColumn patrimonio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCuota;
    }
}