using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QnA
{
    public partial class NewSubject : Form
    {
        subjectHandler subjecthandler = new subjectHandler();
        List<string> lists = new List<string>();
        public NewSubject(List<string> x)
        {
            InitializeComponent();
            errorsign.Visible = false;
            lists = x;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lists.Contains(textBox1.Text, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show(@"Subject : """ + textBox1.Text + @""" already exist");
            }
            else { 
            //When submit commited 2 sql Query required.
            subjecthandler.insertSubject(textBox1.Text, textBox2.Text);
         
            this.Close();
        }
       }
    }
}
