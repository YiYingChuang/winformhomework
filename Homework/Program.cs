using Homework._1013_FrmMyNotePad;
using Lab_01;
using Lab_01._1005_loan_report;
using Lab_01._1005_貸款;
using Lab_02__Y_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmStudent());
        }
    }
}
