using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QnA
{
    class databaseHandler
    {
        protected static SqlConnection con;
        protected static SqlDataAdapter sda;
        protected static DataTable dt;
        protected static SqlCommand cmd;
        protected static SqlDataReader dr;
        public void openConnection()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\FFrost\Desktop\Aimhigh\Work\QnA\QnA\subjectData.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

        }

    }
}
