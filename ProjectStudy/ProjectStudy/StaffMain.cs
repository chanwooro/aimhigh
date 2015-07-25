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
    public partial class StaffMain : Form
    {
        int buttonOffSet;
        public StaffMain()
        {
            InitializeComponent();

            buttonOffSet = this.Width - button1.Width;
        }

        private void StaffMain_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NWSubject_Click(object sender, EventArgs e)
        {
            NewSubject nwsbj = new NewSubject();
            nwsbj.Show();
        }

        private void StaffMain_Resize(object sender, EventArgs e)
        {
           


        }

        private int getButtonWidth()
        {
            return this.Width / 2 - buttonOffSet;


        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            Delete deletebutton = new Delete();
            deletebutton.Show();
        }
    }
}
