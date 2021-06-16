using System;

namespace A._Theatre_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long n;
            long m;
            long a;
            var parts = input.Split(" ");
            n = long.Parse(parts[0]);
            m = long.Parse(parts[1]);
            a = long.Parse(parts[2]);

            long m1 = 0;
            long n1 = 0;

            m1 = (m + a - 1) / a;

            n1 = (n + a - 1) / a;

            Console.WriteLine(m1 * n1);
        }
    }
}
