
namespace GGNoTeam_V5.VentanaPrincipal.TareasPendientes.Tareas
{
    partial class frmPropiasTareasPendientes
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
            this.btnConsultarTareas = new FontAwesome.Sharp.IconButton();
            this.btnRenovarTarea = new FontAwesome.Sharp.IconButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnCompletarTarea = new FontAwesome.Sharp.IconButton();
            this.dgvTareasPendientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboEstadoTarea = new GGNoTeam_V5.Recursos.UserControls.GGComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasPendientes)).BeginInit();
            this.SuspendLayout();
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
            this.btnConsultarTareas.Location = new System.Drawing.Point(898, 15);
            this.btnConsultarTareas.Name = "btnConsultarTareas";
            this.btnConsultarTareas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultarTareas.Size = new System.Drawing.Size(53, 30);
            this.btnConsultarTareas.TabIndex = 75;
            this.btnConsultarTareas.Text = " ";
            this.btnConsultarTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarTareas.UseVisualStyleBackColor = false;
            this.btnConsultarTareas.Click += new System.EventHandler(this.btnConsultarTareas_Click);
            // 
            // btnRenovarTarea
            // 
            this.btnRenovarTarea.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRenovarTarea.FlatAppearance.BorderSize = 0;
            this.btnRenovarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovarTarea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRenovarTarea.ForeColor = System.Drawing.Color.White;
            this.btnRenovarTarea.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnRenovarTarea.IconColor = System.Drawing.Color.White;
            this.btnRenovarTarea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRenovarTarea.IconSize = 32;
            this.btnRenovarTarea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRenovarTarea.Location = new System.Drawing.Point(34, 486);
            this.btnRenovarTarea.Name = "btnRenovarTarea";
            this.btnRenovarTarea.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnRenovarTarea.Size = new System.Drawing.Size(117, 52);
            this.btnRenovarTarea.TabIndex = 73;
            this.btnRenovarTarea.Text = "Renovar Tarea";
            this.btnRenovarTarea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRenovarTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRenovarTarea.UseVisualStyleBackColor = false;
            this.btnRenovarTarea.Click += new System.EventHandler(this.btnRenovarTarea_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNombre.Location = new System.Drawing.Point(30, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(235, 20);
            this.lblNombre.TabIndex = 72;
            this.lblNombre.Text = "Gestión de tareas de -USUARIO-";
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
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(683, 486);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(121, 52);
            this.btnEliminar.TabIndex = 71;
            this.btnEliminar.Text = "Eliminar Tarea";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCompletarTarea
            // 
            this.btnCompletarTarea.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCompletarTarea.FlatAppearance.BorderSize = 0;
            this.btnCompletarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletarTarea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCompletarTarea.ForeColor = System.Drawing.Color.White;
            this.btnCompletarTarea.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnCompletarTarea.IconColor = System.Drawing.Color.White;
            this.btnCompletarTarea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompletarTarea.IconSize = 32;
            this.btnCompletarTarea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompletarTarea.Location = new System.Drawing.Point(830, 486);
            this.btnCompletarTarea.Name = "btnCompletarTarea";
            this.btnCompletarTarea.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCompletarTarea.Size = new System.Drawing.Size(121, 52);
            this.btnCompletarTarea.TabIndex = 70;
            this.btnCompletarTarea.Text = "Completar Tarea";
            this.btnCompletarTarea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompletarTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompletarTarea.UseVisualStyleBackColor = false;
            this.btnCompletarTarea.Click += new System.EventHandler(this.btnCompletarTarea_Click);
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
            this.dgvTareasPendientes.Location = new System.Drawing.Point(34, 48);
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
            this.dgvTareasPendientes.TabIndex = 69;
            this.dgvTareasPendientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTareasPendientes_CellFormatting);
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
            this.comboEstadoTarea.Location = new System.Drawing.Point(692, 15);
            this.comboEstadoTarea.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboEstadoTarea.Name = "comboEstadoTarea";
            this.comboEstadoTarea.Padding = new System.Windows.Forms.Padding(1);
            this.comboEstadoTarea.Size = new System.Drawing.Size(200, 30);
            this.comboEstadoTarea.TabIndex = 74;
            this.comboEstadoTarea.Texts = "";
            // 
            // frmPropiasTareasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.btnConsultarTareas);
            this.Controls.Add(this.comboEstadoTarea);
            this.Controls.Add(this.btnRenovarTarea);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCompletarTarea);
            this.Controls.Add(this.dgvTareasPendientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPropiasTareasPendientes";
            this.Text = "frmPropiasTareasPendientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnConsultarTareas;
        private Recursos.UserControls.GGComboBox comboEstadoTarea;
        private FontAwesome.Sharp.IconButton btnRenovarTarea;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnCompletarTarea;
        private System.Windows.Forms.DataGridView dgvTareasPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
    }
}