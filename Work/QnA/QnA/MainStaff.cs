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
        public MainStaff()
        {
            InitializeComponent();
        }

        private void MainStaff_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewSubject newsubject = new NewSubject();
            newsubject.Show();
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
            delete.Show();


        }

       
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
