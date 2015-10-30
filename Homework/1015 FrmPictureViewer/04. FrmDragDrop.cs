using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02__Y_
{
    public partial class FrmDragDrop : Form
    {
        List<Control> ShowPicture = new List<Control>();
        List<string> s = new List<string>();
        int t = 0;
        int h, w;
        public FrmDragDrop()
        {
            InitializeComponent();
            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.DragEnter += pictureBox1_DragEnter;
            this.pictureBox1.DragDrop += pictureBox1_DragDrop;
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.DragEnter += flowLayoutPanel1_DragEnter;
            this.flowLayoutPanel1.DragDrop += flowLayoutPanel1_DragDrop;
            this.openFileDialog1.InitialDirectory = "c:\\User\\III\\圖片";
            this.openFileDialog1.Filter = "Image|*.jpg;*.bmp;*.gif;*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            foreach (Control x in this.flowLayoutPanel1.Controls)
            {
                x.MouseDown += Source_pictureBox_MouseDown;
            }
            h = this.pictureBox1.Height;
            w = this.pictureBox1.Width;            
        }

        void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
                for (int i = 0; i < filenames.Length; i++)
                {
                    PictureBox p = new PictureBox();
                    p.Width = 120;
                    p.Height = 90;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Image = Image.FromFile(filenames[i]);
                    this.flowLayoutPanel1.Controls.Add(p);
                }
            }
            foreach (Control x in this.flowLayoutPanel1.Controls)
            {
                x.MouseDown += Source_pictureBox_MouseDown;
            }
        }

        void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Source_pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //this.DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);

            PictureBox p = sender as PictureBox;

            if (p != null)
            {
                this.DoDragDrop(p.Image, DragDropEffects.Copy);
            }
        }

        void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            //MessageBox.Show("Drag Drop!");
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
                this.pictureBox1.Image = Image.FromFile(filenames[0]);
            }
            else if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                this.pictureBox1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            }
        }

        void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShowPicture.Clear();
            foreach (Control x in this.flowLayoutPanel1.Controls)
            {
                ShowPicture.Add(x);
            }
            for (int i = 0; i < this.ShowPicture.Count; i++)
            {
                if (this.pictureBox1.Image == ((PictureBox)this.ShowPicture[i]).Image)
                {
                    if (i-1 < 0)
                    {
                        i = this.ShowPicture.Count;
                    }
                    this.pictureBox1.Image = ((PictureBox)this.ShowPicture[i - 1]).Image;
                    return;
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ShowPicture.Clear();
            foreach (Control x in this.flowLayoutPanel1.Controls)
            {
                ShowPicture.Add(x);
            }
            for (int i = 0; i < this.ShowPicture.Count; i++)
            {
                if (this.pictureBox1.Image == ((PictureBox)this.ShowPicture[i]).Image)
                {
                    if (i + 1 == this.ShowPicture.Count)
                    {
                        i = -1;
                    }
                    this.pictureBox1.Image = ((PictureBox)this.ShowPicture[i + 1]).Image;
                    return;
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;
        }

        private void Openfile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] a = this.openFileDialog1.FileNames;
                foreach (var item in a)
                {
                    this.s.Add(item);
                }                
                this.AddPicturebox(this.s);
                this.s.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timer1.Enabled == true)
            {
                this.show_picturebox();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.trackBar1.Value == 0)
            {
                this.pictureBox1.Height = h;
                this.pictureBox1.Width = w;
            }
            if (this.trackBar1.Value != 0)
            {
                this.pictureBox1.Height = h * (this.trackBar1.Value * 2 + 1);
                this.pictureBox1.Width = w * (this.trackBar1.Value * 2 + 1);
            }

        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer2.Enabled = false;
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
           
            this.timer2.Enabled = true;
        }
             
        void show_picturebox()
        {
            ShowPicture.Clear();
            foreach (Control x in this.flowLayoutPanel1.Controls)
            {
                ShowPicture.Add(x);
            }
            if (this.t < this.ShowPicture.Count)
            {
                this.pictureBox1.Image = ((PictureBox)ShowPicture[this.t]).Image;
                this.t++;
            }
            else 
            {
                this.t = 0;
            }
            
        }

        void AddPicturebox( List<string>x)
        { 
            for (int i = 0; i < x.Count ; i++)
			{
                PictureBox p = new PictureBox();
                p.Width = 120;
                p.Height = 90;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Image = Image.FromFile(x[i]);
                this.flowLayoutPanel1.Controls.Add(p);
			}
         
        }
        
    }
}
