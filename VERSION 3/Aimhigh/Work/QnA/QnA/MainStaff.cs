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
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;


namespace QnA
{


    public partial class MainStaff : Form
    {
        subjectHandler subjecthandler = new subjectHandler();
        List<subjectHandler.Data> answerList;
        List<VariableData> listVariables;
        Calculator calculator = new Calculator();
        public DataSet ds;
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        static int limitCaller = 1;
        private static string displayResult;
        private static int i;
        databaseHandler dbHandler;
        private static string equation;
        
        public MainStaff()
        {
            InitializeComponent();
            initialPanelColor();
            //listTopic();
            addButton.Enabled = false;
            removeButton.Enabled = false;
            newSubject.Enabled = false;
            Console.WriteLine(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
        }
    

        private void MainStaff_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {            
            
            string currentCopyFile = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\FileWriter.accdb";
            sfd.Filter = "access(*.accdb)|*.accdb";
            sfd.OverwritePrompt = true;
            dbHandler = new databaseHandler();
            if(sfd.ShowDialog()  == DialogResult.OK)
            {
                System.IO.File.Copy(currentCopyFile, sfd.FileName.ToString(), true);
                newSubject.Enabled = true;
            }
            try
            {
                dbHandler.setConnectionString(sfd.FileName.ToString());
                listTopic();

            }
            catch
            {

            }

        }
        private void listbox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listQuestion.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string y = comboBox1.Text;
                string x = listQuestion.SelectedItem.ToString();
                newSubQuestion sub = new newSubQuestion(x, y);
                sub.ShowDialog();                
                viewHTML(subjecthandler.getDatabase(x, y), y);


            }
            
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();
            listChapter();
            listTopic();

        }
        private void testButton_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.ShowDialog();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
    
