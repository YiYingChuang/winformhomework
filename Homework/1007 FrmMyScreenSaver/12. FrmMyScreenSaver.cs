using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_01
{
    public partial class FrmMyScreenSaver : Form
    {
        public FrmMyScreenSaver()
        {
            InitializeComponent();
        }
        int x = 3;
        int y = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToLongTimeString();

            //Right取得控制項右邊緣和其容器工作區 (Client Area) 左邊緣之間的距離 (單位為像素)。
            //this.label1.Right = += 5;


            //取得或設定控制項左邊緣和其容器工作區 (Client Area) 左邊緣之間的距離 (單位為像素)。
            this.label1.Left += x;
            if (this.label1.Left>=(this.Width-this.label1.Size.Width)|this.label1.Left<=0)
            {
               x= x * (-1);  
            }
          
            this.label1.Top += y;
            if (this.label1.Top >= (this.Height-this.label1.Size.Height)|this.label1.Top<=0)
            {
                y = y * (-1);
            }

            //lily id  piggy
            this.pictureBox1.BackgroundImage = this.imageList1.Images[i];
            i += 1;
            if (i > this.imageList1.Images.Count - 1)
            {
                i = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }
        int firstx, firsty;

        private void FrmMyScreenSaver_Load(object sender, EventArgs e)
        {
            //this.MouseClick += FrmMyScreenSaver_Click;

            
            firstx = MousePosition.X;
            firsty = MousePosition.Y;

           
        }

        //void FrmMyScreenSaver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
        
        
        private void FrmMyScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            this.label3.Text =  e.X + ", " +e.Y;
            this.label4.Text = firstx + "," + firsty;
            
            int secx = MousePosition.X;
            int secy = MousePosition.Y;
            if ((firstx - secx) > 5 | (firsty - secy) > 5 | (firsty - secy) < -5 | (firsty - secy) < -5)
            {
                this.Close();
            }
        }
        int i = 0;
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
