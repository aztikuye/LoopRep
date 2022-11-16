using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "max", "Eleni", "Behailu", "Sirgut" };
        
        foreach (var n in name)
            { Console.WriteLine("your name is {0} " ,  n);
             
            }
            

            string word = "Azmera";
            Console.WriteLine(word + " " + word.Length);
            
            for(int k = 0; k <word.Length ; k++)
            { Console.Write(word[k]); }
            Console.WriteLine();
            
            for (int j=word.Length-1; j>=0 ; j--)
            { 
                Console.Write( word[j]) ; }

            Console.WriteLine();

            int i=0;
            while(i< word.Length)
            { Console.Write(word[i]) ; 
                i++;
            }
            
            Console.WriteLine();

            int m = 5;
            do
            {
                Console.Write("Bravo");
                m++;
           }  while(m < 5);  

            for(int s=0; s<10; s++)
            { for (int l=10; l>0; l--)
                    {
                    Console.Write("*");
                    
                         }
                Console.WriteLine();
                    }    
                
                Console.ReadLine();
        }
    }
    }

