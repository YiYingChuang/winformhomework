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
    public partial class FrmGame : Form
    {
        bool a, b=true;
        
        public FrmGame()
        {
            InitializeComponent();

            foreach (Control x in this.Controls) //Controls 為表單上所有控制項的集合，Controls繼承自Control
            {
                if (x != button10)
                { 
                x.ForeColor = Color.DarkBlue;//先想想是誰的顏色要變?  變的是所按的button的顏色，
                x.BackColor = Color.LightSalmon;
                x.Click += x_Click; 
                }
                
                              
                
            }           
            
        }

        void x_Click(object sender, EventArgs e)
        {
            //觀念是對的
            //sender.Text = "X"; 
            if(b== false)
            {
                return;  
            }          

            if (a == true)//利用變數
            {
                ((Button)sender).Text = "X";                
                b = true;                
            }
            else
            {
                ((Button)sender).Text = "O";
            }
            a = !a;
            ((Button)sender).Enabled = false;
            check(); 
        }

        bool check()
        {
            if (button1.Text == button2.Text & button2.Text == button3.Text & button3.Text != "")
            {
                MessageBox.Show(button1.Text + "win");                 
                return b =false;
            }
            else if (button4.Text == button5.Text & button5.Text == button6.Text & button6.Text != "")
            {
                MessageBox.Show(button4.Text + "win");
                return b = false;
            }
            else if (button7.Text == button8.Text & button8.Text == button9.Text & button9.Text != "")
            {
                MessageBox.Show(button7.Text + "win");
                return b = false;
            }
            else if (button1.Text == button5.Text & button5.Text == button9.Text & button9.Text != "")
            {
                MessageBox.Show(button1.Text + "win");
                return b = false;
            }
            else if (button3.Text == button5.Text & button5.Text == button7.Text & button7.Text != "")
            {
                MessageBox.Show(button3.Text + "win");
                return b = false;
            }
            else if (button1.Text == button4.Text & button4.Text == button7.Text & button7.Text != "")
            {
                MessageBox.Show(button1.Text + "win");
                return b = false;
            }
            else if (button2.Text == button5.Text & button5.Text == button8.Text & button8.Text != "")
            {
                MessageBox.Show(button2.Text + "win");
                return b = false;
            }
            else if (button3.Text == button6.Text & button6.Text == button9.Text & button9.Text != "")
            {
                MessageBox.Show(button3.Text + "win");
                return b = false;
            }
            else if (button1.Text != "" & button2.Text != "" & button3.Text != "" & button4.Text != "" & button5.Text != "" & button6.Text != "" & button7.Text != "" & button8.Text != "" & button9.Text != "")
            {
                MessageBox.Show("Tie!!");
                return b = false;
            }
            else
            {
                return b=true;
            }
        }

        void again()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                again();
                
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                b = true;
                
                

            }
            
        }

    }
}
