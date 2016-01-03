using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlServerCe;
using System.Data.OleDb;
using System.Data.Odbc;

namespace QnA
{
    class databaseHandler
    {
        protected static OleDbConnection con;
        protected static OleDbDataAdapter sda;
        protected static DataTable dt;
        protected static OleDbCommand cmd;
        protected static OleDbDataReader dr;
        protected static DataSet ds;
        protected static int pKey;
        protected static OleDbCommand rder;
        protected static DataSet dsQuestion;
        protected static OleDbDataAdapter sdaQuestion;
        protected static OleDbParameter picture;
        protected static string dataFileName;
        protected static string connectionString;
        public void openConnection() //"Server=192.168.1.65\\SQLEXPRESS;Database=AimHighData;Integrated Security=true"
        {
            //@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\subjectData.accdb;Persist Security Info=False;"

            con = new OleDbConnection(connectionString);
            con.Open();

        }

        public void setConnectionString(string path){
            Console.WriteLine("Path :" + path);
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=False;";
            

        }

        public void getTopicPrimaryKey(string parent)
        {
            openConnection();
            rder = new OleDbCommand("SELECT Id FROM TopicT WHERE TOPIC='" + parent + "'", con);
            OleDbDataReader dr = rder.ExecuteReader();
            while (dr.Read())
            {
                string key = dr.GetValue(0).ToString();
                pKey = int.Parse(key);


            }
            con.Close();


        }

        public void getQuestionPrimaryKey(string parent, string topicT)
        {
            openConnection();
            rder = new OleDbCommand("SELECT Question.Id FROM Question INNER JOIN TopicT ON TopicT.Id=Question.topicT WHERE Question.QUESTION='" + parent + "' AND TopicT.TOPIC='" + topicT + "'", con);
            OleDbDataReader dr = rder.ExecuteReader();
            while (dr.Read())
            {
                string key = dr.GetValue(0).ToString();
                pKey = int.Parse(key);


            }
            con.Close();


        }

        public void getTestPrimaryKey(string parent)
        {
            openConnection();
            rder = new OleDbCommand("SELECT Id FROM Test WHERE TEST='" + parent + "'", con);
            OleDbDataReader dr = rder.ExecuteReader();
            while (dr.Read())
            {
                string key = dr.GetValue(0).ToString();
                pKey = int.Parse(key);


            }
            con.Close();


        }


        public void getTLQPrimaryKey(string parent, string testParent)
        {
            openConnection();
            rder = new OleDbCommand("SELECT TestListQuestion.Id FROM TestListQuestion INNER JOIN Test ON Test.Id=TestListQuestion.test WHERE TestListQuestion.QUESTION='" + parent + "' AND Test.TEST='" + testParent + "'", con);
            OleDbDataReader dr = rder.ExecuteReader();
            while (dr.Read())
            {
                string key = dr.GetValue(0).ToString();
                pKey = int.Parse(key);


            }
            con.Close();


        }
        public string loginProperty(string x)
        {
            openConnection();
            string value = "";
            rder = new OleDbCommand("SELECT IDENTITY FROM UserIds WHERE USERID='" + x + "'", con);
            dr = rder.ExecuteReader();
            while (dr.Read())
            {
                value = dr.GetValue(0).ToString();


            }
            con.Close();
            Console.WriteLine("Value :" + value);
            return value;
        }



    }
}
