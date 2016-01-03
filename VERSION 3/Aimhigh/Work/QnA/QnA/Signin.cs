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
using System.Data.Odbc;

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

            OdbcConnection con = new OdbcConnection("Dsn=QNA");
            con.Open();
            OdbcDataAdapter sda = new OdbcDataAdapter("Select Count(*) From UserIds where USERID='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();


            MainStaff staffMain = new MainStaff();
            staffMain.Show();
            this.Hide();
        /*    if (dt.Rows[0][0].ToString() == "1")
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


            }*/


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
