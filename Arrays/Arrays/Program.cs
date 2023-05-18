using System;
using System.Collections.Generic;

namespace Arrays
{
    class Arrays
    {
        static void Main()
        {
            Console.WriteLine("Select an index of the Array");

            List<string> intList = new List<string>();
            intList.Add("Blue");
            intList.Add("Yellow");
            intList.Add("Purple");
            intList.Add("Green");
            intList.Add("Red");
            Console.WriteLine(intList[]);
            if (intList[] >= 4)
            {
                Console.WriteLine("Index Does not exist ");
                Console.ReadLine();
            }
            Console.ReadLine();


            Console.WriteLine("Select an index of the Array");
            int[] numArray = new int[] { 1, 2, 3, 4, 5 };
            numArray[5] = 6;
            Console.WriteLine(numArray[5]);
            Console.ReadLine();

            Console.WriteLine("Select an index of the Array");
            string[] Alphebet = { "a", "b", "c", "d", "e" };
            Console.WriteLine(Alphebet);
        }
    }
}
