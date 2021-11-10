
namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.TrackingErrorvsAlfa
{
    partial class frmTrackingErrorvsAlfa
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelGraficos = new System.Windows.Forms.Panel();
            this.lblTitutlo = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExportarGraficos = new FontAwesome.Sharp.IconButton();
            this.btnFondo_2 = new FontAwesome.Sharp.IconButton();
            this.btnFondo_3 = new FontAwesome.Sharp.IconButton();
            this.btnFondo_1 = new FontAwesome.Sharp.IconButton();
            this.btnVerCalculoTE = new FontAwesome.Sharp.IconButton();
            this.btnVerCalculoAlpha = new FontAwesome.Sharp.IconButton();
            this.panelGraficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGraficos
            // 
            this.panelGraficos.Controls.Add(this.btnVerCalculoTE);
            this.panelGraficos.Controls.Add(this.btnVerCalculoAlpha);
            this.panelGraficos.Controls.Add(this.chart2);
            this.panelGraficos.Controls.Add(this.chart1);
            this.panelGraficos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGraficos.Location = new System.Drawing.Point(240, 0);
            this.panelGraficos.Name = "panelGraficos";
            this.panelGraficos.Size = new System.Drawing.Size(741, 478);
            this.panelGraficos.TabIndex = 0;
            // 
            // lblTitutlo
            // 
            this.lblTitutlo.AutoSize = true;
            this.lblTitutlo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitutlo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitutlo.Location = new System.Drawing.Point(6, 9);
            this.lblTitutlo.Name = "lblTitutlo";
            this.lblTitutlo.Size = new System.Drawing.Size(232, 28);
            this.lblTitutlo.TabIndex = 16;
            this.lblTitutlo.Text = "Tracking Error vs Alpha";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaFinal.Location = new System.Drawing.Point(8, 103);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(70, 15);
            this.lblFechaFinal.TabIndex = 17;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicial.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFechaInicial.Location = new System.Drawing.Point(8, 51);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(77, 15);
            this.lblFechaInicial.TabIndex = 18;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(11, 69);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(222, 20);
            this.dateInicial.TabIndex = 0;
            // 
            // dateFinal
            // 
            this.dateFinal.Location = new System.Drawing.Point(11, 121);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(222, 20);
            this.dateFinal.TabIndex = 19;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(37, 9);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(655, 226);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(37, 235);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(655, 208);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // btnExportarGraficos
            // 
            this.btnExportarGraficos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExportarGraficos.FlatAppearance.BorderSize = 0;
            this.btnExportarGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarGraficos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportarGraficos.ForeColor = System.Drawing.Color.White;
            this.btnExportarGraficos.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnExportarGraficos.IconColor = System.Drawing.Color.White;
            this.btnExportarGraficos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportarGraficos.IconSize = 32;
            this.btnExportarGraficos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarGraficos.Location = new System.Drawing.Point(11, 386);
            this.btnExportarGraficos.Name = "btnExportarGraficos";
            this.btnExportarGraficos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnExportarGraficos.Size = new System.Drawing.Size(222, 53);
            this.btnExportarGraficos.TabIndex = 42;
            this.btnExportarGraficos.Text = "Descargas gráficos";
            this.btnExportarGraficos.UseVisualStyleBackColor = false;
            this.btnExportarGraficos.Click += new System.EventHandler(this.btnExportarGraficos_Click);
            // 
            // btnFondo_2
            // 
            this.btnFondo_2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFondo_2.FlatAppearance.BorderSize = 0;
            this.btnFondo_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFondo_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFondo_2.ForeColor = System.Drawing.Color.White;
            this.btnFondo_2.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnFondo_2.IconColor = System.Drawing.Color.White;
            this.btnFondo_2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFondo_2.IconSize = 32;
            this.btnFondo_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFondo_2.Location = new System.Drawing.Point(11, 235);
            this.btnFondo_2.Name = "btnFondo_2";
            this.btnFondo_2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFondo_2.Size = new System.Drawing.Size(222, 53);
            this.btnFondo_2.TabIndex = 41;
            this.btnFondo_2.Text = "Análisis Fondo 2";
            this.btnFondo_2.UseVisualStyleBackColor = false;
            this.btnFondo_2.Click += new System.EventHandler(this.btnFondo_2_Click);
            // 
            // btnFondo_3
            // 
            this.btnFondo_3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFondo_3.FlatAppearance.BorderSize = 0;
            this.btnFondo_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFondo_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFondo_3.ForeColor = System.Drawing.Color.White;
            this.btnFondo_3.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnFondo_3.IconColor = System.Drawing.Color.White;
            this.btnFondo_3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFondo_3.IconSize = 32;
            this.btnFondo_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFondo_3.Location = new System.Drawing.Point(11, 294);
            this.btnFondo_3.Name = "btnFondo_3";
            this.btnFondo_3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFondo_3.Size = new System.Drawing.Size(222, 53);
            this.btnFondo_3.TabIndex = 40;
            this.btnFondo_3.Text = "Análisis Fondo 3";
            this.btnFondo_3.UseVisualStyleBackColor = false;
            this.btnFondo_3.Click += new System.EventHandler(this.btnFondo_3_Click);
            // 
            // btnFondo_1
            // 
            this.btnFondo_1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFondo_1.FlatAppearance.BorderSize = 0;
            this.btnFondo_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFondo_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFondo_1.ForeColor = System.Drawing.Color.White;
            this.btnFondo_1.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnFondo_1.IconColor = System.Drawing.Color.White;
            this.btnFondo_1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFondo_1.IconSize = 32;
            this.btnFondo_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFondo_1.Location = new System.Drawing.Point(11, 176);
            this.btnFondo_1.Name = "btnFondo_1";
            this.btnFondo_1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFondo_1.Size = new System.Drawing.Size(222, 53);
            this.btnFondo_1.TabIndex = 39;
            this.btnFondo_1.Text = "Análisis Fondo 1";
            this.btnFondo_1.UseVisualStyleBackColor = false;
            this.btnFondo_1.Click += new System.EventHandler(this.btnFondo_1_Click);
            // 
            // btnVerCalculoTE
            // 
            this.btnVerCalculoTE.BackColor = System.Drawing.Color.Teal;
            this.btnVerCalculoTE.FlatAppearance.BorderSize = 0;
            this.btnVerCalculoTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCalculoTE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerCalculoTE.ForeColor = System.Drawing.Color.White;
            this.btnVerCalculoTE.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerCalculoTE.IconColor = System.Drawing.Color.White;
            this.btnVerCalculoTE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerCalculoTE.IconSize = 32;
            this.btnVerCalculoTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCalculoTE.Location = new System.Drawing.Point(383, 446);
            this.btnVerCalculoTE.Name = "btnVerCalculoTE";
            this.btnVerCalculoTE.Size = new System.Drawing.Size(222, 29);
            this.btnVerCalculoTE.TabIndex = 44;
            this.btnVerCalculoTE.Text = "Ver calculo Tracking Error";
            this.btnVerCalculoTE.UseVisualStyleBackColor = false;
            this.btnVerCalculoTE.Click += new System.EventHandler(this.btnVerCalculoTE_Click);
            // 
            // btnVerCalculoAlpha
            // 
            this.btnVerCalculoAlpha.BackColor = System.Drawing.Color.Teal;
            this.btnVerCalculoAlpha.FlatAppearance.BorderSize = 0;
            this.btnVerCalculoAlpha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCalculoAlpha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerCalculoAlpha.ForeColor = System.Drawing.Color.White;
            this.btnVerCalculoAlpha.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerCalculoAlpha.IconColor = System.Drawing.Color.White;
            this.btnVerCalculoAlpha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerCalculoAlpha.IconSize = 32;
            this.btnVerCalculoAlpha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCalculoAlpha.Location = new System.Drawing.Point(124, 446);
            this.btnVerCalculoAlpha.Name = "btnVerCalculoAlpha";
            this.btnVerCalculoAlpha.Size = new System.Drawing.Size(222, 29);
            this.btnVerCalculoAlpha.TabIndex = 43;
            this.btnVerCalculoAlpha.Text = "Ver calculo Alpha";
            this.btnVerCalculoAlpha.UseVisualStyleBackColor = false;
            this.btnVerCalculoAlpha.Click += new System.EventHandler(this.btnVerCalculoAlpha_Click);
            // 
            // frmTrackingErrorvsAlfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 478);
            this.Controls.Add(this.btnExportarGraficos);
            this.Controls.Add(this.btnFondo_2);
            this.Controls.Add(this.btnFondo_3);
            this.Controls.Add(this.btnFondo_1);
            this.Controls.Add(this.dateFinal);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblTitutlo);
            this.Controls.Add(this.panelGraficos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTrackingErrorvsAlfa";
            this.Text = "frmTrackingErrorvsAlfa";
            this.panelGraficos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGraficos;
        private System.Windows.Forms.Label lblTitutlo;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private FontAwesome.Sharp.IconButton btnFondo_1;
        private FontAwesome.Sharp.IconButton btnFondo_3;
        private FontAwesome.Sharp.IconButton btnFondo_2;
        private FontAwesome.Sharp.IconButton btnExportarGraficos;
        private FontAwesome.Sharp.IconButton btnVerCalculoTE;
        private FontAwesome.Sharp.IconButton btnVerCalculoAlpha;
    }
}