using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QnA
{
    class subjectHandler : databaseHandler
    {
        public void listSubject()
        {
            base.openConnection();
            cmd = new SqlCommand("SELECT TOPIC FROM TopicT", con);
            dr = cmd.ExecuteReader();

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

    }
}
