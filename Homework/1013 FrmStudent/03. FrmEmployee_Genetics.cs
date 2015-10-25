using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework._1013_FrmStudent;
using System.Threading;

namespace Lab_02__Y_
{
    public partial class FrmStudent : Form
    {
        int No_ = 1;
        int C, E, M,totalstu_num;
        int highestCh=0, highestEn=0, highestMa=0;
        List<clsStudent> stuList = new List<clsStudent>();
        List<string> name = new List<string>(){"Zoey","Tony","Adam","Isabel","Linda","Harriet","Natasha","Dora",
            "Marian","Tonya","Yolanda","Vivian","Paula","Rachel","Christina","Karen","Upton","Sam","Quentin","Fabian",
            "Antony","Edward","Miranda","Wesley","Joyce","Xenia","Addison","Ryan","Aidan","Wilson","Colin","Damon","Kenny",
            "Evan","Nick","Alfredo"};
        string s1 = string.Format(" {0}\t{1}\t{2}\t{3}\t{4}\r\n", "No. ", "Name", "Chinese", "English", "Math");
        string s3 = string.Format(" {0}\t{1}\t{2}\t{3}\t{4}\r\n", " ", " ", " ", " ", " ");
        public FrmStudent()
        {
            InitializeComponent();
            this.button3.Enabled = this.toolStripButton2.Enabled = this.toolStripButton11.Enabled = false;
            this.textbox5.Text = s1;
           
        }

        private void Addstu_Click(object sender, EventArgs e)
        {
            this.AddStudent();
            this.button3.Enabled = this.toolStripButton2.Enabled = true;
        }

        private void Summery_Click(object sender, EventArgs e)
        {
            this.Summery();                                                                                                                   
        }

        private void Fold_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel1Collapsed = !this.splitContainer2.Panel1Collapsed;
            this.button4.Visible = true;
        }

        private void Add20Random_Click(object sender, EventArgs e)
        {
            int Addrandom = 20;
            this.RandomAddStudent(Addrandom);
            this.button3.Enabled = this.toolStripButton2.Enabled = true;
        }

