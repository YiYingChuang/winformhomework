using Lab_02__Y_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework._1013_FrmStudent
{
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newNo, newChi, newEng, newMat;
            int.TryParse(this.textBox1.Text, out newNo);
            int.TryParse(this.textBox2.Text, out newChi);
            int.TryParse(this.textBox3.Text, out newEng);
            int.TryParse(this.textBox4.Text, out newMat);
            if (clsStudent.student.stuList.Count > 1 && newNo <= clsStudent.student.stuList.Count)
            {
                clsStudent.student.stuList[clsStudent.student.stuList.Count - newNo].Chinese = newChi;
                clsStudent.student.stuList[clsStudent.student.stuList.Count - newNo].English = newEng;
                clsStudent.student.stuList[clsStudent.student.stuList.Count - newNo].Math = newMat;
                clsStudent.student.Printtext();
            }
            else
            {
                MessageBox.Show("Input Wrong!");
            }
           
            
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
