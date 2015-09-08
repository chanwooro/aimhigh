using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QnA
{
    public partial class Confirm : Form
    {
        subjectHandler sbj = new subjectHandler();
        private static string test;
        public Confirm(string x)
        {
            test = x;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void deleteB_Click(object sender, EventArgs e)
        {
            this.testListener = "1";
            sbj.deleteTestList(test);            
            this.Close();
        }

        public string testListener { get; set; }
    }
}
