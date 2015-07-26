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

namespace ProjectStudy
{
    public partial class NewSubject : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public NewSubject()
        {
            
            InitializeComponent();
            errorsign.Visible = false;
            this.MinimumSize = new Size(427, 378);
            this.MaximumSize = new Size(427, 378);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            string subjectname = textBox1.Text;
            string descript = textBox2.Text;
            if (subjectname == "")
            {
                errorsign.Visible = true;

            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\FFrost\Documents\Visual Studio 2013\Projects\335\ProjectStudy\ProjectStudy\Data.mdf;Integrated Security=True");
               
                
                
               
                if (descript == "")
                {
                   

                    SqlCommand cmd = new SqlCommand("INSERT INTO TopicT (TOPIC) VALUES ('" + textBox1.Text + "')", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Update(dt);
                    this.Close();

                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO TopicT (TOPIC, DESCRIPTION) VALUES ('" + textBox1.Text + "', '" +textBox2.Text+ "')", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    this.Close();


                }
            }
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
