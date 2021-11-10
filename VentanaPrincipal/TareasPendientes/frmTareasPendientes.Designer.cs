
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
            this.btnCambiarEstado = new FontAwesome.Sharp.IconButton();
            this.btnAgregarTarea = new FontAwesome.Sharp.IconButton();
            this.txtboxTarea = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodicidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCambiarEstado.FlatAppearance.BorderSize = 0;
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCambiarEstado.ForeColor = System.Drawing.Color.White;
            this.btnCambiarEstado.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btnCambiarEstado.IconColor = System.Drawing.Color.White;
            this.btnCambiarEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarEstado.IconSize = 32;
            this.btnCambiarEstado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCambiarEstado.Location = new System.Drawing.Point(793, 487);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCambiarEstado.Size = new System.Drawing.Size(158, 52);
            this.btnCambiarEstado.TabIndex = 27;
            this.btnCambiarEstado.Text = "Cambiar estado de tarea";
            this.btnCambiarEstado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCambiarEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnTareaCompleta_Click);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.Orange;
            this.btnAgregarTarea.FlatAppearance.BorderSize = 0;
            this.btnAgregarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTarea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarTarea.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTarea.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregarTarea.IconColor = System.Drawing.Color.White;
            this.btnAgregarTarea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarTarea.IconSize = 32;
            this.btnAgregarTarea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarTarea.Location = new System.Drawing.Point(555, 487);
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
            // txtboxTarea
            // 
            this.txtboxTarea.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxTarea.BorderColor = System.Drawing.Color.Orange;
            this.txtboxTarea.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtboxTarea.BorderSize = 2;
            this.txtboxTarea.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtboxTarea.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxTarea.IsFocused = false;
            this.txtboxTarea.Location = new System.Drawing.Point(34, 509);
            this.txtboxTarea.MaxLength = 32767;
            this.txtboxTarea.Multiline = false;
            this.txtboxTarea.Name = "txtboxTarea";
            this.txtboxTarea.Padding = new System.Windows.Forms.Padding(6);
            this.txtboxTarea.PasswordChar = false;
            this.txtboxTarea.Size = new System.Drawing.Size(515, 30);
            this.txtboxTarea.TabIndex = 28;
            this.txtboxTarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtboxTarea.Texts = "                                                    Ingrese la tarea a agregar.";
            this.txtboxTarea.UnderlinedStyle = true;
            this.txtboxTarea._TextChanged += new System.EventHandler(this.txtboxTarea__TextChanged);
            this.txtboxTarea.Enter += new System.EventHandler(this.txtboxTarea_Enter);
            this.txtboxTarea.Leave += new System.EventHandler(this.txtboxTarea_Leave);
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
            // frmTareasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtboxTarea);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.dgvTareasPendientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTareasPendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTareasPendientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasPendientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTareasPendientes;
        private FontAwesome.Sharp.IconButton btnCambiarEstado;
        private FontAwesome.Sharp.IconButton btnAgregarTarea;
        private Recursos.UserControls.GGTextBox txtboxTarea;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodicidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}