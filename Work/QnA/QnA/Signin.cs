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
using System.Data.OleDb;

namespace QnA
{
    public partial class Signin : Form
    {
        databaseHandler dbHandler = new databaseHandler();
        public Signin()
        {
            InitializeComponent();
            errormessage.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainStaff mainstaff = new MainStaff();

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\한국말\subjectData.accdb;Persist Security Info=False;");
            con.Open();
            OleDbDataAdapter sda = new OleDbDataAdapter("Select Count(*) From UserIds where USERID='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            Console.WriteLine("한국말");
            //if(dt.Rows[0][0].ToString() == "1")
            if (dt.Rows[0][0].ToString() == "1")
            {
                string username = textBox1.Text;
        
                
                Console.WriteLine("testing :" + dbHandler.loginProperty(username));
                if (dbHandler.loginProperty(username) != "1")
                {
                    Student student = new Student();
                    student.username.Text = "Welcome to AimHigh QnA";
                    student.Show();
                }
                else
                {
                    MainStaff staffMain = new MainStaff();
                    staffMain.username.Text = "Welcome " + username;
                    staffMain.Show();
                    
                }
                this.Hide();
            }
            else
            {
                errormessage.Visible = true;


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
