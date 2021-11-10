
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
            this.dgvTareasPendientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodicidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Descripcion,
            this.Hora,
            this.Periodicidad,
            this.Estado});
            this.dgvTareasPendientes.EnableHeadersVisualStyles = false;
            this.dgvTareasPendientes.Location = new System.Drawing.Point(34, 49);
            this.dgvTareasPendientes.MultiSelect = false;
            this.dgvTareasPendientes.Name = "dgvTareasPendientes";
            this.dgvTareasPendientes.ReadOnly = true;
            this.dgvTareasPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvTareasPendientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
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
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 95;
            // 
            // Hora
            // 
            this.Hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Hora.HeaderText = "Hora creación";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 107;
            // 
            // Periodicidad
            // 
            this.Periodicidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Periodicidad.HeaderText = "periodicidad";
            this.Periodicidad.Name = "Periodicidad";
            this.Periodicidad.ReadOnly = true;
            this.Periodicidad.Width = 98;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
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
            this.btnModificarTarea.Location = new System.Drawing.Point(682, 487);
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
            this.btnAgregarTarea.Location = new System.Drawing.Point(846, 487);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTareasPendientes;
        private FontAwesome.Sharp.IconButton btnModificarTarea;
        private FontAwesome.Sharp.IconButton btnAgregarTarea;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodicidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}