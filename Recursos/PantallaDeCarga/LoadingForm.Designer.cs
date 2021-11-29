
namespace GGNoTeam_V5.Recursos
{
    partial class LoadingForm
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
            this.loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.Transparent;
            this.loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading.Location = new System.Drawing.Point(0, 0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(250, 250);
            this.loading.TabIndex = 0;
            this.loading.TabStop = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loading;
    }
}