using System;

namespace _40_Indexes_ranges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 111, 10, 4, 99, 49, 64, 77, 4, 42, 5 };
            Console.WriteLine(myArray[myArray.Length - 1]);
            Console.WriteLine(myArray[^1]);

            //Index myIndex = ^2;
            Index myIndex = new Index(3, true);

            //Range myRange = 1..4;
            //Range myRange = new Range(1,4);
            Range myRange = ^4..^1;

            Console.WriteLine(myArray[myIndex]);


            int[] myArray2 = myArray[1..4];
            myArray2 = myArray[1..];

            string str = "Hello World!!!! *)";

            Console.WriteLine(str[^2..]);
            Console.WriteLine(str[0..6]);
            foreach (var item in collection)
            {

            }

        }
    }
}
