using System;

namespace A._Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double one = Math.Ceiling(a / 5);
            Console.WriteLine(one);
        }
    }
}
