namespace _47_Functions_Methods
{
    class Program
    {
        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static int Ndx(int[] Arr, int value) 
        {
            int result = -1;

            for (int i = 0; i < Arr.Length; i++){
                if (value == Arr[i]) {
                    result = i;
                    break;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);
            Console.WriteLine(c);

            int[] myArray = { 111, 10, 4, 99, 49, 64, 77, 4, 42, 5 };

            int index = Ndx(myArray, 22);
            Console.WriteLine(index);

        }
    }
}
