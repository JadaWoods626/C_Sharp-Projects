using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   
        public abstract class Person 
        {

            public List<string> FirstName { get; set; } 
            public List<string> LastName { get; set; }   


            public virtual void SayName() // virtual Method "SayName"
            {
                //Nested Foreach loops to bring together First and last names and concatenate them into the desired return to console
                foreach (string firstName in FirstName)
                {

                    foreach (string lastName in LastName)
                    {
                        Console.WriteLine("\"" + firstName + "\"" + " " + "\"" + lastName + "\""); 
                    }
                }

            }
        }
}       
