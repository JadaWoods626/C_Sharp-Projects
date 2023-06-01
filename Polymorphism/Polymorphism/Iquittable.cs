using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Iquittable
    {
        interface IQuittable // interface called IQuittable
        {
            //void Quit(Employee employee); //void method called Quit
            void Quit(string name);
        }
    }
}
