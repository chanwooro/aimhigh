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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
            startup();
            viewData();
        }

        private void createB_Click(object sender, EventArgs e)
        {
            Registeration rgst = new Registeration();
            rgst.ShowDialog();
            viewData();
        }

        private void viewData()
        {
            OdbcConnection con = new OdbcConnection("Dsn=QNA");
            con.Open();
            OdbcDataAdapter sda = new OdbcDataAdapter("SELECT name, USERID AS ID, PASSWORD AS PW FROM UserIds", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "UserIds");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "UserIds";

        }

        private void startup()
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=QNA");
                con.Open();
                OdbcCommand cmd = new OdbcCommand("ALTER TABLE UserIds ADD name text;", con);
                OdbcDataAdapter sda = new OdbcDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {

            }

        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            
        
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                Confirm cf = new Confirm();
                DialogResult dr = cf.ShowDialog();
                if (dr == DialogResult.OK)
                {
                OdbcConnection con = new OdbcConnection("Dsn=QNA");
                con.Open();
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    OdbcCommand cmd = new OdbcCommand("DELETE FROM UserIds WHERE USERID='" + item.Cells["ID"].Value.ToString() + "'", con);
                    OdbcDataAdapter sda = new OdbcDataAdapter(cmd);
                    cmd.ExecuteNonQuery();                    
                   
                }
                con.Close();
                viewData();
                }
            }
            else
            {
                MessageBox.Show("Please Select Correct Item");
            }
            
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new OdbcConnection("Dsn=QNA");
            con.Open();
          
          
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT name, USERID AS ID, PASSWORD AS PW FROM UserIds WHERE name LIKE '%" + textBox1.Text + "%' OR USERID LIKE '%"+textBox1.Text+"%'", con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "UserIds");
                con.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "UserIds";      
            
        }

        private void resetB_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            viewData();
        }
    }
}
