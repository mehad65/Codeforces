using System;

namespace A._Domino_piling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arr = input.Split(" ");
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);

            decimal c = a * b;
            decimal d = decimal.Floor(c/2);

            Console.WriteLine(d);
        }
    }
}
