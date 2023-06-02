using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();     
            Employee<int> employee2 = new Employee<int>();    

            employee.things = new List<string>() { "Daniel is " }; 
            employee2.things = new List<int>() { 24 }; 

            foreach (string thing in employee.things) // loop through "things"
            {
                foreach (int thing2 in employee2.things)

                {
                    Console.WriteLine(thing + thing2); 
                }
            }

            Console.ReadLine(); 

        }
    }
    }
}
