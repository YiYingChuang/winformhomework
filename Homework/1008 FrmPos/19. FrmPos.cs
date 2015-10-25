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
    public partial class FrmPos : Form
    {
        public FrmPos()
        {
            InitializeComponent();
        }


        bool select = true;
        private void checkBox5_Click(object sender, EventArgs e)
        {
            this.checkBox1.Checked = select;
            this.checkBox2.Checked = select;
            this.checkBox3.Checked = select;
            this.checkBox4.Checked = select;
            this.checkBox5.Checked = select;
            select = !select;
            
        }

        int A, C, K, S;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                check();
                if (checkBox1.Checked == true | checkBox2.Checked == true | checkBox3.Checked == true | checkBox4.Checked == true)
                {
                    if (radioButton1.Checked == true | radioButton2.Checked == true)
                    {
                        this.label2.Text = (A + C + K + S).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please choose the payment method!!");
                    }
                }
                else 
                {
                    MessageBox.Show("Input something wrong!!");
                }

            }
            catch
            {
                MessageBox.Show("Input something wrong!!");
            }
        }

        const int xxxCoffee = 110;
        void check()
        {
            if (checkBox1.Checked == true)
            {
                A = int.Parse(textBox1.Text) * 30;
            }
            else
            {
                A = 0;
            }

            if (checkBox2.Checked == true)
            {
                C = int.Parse(textBox2.Text) * xxxCoffee;
            }
            else
            {
                C = 0;
            }

            if (checkBox3.Checked == true)
            {
                K = int.Parse(textBox3.Text) * 15;
            }
            else
            {
                K = 0;
            }

            if (checkBox4.Checked == true)
            {
                S = int.Parse(textBox4.Text) * 150;
            }
            else
            {
                S = 0;
            }

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            this.textBox1.Focus();
            this.textBox1.SelectAll();
            checkchange();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            this.textBox2.Focus();
            this.textBox2.SelectAll();
            checkchange();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            this.textBox3.Focus();
            this.textBox3.SelectAll();
            checkchange();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            this.textBox4.Focus();
            this.textBox4.SelectAll();
            checkchange();
        }
        void checkchange()
        {
            if (checkBox1.Checked == false | checkBox2.Checked == false | checkBox3.Checked == false | checkBox4.Checked == false)
            {
                this.checkBox5.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select = true;

            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = checkBox4.Checked =checkBox5.Checked= false;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = label2.Text = "0";
            
            radioButton1.Checked = radioButton2.Checked = false;            
        }
        
         FrmFruitReport report = new FrmFruitReport();
        private void button3_Click(object sender, EventArgs e)
        {
           
            check();        
   
            if (report.IsDisposed ==true)//視窗是否有關掉過，true是關掉過
            {
                report = new FrmFruitReport();

            }
            report.Show();
            
            string radiobtn;
            if (radioButton1.Checked == true)
            {
                radiobtn = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                radiobtn = radioButton2.Text;
            }
            else
            {
                radiobtn = "pay with... --> You didn't buy anything!";
            }

            report.textBox1.Text = string.Format("{0}\r\n {1}\r\n {2}\r\n {3}\r\n {4}\r\n {5}\r\n {6}",
                                                 "You buy:",
                                                 textBox1.Text + "  Apple = NT$ " + A.ToString(),
                                                 textBox2.Text + " box of Cherry = NT$ " + C.ToString(),
                                                 textBox3.Text + " Kiwi = NT$ " + K.ToString(),
                                                 textBox4.Text + " box of Strawberry = NT$" + S.ToString(), 
                                                 "You want to " + radiobtn, 
                                                 "Total Money: " + label2.Text);
            


        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.SelectAll();
        }
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox2.SelectAll();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox3.SelectAll();
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox4.SelectAll();
        }
        
        int change;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox5.Text) - int.Parse(label2.Text) >= 0)
                this.textBox6.Text = (int.Parse(textBox5.Text) - int.Parse(label2.Text)).ToString();

                change = int.Parse(this.textBox6.Text);
                this.label12.Text = (change / 1000).ToString();
                int change_500 = change%1000;
                this.label13.Text = (change_500 / 500).ToString();
                int change_100=change_500%500;
                this.label14.Text = (change_100 / 100).ToString();
                int change_50 = change_100 % 100;
                this.label15.Text = (change_50 / 50).ToString();
                int change_10 = change_50 % 50;
                this.label16.Text = (change_10 / 10).ToString();
                int change_5 = change_10 % 10;
                this.label17.Text = (change_5 / 5).ToString();
                int change_1 = change_5 % 5;
                this.label18.Text = (change_1 / 1).ToString();
               

                
            }
            catch 
            {
                
                
            }
            
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox5.SelectAll();

        }
       
    }
}
