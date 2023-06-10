using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();  
            Employee employee2 = new Employee();    

            employee.FirstName = new List<string>() { "John" }; 
            employee.LastName = new List<string>() { "Cena" }; 
            employee.Id = 1;    //add value of 1 to employee property 


            employee2.FirstName = new List<string>() { "Chris" }; 
            employee2.LastName = new List<string>() { "Evans" }; 
            employee2.Id = 2;   //add value of 2 to employee2 property




            Console.WriteLine((employee == employee2)); // display result of if equals, could also return if not equal !=

            Console.ReadLine(); 

        }
    }
}
