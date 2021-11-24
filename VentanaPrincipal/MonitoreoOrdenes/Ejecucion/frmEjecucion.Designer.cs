
namespace GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes.Ejecucion
{
    partial class frmEjecucion
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
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.EliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnModificarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnAgregarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnConsultarEjecuciones = new FontAwesome.Sharp.IconButton();
            this.comboFondo = new GGNoTeam_V5.Recursos.UserControls.GGComboBox();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fondo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUMEjecuciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(68, 127);
            this.dateInicial.Margin = new System.Windows.Forms.Padding(6);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(392, 31);
            this.dateInicial.TabIndex = 72;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFecha.Location = new System.Drawing.Point(62, 92);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(86, 32);
            this.lblFecha.TabIndex = 74;
            this.lblFecha.Text = "Fecha:";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdenes.ColumnHeadersHeight = 25;
            this.dgvOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.AssetClass,
            this.Fondo,
            this.CodigoSBS,
            this.CodigoISIN,
            this.Instrumento,
            this.Operación,
            this.AUMEjecuciones});
            this.dgvOrdenes.EnableHeadersVisualStyles = false;
            this.dgvOrdenes.Location = new System.Drawing.Point(66, 177);
            this.dgvOrdenes.Margin = new System.Windows.Forms.Padding(6);
            this.dgvOrdenes.MultiSelect = false;
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.ReadOnly = true;
            this.dgvOrdenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvOrdenes.RowHeadersWidth = 82;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvOrdenes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrdenes.RowTemplate.Height = 25;
            this.dgvOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenes.Size = new System.Drawing.Size(1848, 783);
            this.dgvOrdenes.TabIndex = 71;
            this.dgvOrdenes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrdenes_CellFormatting);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(56, 2);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(442, 54);
            this.lblTitulo.TabIndex = 70;
            this.lblTitulo.Text = "Monitoreo de órdenes";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSubtitulo.Location = new System.Drawing.Point(60, 54);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(179, 41);
            this.lblSubtitulo.TabIndex = 80;
            this.lblSubtitulo.Text = "Ejecuciones";
            // 
            // EliminarRegistro
            // 
            this.EliminarRegistro.BackColor = System.Drawing.Color.Crimson;
            this.EliminarRegistro.FlatAppearance.BorderSize = 0;
            this.EliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.EliminarRegistro.ForeColor = System.Drawing.Color.White;
            this.EliminarRegistro.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EliminarRegistro.IconColor = System.Drawing.Color.White;
            this.EliminarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarRegistro.IconSize = 32;
            this.EliminarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarRegistro.Location = new System.Drawing.Point(1614, 971);
            this.EliminarRegistro.Margin = new System.Windows.Forms.Padding(6);
            this.EliminarRegistro.Name = "EliminarRegistro";
            this.EliminarRegistro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.EliminarRegistro.Size = new System.Drawing.Size(300, 73);
            this.EliminarRegistro.TabIndex = 79;
            this.EliminarRegistro.Text = "Eliminar Registro";
            this.EliminarRegistro.UseVisualStyleBackColor = false;
            this.EliminarRegistro.Click += new System.EventHandler(this.EliminarRegistro_Click);
            // 
            // btnModificarRegistro
            // 
            this.btnModificarRegistro.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModificarRegistro.FlatAppearance.BorderSize = 0;
            this.btnModificarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnModificarRegistro.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificarRegistro.IconColor = System.Drawing.Color.White;
            this.btnModificarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarRegistro.IconSize = 32;
            this.btnModificarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarRegistro.Location = new System.Drawing.Point(1256, 971);
            this.btnModificarRegistro.Margin = new System.Windows.Forms.Padding(6);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnModificarRegistro.Size = new System.Drawing.Size(300, 73);
            this.btnModificarRegistro.TabIndex = 78;
            this.btnModificarRegistro.Text = "Modificar Registro";
            this.btnModificarRegistro.UseVisualStyleBackColor = false;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregarRegistro.FlatAppearance.BorderSize = 0;
            this.btnAgregarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarRegistro.IconColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarRegistro.IconSize = 32;
            this.btnAgregarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(1614, 92);
            this.btnAgregarRegistro.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgregarRegistro.Size = new System.Drawing.Size(300, 73);
            this.btnAgregarRegistro.TabIndex = 77;
            this.btnAgregarRegistro.Text = "Agregar Registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnConsultarEjecuciones
            // 
            this.btnConsultarEjecuciones.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnConsultarEjecuciones.FlatAppearance.BorderSize = 0;
            this.btnConsultarEjecuciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEjecuciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarEjecuciones.ForeColor = System.Drawing.Color.White;
            this.btnConsultarEjecuciones.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConsultarEjecuciones.IconColor = System.Drawing.Color.White;
            this.btnConsultarEjecuciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultarEjecuciones.IconSize = 32;
            this.btnConsultarEjecuciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarEjecuciones.Location = new System.Drawing.Point(532, 92);
            this.btnConsultarEjecuciones.Margin = new System.Windows.Forms.Padding(6);
            this.btnConsultarEjecuciones.Name = "btnConsultarEjecuciones";
            this.btnConsultarEjecuciones.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConsultarEjecuciones.Size = new System.Drawing.Size(300, 73);
            this.btnConsultarEjecuciones.TabIndex = 76;
            this.btnConsultarEjecuciones.Text = "Consultar ejecuciones";
            this.btnConsultarEjecuciones.UseVisualStyleBackColor = false;
            this.btnConsultarEjecuciones.Click += new System.EventHandler(this.btnConsultarEjecuciones_Click);
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
            this.comboFondo.Location = new System.Drawing.Point(909, 100);
            this.comboFondo.Margin = new System.Windows.Forms.Padding(6);
            this.comboFondo.MinimumSize = new System.Drawing.Size(400, 58);
            this.comboFondo.Name = "comboFondo";
            this.comboFondo.Padding = new System.Windows.Forms.Padding(2);
            this.comboFondo.Size = new System.Drawing.Size(400, 58);
            this.comboFondo.TabIndex = 81;
            this.comboFondo.Texts = "Fondo";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 10;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 122;
            // 
            // AssetClass
            // 
            this.AssetClass.HeaderText = "Asset Class";
            this.AssetClass.MinimumWidth = 10;
            this.AssetClass.Name = "AssetClass";
            this.AssetClass.ReadOnly = true;
            this.AssetClass.Width = 183;
            // 
            // Fondo
            // 
            this.Fondo.HeaderText = "Fondo";
            this.Fondo.MinimumWidth = 10;
            this.Fondo.Name = "Fondo";
            this.Fondo.ReadOnly = true;
            this.Fondo.Width = 130;
            // 
            // CodigoSBS
            // 
            this.CodigoSBS.HeaderText = "Codigo SBS";
            this.CodigoSBS.MinimumWidth = 10;
            this.CodigoSBS.Name = "CodigoSBS";
            this.CodigoSBS.ReadOnly = true;
            this.CodigoSBS.Width = 188;
            // 
            // CodigoISIN
            // 
            this.CodigoISIN.HeaderText = "Codigo ISIN ";
            this.CodigoISIN.MinimumWidth = 10;
            this.CodigoISIN.Name = "CodigoISIN";
            this.CodigoISIN.ReadOnly = true;
            this.CodigoISIN.Width = 202;
            // 
            // Instrumento
            // 
            this.Instrumento.HeaderText = "Instrumento";
            this.Instrumento.MinimumWidth = 10;
            this.Instrumento.Name = "Instrumento";
            this.Instrumento.ReadOnly = true;
            this.Instrumento.Width = 200;
            // 
            // Operación
            // 
            this.Operación.HeaderText = "Operación";
            this.Operación.MinimumWidth = 10;
            this.Operación.Name = "Operación";
            this.Operación.ReadOnly = true;
            this.Operación.Width = 176;
            // 
            // AUMEjecuciones
            // 
            this.AUMEjecuciones.HeaderText = "AUM Ejecuciones";
            this.AUMEjecuciones.MinimumWidth = 10;
            this.AUMEjecuciones.Name = "AUMEjecuciones";
            this.AUMEjecuciones.ReadOnly = true;
            this.AUMEjecuciones.Width = 255;
            // 
            // frmEjecucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1962, 1052);
            this.Controls.Add(this.comboFondo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.EliminarRegistro);
            this.Controls.Add(this.btnModificarRegistro);
            this.Controls.Add(this.btnAgregarRegistro);
            this.Controls.Add(this.btnConsultarEjecuciones);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dgvOrdenes);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmEjecucion";
            this.Text = "frmEjecucion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton EliminarRegistro;
        private FontAwesome.Sharp.IconButton btnModificarRegistro;
        private FontAwesome.Sharp.IconButton btnAgregarRegistro;
        private FontAwesome.Sharp.IconButton btnConsultarEjecuciones;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Recursos.UserControls.GGComboBox comboFondo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fondo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoISIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instrumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operación;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUMEjecuciones;
    }
}