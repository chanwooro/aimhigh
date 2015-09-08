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
    public partial class remove : Form
    {
        private static string parent;
        private static string topicT;
        subjectHandler handler = new subjectHandler();

        public remove(string x, string y)
        {
            InitializeComponent();
            parent = x;
            topicT = y;
            chapter.Text = parent;

        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            handler.deleteChapter(parent, topicT);
            
            this.Close();
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
 
            this.Close();
        }
    }
}
