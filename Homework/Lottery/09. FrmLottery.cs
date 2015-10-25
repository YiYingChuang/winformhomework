using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02__Y_
{
    public partial class FrmLottery : Form
    {
        public FrmLottery()
        {
            InitializeComponent();
            this.ChooseNumber(winner);
            this.button5.Enabled = this.button6.Enabled = false;

        }
        List<int> LotteryNumber = new List<int>();
        List<int> winner = new List<int>();
        List<string> 對獎結果 = new List<string>();
        List<int> WinningTime = new List<int>();
        List<int> WinNo = new List<int>();
        List<int> WinOnce = new List<int>();
        List<int> WinTwice = new List<int>();
        List<int> WinThree = new List<int>();
        List<int> WinFour = new List<int>();
        List<int> WinFive = new List<int>();
        List<int> WinSix = new List<int>();
        int No_=0;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string s = string.Format("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t", winner[0], winner[1], winner[2], winner[3], winner[4], winner[5]);
            this.textBox1.Text = s;
            this.button1.Enabled = false;
            this.button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> buy = new List<int>();
            this.ChooseNumber(buy);    
            this.textBox2.Text += this.Printtext(buy);
            this.CheckNumber(buy);
            No_++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            No_ = 0;
            winner.Clear();
            this.button1.Enabled = true;
            this.button5.Enabled = this.button6.Enabled = false;
            this.timer1.Enabled = false;
            this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = "";
            this.對獎結果.Clear();
            this.WinningTime.Clear();
            this.WinNo.Clear();
            this.WinOnce.Clear();
            this.WinTwice.Clear();
            this.WinThree.Clear();
            this.WinFour.Clear();
            this.WinFive.Clear();
            this.WinSix.Clear();
            this.ChooseNumber(winner);
        }
        void lottery()
        {
            LotteryNumber.Clear();
            for (int i = 1; i < 43; i++)
            {
               
                LotteryNumber.Add(i);
            }
        }
        void ChooseNumber(List<int> x)
        {
            lottery();
            Random r = new Random();
            Thread.Sleep(20);
            for (int i = 0; i < 6; i++)
            {
                int n = r.Next(1, LotteryNumber.Count);
                x.Add(LotteryNumber[n]);
                LotteryNumber.RemoveAt(n);
            }
            x.Sort();
        }
        string Printtext(List<int> x)
        {
            string s = string.Format("No.{0}:\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\r\n",No_, x[0], x[1], x[2], x[3], x[4], x[5]);
            return s;
        }
        void CheckNumber(List<int> x)
        {
            string text = "";
            int WinningNum=0;
            text += string.Format("No.{0}:\t", No_);
            for (int j = 0; j < winner.Count; j++)
            {
                for (int i = 0; i < x.Count; i++)
                {
                    if (winner[j] == x[i])
                    {
                        string s = string.Format("numer {0} win\t", x[i]);
                        text += s;
                        WinningNum++;
                    }
                }
            }
            text += "\r\n";
            this.對獎結果.Add(text);
            this.CheckWinTime(WinningNum);
        }
        void CheckWinTime(int x)
        {
            int i = 1;
            if (x == 0)
            {
                this.WinNo.Add(i);
            }
            else if (x == 1)
            {
                this.WinOnce.Add(i);
            }
            else if (x == 2)
            {
                this.WinTwice.Add(i);
            }
            else if (x == 3)
            {
                this.WinThree.Add(i);
            }
            else if (x == 4)
            {
                this.WinFour.Add(i);

            }
            else if (x == 5)
            {
                this.WinFive.Add(i);
            }
            else if (x == 6)
            { this.WinSix.Add(i); }
        }
        double Progress(double x)
        {
            int total = this.WinNo.Count + this.WinOnce.Count + this.WinTwice.Count +
                        this.WinThree.Count + this.WinFour.Count + this.WinFive.Count + this.WinSix.Count;
            if (total != 0)
            {

                x = x / total * 100;
            }
            else
            {
                x = 0;
            }
            return x;
        }
        double Progress2(double x)
        {
            int total = this.WinNo.Count + this.WinOnce.Count + this.WinTwice.Count +
                        this.WinThree.Count + this.WinFour.Count + this.WinFive.Count + this.WinSix.Count;
            if (total != 0)
            {

                x = x / total;
            }
            else
            {
                x = 0;
            }
            return x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox3.Clear();
            this.button6.Enabled = true;
            for (int i = 0; i < this.對獎結果.Count; i++)
            {
                this.textBox3.Text += this.對獎結果[i];
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<int> buy = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                this.ChooseNumber(buy);
                this.textBox2.Text += this.Printtext(buy);
                this.CheckNumber(buy);
                No_++;
                buy.Clear();
            }
            
            //Random r = new Random();
            //for (int i = 1; i <= 10; i++)
            //{
            //    lottery();
            //    for (int j = 0; j < 6; j++)
            //    {
            //        int n = r.Next(1, LotteryNumber.Count);
            //        buy.Add(LotteryNumber[n]);
            //        LotteryNumber.RemoveAt(n);
            //    }
            //    buy.Sort();
                //this.textBox2.Text += this.Printtext(buy);
                //this.CheckNumber(buy);
                //No_++;
                //buy.Clear();
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmLotteryReport f = new FrmLotteryReport();
            double No, One, Two, Three, Four, Five, Six;
            No = this.WinNo.Count;
            One = this.WinOnce.Count;
            Two = this.WinTwice.Count;
            Three = this.WinThree.Count;
            Four = this.WinFour.Count;
            Five = this.WinFive.Count;
            Six = this.WinSix.Count;

            f.progressBar1.Value = (int)this.Progress(No);
            f.progressBar2.Value = (int)this.Progress(One);
            f.progressBar3.Value = (int)this.Progress(Two);
            f.progressBar4.Value = (int)this.Progress(Three);
            f.progressBar5.Value = (int)this.Progress(Four);
            f.progressBar6.Value = (int)this.Progress(Five);
            f.progressBar7.Value = (int)this.Progress(Six);

            f.label8.Text = this.Progress2(No).ToString("P1");
            f.label9.Text = this.Progress2(One).ToString("P1");
            f.label10.Text = this.Progress2(Two).ToString("P1");
            f.label11.Text = this.Progress2(Three).ToString("P1");
            f.label12.Text = this.Progress2(Four).ToString("P1");
            f.label13.Text = this.Progress2(Five).ToString("P1");
            f.label14.Text = this.Progress2(Six).ToString("P1");
            f.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<int> buy = new List<int>();

            this.ChooseNumber(buy);
            this.textBox2.Text += this.Printtext(buy);
            this.CheckNumber(buy);
            No_++;
            buy.Clear();

            //Random r = new Random();
            //lottery();
            //for (int j = 0; j < 6; j++)
            //{
            //    int n = r.Next(1, LotteryNumber.Count);
            //    buy.Add(LotteryNumber[n]);
            //    LotteryNumber.RemoveAt(n);
            //}
            //buy.Sort();
            //this.textBox2.Text += this.Printtext(buy);
            //this.CheckNumber(buy);
            //buy.Clear();
            //this.textBox3.Text += this.對獎結果[No_];
            //No_++;
        }

        

        

        

        
       
    }
}
