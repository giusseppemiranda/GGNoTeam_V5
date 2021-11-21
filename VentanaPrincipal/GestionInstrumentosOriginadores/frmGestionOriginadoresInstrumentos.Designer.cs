
namespace GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores
{
    partial class frmGestionOriginadoresInstrumentos
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
            this.dgvInstrumentosOriginadores = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.comboTipo = new GGNoTeam_V5.Recursos.UserControls.GGComboBox();
            this.btnBuscar = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.txtboxbusqueda = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.btnAsociado = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentosOriginadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInstrumentosOriginadores
            // 
            this.dgvInstrumentosOriginadores.AllowUserToAddRows = false;
            this.dgvInstrumentosOriginadores.AllowUserToDeleteRows = false;
            this.dgvInstrumentosOriginadores.AllowUserToResizeColumns = false;
            this.dgvInstrumentosOriginadores.AllowUserToResizeRows = false;
            this.dgvInstrumentosOriginadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInstrumentosOriginadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInstrumentosOriginadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInstrumentosOriginadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstrumentosOriginadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInstrumentosOriginadores.ColumnHeadersHeight = 25;
            this.dgvInstrumentosOriginadores.EnableHeadersVisualStyles = false;
            this.dgvInstrumentosOriginadores.Location = new System.Drawing.Point(17, 61);
            this.dgvInstrumentosOriginadores.MultiSelect = false;
            this.dgvInstrumentosOriginadores.Name = "dgvInstrumentosOriginadores";
            this.dgvInstrumentosOriginadores.ReadOnly = true;
            this.dgvInstrumentosOriginadores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvInstrumentosOriginadores.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInstrumentosOriginadores.RowTemplate.Height = 25;
            this.dgvInstrumentosOriginadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstrumentosOriginadores.Size = new System.Drawing.Size(954, 421);
            this.dgvInstrumentosOriginadores.TabIndex = 30;
            this.dgvInstrumentosOriginadores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInstrumentosOriginadores_CellFormatting);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(341, 50);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Gestión de Instrumentos, Originadores\r\ny Emisores";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 32;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(621, 488);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(112, 38);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Orange;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 32;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(739, 488);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnActualizar.Size = new System.Drawing.Size(112, 38);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "Modificar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 32;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(857, 488);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(112, 38);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // comboTipo
            // 
            this.comboTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboTipo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.comboTipo.BorderSize = 2;
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboTipo.ForeColor = System.Drawing.Color.DimGray;
            this.comboTipo.IconColor = System.Drawing.Color.DodgerBlue;
            this.comboTipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboTipo.ListTextColor = System.Drawing.Color.DimGray;
            this.comboTipo.Location = new System.Drawing.Point(431, 16);
            this.comboTipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Padding = new System.Windows.Forms.Padding(2);
            this.comboTipo.Size = new System.Drawing.Size(200, 30);
            this.comboTipo.TabIndex = 46;
            this.comboTipo.Texts = "";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscar.BorderRadius = 8;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(887, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 30);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtboxbusqueda
            // 
            this.txtboxbusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxbusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxbusqueda.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtboxbusqueda.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtboxbusqueda.BorderSize = 2;
            this.txtboxbusqueda.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtboxbusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxbusqueda.IsFocused = false;
            this.txtboxbusqueda.Location = new System.Drawing.Point(648, 16);
            this.txtboxbusqueda.MaxLength = 32767;
            this.txtboxbusqueda.Multiline = false;
            this.txtboxbusqueda.Name = "txtboxbusqueda";
            this.txtboxbusqueda.Padding = new System.Windows.Forms.Padding(6);
            this.txtboxbusqueda.PasswordChar = false;
            this.txtboxbusqueda.Size = new System.Drawing.Size(220, 30);
            this.txtboxbusqueda.TabIndex = 13;
            this.txtboxbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxbusqueda.Texts = "";
            this.txtboxbusqueda.UnderlinedStyle = true;
            // 
            // btnAsociado
            // 
            this.btnAsociado.AutoSize = true;
            this.btnAsociado.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAsociado.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAsociado.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAsociado.BorderRadius = 8;
            this.btnAsociado.BorderSize = 0;
            this.btnAsociado.FlatAppearance.BorderSize = 0;
            this.btnAsociado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsociado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAsociado.ForeColor = System.Drawing.Color.White;
            this.btnAsociado.Location = new System.Drawing.Point(42, 496);
            this.btnAsociado.Name = "btnAsociado";
            this.btnAsociado.Size = new System.Drawing.Size(146, 30);
            this.btnAsociado.TabIndex = 47;
            this.btnAsociado.TextColor = System.Drawing.Color.White;
            this.btnAsociado.UseVisualStyleBackColor = false;
            this.btnAsociado.Click += new System.EventHandler(this.btnAsociado_Click);
            // 
            // frmGestionOriginadoresInstrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 547);
            this.Controls.Add(this.btnAsociado);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvInstrumentosOriginadores);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtboxbusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionOriginadoresInstrumentos";
            this.Text = "frmGestionOriginadoresInstrumentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentosOriginadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Recursos.UserControls.GGTextBox txtboxbusqueda;
        private Recursos.UserControls.GGButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvInstrumentosOriginadores;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Recursos.UserControls.GGComboBox comboTipo;
        private Recursos.UserControls.GGButton btnAsociado;
    }
}