            // code below this is delete.
           // int rowIndex = listBox1.SelectedIndex;
           // ds.Tables["TopicT"].Rows[rowIndex].Delete();



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewHTML(List<subjectHandler.Data> list, string y)
        {

            string x = subjecthandler.getVariable(listQuestion.SelectedItem.ToString(), y);

           
             listVariables= calculator.getQuestionWithRandomNumbers(x);
            
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

                //DESCRIPTION will be added inside "<div id="header>"
                file.WriteLine("</HEAD>\n<BODY>\n\t");
                file.WriteLine(@"<div id=""header"">" + "\n\t</div>");
                file.WriteLine(@"<div id=""body"">"+"\n");
                file.WriteLine(@"<p id=""title"">"+listQuestion.SelectedItem.ToString()+"</p>");
                foreach (var item in list)
                {
                    if ((item.boxData).Contains("Question"))
                    {
                        
                        file.WriteLine(@"<p id=""question"">" + item.contentData + "</p>\n");
                    }

                    else if ((item.boxData).Contains("Images") || (item.boxData).Contains("image"))
                    {
                        file.Write(@"<div id=""image""> <img src="+"\""+item.contentData+"\" ");
                        file.WriteLine(@"class=""Image"" /> </div>");


                    }
                    else if ((item.boxData).Contains("Answer"))
                    {
                        string answer = "\""+item.boxData+"\"";
                        //To see double quote inside the string answer
                        Console.WriteLine(answer);
                        file.Write("<form><input id="+answer+" ");
                        file.WriteLine(@"type=""text"" class=""answerbox""></form>");
                        answerList.Add(new subjectHandler.Data(item.boxData, item.contentData));
                        ansCounter++;

                    }
                    else if((item.boxData).Contains("variable")){

                      // do nothing


                    }
                    else
                    {

                        displayResult = item.contentData;
                        Console.WriteLine(listVariables.Count);
                        if (listVariables.Count != 0)
                        {
                          
                            displayResult = calculator.DisplaySubstitue(item.contentData, listVariables);
                           
                            
                        }
                       
                        file.WriteLine(@"<p id=""paragraph"">" + displayResult + "</p>\n");
                                 
                    }                    
                }


                if (ansCounter != 0)
                {
                    file.WriteLine(@"<button id=""ans"" type=""button"" name=""button"">Submit Answer</button>");
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






        private void listbox1_Click(object sender, MouseEventArgs e)
        {
            try
            {
                string x = listQuestion.SelectedItem.ToString();
                string y = comboBox1.Text;
                List<subjectHandler.Data> list = subjecthandler.getDatabase(x, y);
                viewHTML(list, y);

                removeButton.Enabled = true;
            }
            catch
            {

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = false;

            if (i == 2)
            {
                listChapter();
                addButton.Enabled = true;
                

            }
            else
            {
                i++;


            }
            
          
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Select Topic")
            {
            string x = comboBox1.Text;
            List<string> lists = new List<string>();
                for (int i = 0; i < listQuestion.Items.Count; i++)
                    {
                        lists.Add(listQuestion.Items[i].ToString());

                    }
            Dummy dum = new Dummy(x, lists);
            dum.ShowDialog();
            listChapter();

            }
            else
            {
                MessageBox.Show("Please select a topic");
            }
        }

        public void listChapter()
        {
            List<string> listquestion = new List<string>();
            listquestion = subjecthandler.listQuestions(comboBox1.Text);
            BindingSource bs = new BindingSource();
            bs.DataSource = listquestion;
            listQuestion.DataSource = bs;
            listQuestion.DisplayMember = "QUESTION";
            listQuestion.SelectedIndex = -1;


        }
        public void listTopic()
        {
            List<string> x = new List<string>();
            x = subjecthandler.listSubject();
            BindingSource bs = new BindingSource();
            bs.DataSource = x;
            i = 0;
            comboBox1.DataSource = bs;
            comboBox1.DisplayMember = "TOPIC";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Select Topic";

        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            string x = "";
            try
            {
                x = listQuestion.SelectedItem.ToString();
                string y = comboBox1.Text;
                remove rmv = new remove(x, y);
                rmv.ShowDialog();
                listChapter();
            }
            catch
            {
             

            }
            



        }

        private void normalQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string x = listQuestion.SelectedItem.ToString();
            string y = comboBox1.Text;
            newSubQuestion sub = new newSubQuestion(x, y);
            sub.ShowDialog();

            viewHTML(subjecthandler.getDatabase(x, y), y);
        }

        private void contextAdd_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = this.listQuestion.SelectedItems.Count <= 0;
        }


        private void draw()
        {


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

            //when this counter increase when user get the question right. and When total counter = arrray.count, then it will show user is correct.
            int answerCounter = 0;
            string blocker = "";
            Console.WriteLine("Testing multiple clicks");
            if (mainViewHtml.Document.ActiveElement.TagName == "BUTTON")
            {
                if (mainViewHtml.Document.ActiveElement.Id == "ans")
                {
                    foreach (var result in answerList)
                    {
                        dynamic answer = mainViewHtml.Document.GetElementById(result.boxData).DomElement;
                        Console.WriteLine("what is answer :" + answer);
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
                            
                            if(!double.TryParse(answer.value, out num)){
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
                    
                    
                   // MessageBox.Show(answer.value);


                }


            }
            
        }
        
        

     

        private void getScore(int correct, int total)
        {
            MessageBox.Show("Score:   "+correct+" out of "+total+" correct");

        }

        public struct VariableData
        {

            public string variable { get; private set; }
            public double value { get; private set; }

            public VariableData(string x, double y)
                : this()
            {


                variable = x;
                value = y;

            }



        }

        private void listTest_Click(object sender, EventArgs e)
        {
            ListTest lt = new ListTest();
            lt.Show();
        }

        private void LoadSubject_Click(object sender, EventArgs e)
        {
            ofd.Filter = "All Files|*.*|Access Files|*.accdb";
            ofd.FilterIndex = 2;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dbHandler = new databaseHandler();
                dbHandler.setConnectionString(ofd.FileName.ToString());
                
                listTopic();
                newSubject.Enabled = true;
            }
        }

        private void newSubject_Click(object sender, EventArgs e)
        {
            List<string> lists = new List<string>();
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                lists.Add(comboBox1.Items[i].ToString());

            }       
            NewSubject newsubject = new NewSubject(lists);
            newsubject.ShowDialog();
            //after button function finish update here
            listTopic();
        }

       

    }
}
