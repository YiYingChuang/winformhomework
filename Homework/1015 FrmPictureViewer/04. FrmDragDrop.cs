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

            this.textBox1.AllowDrop = true;
            this.textBox1.DragEnter += textBox1_DragEnter;
            this.textBox1.DragDrop += textBox1_DragDrop;
        }

        void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
                

                OpenFile(filenames[0]);
            }
        }

        private void OpenFile(string filename)
        {
            StreamReader sr = new StreamReader(filename , Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();// 關閉 System.IO.StreamReader 物件和基礎資料流，並釋放任何與讀取器 (Reader) 相關聯的系統資源。
            sr.Dispose();//釋放 System.IO.TextReader 物件所使用的所有資源。
        }



        void textBox1_DragEnter(object sender, DragEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
