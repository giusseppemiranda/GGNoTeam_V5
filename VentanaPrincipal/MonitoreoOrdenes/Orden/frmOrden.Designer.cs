
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.EliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnModificarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnAgregarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnConsultarOrdenes = new FontAwesome.Sharp.IconButton();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fondo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUMordenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.comboFondo = new GGNoTeam_V5.Recursos.UserControls.GGComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSubtitulo.Location = new System.Drawing.Point(56, 46);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(135, 41);
            this.lblSubtitulo.TabIndex = 89;
            this.lblSubtitulo.Text = "Órdenes";
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
            this.EliminarRegistro.Location = new System.Drawing.Point(1610, 963);
            this.EliminarRegistro.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EliminarRegistro.Name = "EliminarRegistro";
            this.EliminarRegistro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.EliminarRegistro.Size = new System.Drawing.Size(300, 73);
            this.EliminarRegistro.TabIndex = 88;
            this.EliminarRegistro.Text = "Eliminar Registro";
            this.EliminarRegistro.UseVisualStyleBackColor = false;
            //this.EliminarRegistro.Click += new System.EventHandler(this.EliminarRegistro_Click);
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
            this.btnModificarRegistro.Location = new System.Drawing.Point(1252, 963);
            this.btnModificarRegistro.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnModificarRegistro.Size = new System.Drawing.Size(300, 73);
            this.btnModificarRegistro.TabIndex = 87;
            this.btnModificarRegistro.Text = "Modificar Registro";
            this.btnModificarRegistro.UseVisualStyleBackColor = false;
            //this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
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
            this.btnAgregarRegistro.Location = new System.Drawing.Point(1610, 85);
            this.btnAgregarRegistro.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgregarRegistro.Size = new System.Drawing.Size(300, 73);
            this.btnAgregarRegistro.TabIndex = 86;
            this.btnAgregarRegistro.Text = "Agregar Registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            //this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnConsultarOrdenes
            // 
            this.btnConsultarOrdenes.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnConsultarOrdenes.FlatAppearance.BorderSize = 0;
            this.btnConsultarOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarOrdenes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnConsultarOrdenes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConsultarOrdenes.IconColor = System.Drawing.Color.White;
            this.btnConsultarOrdenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultarOrdenes.IconSize = 32;
            this.btnConsultarOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarOrdenes.Location = new System.Drawing.Point(528, 85);
            this.btnConsultarOrdenes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConsultarOrdenes.Name = "btnConsultarOrdenes";
            this.btnConsultarOrdenes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConsultarOrdenes.Size = new System.Drawing.Size(300, 73);
            this.btnConsultarOrdenes.TabIndex = 85;
            this.btnConsultarOrdenes.Text = "Consultar órdenes";
            this.btnConsultarOrdenes.UseVisualStyleBackColor = false;
            //this.btnConsultarOrdenes.Click += new System.EventHandler(this.btnConsultarEjecuciones_Click);
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(64, 119);
            this.dateInicial.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(392, 31);
            this.dateInicial.TabIndex = 83;
            //this.dateInicial.ValueChanged += new System.EventHandler(this.dateInicial_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFecha.Location = new System.Drawing.Point(58, 85);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(86, 32);
            this.lblFecha.TabIndex = 84;
            this.lblFecha.Text = "Fecha:";
            //this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
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
            this.Fondo,
            this.CodigoSBS,
            this.CodigoISIN,
            this.Instrumento,
            this.Operación,
            this.AUMordenes});
            this.dgvOrdenes.EnableHeadersVisualStyles = false;
            this.dgvOrdenes.Location = new System.Drawing.Point(62, 169);
            this.dgvOrdenes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.dgvOrdenes.TabIndex = 82;
            //this.dgvOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenes_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 10;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 122;
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
            // AUMordenes
            // 
            this.AUMordenes.HeaderText = "AUM órdenes";
            this.AUMordenes.MinimumWidth = 10;
            this.AUMordenes.Name = "AUMordenes";
            this.AUMordenes.ReadOnly = true;
            this.AUMordenes.Width = 214;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(52, -6);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(442, 54);
            this.lblTitulo.TabIndex = 81;
            this.lblTitulo.Text = "Monitoreo de órdenes";
            //this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
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
            this.comboFondo.Location = new System.Drawing.Point(943, 85);
            this.comboFondo.Margin = new System.Windows.Forms.Padding(6);
            this.comboFondo.MinimumSize = new System.Drawing.Size(400, 58);
            this.comboFondo.Name = "comboFondo";
            this.comboFondo.Padding = new System.Windows.Forms.Padding(2);
            this.comboFondo.Size = new System.Drawing.Size(400, 58);
            this.comboFondo.TabIndex = 90;
            this.comboFondo.Texts = "Fondo";
            // 
            // frmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1962, 1052);
            this.Controls.Add(this.comboFondo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.EliminarRegistro);
            this.Controls.Add(this.btnModificarRegistro);
            this.Controls.Add(this.btnAgregarRegistro);
            this.Controls.Add(this.btnConsultarOrdenes);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dgvOrdenes);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmOrden";
            this.Text = "frmOrden";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtitulo;
        private FontAwesome.Sharp.IconButton EliminarRegistro;
        private FontAwesome.Sharp.IconButton btnModificarRegistro;
        private FontAwesome.Sharp.IconButton btnAgregarRegistro;
        private FontAwesome.Sharp.IconButton btnConsultarOrdenes;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fondo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoISIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instrumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operación;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUMordenes;
        private System.Windows.Forms.Label lblTitulo;
        private Recursos.UserControls.GGComboBox comboFondo;
    }
}