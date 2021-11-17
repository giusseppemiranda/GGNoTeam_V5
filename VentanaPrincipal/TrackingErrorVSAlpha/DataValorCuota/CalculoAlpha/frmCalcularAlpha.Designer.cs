
namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota
{
    partial class frmCalcularAlpha
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
            this.lblFondo_3 = new System.Windows.Forms.Label();
            this.lblFondo_2 = new System.Windows.Forms.Label();
            this.lblFondo_1 = new System.Windows.Forms.Label();
            this.lblTE = new System.Windows.Forms.Label();
            this.btnConsultarRegistros = new FontAwesome.Sharp.IconButton();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvAlpha = new System.Windows.Forms.DataGridView();
            this.boxFondo3 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.boxFondo1 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.boxFondo2 = new GGNoTeam_V5.Recursos.UserControls.GGTextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fidFondo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alpha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patrimonioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFondo_3
            // 
            this.lblFondo_3.AutoSize = true;
            this.lblFondo_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFondo_3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFondo_3.Location = new System.Drawing.Point(701, 416);
            this.lblFondo_3.Name = "lblFondo_3";
            this.lblFondo_3.Size = new System.Drawing.Size(59, 15);
            this.lblFondo_3.TabIndex = 56;
            this.lblFondo_3.Text = "FONDO 3";
            this.lblFondo_3.Visible = false;
            // 
            // lblFondo_2
            // 
            this.lblFondo_2.AutoSize = true;
            this.lblFondo_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFondo_2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFondo_2.Location = new System.Drawing.Point(522, 416);
            this.lblFondo_2.Name = "lblFondo_2";
            this.lblFondo_2.Size = new System.Drawing.Size(59, 15);
            this.lblFondo_2.TabIndex = 55;
            this.lblFondo_2.Text = "FONDO 2";
            this.lblFondo_2.Visible = false;
            // 
            // lblFondo_1
            // 
            this.lblFondo_1.AutoSize = true;
            this.lblFondo_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFondo_1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFondo_1.Location = new System.Drawing.Point(329, 416);
            this.lblFondo_1.Name = "lblFondo_1";
            this.lblFondo_1.Size = new System.Drawing.Size(59, 15);
            this.lblFondo_1.TabIndex = 54;
            this.lblFondo_1.Text = "FONDO 1";
            this.lblFondo_1.Visible = false;
            // 
            // lblTE
            // 
            this.lblTE.AutoSize = true;
            this.lblTE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTE.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTE.Location = new System.Drawing.Point(112, 451);
            this.lblTE.Name = "lblTE";
            this.lblTE.Size = new System.Drawing.Size(101, 15);
            this.lblTE.TabIndex = 53;
            this.lblTE.Text = "Valores de Alpha:";
            // 
            // btnConsultarRegistros
            // 
            this.btnConsultarRegistros.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsultarRegistros.FlatAppearance.BorderSize = 0;
            this.btnConsultarRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarRegistros.ForeColor = System.Drawing.Color.White;
            this.btnConsultarRegistros.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConsultarRegistros.IconColor = System.Drawing.Color.White;
            this.btnConsultarRegistros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultarRegistros.IconSize = 32;
            this.btnConsultarRegistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarRegistros.Location = new System.Drawing.Point(240, 47);
            this.btnConsultarRegistros.Name = "btnConsultarRegistros";
            this.btnConsultarRegistros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultarRegistros.Size = new System.Drawing.Size(178, 38);
            this.btnConsultarRegistros.TabIndex = 51;
            this.btnConsultarRegistros.Text = "Consultar Registros";
            this.btnConsultarRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarRegistros.UseVisualStyleBackColor = false;
            this.btnConsultarRegistros.Click += new System.EventHandler(this.btnConsultarRegistros_Click);
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(11, 65);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(222, 20);
            this.dateInicial.TabIndex = 49;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicial.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaInicial.Location = new System.Drawing.Point(8, 47);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(77, 15);
            this.lblFechaInicial.TabIndex = 50;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(8, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 28);
            this.lblTitulo.TabIndex = 48;
            this.lblTitulo.Text = "Calculo Alpha";
            // 
            // dgvAlpha
            // 
            this.dgvAlpha.AllowUserToAddRows = false;
            this.dgvAlpha.AllowUserToDeleteRows = false;
            this.dgvAlpha.AllowUserToResizeColumns = false;
            this.dgvAlpha.AllowUserToResizeRows = false;
            this.dgvAlpha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlpha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlpha.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAlpha.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlpha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlpha.ColumnHeadersHeight = 25;
            this.dgvAlpha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fecha,
            this.fidFondo,
            this.alpha,
            this.patrimonioTotal});
            this.dgvAlpha.EnableHeadersVisualStyles = false;
            this.dgvAlpha.Location = new System.Drawing.Point(12, 91);
            this.dgvAlpha.MultiSelect = false;
            this.dgvAlpha.Name = "dgvAlpha";
            this.dgvAlpha.ReadOnly = true;
            this.dgvAlpha.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAlpha.RowHeadersWidth = 82;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvAlpha.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlpha.RowTemplate.Height = 25;
            this.dgvAlpha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlpha.Size = new System.Drawing.Size(952, 322);
            this.dgvAlpha.TabIndex = 63;
            // 
            // boxFondo3
            // 
            this.boxFondo3.BackColor = System.Drawing.SystemColors.Window;
            this.boxFondo3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.boxFondo3.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.boxFondo3.BorderSize = 2;
            this.boxFondo3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.boxFondo3.ForeColor = System.Drawing.Color.DimGray;
            this.boxFondo3.IsFocused = false;
            this.boxFondo3.Location = new System.Drawing.Point(668, 434);
            this.boxFondo3.MaxLength = 32767;
            this.boxFondo3.Multiline = false;
            this.boxFondo3.Name = "boxFondo3";
            this.boxFondo3.Padding = new System.Windows.Forms.Padding(7);
            this.boxFondo3.PasswordChar = false;
            this.boxFondo3.Size = new System.Drawing.Size(125, 32);
            this.boxFondo3.TabIndex = 59;
            this.boxFondo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxFondo3.Texts = "";
            this.boxFondo3.UnderlinedStyle = false;
            this.boxFondo3.Visible = false;
            // 
            // boxFondo1
            // 
            this.boxFondo1.BackColor = System.Drawing.SystemColors.Window;
            this.boxFondo1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.boxFondo1.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.boxFondo1.BorderSize = 2;
            this.boxFondo1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.boxFondo1.ForeColor = System.Drawing.Color.DimGray;
            this.boxFondo1.IsFocused = false;
            this.boxFondo1.Location = new System.Drawing.Point(293, 434);
            this.boxFondo1.MaxLength = 32767;
            this.boxFondo1.Multiline = false;
            this.boxFondo1.Name = "boxFondo1";
            this.boxFondo1.Padding = new System.Windows.Forms.Padding(7);
            this.boxFondo1.PasswordChar = false;
            this.boxFondo1.Size = new System.Drawing.Size(125, 32);
            this.boxFondo1.TabIndex = 57;
            this.boxFondo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxFondo1.Texts = "";
            this.boxFondo1.UnderlinedStyle = false;
            // 
            // boxFondo2
            // 
            this.boxFondo2.BackColor = System.Drawing.SystemColors.Window;
            this.boxFondo2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.boxFondo2.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.boxFondo2.BorderSize = 2;
            this.boxFondo2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.boxFondo2.ForeColor = System.Drawing.Color.DimGray;
            this.boxFondo2.IsFocused = false;
            this.boxFondo2.Location = new System.Drawing.Point(486, 434);
            this.boxFondo2.MaxLength = 32767;
            this.boxFondo2.Multiline = false;
            this.boxFondo2.Name = "boxFondo2";
            this.boxFondo2.Padding = new System.Windows.Forms.Padding(7);
            this.boxFondo2.PasswordChar = false;
            this.boxFondo2.Size = new System.Drawing.Size(125, 32);
            this.boxFondo2.TabIndex = 58;
            this.boxFondo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxFondo2.Texts = "";
            this.boxFondo2.UnderlinedStyle = false;
            this.boxFondo2.Visible = false;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 62;
            // 
            // fidFondo
            // 
            this.fidFondo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fidFondo.HeaderText = "Fondo";
            this.fidFondo.Name = "fidFondo";
            this.fidFondo.ReadOnly = true;
            this.fidFondo.Width = 64;
            // 
            // alpha
            // 
            this.alpha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alpha.HeaderText = "Alpha";
            this.alpha.Name = "alpha";
            this.alpha.ReadOnly = true;
            this.alpha.Width = 61;
            // 
            // patrimonioTotal
            // 
            this.patrimonioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patrimonioTotal.HeaderText = "Patrimonio Total";
            this.patrimonioTotal.Name = "patrimonioTotal";
            this.patrimonioTotal.ReadOnly = true;
            // 
            // frmCalcularAlpha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 478);
            this.Controls.Add(this.dgvAlpha);
            this.Controls.Add(this.boxFondo3);
            this.Controls.Add(this.boxFondo1);
            this.Controls.Add(this.lblFondo_3);
            this.Controls.Add(this.lblFondo_2);
            this.Controls.Add(this.lblFondo_1);
            this.Controls.Add(this.lblTE);
            this.Controls.Add(this.btnConsultarRegistros);
            this.Controls.Add(this.boxFondo2);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCalcularAlpha";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Recursos.UserControls.GGTextBox boxFondo3;
        private Recursos.UserControls.GGTextBox boxFondo1;
        private System.Windows.Forms.Label lblFondo_3;
        private System.Windows.Forms.Label lblFondo_2;
        private System.Windows.Forms.Label lblFondo_1;
        private System.Windows.Forms.Label lblTE;
        private FontAwesome.Sharp.IconButton btnConsultarRegistros;
        private Recursos.UserControls.GGTextBox boxFondo2;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvAlpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidFondo;
        private System.Windows.Forms.DataGridViewTextBoxColumn alpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn patrimonioTotal;
    }
}