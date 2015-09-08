using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace QnA
{
    public partial class Student : Form
    {
        subjectHandler subjecthandler = new subjectHandler();
        List<subjectHandler.Data> answerList;
        List<MainStaff.VariableData> listVariables;
        Calculator calculator = new Calculator();
        public DataSet ds;

        static int limitCaller = 1;
        private static string displayResult;
        private static int i;
        private static string equation;
        
        public Student()
        {
            InitializeComponent();
            initialPanelColor();
            listTopic();
        
        }




        private void initialPanelColor()
        {
            SplitterPanel drawPanel = splitContainer1.Panel2;
            drawPanel.BackColor = Color.White;


        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewHTML(List<subjectHandler.Data> list)
        {
            string y = comboBox1.Text;
            string x = subjecthandler.getVariable(listQuestion.SelectedItem.ToString(), y);


            listVariables = calculator.getQuestionWithRandomNumbers(x);

            // Create HTML
            string urls = Application.StartupPath + "/text.html";
            answerList = new List<subjectHandler.Data>();
            if (listQuestion.Name == "Chapter")
            {
                try
                {
                    int ansCounter = 0;
                    // Delete the file if it exists. 
                    if (File.Exists(urls))
                    {
                        File.Delete(urls);
                    }

                    StreamWriter file = new System.IO.StreamWriter(urls);
                    file.WriteLine("<!DOCTYPE html PUBLIC \"-//IETF//DTD HTML 2.0//EN\">\n");
                    file.WriteLine("<HTML>\n\t<HEAD>\n");
                    file.WriteLine(@"<link rel=""stylesheet"" type=""text/css"" href=""style.css""/>");

                    //DESCRIPTION will be added inside "<div id="header>"
                    file.WriteLine("</HEAD>\n<BODY>\n\t");
                    file.WriteLine(@"<div id=""header"">" + "\n\t</div>");
                    file.WriteLine(@"<div id=""body"">" + "\n");
                    file.WriteLine(@"<p id=""title"">" + listQuestion.SelectedItem.ToString() + "</p>");
                    foreach (var item in list)
                    {
                        if ((item.boxData).Contains("Question"))
                        {

                            file.WriteLine(@"<p id=""question"">" + item.contentData + "</p>\n");
                        }

                        else if ((item.boxData).Contains("Images") || (item.boxData).Contains("image"))
                        {
                            file.Write(@"<div id=""image""> <img src=" + "\"" + item.contentData + "\" ");
                            file.WriteLine(@"class=""Image"" /> </div>");


                        }
                        else if ((item.boxData).Contains("Answer"))
                        {
                            string answer = "\"" + item.boxData + "\"";
                            //To see double quote inside the string answer
                            file.Write("<form><input id=" + answer + " ");
                            file.WriteLine(@"type=""text"" class=""answerbox""></form>");
                            answerList.Add(new subjectHandler.Data(item.boxData, item.contentData));
                            ansCounter++;

                        }
                        else if ((item.boxData).Contains("variable"))
                        {

                            // do nothing


                        }
                        else
                        {

                            displayResult = item.contentData;
                            if (listVariables.Count != 0)
                            {

                                displayResult = calculator.DisplaySubstitue(item.contentData, listVariables);


                            }

                            file.WriteLine(@"<p id=""paragraph"">" + displayResult + "</p>\n");

                        }
                    }


                    if (ansCounter != 0)
                    {
                        file.WriteLine(@"<button id=""ans"" type=""button"" name=""button"">Submit Answer </button>");
                    }
                    file.WriteLine("</div>\n");

                    file.WriteLine("\n</p>\n</BODY>\n</HTML>");
                    file.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else if(listQuestion.Name =="Test")
            {
                try
                {
                    int ansCounter = 0;
                    // Delete the file if it exists. 
                    if (File.Exists(urls))
                    {
                        File.Delete(urls);
                    }

                    StreamWriter file = new System.IO.StreamWriter(urls);
                    file.WriteLine("<!DOCTYPE html PUBLIC \"-//IETF//DTD HTML 2.0//EN\">\n");
                    file.WriteLine("<HTML>\n\t<HEAD>\n");
                    file.WriteLine(@"<link rel=""stylesheet"" type=""text/css"" href=""style.css""/>");

                    //DESCRIPTION will be added inside "<div id="header>"
                    file.WriteLine("</HEAD>\n<BODY>\n\t");
                    file.WriteLine(@"<div id=""header"">" + "\n\t</div>");
                    file.WriteLine(@"<div id=""body"">" + "\n");
                    file.WriteLine(@"<p id=""title""> This is Test :" + listQuestion.SelectedItem.ToString() + "</p>");
                    file.WriteLine(@"<p id=""question"">This is test. Be honest with yourself while doing the test. Your skills will not improve if you do cheat/Internet Browsing</p> <p id=""question""> This is for your sake </p>");
                    file.WriteLine(@"<button id=""ans"" type=""button"" name=""button"">Start Test </button>");
                    file.WriteLine("\n</p>\n</BODY>\n</HTML>");
                    file.Close();
                }
                catch
                {


                }

                
            }
            // Show HTML
            mainViewHtml.Navigate(new Uri(urls));
        }


        public void listTest()
        {
            List<string> x = new List<string>();
            x = subjecthandler.listTest();
            BindingSource bs = new BindingSource();
            bs.DataSource = x;
            listQuestion.DataSource = bs;
            listQuestion.DisplayMember = "TEST";
            listQuestion.SelectedIndex = -1;
            listQuestion.Name = "Test";
            listQuestion.Text = "Select Test";

        }
  



        private void listbox1_Click(object sender, MouseEventArgs e)
        {
            try
            {
                string x = listQuestion.SelectedItem.ToString();
                string y = comboBox1.Text;
                List<subjectHandler.Data> list = subjecthandler.getDatabase(x, y);
                viewHTML(list);
            }
            catch
            {

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {    
            if (i == 2)
            {
                if (comboBox1.Name == "Topic")
                {
                    listChapter();
                }
               
            }
            else
            {
                i++;
            }


        }



        public void listChapter()
        {
            if (comboBox1.Text != "Select Topic")
            {
                List<string> listquestion = new List<string>();
                listquestion = subjecthandler.listQuestions(comboBox1.Text);
                BindingSource bs = new BindingSource();
                bs.DataSource = listquestion;
                listQuestion.DataSource = bs;
                listQuestion.DisplayMember = "QUESTION";
                listQuestion.SelectedIndex = -1;
                listQuestion.Name = "Chapter";
            }
            else
            {
                listQuestion.DataSource = null;

            }


        }
        public void listTopic()
        {
            List<string> x = new List<string>();
            x = subjecthandler.listSubject();
            BindingSource bs = new BindingSource();
            bs.DataSource = x;
            i = 0;
            comboBox1.DataSource = bs;
            comboBox1.Name = "Topic";
            comboBox1.DisplayMember = "TOPIC";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Select Topic";

        }




        private void contextAdd_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = this.listQuestion.SelectedItems.Count <= 0;
        }




        private void mainViewHtml_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            limitCaller = 1;
            //this keep added.
            if (limitCaller == 1)
            {
                mainViewHtml.Document.Click -= new HtmlElementEventHandler(DocumentClick);
                mainViewHtml.Document.Click += new HtmlElementEventHandler(DocumentClick);
            }


             
        }

        // x = result.contentData   


        public void DocumentClick(object sender, HtmlElementEventArgs e)
        {
            int answerCounter = 0;
            string blocker = "";

            if (mainViewHtml.Document.ActiveElement.TagName == "BUTTON")
            {
                if (comboBox1.Name == "Test")
                {
                    string y = listQuestion.SelectedItem.ToString();
                    TestPerform testperform = new TestPerform(subjecthandler.listTestQuestion(y), y);
                    testperform.ShowDialog();
                }
                else
                {
                    
                        if (mainViewHtml.Document.ActiveElement.Id == "ans")
                        {
                            foreach (var result in answerList)
                            {
                                dynamic answer = mainViewHtml.Document.GetElementById(result.boxData).DomElement;
                                try
                                {
                                    string correctAnswer = calculator.getAnswer(result.contentData, listVariables);

                                    //check whether the answer in html box and answer in answerList is same

                                    double correct = double.Parse(correctAnswer, CultureInfo.InvariantCulture);
                                    double student = double.Parse(answer.value, CultureInfo.InvariantCulture);
                                    double percent = student / correct;
                                    Console.WriteLine("Result :" + correctAnswer);
                                    if (percent > 0.98 && percent < 1.02)
                                    {
                                        Console.WriteLine("correct/student" + correct / student);
                                        answerCounter++;
                                    }

                                    blocker = "";


                                }
                                catch
                                {
                                    double num;

                                    if (!double.TryParse(answer.value, out num))
                                    {
                                        MessageBox.Show("Please Enter Numbers");

                                    }
                                    else
                                    {
                                        MessageBox.Show("Please fill out answer box");

                                    }
                                    blocker = "1";
                                }
                            }

                            if (answerCounter == answerList.Count)
                            {
                                getScore(answerCounter, answerList.Count);
                                Console.WriteLine("everthing is correct");
                            }
                            else if (answerCounter != answerList.Count && blocker == "")
                            {
                                getScore(answerCounter, answerList.Count);
                            }
                        }
                }
            }




            

           
        }

        private void getScore(int correct, int total)
        {
            MessageBox.Show("Score:   " + correct + " out of " + total + " correct");

        }

        private void problemB_Click(object sender, EventArgs e)
        {

            comboBox1.Enabled = true;
            listTopic();
            listChapter();
            emptyHTML();
        }

        private void testB_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Select Test";
            comboBox1.Name = "Test";
            comboBox1.Enabled = false;
            listTest();
            emptyHTML();
       
        }
        private void emptyHTML()
        {
            Console.WriteLine("EMPTY");
            string urls = Application.StartupPath + "/text.html";
            if (File.Exists(urls))
            {
                File.Delete(urls);
            }
            StreamWriter file = new System.IO.StreamWriter(urls);
            file.WriteLine("<!DOCTYPE html PUBLIC \"-//IETF//DTD HTML 2.0//EN\">\n");
            file.Close();
            mainViewHtml.Navigate(new Uri(urls));
        }

       
    }
}
