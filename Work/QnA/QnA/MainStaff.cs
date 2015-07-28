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

namespace QnA
{
    public partial class MainStaff : Form
    {
        subjectHandler subjecthandler = new subjectHandler();
        public DataSet ds;
        
        public MainStaff()
        {
            InitializeComponent();

            // VERY BASIC STEPS TO DISPLAY LISTBOX;
           /* List<string> x = new List<string>();
            x.Add("ONE");
            listBox1.DataSource = x;*/
            List<string> x = new List<string>();
            x = subjecthandler.listSubject();          
            BindingSource bs = new BindingSource();
            bs.DataSource = x;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "TOPIC";
            listBox1.SelectedIndex = -1;

        }

        private void MainStaff_Load(object sender, EventArgs e)
        {

           
            
            
            
           
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewSubject newsubject = new NewSubject();
            newsubject.ShowDialog();
            //after button function finish update here
            List<string> x = new List<string>();
            x = subjecthandler.listSubject();
            BindingSource bs = new BindingSource();
            bs.DataSource = x;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "TOPIC";
            listBox1.SelectedIndex = -1;
            

        }
        private void listbox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string x = listBox1.SelectedItem.ToString();
                Dummy dum = new Dummy(x);
                dum.ShowDialog();


            }
            
        }

     

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();


        }

       
        private void button3_Click(object sender, EventArgs e)
        {
    
            // code below this is delete.
           // int rowIndex = listBox1.SelectedIndex;
           // ds.Tables["TopicT"].Rows[rowIndex].Delete();
          


        }

        private void button4_Click(object sender, EventArgs e)
        {

           /* SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\FFrost\Desktop\Work\QnA\QnA\subjectData.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string x = "41";
           SqlCommand rder = new SqlCommand("SELECT Id FROM TopicT WHERE TOPIC='"+x+"'", con);
           SqlDataReader rd = rder.ExecuteReader();
        
               button4.Text = rd.GetValue(0).ToString();*/

          
         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listbox1_Click(object sender, MouseEventArgs e)
        {
            
            
            List<string> listquestion = new List<string>();
            listquestion = subjecthandler.listQuestions(listBox1.SelectedItem.ToString());
            BindingSource bs = new BindingSource();
            bs.DataSource = listquestion;
            listBox2.DataSource = bs;
            listBox2.DisplayMember = "QUESTION";
            listBox2.SelectedIndex = -1;
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox2.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string y = listBox2.SelectedItem.ToString();
                SubQuestion sub = new SubQuestion(y);
                sub.ShowDialog();


            }
        }
    }
}
