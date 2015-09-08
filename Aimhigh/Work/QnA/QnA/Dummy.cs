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
    public partial class Dummy : Form
    {

   
        private static string parent;
        private static string topicT;
        List<string> lists = new List<string>();
        subjectHandler subjecthandler = new subjectHandler();
        MainStaff mainstaff = new MainStaff();
        public Dummy(string x, List<string> y)
        {
             InitializeComponent();
             parent = x;
             lists = y;
        }

     
        private void button1_Click(object sender, EventArgs e)
        {

            if (lists.Contains(textBox1.Text, StringComparer.OrdinalIgnoreCase))
            {
                
                MessageBox.Show(@"Question : """ + textBox1.Text + @""" already exist");
            }
            else
            {
                subjecthandler.insertQuestion(parent, textBox1.Text, textBox2.Text);

                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
