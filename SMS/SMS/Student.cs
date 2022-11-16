using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace SMS
{
    public class Student:Person
    {
        public Student()
        { }

        public int StudentId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DOB { get; set; }
        public int DepartmentId { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }



        public string GetStudentInfo()
        {
            //servername, database name, username, pwd, trusted onnn

            //servername.databasename" connection string
            //query command
            //servername=
            string connstring = "Data Source=.;Initial Catalog=SMS_NEW_2020; Trusted_Connection=True;";
            string query = "select * from Student";
            SqlDataReader dataReader;
            string output = "";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                  //  DOB =DateTime.Parse((string) dataReader.GetValue(3) );

                    output = output + dataReader.GetValue(1)   + " " + dataReader.GetValue(2) + ", " + "\n";
                    
                }

            }
            return output;
        }
        public int GetAge()
        {       
            int yrdob= DOB.Year;
            int cyr= DateTime.Now.Year;
            int age= yrdob- cyr;
            return age;
            
        }
    }
}
