
namespace GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes
{
    partial class frmMonitoreoOrdenes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnAccederEjecucion = new FontAwesome.Sharp.IconButton();
            this.btnAccederOrden = new FontAwesome.Sharp.IconButton();
            this.EliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnModificarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codSBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUM_Ejecucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUM_Ordenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valides = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboFondo = new GGNoTeam_V5.Recursos.UserControls.GGComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(6, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 28);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "Monitoreo de órdenes";
            // 
            // dateFinal
            // 
            this.dateFinal.Location = new System.Drawing.Point(216, 65);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(198, 20);
            this.dateFinal.TabIndex = 63;
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(11, 65);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(199, 20);
            this.dateInicial.TabIndex = 60;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicial.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaInicial.Location = new System.Drawing.Point(8, 47);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(77, 15);
            this.lblFechaInicial.TabIndex = 62;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaFinal.Location = new System.Drawing.Point(213, 47);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(70, 15);
            this.lblFechaFinal.TabIndex = 61;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSubtitulo.Location = new System.Drawing.Point(240, 15);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(95, 20);
            this.lblSubtitulo.TabIndex = 25;
            this.lblSubtitulo.Text = "Operaciones";
            // 
            // btnAccederEjecucion
            // 
            this.btnAccederEjecucion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAccederEjecucion.FlatAppearance.BorderSize = 0;
            this.btnAccederEjecucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccederEjecucion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAccederEjecucion.ForeColor = System.Drawing.Color.White;
            this.btnAccederEjecucion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAccederEjecucion.IconColor = System.Drawing.Color.White;
            this.btnAccederEjecucion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccederEjecucion.IconSize = 32;
            this.btnAccederEjecucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccederEjecucion.Location = new System.Drawing.Point(168, 497);
            this.btnAccederEjecucion.Name = "btnAccederEjecucion";
            this.btnAccederEjecucion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccederEjecucion.Size = new System.Drawing.Size(150, 38);
            this.btnAccederEjecucion.TabIndex = 72;
            this.btnAccederEjecucion.Text = "Acceder ejecución";
            this.btnAccederEjecucion.UseVisualStyleBackColor = false;
            this.btnAccederEjecucion.Click += new System.EventHandler(this.btnAccederEjecucion_Click);
            // 
            // btnAccederOrden
            // 
            this.btnAccederOrden.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAccederOrden.FlatAppearance.BorderSize = 0;
            this.btnAccederOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccederOrden.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAccederOrden.ForeColor = System.Drawing.Color.White;
            this.btnAccederOrden.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAccederOrden.IconColor = System.Drawing.Color.White;
            this.btnAccederOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccederOrden.IconSize = 32;
            this.btnAccederOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccederOrden.Location = new System.Drawing.Point(12, 497);
            this.btnAccederOrden.Name = "btnAccederOrden";
            this.btnAccederOrden.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccederOrden.Size = new System.Drawing.Size(150, 38);
            this.btnAccederOrden.TabIndex = 71;
            this.btnAccederOrden.Text = "Acceder órden";
            this.btnAccederOrden.UseVisualStyleBackColor = false;
            this.btnAccederOrden.Click += new System.EventHandler(this.btnAccederOrden_Click);
            // 
            // EliminarRegistro
            // 
            this.EliminarRegistro.BackColor = System.Drawing.Color.IndianRed;
            this.EliminarRegistro.FlatAppearance.BorderSize = 0;
            this.EliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.EliminarRegistro.ForeColor = System.Drawing.Color.White;
            this.EliminarRegistro.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.EliminarRegistro.IconColor = System.Drawing.Color.White;
            this.EliminarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarRegistro.IconSize = 32;
            this.EliminarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarRegistro.Location = new System.Drawing.Point(806, 497);
            this.EliminarRegistro.Name = "EliminarRegistro";
            this.EliminarRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EliminarRegistro.Size = new System.Drawing.Size(163, 38);
            this.EliminarRegistro.TabIndex = 76;
            this.EliminarRegistro.Text = "Eliminar registro";
            this.EliminarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarRegistro.UseVisualStyleBackColor = false;
            this.EliminarRegistro.Click += new System.EventHandler(this.EliminarRegistro_Click);
            // 
            // btnModificarRegistro
            // 
            this.btnModificarRegistro.BackColor = System.Drawing.Color.Orange;
            this.btnModificarRegistro.FlatAppearance.BorderSize = 0;
            this.btnModificarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnModificarRegistro.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnModificarRegistro.IconColor = System.Drawing.Color.White;
            this.btnModificarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarRegistro.IconSize = 32;
            this.btnModificarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarRegistro.Location = new System.Drawing.Point(636, 497);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnModificarRegistro.Size = new System.Drawing.Size(163, 38);
            this.btnModificarRegistro.TabIndex = 77;
            this.btnModificarRegistro.Text = "Modificar registro";
            this.btnModificarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarRegistro.UseVisualStyleBackColor = false;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConsultar.IconColor = System.Drawing.Color.White;
            this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultar.IconSize = 32;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(765, 47);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultar.Size = new System.Drawing.Size(204, 38);
            this.btnConsultar.TabIndex = 78;
            this.btnConsultar.Text = "Consultar Registros";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnconsultar_click);
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.AllowUserToAddRows = false;
            this.dgvOrdenes.AllowUserToDeleteRows = false;
            this.dgvOrdenes.AllowUserToResizeColumns = false;
            this.dgvOrdenes.AllowUserToResizeRows = false;
            this.dgvOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrdenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrdenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrdenes.ColumnHeadersHeight = 25;
            this.dgvOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.f,
            this.codSBS,
            this.codISIN,
            this.instru,
            this.AUM_Ejecucion,
            this.AUM_Ordenes,
            this.Valides,
            this.Coment});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdenes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrdenes.EnableHeadersVisualStyles = false;
            this.dgvOrdenes.Location = new System.Drawing.Point(11, 91);
            this.dgvOrdenes.MultiSelect = false;
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.ReadOnly = true;
            this.dgvOrdenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvOrdenes.RowHeadersWidth = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvOrdenes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrdenes.RowTemplate.Height = 25;
            this.dgvOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenes.Size = new System.Drawing.Size(958, 400);
            this.dgvOrdenes.TabIndex = 79;
            this.dgvOrdenes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrdenes_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 62;
            // 
            // f
            // 
            this.f.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.f.HeaderText = "Fondo";
            this.f.Name = "f";
            this.f.ReadOnly = true;
            this.f.Width = 64;
            // 
            // codSBS
            // 
            this.codSBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codSBS.HeaderText = "Codigo SBS";
            this.codSBS.Name = "codSBS";
            this.codSBS.ReadOnly = true;
            this.codSBS.Width = 93;
            // 
            // codISIN
            // 
            this.codISIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codISIN.HeaderText = "Codigo ISIN";
            this.codISIN.Name = "codISIN";
            this.codISIN.ReadOnly = true;
            this.codISIN.Width = 95;
            // 
            // instru
            // 
            this.instru.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.instru.HeaderText = "Instrumento";
            this.instru.Name = "instru";
            this.instru.ReadOnly = true;
            // 
            // AUM_Ejecucion
            // 
            this.AUM_Ejecucion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AUM_Ejecucion.HeaderText = "AUM_Ejecucion";
            this.AUM_Ejecucion.Name = "AUM_Ejecucion";
            this.AUM_Ejecucion.ReadOnly = true;
            this.AUM_Ejecucion.Width = 115;
            // 
            // AUM_Ordenes
            // 
            this.AUM_Ordenes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AUM_Ordenes.HeaderText = "AUM Ordenes";
            this.AUM_Ordenes.Name = "AUM_Ordenes";
            this.AUM_Ordenes.ReadOnly = true;
            this.AUM_Ordenes.Width = 108;
            // 
            // Valides
            // 
            this.Valides.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Valides.HeaderText = "Validación";
            this.Valides.Name = "Valides";
            this.Valides.ReadOnly = true;
            this.Valides.Width = 85;
            // 
            // Coment
            // 
            this.Coment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Coment.HeaderText = "Comentario";
            this.Coment.Name = "Coment";
            this.Coment.ReadOnly = true;
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
            this.comboFondo.TabIndex = 75;
            this.comboFondo.Texts = "";
            // 
            // frmMonitoreoOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 547);
            this.Controls.Add(this.dgvOrdenes);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnModificarRegistro);
            this.Controls.Add(this.EliminarRegistro);
            this.Controls.Add(this.comboFondo);
            this.Controls.Add(this.btnAccederEjecucion);
            this.Controls.Add(this.btnAccederOrden);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.dateFinal);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMonitoreoOrdenes";
            this.Text = "frmMonitoreoOrdenes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblSubtitulo;
        private FontAwesome.Sharp.IconButton btnAccederOrden;
        private FontAwesome.Sharp.IconButton btnAccederEjecucion;
        private Recursos.UserControls.GGComboBox comboFondo;
        private FontAwesome.Sharp.IconButton EliminarRegistro;
        private FontAwesome.Sharp.IconButton btnModificarRegistro;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn codISIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn instru;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUM_Ejecucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUM_Ordenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valides;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coment;
    }
}