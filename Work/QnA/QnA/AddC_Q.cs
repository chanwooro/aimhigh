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
    public partial class AddC_Q : Form
    {
        MainStaff main = new MainStaff();
        private static string parent;
        public AddC_Q(string x)
        {

            InitializeComponent();
            parent = x;
            MessageBox.Show(parent);
            
            
        }



    }
}
