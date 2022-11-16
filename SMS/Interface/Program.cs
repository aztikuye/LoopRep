using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department d = new Department();
            Console.WriteLine(d.Graduate());

            Console.ReadLine();
        }
    }
}
