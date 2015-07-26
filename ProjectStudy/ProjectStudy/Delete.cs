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
    public partial class Delete : Form
    {

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Delete()
        {
            InitializeComponent();
            checkedListBox1.Update();
          
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            confirmation x = new confirmation();
       
            var res = x.ShowDialog();

            if (res == DialogResult.OK)
            {
               
                foreach (string s in checkedListBox1.CheckedItems)
                {

                       
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\FFrost\Documents\Visual Studio 2013\Projects\335\ProjectStudy\ProjectStudy\Data.mdf;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM TopicT WHERE TOPIC='"+s+"'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        

                    
                }

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        checkedListBox1.Items.RemoveAt(i);


                    }



                }

                    

            }
        
           
        }

        private void init()
        {
            DataEntities db = new DataEntities();
            var group = from d in db.TopicTs
                        select d.TOPIC;
            checkedListBox1.Items.AddRange(group.ToArray());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.checkedListBox1.Refresh();
        }
    }


}
