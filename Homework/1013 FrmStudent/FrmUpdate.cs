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
            FrmStudent stu = new FrmStudent();
            int newNo, newChi, newEng, newMat;
            int.TryParse(this.textBox1.Text, out newNo);
            int.TryParse(this.textBox2.Text, out newChi);
            int.TryParse(this.textBox3.Text, out newEng);
            int.TryParse(this.textBox4.Text, out newMat);
            stu.stuList[stu.stuList.Count - newNo].Chinese = newChi;
            stu.stuList[stu.stuList.Count - newNo].English = newEng;
            stu.stuList[stu.stuList.Count - newNo].Math = newMat;
            stu.stuList[stu.stuList.Count - newNo].Display = true;

        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
