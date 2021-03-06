
namespace GGNoTeam_V5.VentanaPrincipal
{
    partial class frmGestionUsuarios
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
            this.btnListarAdministradores = new FontAwesome.Sharp.IconButton();
            this.btnListarUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnListarPersonas = new FontAwesome.Sharp.IconButton();
            this.btnEliminarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnActualizarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            this.dgvPersonas = new GGNoTeam_V5.Recursos.CustomDGV.ProgressDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerTareas = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new GGNoTeam_V5.Recursos.UserControls.GGButton();
            this.txtBoxBusqueda = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.btnEnviarMensaje = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarAdministradores
            // 
            this.btnListarAdministradores.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnListarAdministradores.FlatAppearance.BorderSize = 0;
            this.btnListarAdministradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarAdministradores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnListarAdministradores.ForeColor = System.Drawing.Color.White;
            this.btnListarAdministradores.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            this.btnListarAdministradores.IconColor = System.Drawing.Color.White;
            this.btnListarAdministradores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarAdministradores.IconSize = 36;
            this.btnListarAdministradores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListarAdministradores.Location = new System.Drawing.Point(184, 478);
            this.btnListarAdministradores.Name = "btnListarAdministradores";
            this.btnListarAdministradores.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnListarAdministradores.Size = new System.Drawing.Size(108, 61);
            this.btnListarAdministradores.TabIndex = 20;
            this.btnListarAdministradores.Text = "Administradores";
            this.btnListarAdministradores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListarAdministradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListarAdministradores.UseVisualStyleBackColor = false;
            this.btnListarAdministradores.Click += new System.EventHandler(this.btnAdministradores_Click);
            // 
            // btnListarUsuarios
            // 
            this.btnListarUsuarios.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnListarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnListarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnListarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnListarUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnListarUsuarios.IconColor = System.Drawing.Color.White;
            this.btnListarUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarUsuarios.IconSize = 36;
            this.btnListarUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListarUsuarios.Location = new System.Drawing.Point(98, 478);
            this.btnListarUsuarios.Name = "btnListarUsuarios";
            this.btnListarUsuarios.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnListarUsuarios.Size = new System.Drawing.Size(80, 61);
            this.btnListarUsuarios.TabIndex = 19;
            this.btnListarUsuarios.Text = "Usuarios";
            this.btnListarUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListarUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListarUsuarios.UseVisualStyleBackColor = false;
            this.btnListarUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnListarPersonas
            // 
            this.btnListarPersonas.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnListarPersonas.FlatAppearance.BorderSize = 0;
            this.btnListarPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPersonas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnListarPersonas.ForeColor = System.Drawing.Color.White;
            this.btnListarPersonas.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnListarPersonas.IconColor = System.Drawing.Color.White;
            this.btnListarPersonas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarPersonas.IconSize = 36;
            this.btnListarPersonas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListarPersonas.Location = new System.Drawing.Point(11, 478);
            this.btnListarPersonas.Name = "btnListarPersonas";
            this.btnListarPersonas.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnListarPersonas.Size = new System.Drawing.Size(80, 61);
            this.btnListarPersonas.TabIndex = 18;
            this.btnListarPersonas.Text = "Inactivos";
            this.btnListarPersonas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListarPersonas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListarPersonas.UseVisualStyleBackColor = false;
            this.btnListarPersonas.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEliminarUsuario.IconColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarUsuario.IconSize = 32;
            this.btnEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(747, 479);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnEliminarUsuario.Size = new System.Drawing.Size(70, 60);
            this.btnEliminarUsuario.TabIndex = 21;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.BackColor = System.Drawing.Color.Goldenrod;
            this.btnActualizarUsuario.FlatAppearance.BorderSize = 0;
            this.btnActualizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnActualizarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnActualizarUsuario.IconColor = System.Drawing.Color.White;
            this.btnActualizarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarUsuario.IconSize = 32;
            this.btnActualizarUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizarUsuario.Location = new System.Drawing.Point(823, 479);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnActualizarUsuario.Size = new System.Drawing.Size(70, 60);
            this.btnActualizarUsuario.TabIndex = 22;
            this.btnActualizarUsuario.Text = "Actualizar";
            this.btnActualizarUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizarUsuario.UseVisualStyleBackColor = false;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregarUsuario.IconColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarUsuario.IconSize = 32;
            this.btnAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(899, 479);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnAgregarUsuario.Size = new System.Drawing.Size(70, 60);
            this.btnAgregarUsuario.TabIndex = 23;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
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
            this.Password,
            this.Validacion,
            this.Rol});
            this.dgvPersonas.EnableHeadersVisualStyles = false;
            this.dgvPersonas.Location = new System.Drawing.Point(12, 49);
            this.dgvPersonas.MultiSelect = false;
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvPersonas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonas.RowTemplate.Height = 25;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(957, 426);
            this.dgvPersonas.TabIndex = 24;
            this.dgvPersonas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPersonas_CellFormatting);
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
            // btnVerTareas
            // 
            this.btnVerTareas.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnVerTareas.FlatAppearance.BorderSize = 0;
            this.btnVerTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTareas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerTareas.ForeColor = System.Drawing.Color.White;
            this.btnVerTareas.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnVerTareas.IconColor = System.Drawing.Color.White;
            this.btnVerTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerTareas.IconSize = 32;
            this.btnVerTareas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerTareas.Location = new System.Drawing.Point(423, 478);
            this.btnVerTareas.Name = "btnVerTareas";
            this.btnVerTareas.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnVerTareas.Size = new System.Drawing.Size(107, 60);
            this.btnVerTareas.TabIndex = 28;
            this.btnVerTareas.Text = "Asignar Tareas";
            this.btnVerTareas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerTareas.UseVisualStyleBackColor = false;
            this.btnVerTareas.Click += new System.EventHandler(this.btnVerTareas_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(6, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 28);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Gestión de Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(368, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ingrese el código o nombre:";
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
            this.btnBuscar.Location = new System.Drawing.Point(889, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 30);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxBusqueda.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtBoxBusqueda.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtBoxBusqueda.BorderSize = 2;
            this.txtBoxBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBoxBusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxBusqueda.IsFocused = false;
            this.txtBoxBusqueda.Location = new System.Drawing.Point(536, 13);
            this.txtBoxBusqueda.MaxLength = 32767;
            this.txtBoxBusqueda.Multiline = false;
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Padding = new System.Windows.Forms.Padding(6);
            this.txtBoxBusqueda.PasswordChar = false;
            this.txtBoxBusqueda.Size = new System.Drawing.Size(347, 30);
            this.txtBoxBusqueda.TabIndex = 25;
            this.txtBoxBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBusqueda.Texts = "";
            this.txtBoxBusqueda.UnderlinedStyle = true;
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEnviarMensaje.FlatAppearance.BorderSize = 0;
            this.btnEnviarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEnviarMensaje.ForeColor = System.Drawing.Color.White;
            this.btnEnviarMensaje.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.btnEnviarMensaje.IconColor = System.Drawing.Color.White;
            this.btnEnviarMensaje.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnviarMensaje.IconSize = 32;
            this.btnEnviarMensaje.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnviarMensaje.Location = new System.Drawing.Point(536, 478);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnEnviarMensaje.Size = new System.Drawing.Size(107, 60);
            this.btnEnviarMensaje.TabIndex = 31;
            this.btnEnviarMensaje.Text = "Enviar Mensajes";
            this.btnEnviarMensaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnviarMensaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnviarMensaje.UseVisualStyleBackColor = false;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // frmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVerTareas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.btnActualizarUsuario);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnListarAdministradores);
            this.Controls.Add(this.btnListarUsuarios);
            this.Controls.Add(this.btnListarPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionUsuarios";
            this.Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnListarAdministradores;
        private FontAwesome.Sharp.IconButton btnListarUsuarios;
        private FontAwesome.Sharp.IconButton btnListarPersonas;
        private FontAwesome.Sharp.IconButton btnEliminarUsuario;
        private FontAwesome.Sharp.IconButton btnActualizarUsuario;
        private FontAwesome.Sharp.IconButton btnAgregarUsuario;
        private Recursos.CustomDGV.ProgressDataGridView dgvPersonas;
        private Recursos.UserControls.GGTextBox txtBoxBusqueda;
        private Recursos.UserControls.GGButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnVerTareas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnEnviarMensaje;
    }
}