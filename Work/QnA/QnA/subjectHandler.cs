using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace QnA
{
    class subjectHandler : databaseHandler
    {

        
        
        public List<string> listSubject()
        {
            base.openConnection();
           
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOPIC FROM TopicT", con);
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
            SqlDataAdapter sdaQuestion = new SqlDataAdapter("SELECT QUESTION FROM Question INNER JOIN TopicT ON TopicT.Id=Question.topicT AND TopicT.Id='" + pKey + "'", con);
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
            
            base.openConnection();
            if (x != null)
            {

                cmd = new SqlCommand("INSERT INTO TopicT (TOPIC, DESCRIPTION) VALUES ('" + j + "', '" + x + "')", con);
                sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
               
               
                con.Close();



            }
            else
            {
                cmd = new SqlCommand("INSERT INTO TopicT (TOPIC) VALUES ('" + j + "')", con);
                sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
            }



        }

        public void insertQuestion(string parent, string qname, string descrption)
        {
            base.getTopicPrimaryKey(parent);
            base.openConnection();


            if (descrption != null)
            {
                cmd = new SqlCommand("INSERT INTO Question (QUESTION, DESCRIPTION, topicT) VALUES ('" + qname + "', '" + descrption + "', '" + pKey + "')", con);
                sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();


            }
            else
            {
                cmd = new SqlCommand("INSERT INTO Question (QUESTION, topicT) VALUES ('" + qname + "', '" + pKey + "')", con);
                sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();


            }

        }

        public void insertSubQuestion(string question, string answer, string equation, string subQues, string img )
        {
            base.getQuestionPrimaryKey(question);
            base.openConnection();
            if (equation != null && img != null)
            {
                cmd = new SqlCommand("INSERT INTO SubQuestion (QuestionId, Answer, Equation, ques, image) VALUES ('" + pKey + "', '" + answer + "', '" + equation + "', '" + subQues + "', '" + img + "')", con);
                sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();


            }
            else if (equation == null && img != null)
            {
                cmd = new SqlCommand("INSERT INTO SubQuestion (QuestionId, Answer, ques, image) VALUES ('" + pKey + "', '" + answer + "',  '" + subQues + "', '" + img + "')", con);
                sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();


            }
            else if (equation != null && img == null)
            {
                cmd = new SqlCommand("INSERT INTO SubQuestion (QuestionId, Answer, Equation, ques) VALUES ('" + pKey + "', '" + answer + "', '" + equation + "', '" + subQues + "')", con);
                sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();

            }
            else
            {
                cmd = new SqlCommand("INSERT INTO SubQuestion (QuestionId, Answer, ques) VALUES ('" + pKey + "', '" + answer + "', '" + subQues + "')", con);
                sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                con.Close();

            }

        }

        

        public void deleteSubject(string x)
        {




        }

        public void deleteChapter()
        {



        }


        public void deleteQuestion()
        {





        }




    }
}
