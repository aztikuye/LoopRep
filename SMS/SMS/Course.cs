using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class Course:Student
    {
        public int CourseNo { get; set; }
        public string CourseTitle { get; set; }
        public int CreditHr { get; set; }

        public string GetCourseInfo()
        {
            string connstring = "Data Source=.; Initial Catalog=SMS_NEW_2020; Trusted_Connection=True;";
            string query = "select * from Course";
            SqlDataReader dataReader;
            string output = "";

            using(SqlConnection conn = new SqlConnection(connstring))
            {
                SqlCommand comm= new SqlCommand(query, conn);
                conn.Open();
                dataReader = comm.ExecuteReader();

                while(dataReader.Read())
                {
                    output=output + dataReader.GetValue(1) + ", " + dataReader.GetValue(2) + "\n";
                }
            }
           return output;
        }

    }
}
