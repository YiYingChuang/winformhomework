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
    public partial class FrmFruitReport : Form
    {
        public FrmFruitReport()
        {
            InitializeComponent();
            
        }

        private void FrmFruitReport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            
        }

        private void FrmFruitReport_FormClosing(object sender, FormClosingEventArgs e)
        {           
            //e.Cancel = true;
        }

        private void FrmFruitReport_MouseDown(object sender, MouseEventArgs e)
        {

        }
               
    }
}
