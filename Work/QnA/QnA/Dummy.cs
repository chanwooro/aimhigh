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
        subjectHandler subjecthandler = new subjectHandler();
        public Dummy(string x)
        {
            InitializeComponent();

             parent = x;
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            subjecthandler.insertQuestion(parent, textBox1.Text, textBox2.Text);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
