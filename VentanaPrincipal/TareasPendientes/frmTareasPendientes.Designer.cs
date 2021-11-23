
namespace GGNoTeam_V5.VentanaPrincipal
{
    partial class frmTareasPendientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTareasPendientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            this.comboEstadoTarea = new GGNoTeam_V5.Recursos.UserControls.GGComboBox();
            this.btnConsultarTareas = new FontAwesome.Sharp.IconButton();
            this.btnListarCompletos = new FontAwesome.Sharp.IconButton();
            this.btnListarPorTipo = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnModificarTarea = new FontAwesome.Sharp.IconButton();
            this.btnAgregarTarea = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTareasPendientes
            // 
            this.dgvTareasPendientes.AllowUserToAddRows = false;
            this.dgvTareasPendientes.AllowUserToDeleteRows = false;
            this.dgvTareasPendientes.AllowUserToResizeColumns = false;
            this.dgvTareasPendientes.AllowUserToResizeRows = false;
            this.dgvTareasPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTareasPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTareasPendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTareasPendientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareasPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTareasPendientes.ColumnHeadersHeight = 25;
            this.dgvTareasPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fechaCreacion,
            this.fechaLimite,
            this.Descripcion,
            this.Autor});
            this.dgvTareasPendientes.EnableHeadersVisualStyles = false;
            this.dgvTareasPendientes.Location = new System.Drawing.Point(34, 49);
            this.dgvTareasPendientes.MultiSelect = false;
            this.dgvTareasPendientes.Name = "dgvTareasPendientes";
            this.dgvTareasPendientes.ReadOnly = true;
            this.dgvTareasPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareasPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvTareasPendientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTareasPendientes.RowTemplate.Height = 25;
            this.dgvTareasPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareasPendientes.Size = new System.Drawing.Size(917, 432);
            this.dgvTareasPendientes.TabIndex = 25;
            this.dgvTareasPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareasPendientes_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID Tarea";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 76;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.HeaderText = "Fecha de creación";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            this.fechaCreacion.Width = 129;
            // 
            // fechaLimite
            // 
            this.fechaLimite.HeaderText = "Fecha límite";
            this.fechaLimite.Name = "fechaLimite";
            this.fechaLimite.ReadOnly = true;
            this.fechaLimite.Width = 97;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNombre.Location = new System.Drawing.Point(30, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(235, 20);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Gestión de tareas de -USUARIO-";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // comboEstadoTarea
            // 
            this.comboEstadoTarea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboEstadoTarea.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboEstadoTarea.BorderSize = 1;
            this.comboEstadoTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboEstadoTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboEstadoTarea.ForeColor = System.Drawing.Color.DimGray;
            this.comboEstadoTarea.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboEstadoTarea.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboEstadoTarea.ListTextColor = System.Drawing.Color.DimGray;
            this.comboEstadoTarea.Location = new System.Drawing.Point(360, 16);
            this.comboEstadoTarea.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboEstadoTarea.Name = "comboEstadoTarea";
            this.comboEstadoTarea.Padding = new System.Windows.Forms.Padding(1);
            this.comboEstadoTarea.Size = new System.Drawing.Size(200, 30);
            this.comboEstadoTarea.TabIndex = 67;
            this.comboEstadoTarea.Texts = "";
            this.comboEstadoTarea.OnSelectedIndexChanged += new System.EventHandler(this.comboEstadoTarea_OnSelectedIndexChanged);
            this.comboEstadoTarea.Load += new System.EventHandler(this.comboEstadoTarea_Load);
            // 
            // btnConsultarTareas
            // 
            this.btnConsultarTareas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsultarTareas.FlatAppearance.BorderSize = 0;
            this.btnConsultarTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarTareas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarTareas.ForeColor = System.Drawing.Color.White;
            this.btnConsultarTareas.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConsultarTareas.IconColor = System.Drawing.Color.White;
            this.btnConsultarTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultarTareas.IconSize = 25;
            this.btnConsultarTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarTareas.Location = new System.Drawing.Point(566, 16);
            this.btnConsultarTareas.Name = "btnConsultarTareas";
            this.btnConsultarTareas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultarTareas.Size = new System.Drawing.Size(53, 30);
            this.btnConsultarTareas.TabIndex = 68;
            this.btnConsultarTareas.Text = " ";
            this.btnConsultarTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarTareas.UseVisualStyleBackColor = false;
            this.btnConsultarTareas.Click += new System.EventHandler(this.btnConsultarTareas_Click);
            // 
            // btnListarCompletos
            // 
            this.btnListarCompletos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListarCompletos.FlatAppearance.BorderSize = 0;
            this.btnListarCompletos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarCompletos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnListarCompletos.ForeColor = System.Drawing.Color.White;
            this.btnListarCompletos.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.btnListarCompletos.IconColor = System.Drawing.Color.White;
            this.btnListarCompletos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarCompletos.IconSize = 32;
            this.btnListarCompletos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListarCompletos.Location = new System.Drawing.Point(191, 487);
            this.btnListarCompletos.Name = "btnListarCompletos";
            this.btnListarCompletos.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnListarCompletos.Size = new System.Drawing.Size(151, 52);
            this.btnListarCompletos.TabIndex = 33;
            this.btnListarCompletos.Text = "Listar Total Tareas";
            this.btnListarCompletos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListarCompletos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListarCompletos.UseVisualStyleBackColor = false;
            // 
            // btnListarPorTipo
            // 
            this.btnListarPorTipo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnListarPorTipo.FlatAppearance.BorderSize = 0;
            this.btnListarPorTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPorTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnListarPorTipo.ForeColor = System.Drawing.Color.White;
            this.btnListarPorTipo.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnListarPorTipo.IconColor = System.Drawing.Color.White;
            this.btnListarPorTipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarPorTipo.IconSize = 32;
            this.btnListarPorTipo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListarPorTipo.Location = new System.Drawing.Point(34, 487);
            this.btnListarPorTipo.Name = "btnListarPorTipo";
            this.btnListarPorTipo.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnListarPorTipo.Size = new System.Drawing.Size(151, 52);
            this.btnListarPorTipo.TabIndex = 32;
            this.btnListarPorTipo.Text = "Listar Completos";
            this.btnListarPorTipo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListarPorTipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListarPorTipo.UseVisualStyleBackColor = false;
            this.btnListarPorTipo.Click += new System.EventHandler(this.btnListarPorTipo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Phabricator;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 32;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(571, 487);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(105, 52);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar Tarea";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(766, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(185, 31);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Cerrar gestión de tareas";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificarTarea
            // 
            this.btnModificarTarea.BackColor = System.Drawing.Color.Orange;
            this.btnModificarTarea.FlatAppearance.BorderSize = 0;
            this.btnModificarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTarea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificarTarea.ForeColor = System.Drawing.Color.White;
            this.btnModificarTarea.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btnModificarTarea.IconColor = System.Drawing.Color.White;
            this.btnModificarTarea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarTarea.IconSize = 32;
            this.btnModificarTarea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarTarea.Location = new System.Drawing.Point(793, 487);
            this.btnModificarTarea.Name = "btnModificarTarea";
            this.btnModificarTarea.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnModificarTarea.Size = new System.Drawing.Size(158, 52);
            this.btnModificarTarea.TabIndex = 27;
            this.btnModificarTarea.Text = "Modificar Tarea";
            this.btnModificarTarea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificarTarea.UseVisualStyleBackColor = false;
            this.btnModificarTarea.Click += new System.EventHandler(this.btnModificarTarea_Click);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarTarea.FlatAppearance.BorderSize = 0;
            this.btnAgregarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTarea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarTarea.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTarea.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarTarea.IconColor = System.Drawing.Color.White;
            this.btnAgregarTarea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarTarea.IconSize = 32;
            this.btnAgregarTarea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarTarea.Location = new System.Drawing.Point(682, 487);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnAgregarTarea.Size = new System.Drawing.Size(105, 52);
            this.btnAgregarTarea.TabIndex = 26;
            this.btnAgregarTarea.Text = "Agregar tarea";
            this.btnAgregarTarea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // frmTareasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.btnConsultarTareas);
            this.Controls.Add(this.comboEstadoTarea);
            this.Controls.Add(this.btnListarCompletos);
            this.Controls.Add(this.btnListarPorTipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarTarea);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.dgvTareasPendientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTareasPendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTareasPendientes";
            this.Load += new System.EventHandler(this.frmTareasPendientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTareasPendientes;
        private FontAwesome.Sharp.IconButton btnAgregarTarea;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Label lblNombre;
        private Recursos.UserControls.GGComboBox comboEstadoTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private FontAwesome.Sharp.IconButton btnConsultarTareas;
        private FontAwesome.Sharp.IconButton btnListarPorTipo;
        private FontAwesome.Sharp.IconButton btnListarCompletos;
        private FontAwesome.Sharp.IconButton btnModificarTarea;
    }
}