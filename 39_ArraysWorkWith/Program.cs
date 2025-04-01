using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_ArraysWorkWith
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 111, 10, 4, 99, 49, 64, 77, 4, 42, 5 };
            Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());
            Console.ReadLine();
            int[] result = myArray.Distinct().ToArray();

            Array.Find(result, i => i < 70);
            Array.FindLast(result, i => i < 70);

            Array.FindIndex;
            Array.FindLastIndex;

            myArray.Where(i => i % 2 != 0).First;
            myArray.Where(i => i % 2 != 0).FirstOrDefault;


        }
    }
}
