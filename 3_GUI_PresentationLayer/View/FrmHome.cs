using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmHome : Form
    {
        private Random randomNum;
        public FrmHome()
        {
            InitializeComponent();
            randomNum = new Random();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblClock.Text = DateTime.Now.ToString("HH:mm");
            this.lblSecond.Text = ":" + DateTime.Now.ToString("ss");
            int r = randomNum.Next(0, 255);
            int g = randomNum.Next(0, 255);
            int b = randomNum.Next(0, 255);

            Color color = Color.FromArgb(r, g, b);
            this.lblClock.ForeColor = color;
            this.lblSecond.ForeColor = color;
        }
    }
}
