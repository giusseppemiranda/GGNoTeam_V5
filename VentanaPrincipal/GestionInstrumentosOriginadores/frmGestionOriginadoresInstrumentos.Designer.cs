
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtboxbusqueda = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.btnBuscar = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itinerario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.comboTipo = new GGNoTeam_V5.Recursos.UserControls.GGComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
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
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.AllowUserToResizeColumns = false;
            this.dgvPersonas.AllowUserToResizeRows = false;
            this.dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonas.ColumnHeadersHeight = 25;
            this.dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Nombre,
            this.Apellidos,
            this.Correo,
            this.Itinerario,
            this.TipoUsuario,
            this.Password,
            this.Validacion,
            this.Rol});
            this.dgvPersonas.EnableHeadersVisualStyles = false;
            this.dgvPersonas.Location = new System.Drawing.Point(15, 61);
            this.dgvPersonas.MultiSelect = false;
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvPersonas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonas.RowTemplate.Height = 25;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(954, 421);
            this.dgvPersonas.TabIndex = 30;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 68;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 76;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 80;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 68;
            // 
            // Itinerario
            // 
            this.Itinerario.HeaderText = "Itiner.";
            this.Itinerario.Name = "Itinerario";
            this.Itinerario.ReadOnly = true;
            this.Itinerario.Width = 63;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.HeaderText = "Tipo";
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.ReadOnly = true;
            this.TipoUsuario.Width = 54;
            // 
            // Password
            // 
            this.Password.HeaderText = "Contraseña";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 92;
            // 
            // Validacion
            // 
            this.Validacion.HeaderText = "Validacion";
            this.Validacion.Name = "Validacion";
            this.Validacion.ReadOnly = true;
            this.Validacion.Width = 85;
            // 
            // Rol
            // 
            this.Rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
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
            // frmGestionOriginadoresInstrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 547);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtboxbusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionOriginadoresInstrumentos";
            this.Text = "frmGestionOriginadoresInstrumentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Recursos.UserControls.GGTextBox txtboxbusqueda;
        private Recursos.UserControls.GGButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itinerario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Recursos.UserControls.GGComboBox comboTipo;
    }
}