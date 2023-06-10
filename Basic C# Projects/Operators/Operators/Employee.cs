using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
  
        public class Employee   
        {
            public int Id { get; set; } // public int class property Id
            public List<string> FirstName { get; set; } 
            public List<string> LastName { get; set; }  



            public static bool operator ==(Employee id1, Employee id2) // overloading operator ==
            {
                return (id1.Id == id2.Id); // returns boolean result of equals to objects compared

            }
            public static bool operator !=(Employee id1, Employee id2) // overloading operator !=
            {
                return (id1.Id != id2.Id);  // returns boolean result of not equals to objects compared

            }
        }
}
