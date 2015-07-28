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
        protected static DataSet ds;
        protected static int pKey;
        protected static SqlCommand rder;
        protected static DataSet dsQuestion;
        protected static SqlDataAdapter sdaQuestion;
        public void openConnection()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\FFrost\Desktop\Work\QnA\QnA\subjectData.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

        }

        public void getTopicPrimaryKey(string parent)
        {
            openConnection();
            rder = new SqlCommand("SELECT Id FROM TopicT WHERE TOPIC='" + parent + "'", con);
            SqlDataReader rd = rder.ExecuteReader();
            while (rd.Read())
            {
                string key = rd.GetValue(0).ToString();
                pKey = int.Parse(key);


            }
            con.Close();


        }

        public void getQuestionPrimaryKey(string parent)
        {
            openConnection();
            rder = new SqlCommand("SELECT Id FROM Question WHERE QUESTION='" + parent + "'", con);
            SqlDataReader rd = rder.ExecuteReader();
            while (rd.Read())
            {
                string key = rd.GetValue(0).ToString();
                pKey = int.Parse(key);


            }
            con.Close();


        }



    }
}
