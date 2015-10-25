using Homework._1005_FrmLoan;
using Lab_01._1005_貸款;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_01._1005_loan_report
{
    public partial class FrmLoanReport : Form
    {
        public FrmLoanReport()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "= " +  "元";
            label4.Text = "= " +  "元";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label6.Text = "= "+claLoan.floan.textBox3.Text;
        }
    }
}
