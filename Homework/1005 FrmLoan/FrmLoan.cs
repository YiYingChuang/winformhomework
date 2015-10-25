using Homework._1005_FrmLoan;
using Lab_01._1005_loan_report;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_01._1005_貸款
{
    public partial class FrmLoan : Form
    {
        public FrmLoan()
        {
            InitializeComponent();
            claLoan.floan = this;
        }

        internal void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        internal void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        internal void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        internal void button1_Click(object sender, EventArgs e)
        {                  
            var final = this.myvoid();
            MessageBox.Show("每月需付" + final + "元");                       
           
        }

        internal void button2_Click(object sender, EventArgs e)
        {
            try
            {
            double final = this.myvoid();
            final = double.Parse(textBox2.Text) * final;            
            MessageBox.Show("需付" + final + "元");
            }
            catch 
            {
                
               
            }
           
           
        }
        internal  static double final, TotalPay;
        internal double myvoid()
        {
            try
            {
                double t1, t2, t3;
                t1=double.Parse(textBox1.Text);
                t2 = double.Parse(textBox2.Text);
                t3 = double.Parse(textBox3.Text); 
                final = Financial.Pmt(t1/12 , t2 , -t3, 0, DueDate.EndOfPeriod); 
                return final;
            }
            catch 
            {
                MessageBox.Show("Please input again!");
                return 0;
            }                                       
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        FrmLoanReport another = new FrmLoanReport();

        public void button3_Click(object sender, EventArgs e)
        {           
           try
           {              
               another.Show();
               final = this.myvoid();
               TotalPay = double.Parse(textBox2.Text) * final;
               another.label3.Text = final + "元";
               another.label4.Text = TotalPay + "元";


           }
           catch 
           {
               
              
           }
        }
    }
}
