using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Console_Number_App
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 - 20");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guessed = number == 8;

            do
            {
                switch (number)
                {
                    default:
                        Console.WriteLine("Hehe nice try but that is not the number");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 12:
                        Console.WriteLine("Cold");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 11:
                        Console.WriteLine("Warmer");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("Warmer");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 9:
                        Console.WriteLine("Hot");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        Console.WriteLine("Let's goooooo!You guessed correctly!");
                        guessed = true;
                        break;

                    case 7:
                        Console.WriteLine("Hot");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 6:
                        Console.WriteLine("Warmer");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("Warmer");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("Cold");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!guessed);
            
            Console.Read();
        }
    }
}
