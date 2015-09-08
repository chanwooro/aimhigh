using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QnA
{
    public partial class Delete : Form
    {
        subjectHandler handler = new subjectHandler();
        public Delete()
        {
            InitializeComponent();
            List<string> x = new List<string>();
            x = handler.listSubject();
            BindingSource bs = new BindingSource();
            bs.DataSource = x;
    
            comboBox1.DataSource = bs;
            comboBox1.DisplayMember = "TOPIC";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Select Topic";
           
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Select Topic")
            {
                MessageBox.Show("Please Select Topic");

            }
            else
            {
                handler.deleteTopic(comboBox1.Text);
                this.Close();

            }
            
        }


    }
}
