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
    public partial class SubQuestion : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        private static string parent;
        subjectHandler subjecthandler = new subjectHandler();
        public SubQuestion(string x)
        {
            InitializeComponent();
            parent = x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label4.Text == "...")
            {
                label4.Text = null;

            }
            subjecthandler.insertSubQuestion(parent, textBox1.Text, textBox2.Text, textBox3.Text, label4.Text);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                label4.Text = ofd.FileName;


            }
        }
    }
}
