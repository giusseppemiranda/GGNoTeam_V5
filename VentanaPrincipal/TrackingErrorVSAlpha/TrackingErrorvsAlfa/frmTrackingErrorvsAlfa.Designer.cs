
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelGraficos = new System.Windows.Forms.Panel();
            this.lblTitutlo = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.btnExportarGraficos = new FontAwesome.Sharp.IconButton();
            this.btnFondo_2 = new FontAwesome.Sharp.IconButton();
            this.btnFondo_3 = new FontAwesome.Sharp.IconButton();
            this.btnFondo_1 = new FontAwesome.Sharp.IconButton();
            this.graficoTE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoAlpha = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelGraficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGraficos
            // 
            this.panelGraficos.Controls.Add(this.graficoAlpha);
            this.panelGraficos.Controls.Add(this.graficoTE);
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
            // graficoTE
            // 
            chartArea5.Name = "ChartArea1";
            this.graficoTE.ChartAreas.Add(chartArea5);
            legend5.DockedToChartArea = "ChartArea1";
            legend5.Name = "Legend1";
            this.graficoTE.Legends.Add(legend5);
            this.graficoTE.Location = new System.Drawing.Point(0, 0);
            this.graficoTE.Name = "graficoTE";
            this.graficoTE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "TrackingError";
            this.graficoTE.Series.Add(series5);
            this.graficoTE.Size = new System.Drawing.Size(742, 239);
            this.graficoTE.TabIndex = 0;
            this.graficoTE.Text = "chart1";
            // 
            // graficoAlpha
            // 
            chartArea6.Name = "ChartArea1";
            this.graficoAlpha.ChartAreas.Add(chartArea6);
            legend6.DockedToChartArea = "ChartArea1";
            legend6.Name = "Legend1";
            this.graficoAlpha.Legends.Add(legend6);
            this.graficoAlpha.Location = new System.Drawing.Point(0, 248);
            this.graficoAlpha.Name = "graficoAlpha";
            this.graficoAlpha.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Alpha";
            this.graficoAlpha.Series.Add(series6);
            this.graficoAlpha.Size = new System.Drawing.Size(742, 230);
            this.graficoAlpha.TabIndex = 1;
            this.graficoAlpha.Text = "chart2";
            this.graficoAlpha.Click += new System.EventHandler(this.chart2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos PNG(*.png)|*.png";
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
            ((System.ComponentModel.ISupportInitialize)(this.graficoTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoAlpha)).EndInit();
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
        private FontAwesome.Sharp.IconButton btnFondo_1;
        private FontAwesome.Sharp.IconButton btnFondo_3;
        private FontAwesome.Sharp.IconButton btnFondo_2;
        private FontAwesome.Sharp.IconButton btnExportarGraficos;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoAlpha;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoTE;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}