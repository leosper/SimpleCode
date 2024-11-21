using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_ArraysInCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 111, 10, 4, 99, 49, 64, 77, 4, 42, 5 };
            int result = myArray.Max();
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
