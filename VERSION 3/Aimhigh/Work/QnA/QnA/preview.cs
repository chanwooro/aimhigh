using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QnA
{
    public partial class preview : Form
    {
        subjectHandler subjecthandler = new subjectHandler();
        List<MainStaff.VariableData> listVariables;
        Calculator calculator = new Calculator();
        private static string displayResult;
        private static string topicT;
        public preview(string x, string y)
        {
            InitializeComponent();
            string name = x;
            topicT = y;
            List<subjectHandler.Data> list = subjecthandler.getDatabase(name, topicT);
            viewHTML(list, name, topicT);
        }
        
        private void viewHTML(List<subjectHandler.Data> list, string y, string topicT)
        {

            string x = subjecthandler.getVariable(y, topicT);


            listVariables = calculator.getQuestionWithRandomNumbers(x);

            // Create HTML
            string urls = Application.StartupPath + "/text.html";

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
                file.WriteLine(@"<p id=""title"">" + y.ToString()+ "</p>");
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
                        Console.WriteLine(answer);
                        file.Write("<form><input id=" + answer + " ");
                        file.WriteLine(@"type=""text"" class=""answerbox""></form>");

                        ansCounter++;

                    }
                    else if ((item.boxData).Contains("variable"))
                    {

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

            // Show HTML
            previewHTML.Navigate(new Uri(urls));
        }
    }
}
