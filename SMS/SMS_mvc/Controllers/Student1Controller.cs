using Microsoft.AspNetCore.Mvc;
using SMS_mvc.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SMS_mvc.Controllers
{
    public class Student1Controller : Controller
    {
      
        public IActionResult Index()
        {
            string connstring = "Data Source=,; Initial Catalog=SMS_NEW_2020; Trusted_Connection=True;";
            string query = "Select * from Student";
            SqlDataReader dataReader;
            //string output;
            List<Student> model = new List<Student>();

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlCommand comm = new SqlCommand(query, conn);
                comm.Connection.Open();
                dataReader = comm.ExecuteReader(); List<Student> students = new List<Student>();


                while (dataReader.Read())
                {
                    model.Add(new Student
                    {
                        StudentId = int.Parse(dataReader.GetValue(0).ToString()),
                        FName = dataReader.GetValue(1).ToString(),
                        LName = dataReader.GetValue(2).ToString(),
                        Gender = dataReader.GetValue(3).ToString()
                    }); 

                }

            }
            return View();
        }
    }
}
