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
using System.Threading;

namespace ProjectStudy
{
    public partial class confirmation : Form
    {

        public confirmation()
        {
            InitializeComponent();
        }

        private void deleteB_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
          
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
