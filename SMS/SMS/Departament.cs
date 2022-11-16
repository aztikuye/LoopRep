using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public class Departament
    {

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int FacultyId { get; set; }

   
        public string GetDepartmentInfo()
        {
            string connstring = " Data Source=.; Initial Catalog= SMS_NEW_2020; Trusted_Connection=True; ";
            string query = "select * from Department";
            SqlDataReader dataReader;
            string output = "";

            using(SqlConnection conn = new SqlConnection(connstring))
            {
                SqlCommand comm= new SqlCommand(query, conn);
                conn.Open();
                dataReader =  comm.ExecuteReader();
                
                while(dataReader.Read())
                { output = output + dataReader.GetValue(1) + "\n";
                }


            }
            return output;

        }
    }
}
