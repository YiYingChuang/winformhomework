using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab_02__Y_
{
    public partial class FrmLotteryReport : Form
    {
        public FrmLotteryReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLotteryReport_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point pt1 = new Point(0, 0);
            Point pt2= new Point(0,this.ClientRectangle.Height);
            LinearGradientBrush b = new LinearGradientBrush(pt1, pt2, Color.LightGray, Color.Salmon);
            e.Graphics.FillRectangle(b, this.ClientRectangle);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point pt1 = new Point(0, 0);
            Point pt2 = new Point(0, this.ClientRectangle.Height);
            LinearGradientBrush b = new LinearGradientBrush(pt1, pt2, Color.LightGray, Color.Salmon);
            e.Graphics.FillRectangle(b, this.ClientRectangle);
        }

        private void FrmLotteryReport_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
