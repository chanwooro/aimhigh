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
    public partial class TestLoad : Form
    {
        subjectHandler subjecthandler = new subjectHandler();
        Test test = new Test();
        public TestLoad()
        {
            InitializeComponent();
            listTest();
        }

        public void listTest()
        {
            List<string> x = new List<string>();
            x = subjecthandler.listTest();
            BindingSource bs = new BindingSource();
            bs.DataSource = x;
            comboBox1.DataSource = bs;
            comboBox1.DisplayMember = "TEST";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Select Topic";
        }

        private void loadB_Click(object sender, EventArgs e)
        {
            try
            {
                this.testTopic = comboBox1.SelectedItem.ToString();
                this.listQuestion = subjecthandler.listTestQuestion(this.testTopic);
            }
            catch
            {


            }
            this.Close();
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string testTopic { get; set; }
        public List<Test.TestData> listQuestion { get; set; }
        
    }
}
