using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dui
{
    class DUI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int age = Convert.ToInt32(yourAge);

            Console.WriteLine("Have you ever had a DUI?");
            bool noDui = true;
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string yourTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(yourTickets);
            Console.ReadLine();

            Console.WriteLine("Qualified?");
            bool qualified = (age >= 18 && noDui && tickets <= 3);

            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
