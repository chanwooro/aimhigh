using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace QnA
{
    public partial class newSubQuestion : Form
    {
        int counter = 1;
        int qNumber = 1;
      
        OpenFileDialog ofd = new OpenFileDialog();
        List<string> table;
        MainStaff mainstaff = new MainStaff();
        private static string parent;
        private static string dataSet;
        private static string topicT;
        string picEmp = "";
        subjectHandler subjecthandler = new subjectHandler();
        public newSubQuestion(string x, string y)
        {
            InitializeComponent();
            table = new List<string>();
            topicT = y;
            parent = x;
            ItemType.SelectedIndex = 2;
            // Show existing data on the screen
            bufferHandler();
            
        }

        public void bufferHandler()
        {
            int pointer = 0;
            List<subjectHandler.Data> buffer = subjecthandler.getDatabase(parent, topicT);
            if (buffer.Count != 0){
                // First row can be hardcoded
                textBox_1.Text = buffer[pointer++].contentData;
                if ((buffer[pointer].boxData).Contains("image")){
                    image_1.Text = buffer[pointer++].contentData;
                }
                variable.Text = buffer[pointer++].contentData;
                for (; pointer < buffer.Count; pointer++)
                {
                    dataSet = buffer[pointer].contentData;

                    if((buffer[pointer].boxData).Contains("Question")){
                        createQuestion(addButton.Location.X, addButton.Location.Y, dataSet);

                    }
                    else if ((buffer[pointer].boxData).Contains("Answer"))
                    {
                        createAnswerbox(addButton.Location.X, addButton.Location.Y, dataSet);

                    }
                    else if ((buffer[pointer].boxData).Contains("Images")){
                        createImage(addButton.Location.X, addButton.Location.Y, dataSet);


                    }

                    pushButtons(25);
                }
            }


        }
   
        private void pushButtons(int margin)
        {
            // Move buttons (i.e., create and cancel buttons) up and down
            // Also, the size of window changes accordingly
            ItemType.Location = new System.Drawing.Point(ItemType.Location.X, ItemType.Location.Y + margin);
            addButton.Location = new System.Drawing.Point(addButton.Location.X, addButton.Location.Y + margin);
            createB.Location = new System.Drawing.Point(createB.Location.X, createB.Location.Y + margin);
            cancelB.Location = new System.Drawing.Point(cancelB.Location.X, cancelB.Location.Y + margin);
        }

        private void createQuestion(int x, int y, string text)
        {
            TextBox textbox = new TextBox();
            textbox.Location = new System.Drawing.Point(x+50, y);
            textbox.Size = new System.Drawing.Size(509, 50);
            textbox.Name = "Question" + qNumber;
            textbox.Text = text;
            Console.WriteLine("New Text: " + textbox.Location.X + ", " + textbox.Location.Y);
            this.Controls.Add(textbox);
            createDel(x, y);
        }

        private void createDel(int x, int y)
        {
            Button button = new Button();
            button.Location = new System.Drawing.Point(x, y);
            button.Size = new System.Drawing.Size(40, 20);
            button.Name = counter.ToString();
            button.Text = "Del";
            this.Controls.Add(button);
            counter++;
            button.Click += delLine;
        }

        private void delLine(object sender, EventArgs e)
        {
            int temp = this.Controls.IndexOf((Button)sender)-1;
            this.Controls.Remove((Button)sender);
            this.Controls.RemoveAt(temp);
            fillGaps(temp);
        }

        private void fillGaps(int index)
        {
            Console.WriteLine("Total num: " + this.Controls.Count.ToString() + " / " + index);
            for (int x = index; x < this.Controls.Count; x++)
            {
                this.Controls[x].Location = new System.Drawing.Point(this.Controls[x].Location.X, this.Controls[x].Location.Y - 25);
            }
            pushButtons(-25);
        }

        private void createImage(int x, int y, string text)
        {
            Button button = new Button();
            button.Location = new System.Drawing.Point(x+50, y);
            button.Size = new System.Drawing.Size(509, 20);
            button.Name = "Images" + qNumber;
            button.Text = text;
           // Console.WriteLine("New Image: " + button.Location.X + ", " + button.Location.Y);
            this.Controls.Add(button);
            button.Click += buttonClick;
            createDel(x, y);
        }

        private void createAnswerbox(int x, int y, string text)
        {
            TextBox textbox = new TextBox();
            textbox.Location = new System.Drawing.Point(x+50, y);
            textbox.Size = new System.Drawing.Size(509, 50);
            textbox.Name = "Answer" + qNumber;
            textbox.Text = text;
          
          //  Console.WriteLine("New Answer: " + textbox.Location.X + ", " + textbox.Location.Y);
            this.Controls.Add(textbox);
            createDel(x, y);
            qNumber++;
        }

     



        private void addButton_Click(object sender, EventArgs e)
        {
            if (ItemType.SelectedIndex == 2) createQuestion(addButton.Location.X, addButton.Location.Y, "Please write down Question here");
            else if (ItemType.SelectedIndex == 0) createImage(addButton.Location.X, addButton.Location.Y, "Click here to add image");
            else if (ItemType.SelectedIndex == 1) createAnswerbox(addButton.Location.X, addButton.Location.Y, "Please write down the Answer as Equation");
            pushButtons(25);
            Console.WriteLine("AddBox: " + addButton.Location.X + ", " + addButton.Location.Y);
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int currentPosition = this.Controls.IndexOf((Button)sender);
                this.Controls[currentPosition].Text = ofd.FileName;
                


             

                // Have array created at start. 이메지 버튼이 눌리면 파일파인더 뜨고, 그거 열기하면 Label에 Path가 저장된다.
                // 그리고 그 Path string이 만들어진 Array에 순서대로 저장.

                // 문재 1. 똑같은 이메지 버튼을 2번 사용했을경구 2개가 저장된다. if statement로 아마도 고칠수있다.

            }

        }

        
        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createB_Click(object sender, EventArgs e)
        {
            string directory = @"L:\images"; //set directory for image. need to create folder to a drive where it is shared to other computers

            if(textBox_1.Text != "" && variable.Text != ""){
                try
                {
                    subjecthandler.deleteAll(parent, topicT);
                }
                catch
                {


                }
                
                if(!Directory.Exists(directory)){
                    System.IO.Directory.CreateDirectory(directory);

                }

                nameInsert();
                setText();

                this.Close();
              
            }

            else
            {

                MessageBox.Show("Need to fill text box");


            }


        }

        private void nameInsert(){
            textBox_1.Name = "textBox_1";
            table.Add(textBox_1.Name);

            if (image_1.Text != "Add a picture"){
                image_1.Name = "image_1";
                table.Add(image_1.Name);

            }

            //variable.Name = "textBox_2";
            table.Add(variable.Name);

            foreach (Control c in this.Controls)
            {
                string name = c.Name;
                if (name.Contains("Question") || name.Contains("Images") || name.Contains("Answer"))
                {
                    table.Add(name);

                }


            }

        }

        public void callErrorMessage()
        {
            MessageBox.Show("Please fill variable box in correct way");


        }
        private void setText()
        {
            List<string> contents = new List<string>();
            textBox_1.Text = textBox_1.Text.Replace(Environment.NewLine, "<br />");
            contents.Add(textBox_1.Text);
            string directory = Path.GetDirectoryName(Application.ExecutablePath) + @"\images";

            if (image_1.Text != "Add a picture")
            {
                //copy file in certain directory
                string filename = getFileName(image_1.Text);
                string fullpath = directory + @"\" + filename;
                Console.WriteLine("image_1 full path" + fullpath);
                if(File.Exists(fullpath) && image_1.Text != fullpath){
                    File.Delete(fullpath);
                    File.Copy(image_1.Text, fullpath);
                }
                else if (!File.Exists(fullpath))
                {
                    File.Copy(image_1.Text, fullpath);
                }

                image_1.Text = fullpath;
                contents.Add(image_1.Text);
              
            }
            contents.Add(variable.Text);
         
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Name != "textBox_1" && c.Name != "variable")
                {

                   contents.Add(((TextBox)c).Text);                        

                }
                else if (c is Button && (c.Name).Contains("Images") && ((Button)c).Text != "Click here to add image")
                {
                    //copy file in certain directory.                    
                    string filename = getFileName(((Button)c).Text);
                    string fullpath = directory + @"\" + filename;
                    Console.WriteLine("image full path" + fullpath);
                    if (File.Exists(fullpath) && ((Button)c).Text != fullpath)
                    {
                        File.Delete(fullpath);
                        File.Copy(((Button)c).Text, fullpath);
                    }
                    else if (!File.Exists(fullpath))
                    {
                        File.Copy(((Button)c).Text, fullpath);
                    }
                    ((Button)c).Text = fullpath;
                    contents.Add(((Button)c).Text);
                   

                }         

            }
          


            subjecthandler.insertNewSQ(parent, contents.ToArray() , table.ToArray(), topicT);
            
     


        }

       /* private void setArray(List<string> x, List<string> y)
        {
            arrayContents = x.ToArray();
            arrayNames = y.ToArray();
           
           
           





        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            
            ofd.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif|PNGs|*.png";
            ofd.FilterIndex = 2;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image_1.Text = ofd.FileName.ToString();
                image_1.Name = "Image_1";
                

            }
        }


        private string getFileName(string file)
        {
            string[] arg = file.Split('\\');
            string filename = arg.Last();

            return filename;

        }

        
    }
}
