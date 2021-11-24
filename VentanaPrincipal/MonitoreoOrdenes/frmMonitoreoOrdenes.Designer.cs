
namespace GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes
{
    partial class frmMonitoreoOrdenes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fondo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUMEjecucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUMOrdenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnAccederOrden = new FontAwesome.Sharp.IconButton();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.EliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnModificarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnGestionarEjecuciones = new FontAwesome.Sharp.IconButton();
            this.btnGestionarOrdenes = new FontAwesome.Sharp.IconButton();
            this.comboFondo = new GGNoTeam_V5.Recursos.UserControls.GGComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(60, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(442, 54);
            this.lblTitulo.TabIndex = 30;
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
            this.Operacion,
            this.AUMEjecucion,
            this.AUMOrdenes,
            this.Validacion,
            this.Comentario});
            this.dgvOrdenes.EnableHeadersVisualStyles = false;
            this.dgvOrdenes.Location = new System.Drawing.Point(70, 192);
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
            this.dgvOrdenes.Size = new System.Drawing.Size(1848, 752);
            this.dgvOrdenes.TabIndex = 31;
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
            this.CodigoSBS.HeaderText = "Código SBS";
            this.CodigoSBS.MinimumWidth = 10;
            this.CodigoSBS.Name = "CodigoSBS";
            this.CodigoSBS.ReadOnly = true;
            this.CodigoSBS.Width = 188;
            // 
            // CodigoISIN
            // 
            this.CodigoISIN.HeaderText = "Código ISIN";
            this.CodigoISIN.MinimumWidth = 10;
            this.CodigoISIN.Name = "CodigoISIN";
            this.CodigoISIN.ReadOnly = true;
            this.CodigoISIN.Width = 195;
            // 
            // Instrumento
            // 
            this.Instrumento.HeaderText = "Instrumento";
            this.Instrumento.MinimumWidth = 10;
            this.Instrumento.Name = "Instrumento";
            this.Instrumento.ReadOnly = true;
            this.Instrumento.Width = 200;
            // 
            // Operacion
            // 
            this.Operacion.HeaderText = "Operacion";
            this.Operacion.MinimumWidth = 10;
            this.Operacion.Name = "Operacion";
            this.Operacion.ReadOnly = true;
            this.Operacion.Width = 176;
            // 
            // AUMEjecucion
            // 
            this.AUMEjecucion.HeaderText = "AUM Ejecución";
            this.AUMEjecucion.MinimumWidth = 10;
            this.AUMEjecucion.Name = "AUMEjecucion";
            this.AUMEjecucion.ReadOnly = true;
            this.AUMEjecucion.Width = 231;
            // 
            // AUMOrdenes
            // 
            this.AUMOrdenes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AUMOrdenes.HeaderText = "AUM Órdenes";
            this.AUMOrdenes.MinimumWidth = 10;
            this.AUMOrdenes.Name = "AUMOrdenes";
            this.AUMOrdenes.ReadOnly = true;
            // 
            // Validacion
            // 
            this.Validacion.HeaderText = "Validacion";
            this.Validacion.MinimumWidth = 10;
            this.Validacion.Name = "Validacion";
            this.Validacion.ReadOnly = true;
            this.Validacion.Width = 176;
            // 
            // Comentario
            // 
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.MinimumWidth = 10;
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Width = 192;
            // 
            // dateFinal
            // 
            this.dateFinal.Location = new System.Drawing.Point(482, 142);
            this.dateFinal.Margin = new System.Windows.Forms.Padding(6);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(392, 31);
            this.dateFinal.TabIndex = 63;
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(72, 142);
            this.dateInicial.Margin = new System.Windows.Forms.Padding(6);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(396, 31);
            this.dateInicial.TabIndex = 60;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicial.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaInicial.Location = new System.Drawing.Point(66, 108);
            this.lblFechaInicial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(162, 32);
            this.lblFechaInicial.TabIndex = 62;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaFinal.Location = new System.Drawing.Point(474, 108);
            this.lblFechaFinal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(147, 32);
            this.lblFechaFinal.TabIndex = 61;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSubtitulo.Location = new System.Drawing.Point(64, 56);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(192, 41);
            this.lblSubtitulo.TabIndex = 25;
            this.lblSubtitulo.Text = "Operaciones";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Goldenrod;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(578, 962);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(6);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(300, 73);
            this.iconButton2.TabIndex = 72;
            this.iconButton2.Text = "Acceder ejecución";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnAccederOrden
            // 
            this.btnAccederOrden.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAccederOrden.FlatAppearance.BorderSize = 0;
            this.btnAccederOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccederOrden.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAccederOrden.ForeColor = System.Drawing.Color.White;
            this.btnAccederOrden.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAccederOrden.IconColor = System.Drawing.Color.White;
            this.btnAccederOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccederOrden.IconSize = 32;
            this.btnAccederOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccederOrden.Location = new System.Drawing.Point(168, 962);
            this.btnAccederOrden.Margin = new System.Windows.Forms.Padding(6);
            this.btnAccederOrden.Name = "btnAccederOrden";
            this.btnAccederOrden.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAccederOrden.Size = new System.Drawing.Size(300, 73);
            this.btnAccederOrden.TabIndex = 71;
            this.btnAccederOrden.Text = "Acceder órden";
            this.btnAccederOrden.UseVisualStyleBackColor = false;
            this.btnAccederOrden.Click += new System.EventHandler(this.btnAccederOrden_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConsultar.IconColor = System.Drawing.Color.White;
            this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultar.IconSize = 32;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(925, 100);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConsultar.Size = new System.Drawing.Size(300, 73);
            this.btnConsultar.TabIndex = 70;
            this.btnConsultar.Text = "Consultar operaciones";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnconsultar_click);
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
            this.EliminarRegistro.Location = new System.Drawing.Point(1618, 962);
            this.EliminarRegistro.Margin = new System.Windows.Forms.Padding(6);
            this.EliminarRegistro.Name = "EliminarRegistro";
            this.EliminarRegistro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.EliminarRegistro.Size = new System.Drawing.Size(300, 73);
            this.EliminarRegistro.TabIndex = 69;
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
            this.btnModificarRegistro.Location = new System.Drawing.Point(1260, 962);
            this.btnModificarRegistro.Margin = new System.Windows.Forms.Padding(6);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnModificarRegistro.Size = new System.Drawing.Size(300, 73);
            this.btnModificarRegistro.TabIndex = 68;
            this.btnModificarRegistro.Text = "Modificar Registro";
            this.btnModificarRegistro.UseVisualStyleBackColor = false;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // btnGestionarEjecuciones
            // 
            this.btnGestionarEjecuciones.BackColor = System.Drawing.Color.Goldenrod;
            this.btnGestionarEjecuciones.FlatAppearance.BorderSize = 0;
            this.btnGestionarEjecuciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarEjecuciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestionarEjecuciones.ForeColor = System.Drawing.Color.White;
            this.btnGestionarEjecuciones.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGestionarEjecuciones.IconColor = System.Drawing.Color.White;
            this.btnGestionarEjecuciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionarEjecuciones.IconSize = 32;
            this.btnGestionarEjecuciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarEjecuciones.Location = new System.Drawing.Point(1260, 100);
            this.btnGestionarEjecuciones.Margin = new System.Windows.Forms.Padding(6);
            this.btnGestionarEjecuciones.Name = "btnGestionarEjecuciones";
            this.btnGestionarEjecuciones.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGestionarEjecuciones.Size = new System.Drawing.Size(313, 73);
            this.btnGestionarEjecuciones.TabIndex = 67;
            this.btnGestionarEjecuciones.Text = "Gestionar ejecuciones";
            this.btnGestionarEjecuciones.UseVisualStyleBackColor = false;
            this.btnGestionarEjecuciones.Click += new System.EventHandler(this.btnGestionarEjecuciones_Click);
            // 
            // btnGestionarOrdenes
            // 
            this.btnGestionarOrdenes.BackColor = System.Drawing.Color.Goldenrod;
            this.btnGestionarOrdenes.FlatAppearance.BorderSize = 0;
            this.btnGestionarOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarOrdenes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestionarOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnGestionarOrdenes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGestionarOrdenes.IconColor = System.Drawing.Color.White;
            this.btnGestionarOrdenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionarOrdenes.IconSize = 32;
            this.btnGestionarOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarOrdenes.Location = new System.Drawing.Point(1600, 100);
            this.btnGestionarOrdenes.Margin = new System.Windows.Forms.Padding(6);
            this.btnGestionarOrdenes.Name = "btnGestionarOrdenes";
            this.btnGestionarOrdenes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGestionarOrdenes.Size = new System.Drawing.Size(318, 73);
            this.btnGestionarOrdenes.TabIndex = 66;
            this.btnGestionarOrdenes.Text = "Gestionar órdenes";
            this.btnGestionarOrdenes.UseVisualStyleBackColor = false;
            this.btnGestionarOrdenes.Click += new System.EventHandler(this.btnGestionarOrdenes_Click);
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
            this.comboFondo.Location = new System.Drawing.Point(770, 15);
            this.comboFondo.Margin = new System.Windows.Forms.Padding(6);
            this.comboFondo.MinimumSize = new System.Drawing.Size(400, 58);
            this.comboFondo.Name = "comboFondo";
            this.comboFondo.Padding = new System.Windows.Forms.Padding(2);
            this.comboFondo.Size = new System.Drawing.Size(400, 58);
            this.comboFondo.TabIndex = 74;
            this.comboFondo.Texts = "Fondo";
            // 
            // frmMonitoreoOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1962, 1052);
            this.Controls.Add(this.comboFondo);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnAccederOrden);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.EliminarRegistro);
            this.Controls.Add(this.btnModificarRegistro);
            this.Controls.Add(this.btnGestionarEjecuciones);
            this.Controls.Add(this.btnGestionarOrdenes);
            this.Controls.Add(this.dateFinal);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.dgvOrdenes);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMonitoreoOrdenes";
            this.Text = "frmMonitoreoOrdenes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private FontAwesome.Sharp.IconButton btnGestionarOrdenes;
        private FontAwesome.Sharp.IconButton btnGestionarEjecuciones;
        private FontAwesome.Sharp.IconButton btnModificarRegistro;
        private FontAwesome.Sharp.IconButton EliminarRegistro;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fondo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoISIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instrumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUMEjecucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUMOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private FontAwesome.Sharp.IconButton btnAccederOrden;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Recursos.UserControls.GGComboBox comboFondo;
    }
}