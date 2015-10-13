using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Register
{
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.MaximizeBox = false;
        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection cons = new OdbcConnection("Dsn=QNA");
            cons.Open();
            OdbcDataAdapter sdas = new OdbcDataAdapter("Select Count(*) From UserIds where USERID='" + textBox1.Text + "'", cons);
            DataTable dt = new DataTable();
            sdas.Fill(dt);
            cons.Close();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter User ID");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter User Password");

            }
            else if (textBox3.Text != textBox2.Text)
            {

                MessageBox.Show("Please correct the password");
            }
            else if (textBox4.Text == "")
            {

                MessageBox.Show("Please Enter User name");
            }
            else if (dt.Rows[0][0].ToString() == "1"){

                MessageBox.Show("Account '"+textBox1.Text+"' already exist");

            }
            else
            {
                try
                {
                    OdbcConnection con = new OdbcConnection("Dsn=QNA");
                    con.Open();
                    int x = 0;
                    if (comboBox1.Text == "Student")
                    {
                        x = 2;
                    }
                    else
                    {
                        x = 1;
                    }
                    OdbcCommand cmd = new OdbcCommand("INSERT INTO UserIds (USERID, PASSWORD, IDENTITY, name) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', " + x + ", '" + textBox4.Text + "')", con);
                    OdbcDataAdapter sda = new OdbcDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Account is successfuly generated!");
                }
                catch
                {
                    MessageBox.Show("Database Connection Error");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
