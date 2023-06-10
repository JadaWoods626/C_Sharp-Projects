using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee(); 
                                                 
            employee.Quit("Sample Student"); //call Quit method from interface IQuittable

            Console.ReadLine(); // keep console window open
        }
    }
}
