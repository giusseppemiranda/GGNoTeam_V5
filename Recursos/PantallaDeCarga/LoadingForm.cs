using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.Recursos
{
    public partial class LoadingForm : Form
    {

        LoadingForm load;
        
        public LoadingForm()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            loading.Load("Recursos/PantallaDeCarga/gifPantallaCarga_2.gif");
            loading.Location = new Point(this.Width / 2 - loading.Width / 2);
            loading.Location = new Point(this.Height / 2 - loading.Height / 2);
        }
    }
}
