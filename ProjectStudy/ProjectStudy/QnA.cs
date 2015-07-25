using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectStudy
{
    public partial class QnA : Form
    {
        public QnA()
        {
            InitializeComponent();
        }

        private void staff_Click(object sender, EventArgs e)
        {
            StaffPW mainPW = new StaffPW();
            mainPW.Show();

        }

        private void student_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