        private void Add1Random_Click(object sender, EventArgs e)
        {
            int Addrandom = 1;
            this.RandomAddStudent(Addrandom);
            this.button3.Enabled = this.toolStripButton2.Enabled = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            No_ = 1;
            C = E = M = 0;
            highestCh = highestEn = highestMa = 0;
            this.textbox5.Text = s1;
            this.stuList.Clear();
            this.button3.Enabled = this.toolStripButton2.Enabled = false;
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
        void AddStudent()
        {
            clsStudent stu = new clsStudent();
            int Chi, Mat, Eng;
            int.TryParse(this.textBox2.Text, out Chi);
            int.TryParse(this.textBox3.Text, out Mat);
            int.TryParse(this.textBox4.Text, out Eng);
            stu.Name = textBox1.Text;
            stu.Chinese = Chi;
            stu.Math = Mat;
            stu.English = Eng;
            stu.No = this.No_;
            stu.Display=true;
            stuList.Insert(0, stu);
            No_++;
            string s2 = string.Format(" No. {0}\t{1}\t{2}\t{3}\t{4}\r\n", stuList[0].No, stuList[0].Name, stuList[0].Chinese, stuList[0].English, stuList[0].Math);
            this.textbox5.Text += s2;
        }
        void InsertStudent()
        {
            clsStudent stu = new clsStudent();
            int Chi, Mat, Eng;
            int.TryParse(this.textBox2.Text, out Chi);
            int.TryParse(this.textBox3.Text, out Mat);
            int.TryParse(this.textBox4.Text, out Eng);
            stu.Name = textBox1.Text;
            stu.Chinese = Chi;
            stu.Math = Mat;
            stu.English = Eng;
            stu.No = this.No_;
            stu.Display = true;
            stuList.Insert(0, stu);
            string s2 = string.Format(" No. {0}\t{1}\t{2}\t{3}\t{4}\r\n", stuList[0].No, stuList[0].Name, stuList[0].Chinese, stuList[0].English, stuList[0].Math);
            int insertpos = this.textbox5.SelectionStart + s1.Length;
            this.textbox5.Text = this.textbox5.Text.Insert(insertpos, s2);
            No_++;
        }
        void RandomAddStudent(int x)
        {   
            
            Random r = new Random();
          
            for (int i = 0; i < x; i++)
            {
                Thread.Sleep(20);
                clsStudent stu = new clsStudent();
                stu.Name = name[r.Next(0, name.Count)];
                stu.Chinese = r.Next(0, 101);
                stu.Math = r.Next(0, 101);
                stu.English = r.Next(0, 101);
                stu.No = this.No_;
                stu.Display = true;
                stuList.Insert(0, stu);
                string s = string.Format(" No. {0}\t{1}\t{2}\t{3}\t{4}\r\n", stuList[0].No, stuList[0].Name, stuList[0].Chinese, stuList[0].English, stuList[0].Math);
                this.textbox5.Text += s;
                No_++;
            }
        }
        void Sum( )
        {
            C = E =M = totalstu_num =0;
            foreach (var item in this.stuList)
            {
                if (item.Display == true)
                {
                    C = C + item.Chinese;
                    E = E + item.English;
                    M = M + item.Math;
                    totalstu_num++;
                }
            }

            //for (int i = 0; i < stuList.Count; i++)
            //{
            //    c = c + this.stuList[i].Chinese; 
            //    e = e + this.stuList[i].English;    
            //    m = m+ this.stuList[i].Math;
            //}                                                          
            
        }
        void heighest()
        {
            #region 歸零
                //每次開始前先歸零
            highestCh = 0;
            highestEn = 0;
            highestMa = 0;
            //歸零end
            #endregion
          
            if (this.stuList.Count > 1)
            {
                foreach (var item in this.stuList)
                {
                    if (item.Display == true)
                    {
                        if (this.highestCh < item.Chinese)
                        {
                            highestCh = item.Chinese;
                        }
                        if (this.highestEn < item.English)
                        {
                            highestEn = item.English;
                        }
                        if (this.highestMa < item.Math)
                        {
                            highestMa = item.Math;
                        }
                    }
                }

            }
        }
        int Average(int x)
        {
           x= x / ((totalstu_num==0)?1:totalstu_num);
           return x;
        }
        void Summery()
        {
            this.textbox5.Text = s1;
            for (int i = this.stuList.Count - 1; i >= 0; i--)
            {
                if (stuList[i].Display == true)
                {
                    string s2 = string.Format(" No. {0}\t{1}\t{2}\t{3}\t{4}\r\n", stuList[i].No, stuList[i].Name, stuList[i].Chinese, stuList[i].English, stuList[i].Math);
                    this.textbox5.Text += s2;
                }
            }
            this.textbox5.Text += "==========================================\r\n";
            this.Sum();
            this.heighest();
            this.textbox5.Text += string.Format(" {0}\t{1}\t{2}\t{3}\t{4}\r\n", " Sum ", "= ", this.C, this.E, this.M);
            this.textbox5.Text += string.Format(" {0}\t{1}\t{2}\t{3}\t{4}\r\n", " Average ", "= ", this.Average(C), this.Average(E), this.Average(M));
            this.textbox5.Text += string.Format(" {0}{1}\t{2}\t{3}\t{4}\r\n", " Heighest= ", " ", this.highestCh, this.highestEn, this.highestMa); 
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            this.InsertStudent();
            this.button3.Enabled = this.toolStripButton2.Enabled = true;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int x;
            int.TryParse(this.textBox6.Text, out x);
            this.stuList[this.stuList.Count - x].Display=false;
           //this.textbox5.Text= this.textbox5.Text.Remove(this.textbox5.SelectionStart, this.textbox5.SelectionLength);
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.toolStripButton11.Enabled = true;
            //int t;
            //int.TryParse(this.textBox6.Text, out t);
            //if (t <= this.stuList.Count - 1)
            //{                
            //    this.stuList.RemoveAt(t);

            //}
        }

    

    }
      
            
}
