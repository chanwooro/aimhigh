using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QnA
{
    public partial class TestPerform : Form
    {
        subjectHandler subjecthandler = new subjectHandler();
        public List<Test.TestData> itemLists;
        List<MainStaff.VariableData> listVariables;
        List<string> records = new List<string>();
        Calculator calculator = new Calculator();
        List<subjectHandler.Data> answerList;
        private static string displayResult;
        private static string testTopic;
        public string[] answers;
        static int counter = 0;        //Counter - sets current question.
        static int answerCounter = 0;  // count correct answer done by user.
        static int questionNumber = 1;  // questionNumber is used displaying 1,2,3,4,5 on question.
        public TestPerform(List<Test.TestData> x, string parent)
        {
            counter = 0;
            answerCounter = 0;
            InitializeComponent();
            itemLists = x;
            answers = new string[itemLists.Count];
            testTopic = parent;
            startTest();  // start test.
            
        }

        private void startTest()
        {
            
            int lastQuestion = itemLists.Count; // counts number of questions inside test
            if (counter < lastQuestion) // do test if current question is not last question.
            {
                try
                {
                    string x = itemLists[counter].question; // get current question name
                    List<subjectHandler.Data> list = subjecthandler.getTestDatabase(x, testTopic); // get data from TestContents table. (this is exact copy from table SQ)
                    
                    viewHTML(list, x); // viewHTML draws HTML codes
                    counter++; // next question
                    questionNumber++; //display question number increase.
                }
                catch
                {

                }
            }
            else //if its last question
            {
                if (records.Count != 0) //if there are any incorrect answer
                {
                    string recording= "";
                    foreach (string item in records)
                    {
                        recording = recording+item +"\n";
                    }
                    MessageBox.Show("Score:  " + answerCounter + " out of " + lastQuestion + " correct \n\nList of Questions incorrect:\n"+recording);
                    /*question1
                     * queston2
                     * queston3                     
                     */
               
                }
                else
                {
                    MessageBox.Show("Score:  " + answerCounter + " out of " + lastQuestion + " correct");
                    
                }
                questionNumber = 1;
                counter = 0;
                answerCounter = 0;
                this.Close();
            }
        }
        private void prevQuestion()
        {
            

        }
        private void viewHTML(List<subjectHandler.Data> list, string y) //string y is used as display question name. List<data> list is used as displaying data
        {

            string x = subjecthandler.getTestVariable(y, testTopic);
            

            listVariables = calculator.getQuestionWithRandomNumbers(x);

            // Create HTML
            string urls = Application.StartupPath + "/text.html";
            answerList = new List<subjectHandler.Data>();
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

                file.WriteLine("</HEAD>\n<BODY>\n\t");
                file.WriteLine(@"<div id=""header"">" + "\n\t</div>");
                file.WriteLine(@"<div id=""body"">" + "\n");
                file.WriteLine(@"<p id=""title"">"+questionNumber+". "+ y + "</p>");
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
                        Console.WriteLine("Write ANSWER BOX");
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
                    file.WriteLine(@"<button id=""ans"" type=""button"" name=""button"">Next </button>");
                }
                file.WriteLine("</div>\n");

                file.WriteLine("\n</p>\n</BODY>\n</HTML>");
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // Show HTML
            mainViewHtml.Navigate(new Uri(urls));
        }
        private void mainViewHtml_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            int limitCaller = 1;
            //this keep added.
            if (limitCaller == 1)
            {
                mainViewHtml.Document.Click -= new HtmlElementEventHandler(DocumentClick); // -ing first and +ing next prevents multiple click error
                mainViewHtml.Document.Click += new HtmlElementEventHandler(DocumentClick);
            }



        }
        public void DocumentClick(object sender, HtmlElementEventArgs e)
        {

            //when this counter increase when user get the question right. and When total counter = arrray.count, then it will show user is correct.
            int subAnswer = 0;
            string blocker = "";

            if (mainViewHtml.Document.ActiveElement.TagName == "BUTTON")
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

                            if (percent > 0.98 && percent < 1.02) // a sub question inside the main question correct then subAnswer increase. 
                            {
                                subAnswer++;
                                
                            }
                            else
                            {
                                int index = counter - 1;
                              
                                records.Add(itemLists[index].question.ToString());                               
                                
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

                    if (subAnswer == answerList.Count) // subquestion corrected answer equals to number of sub questions of the main question
                    {
                        answerCounter++;
                        startTest(); // leads to next question


                    }
                    else
                    {
                        startTest(); // leads to next question


                    }
                }
            }
        }





    }
}
