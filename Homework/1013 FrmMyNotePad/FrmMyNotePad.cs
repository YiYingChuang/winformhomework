using Homework.Properties;
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

namespace Homework._1013_FrmMyNotePad
{
    public partial class FrmMyNotePad : Form
    {
        public FrmMyNotePad()
        {
            InitializeComponent();
            this.openFileDialog1.InitialDirectory="c:\\桌面";
            this.openFileDialog1.Filter = "(*.txt)|*.txt";
            this.saveFileDialog1.InitialDirectory = "c:\\桌面";
            this.saveFileDialog1.Filter = "(*.txt)|*.txt";
            this.saveFileDialog2.InitialDirectory = "c:\\桌面";
            this.saveFileDialog2.Filter = "(*.txt)|*.txt";
            
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMyNotePad f = new FrmMyNotePad();
            f.Show();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
                //this.textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }

        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(openFileDialog1.FileName, false, Encoding.Default);
                sw.Write(textBox1.Text);
                sw.Close();
                sw.Dispose();                
                //File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
            }
            
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog2.FileName, false, Encoding.Default);
                sw.Write(textBox1.Text);
                sw.Close();
                sw.Dispose();
                //File.WriteAllText(saveFileDialog2.FileName, textBox1.Text, Encoding.Default);
            }
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string Do;
        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Do = textBox1.Text;
            this.textBox1.Undo();
            this.復原UToolStripMenuItem.Enabled = false;
        }

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Do;
            this.取消復原RToolStripMenuItem.Enabled = false;
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout f = new FrmAbout();
            f.ShowDialog();
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            FrmMyNotePad f = new FrmMyNotePad();
            f.Show();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
                //this.textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(openFileDialog1.FileName, false, Encoding.Default);
                sw.Write(textBox1.Text);
                sw.Close();
                sw.Dispose();
                //File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
            }
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Multiline=true;
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(this.fontDialog1.ShowDialog()==DialogResult.OK)
            textBox1.Font = this.fontDialog1.Font;
        }

        private void 字型顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.colorDialog1.ShowDialog()==DialogResult.OK)
            textBox1.ForeColor = this.colorDialog1.Color;
        }

        private void 搜尋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Contains(textBox2.Text))
            {
                MessageBox.Show("yessssss");
            }
            else
            {
                MessageBox.Show("NOOOOOOOOOOOOO");

            }

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.復原UToolStripMenuItem.Enabled = true;
            this.取消復原RToolStripMenuItem.Enabled = true;
        }
    }
}
