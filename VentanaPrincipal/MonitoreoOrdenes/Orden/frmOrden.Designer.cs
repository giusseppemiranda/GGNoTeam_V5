
namespace GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes.Orden
{
    partial class frmOrden
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvOrdenes = new Recursos.CustomDGV.ProgressDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asset_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codSBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUM_Ordenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnModificarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnAgregarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnConsultarOrdenes = new FontAwesome.Sharp.IconButton();
            this.comboFondo = new GGNoTeam_V5.Recursos.UserControls.GGComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSubtitulo.Location = new System.Drawing.Point(234, 12);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(67, 20);
            this.lblSubtitulo.TabIndex = 89;
            this.lblSubtitulo.Text = "Órdenes";
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(11, 65);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(198, 20);
            this.dateInicial.TabIndex = 83;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFecha.Location = new System.Drawing.Point(8, 47);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 15);
            this.lblFecha.TabIndex = 84;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(6, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 28);
            this.lblTitulo.TabIndex = 81;
            this.lblTitulo.Text = "Monitoreo de órdenes";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrdenes.ColumnHeadersHeight = 25;
            this.dgvOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Asset_Class,
            this.f,
            this.codSBS,
            this.codISIN,
            this.instru,
            this.Oper,
            this.AUM_Ordenes});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdenes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrdenes.EnableHeadersVisualStyles = false;
            this.dgvOrdenes.Location = new System.Drawing.Point(11, 91);
            this.dgvOrdenes.MultiSelect = false;
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.ReadOnly = true;
            this.dgvOrdenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvOrdenes.RowHeadersWidth = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvOrdenes.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOrdenes.RowTemplate.Height = 25;
            this.dgvOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenes.Size = new System.Drawing.Size(958, 400);
            this.dgvOrdenes.TabIndex = 91;
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
            // Asset_Class
            // 
            this.Asset_Class.HeaderText = "Asset Class";
            this.Asset_Class.Name = "Asset_Class";
            this.Asset_Class.ReadOnly = true;
            this.Asset_Class.Width = 89;
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
            // Oper
            // 
            this.Oper.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Oper.HeaderText = "Operacion";
            this.Oper.Name = "Oper";
            this.Oper.ReadOnly = true;
            this.Oper.Width = 87;
            // 
            // AUM_Ordenes
            // 
            this.AUM_Ordenes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AUM_Ordenes.HeaderText = "AUM Ordenes";
            this.AUM_Ordenes.Name = "AUM_Ordenes";
            this.AUM_Ordenes.ReadOnly = true;
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
            this.EliminarRegistro.TabIndex = 94;
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
            this.btnModificarRegistro.Location = new System.Drawing.Point(637, 497);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnModificarRegistro.Size = new System.Drawing.Size(163, 38);
            this.btnModificarRegistro.TabIndex = 93;
            this.btnModificarRegistro.Text = "Modificar registro";
            this.btnModificarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarRegistro.UseVisualStyleBackColor = false;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarRegistro.FlatAppearance.BorderSize = 0;
            this.btnAgregarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarRegistro.IconColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarRegistro.IconSize = 32;
            this.btnAgregarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(468, 497);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAgregarRegistro.Size = new System.Drawing.Size(163, 38);
            this.btnAgregarRegistro.TabIndex = 92;
            this.btnAgregarRegistro.Text = "Agregar Registro";
            this.btnAgregarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnConsultarOrdenes
            // 
            this.btnConsultarOrdenes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsultarOrdenes.FlatAppearance.BorderSize = 0;
            this.btnConsultarOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarOrdenes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnConsultarOrdenes.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConsultarOrdenes.IconColor = System.Drawing.Color.White;
            this.btnConsultarOrdenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultarOrdenes.IconSize = 32;
            this.btnConsultarOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarOrdenes.Location = new System.Drawing.Point(765, 47);
            this.btnConsultarOrdenes.Name = "btnConsultarOrdenes";
            this.btnConsultarOrdenes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultarOrdenes.Size = new System.Drawing.Size(204, 38);
            this.btnConsultarOrdenes.TabIndex = 95;
            this.btnConsultarOrdenes.Text = "Consultar Ordenes";
            this.btnConsultarOrdenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarOrdenes.UseVisualStyleBackColor = false;
            this.btnConsultarOrdenes.Click += new System.EventHandler(this.btnConsultarEjecuciones_Click);
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
            this.comboFondo.TabIndex = 96;
            this.comboFondo.Texts = "Fondo";
            // 
            // frmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 547);
            this.Controls.Add(this.comboFondo);
            this.Controls.Add(this.btnConsultarOrdenes);
            this.Controls.Add(this.EliminarRegistro);
            this.Controls.Add(this.btnModificarRegistro);
            this.Controls.Add(this.btnAgregarRegistro);
            this.Controls.Add(this.dgvOrdenes);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrden";
            this.Text = "frmOrden";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private Recursos.CustomDGV.ProgressDataGridView dgvOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asset_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn codISIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn instru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oper;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUM_Ordenes;
        private FontAwesome.Sharp.IconButton EliminarRegistro;
        private FontAwesome.Sharp.IconButton btnModificarRegistro;
        private FontAwesome.Sharp.IconButton btnAgregarRegistro;
        private FontAwesome.Sharp.IconButton btnConsultarOrdenes;
        private Recursos.UserControls.GGComboBox comboFondo;
    }
}