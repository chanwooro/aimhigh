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
    public partial class ListTest : Form
    {
        subjectHandler subjecthandler = new subjectHandler();
        private static int i = 0;
        List<Test.TestData> topic;
        public ListTest()
        {
            InitializeComponent();
            topic = new List<Test.TestData>();

        }



        
        public void listTest()
        {
            List<string> x = new List<string>();
            x = subjecthandler.listTest();
            BindingSource bs = new BindingSource();
            bs.DataSource = x;
            testLister.DataSource = bs;
            testLister.DisplayMember = "TEST";
            testLister.SelectedIndex = -1;
            testLister.Text = "Select Test";

        }
        public void listTestQuestion()
        {
            if (testLister.Text != "Select Test")
            {
                List<Test.TestData> listquestion = new List<Test.TestData>();
                listquestion = subjecthandler.listTestQuestion(testLister.Text);
                topic = listquestion;
                BindingSource bs = new BindingSource();
                bs.DataSource = listquestion.Select(a =>a.question);
                questionLister.DataSource = bs;
            }else{
                questionLister.DataSource = null;
             
            }
            

        }
        private void subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i == 2)
            {
                topic.Clear();
                listTestQuestion();
                
            }
            else
            {
                i++;
            }
            

        }
        private void ListTest_Load(object sender, EventArgs e)
        {            
            listTest();
            listTestQuestion();
        }
        private void testList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = questionLister.SelectedIndex;            
            preview pv = new preview(questionLister.SelectedItem.ToString(), topic[index].topic);
            pv.Show();
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (testLister.Text == "Select Test")
            {
                MessageBox.Show("Please Select Test");

            }
            else
            {
                Confirm cfm = new Confirm(testLister.Text);
                cfm.ShowDialog();
                if (cfm.testListener == "1")
                {
                    listTest();
                    listTestQuestion();
                }
            }
        }
    }
}
