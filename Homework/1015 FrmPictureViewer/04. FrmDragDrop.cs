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
        public FrmDragDrop()
        {
            InitializeComponent();
            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.DragEnter += pictureBox1_DragEnter;
            this.pictureBox1.DragDrop += pictureBox1_DragDrop;
            foreach (Control x in this.flowLayoutPanel1.Controls)
            {
                x.MouseDown += Source_pictureBox_MouseDown;
            }
                        
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        List<Control> ShowPicture = new List<Control>();
        void show_picturebox()
        {
            ShowPicture.Clear();
            foreach (Control x in this.flowLayoutPanel1.Controls)
            {
                ShowPicture.Add(x);
            }
            for (int i = 0; i < ShowPicture.Count; i++)
            {
               this.pictureBox1.Image = ((PictureBox)ShowPicture[i]).Image;  
            }
        }
        void AddPicturebox()
        { 
            for (int i = 0; i < this.s.Count ; i++)
			{
                PictureBox p = new PictureBox();
                p.Width = 120;
                p.Height = 90;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Image = Image.FromFile(s[i]);
                this.flowLayoutPanel1.Controls.Add(p);
			}
         
        }
        List<string> s = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //TODO...開項目數目
                s.Add(this.openFileDialog1.FileName);
                this.AddPicturebox();
                s.Clear();
            }
        }

        
    }
}
