using System;
using System.Collections.Generic;

namespace Six_Part_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an index of the Array");
            int[] numArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Please input a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input >= numArray.Length)
            {
                Console.WriteLine("Index Does not exist ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(numArray[input]);
            }
            Console.ReadLine();


            Console.WriteLine("Guess a number between 1 - 10");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guess = number == 3;

            //I made my infinite loop into a while statement
            while (guess == false)
            {
                switch (number)
                {
                    case 22:
                        Console.WriteLine("Great job on guessing correctly!");
                        guess = true;
                        break;

                    case 100:
                        Console.WriteLine("Not quite right, try again");
                        Console.WriteLine("Guess a number between 1 - 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 21:
                        Console.WriteLine("So Close, try again");
                        Console.WriteLine("Guess a number between 1 - 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 1:
                        Console.WriteLine("Nice try but that is not correct");
                        Console.WriteLine("Guess a number between 1 - 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Nope, Try again");
                        Console.WriteLine("Guess a number between 1 - 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }


        }
    }
}
