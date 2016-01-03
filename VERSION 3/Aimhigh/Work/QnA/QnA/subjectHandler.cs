using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data.Odbc;
namespace QnA
{
    class subjectHandler : databaseHandler
    {

        static int counter = 1;
        static int limiter = 2;
        string y;

        public string testNameChecker(string x)
        {
            base.openConnection();
            string identify;
            OleDbDataAdapter sda = new OleDbDataAdapter("Select Count(*) From Test WHERE TEST='" + x + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            if (dt.Rows[0][0].ToString() != "0")
            {
                Console.WriteLine("No Test name exist");
                identify = "0";
            }
            else
            {
                Console.WriteLine("Test name exsit");
                identify = "1";

            }

            return identify;
        }
        public List<string> listSubject()
        {
            base.openConnection();

            OleDbDataAdapter sda = new OleDbDataAdapter("SELECT TOPIC FROM TopicT", con);
            ds = new DataSet();
            sda.Fill(ds, "TopicT");
            List<string> topics = new List<string>();
            foreach (DataRow row in ds.Tables["TopicT"].Rows)
            {
                topics.Add(row["TOPIC"].ToString());

            }
            con.Close();
            return topics;
        }

        public List<string> listQuestions(string topic)
        {

            base.getTopicPrimaryKey(topic);
            base.openConnection();
            OleDbDataAdapter sdaQuestion = new OleDbDataAdapter("SELECT QUESTION FROM Question,TopicT WHERE TopicT.Id=Question.topicT AND TopicT.Id=" + pKey + "", con);
            dsQuestion = new DataSet();
            sdaQuestion.Fill(dsQuestion, "Question");
            List<string> question = new List<string>();
            foreach (DataRow row in dsQuestion.Tables["Question"].Rows)
            {
                question.Add(row["QUESTION"].ToString());

            }
            con.Close();
            return question;
        }

       
        public void insertSubject(string j, string x)
        {
            createTopicTable();
            base.openConnection();
            if (x != null)
            {

                cmd = new OleDbCommand("INSERT INTO TopicT (TOPIC, DESCRIPTION) VALUES ('" + j + "', '" + x + "')", con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();



            }
            else
            {
                cmd = new OleDbCommand("INSERT INTO TopicT (TOPIC) VALUES ('" + j + "')", con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
            }



        }

        public void insertQuestion(string parent, string qname, string descrption)
        {
            createQuestionTable();

            base.getTopicPrimaryKey(parent);
            base.openConnection();
            if (descrption != null)
            {
                cmd = new OleDbCommand("INSERT INTO Question (QUESTION, DESCRIPTION, topicT) VALUES ('" + qname + "', '" + descrption + "', " + pKey + ")", con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();
            }
            else
            {
                cmd = new OleDbCommand("INSERT INTO Question (QUESTION, topicT) VALUES ('" + qname + "', " + pKey + ")", con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();


            }

        }


        /*public void insertSubQuestion(string question, string answer, string equation, string subQues, string img)
        {
            createSQTable();
            base.getQuestionPrimaryKey(question);
            base.openConnection();
            if (equation != null && img != null)
            {
                cmd = new OleDbCommand("INSERT INTO SubQuestion (QuestionId, Answer, Equation, ques, image) VALUES (" + pKey + ", '" + answer + "', '" + equation + "', '" + subQues + "', '" + img + "')", con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();


            }
            else if (equation == null && img != null)
            {
                cmd = new OleDbCommand("INSERT INTO SubQuestion (QuestionId, Answer, ques, image) VALUES (" + pKey + ", '" + answer + "',  '" + subQues + "', '" + img + "')", con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();


            }
            else if (equation != null && img == null)
            {
                cmd = new OleDbCommand("INSERT INTO SubQuestion (QuestionId, Answer, Equation, ques) VALUES (" + pKey + ", '" + answer + "', '" + equation + "', '" + subQues + "')", con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();

            }
            else
            {
                cmd = new OleDbCommand("INSERT INTO SubQuestion (QuestionId, Answer, ques) VALUES (" + pKey + ", '" + answer + "', '" + subQues + "')", con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();

            }

        }*/


        public void insertNewSQ(string parent, string[] contents, string[] names, string topicT)
        {
            createSQTable();
            base.getQuestionPrimaryKey(parent, topicT);
            base.openConnection();
            string insert = "";

            for (int i = 0; i < contents.Length; i++)
            {
                //y = i + " varchar(255)";
                //y = string.Join(", ", y);
                //Problem when reinserting

                insert = "INSERT INTO SQ VALUES ('" + names[i] + "', '" + contents[i] + "', " + pKey + ")";


                cmd = new OleDbCommand(insert, con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();

            }


            // cmd = new SqlCommand("INSERT INTO TopicT (TOPIC) VALUES ('"+ contents[0]+ "')", con);

            con.Close();
        }
        
        private void createSQTable()
        {
            try
            {
                base.openConnection();

                string tablename = "SQ"; //+ counter.ToString();
                string create = "CREATE TABLE " + tablename + " (Boxes varchar(255), contents varchar(255), Question int FOREIGN KEY REFERENCES Question(Id) ON DELETE CASCADE)";
                cmd = new OleDbCommand(create, con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                counter++;
            }
            catch
            {


            }


        }
        private void createQuestionTable()
        {
            try
            {
                base.openConnection();

                string tablename = "SQ"; //+ counter.ToString();
                string create = "CREATE TABLE Question (Id int IDENTITY(1,1) NOT NULL , QUESTION varchar(128) NULL, topicT int FOREIGN KEY REFERENCES topicT(Id) ON DELETE CASCADE, DESCRIPTION varchar(MAX), PRIMARY KEY (Id))";
                cmd = new OleDbCommand(create, con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {


            }


        }
        private void createTopicTable()
        {
            try
            {
                base.openConnection();


                string create = "CREATE TABLE TopicT (Id int IDENTITY(1,1) NOT NULL , TOPIC varchar(64) NOT NULL, DESCRIPTION varchar(MAX), PRIMARY KEY (Id))";
                cmd = new OleDbCommand(create, con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {


            }

        }



        public void deleteChapter(string parent, string topicT)
        {
            base.getTopicPrimaryKey(topicT);
            base.openConnection();
            string chapter = "DELETE FROM Question WHERE QUESTION='" + parent + "' AND topicT="+pKey+"";
            try
            {
                cmd = new OleDbCommand(chapter, con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();
            }
            catch
            {


            }
            con.Close();


        }
        public void deleteTestList(string test)
        {
            base.openConnection();
            string delete = "DELETE FROM Test WHERE TEST='"+test+"'";
            try
            {
                cmd = new OleDbCommand(delete, con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            con.Close();

        }

        public void deleteTopic(string selected)
        {
            base.openConnection();
            string topic = "DELETE FROM TopicT WHERE TOPIC='" + selected + "'";
            cmd = new OleDbCommand(topic, con);
            sda = new OleDbDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            con.Close();


        }

        public void insertTest(string testName)
        {
            base.openConnection();
            cmd = new OleDbCommand("INSERT INTO Test (TEST) VALUES ('" + testName + "')", con);
            sda = new OleDbDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            con.Close();
            



        }

        public void insertTestQuestions(string testName, string question, string topic)
        {
            base.getTestPrimaryKey(testName);
            base.openConnection();
            cmd = new OleDbCommand("INSERT INTO TestListQuestion (QUESTION, test, subject) VALUES ('" + question + "', " + pKey + ", '" + topic + "')", con);
            sda = new OleDbDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void insertTestContents(string parent, string topicT, string testParent)
        {
            base.getQuestionPrimaryKey(parent, topicT);
            int qPK = pKey;
            base.getTLQPrimaryKey(parent, testParent);//???????????????????
            base.openConnection();
            try
            {
                cmd = new OleDbCommand("INSERT INTO TestContents (Boxes, contents, TLQ) SELECT Boxes, contents, " + pKey + " FROM SQ WHERE Question=" + qPK + "", con);
                sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
          
            con.Close();
        }


        public void deleteAll(string parent, string topicT)
        {
            base.getQuestionPrimaryKey(parent, topicT);
            base.openConnection();
            string delete = "DELETE FROM SQ WHERE Question=" + pKey + "";
            cmd = new OleDbCommand(delete, con);
            sda = new OleDbDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public void deleteTest(string test)
        {
            base.openConnection();
            string delete = "DELETE FROM Test WHERE TEST='" + test + "'";
            cmd = new OleDbCommand(delete, con);
            sda = new OleDbDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public List<string> listTest()
        {
            OleDbDataAdapter sda = new OleDbDataAdapter("SELECT TEST FROM Test", con);
            ds = new DataSet();
            sda.Fill(ds, "Test");
            List<string> test = new List<string>();
            foreach (DataRow row in ds.Tables["Test"].Rows)
            {
                test.Add(row["TEST"].ToString());

            }
            con.Close();
            return test;

        }
        public List<Test.TestData> listTestQuestion(string parent)
        {
            base.getTestPrimaryKey(parent);
            base.openConnection();
            cmd = new OleDbCommand("SELECT QUESTION, subject FROM TestListQuestion,Test WHERE Test.Id=TestListQuestion.test AND Test.Id=" + pKey + "", con);
            dr = cmd.ExecuteReader();
            List<Test.TestData> question = new List<Test.TestData>();
            while(dr.Read())
            {
                question.Add(new Test.TestData(dr[0].ToString(), dr[1].ToString()));

            }

           
            con.Close();
            return question;
        }
        public string getVariable(string parent, string topicT)
        {
            base.getQuestionPrimaryKey(parent, topicT);
            base.openConnection();

            try
            {
                string variable = "";
                cmd = new OleDbCommand("SELECT contents FROM SQ WHERE Question=" + pKey + " AND Boxes='variable'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    variable = dr[0].ToString();

                }
                return variable;

            }

            catch
            {
                return "";

            }


        }
        public string getTestVariable(string parent, string testParent)
        {
            base.getTLQPrimaryKey(parent, testParent);
            base.openConnection();

            try
            {
                string variable = "";
                cmd = new OleDbCommand("SELECT contents FROM TestContents WHERE TLQ=" + pKey + " AND Boxes='variable'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    variable = dr[0].ToString();

                }
                return variable;

            }

            catch
            {
                return "";

            }


        }

        public List<Data> getDatabase(string parent, string topicT)//
        {
            //base.getTopicPrimaryKey(topicT);
            //int topicKey = pKey;
            base.getQuestionPrimaryKey(parent, topicT);
            base.openConnection();
            try
            {
                List<Data> dataList = new List<Data>();
                string command = "SELECT Boxes, contents FROM SQ WHERE SQ.Question=" + pKey + ""; //((SQ INNER JOIN Question ON SQ.Question=Question.Id) INNER JOIN topicT ON topicT.Id=Question.topicT) AND topicT.Id = "+topicKey+"

                cmd = new OleDbCommand(command, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {



                    dataList.Add(new Data(dr[0].ToString(), dr[1].ToString()));




                }

                con.Close();
                return dataList;
            }
            catch
            {
                var list = new List<Data>();
                con.Close();
                return list;
            }

    

        }
        public List<Data> getTestDatabase(string parent, string testParent)
        {
            base.getTLQPrimaryKey(parent, testParent);
            base.openConnection();
            try
            {
                List<Data> dataList = new List<Data>();
                string command = "SELECT Boxes, contents FROM TestContents WHERE TLQ=" + pKey + "";

                cmd = new OleDbCommand(command, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {



                    dataList.Add(new Data(dr[0].ToString(), dr[1].ToString()));




                }

                con.Close();
                return dataList;
            }
            catch
            {
                var list = new List<Data>();
                con.Close();
                return list;
            }



        }


        public struct Data
        {

            public string boxData { get; private set; }
            public string contentData { get; private set; }

            public Data(string x, string y)
                : this()
            {


                boxData = x;
                contentData = y;

            }



        }



    }

}
