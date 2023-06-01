using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Employee
    {
        public class Employee : Person, IQuittable //new Class Employee inherts from Person Class and has Interface IQuittable 
        {
            public void Quit(string name)
            {

                Console.WriteLine(name + " Quits.");

            }
        }
    }
}
