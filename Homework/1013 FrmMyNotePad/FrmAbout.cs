using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework._1013_FrmMyNotePad
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
            Version v = Assembly.GetExecutingAssembly().GetName().Version;
            this.label1.Text = string.Format("Version {0}" ,v.ToString());
        }

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
