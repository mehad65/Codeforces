using System;

namespace A._Hulk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("I hate that ");
                }
                else
                {
                    Console.Write("I love that ");
                }
            }
            if (n % 2 != 0)
            {
                Console.Write("I hate it");
            }
            else
            {
                Console.Write("I love it");
            }
        }
    }
}
