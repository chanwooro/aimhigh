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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
            errormessage.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainStaff mainstaff = new MainStaff();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\FFrost\Desktop\Aimhigh\Work\QnA\QnA\Database\authentication.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From UserIds where USERID='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {

                MainStaff staffMain = new MainStaff();
                staffMain.Show();
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
