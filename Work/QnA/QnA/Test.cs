using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QnA
{
    public partial class Test : Form
    {
        subjectHandler subjecthandler = new subjectHandler();
        List<TestData> lists;
        private static int i;
        public Test()
        {
            InitializeComponent();

            lists = new List<TestData>();
        }



        private void createButton_Click(object sender, EventArgs e)
        {

            int checker = Regex.Matches(testName.Text, @"[a-zA-Z]").Count;
            //string exists = subjecthandler.testNameChecker(testName.Text);
            if (checker == 0)
            {
                MessageBox.Show("Please fill out test name");

            }
            else if (lists.Count < 5)
            {
                MessageBox.Show("Each test needs at least 5 Questions");

            }
            /*else if(exists == "0"){
                MessageBox.Show(@"Test : """+testName.Text+ @""" already exist");
            }*/
            else
            {
                try
                {
                    subjecthandler.deleteTest(testName.Text);

                }
                catch
                {

                }
                subjecthandler.insertTest(testName.Text);
                foreach (var item in lists.ToArray())
                {
                    subjecthandler.insertTestQuestions(testName.Text, item.question, item.topic);
                    subjecthandler.insertTestContents(item.question, item.topic, testName.Text);
                }

                this.Close();
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void addQuestion_Click(object sender, EventArgs e)
        {
            string topic = subject.Text;
            string selected = questionList.SelectedItem.ToString();
            testList.Items.Add(selected);
            lists.Add(new TestData(selected, topic));
            
        }


        private void subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i == 2)
            {
                
                listChapter();
            }
            else
            {
                i++;
            }

        }
        public void listTopic()
        {
            List<string> x = new List<string>();
            x = subjecthandler.listSubject();
            BindingSource bs = new BindingSource();
            bs.DataSource = x;
            subject.DataSource = bs;
            subject.DisplayMember = "TOPIC";
            subject.SelectedIndex = -1;
            subject.Text = "Select Topic";         

        }
        public void listChapter()
        {
            if (subject.Text != "Select Topic")
            {
                List<string> listquestion = new List<string>();
                listquestion = subjecthandler.listQuestions(subject.Text);
                BindingSource bs = new BindingSource();
                bs.DataSource = listquestion;
                questionList.DataSource = bs;

            }
            else
            {
                questionList.DataSource = null;

            }

        }

        private void questionList_DoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string topic = subject.Text;
                string selected = questionList.SelectedItem.ToString();
                testList.Items.Add(selected);
                lists.Add(new TestData(selected, topic));
            }
            catch
            {


            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                int index = testList.SelectedIndex;
                testList.Items.RemoveAt(index);
                lists.RemoveAt(index);
                
            }
            catch
            {


            }
        }

        private void testList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = testList.SelectedIndex;
            preview pv = new preview(testList.SelectedItem.ToString(), lists[index].topic);
            pv.Show();
        }

        private void loadList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TestLoad tl = new TestLoad();
            tl.ShowDialog();
            if(testList.Items.Count!=0){
                testList.Items.Clear();
                lists.Clear();
            }
            if(tl.testTopic != null){
                testName.Text = tl.testTopic;

            }

            if (tl.listQuestion != null)
            {
                foreach (var item in tl.listQuestion)
                {
                    lists.Add(new TestData(item.question, item.topic)); // So list format is : QuestionName (0), TestName (1) this is due to same question name in different Test and prevent calling wrong Question.
                    testList.Items.Add(item.question);

                }
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {
            listTopic();
            listChapter();
        }
        public struct TestData
        {

            public string question{ get; private set; }
            public string topic { get; private set; }

            public TestData(string x, string y)
                : this()
            {


                question = x;
                topic = y;

            }



        }

      
        
    }
}
