using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Department : Istudent
    {
        public string Attendance()
        {
            return "Department level Attendance";
        }

        public string CourseAssign()
        {
            return "Facultiy Course is done";                ;
        }

        public string Grade()
        {
            return "Grade is A";
        }

        public string Graduate()
        {
            return "student graduated";
        }

        public string Register()
        {
            return "registration completed";
        }
    }
}
