using System;

namespace A._Even_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(" ");
            long n = Convert.ToInt64(arr[0]);
            long k = Convert.ToInt64(arr[1]);
            

            if (n % 2 == 0)
            {
                if (k <= n / 2)
                {
                    Console.WriteLine(2 * k - 1);
                }
                else
                {
                    k = k - n / 2;
                    Console.WriteLine(2 * k);
                }
            }
            else
            {
                if (k <= (n / 2) + 1)
                {
                    Console.WriteLine(2 * k - 1);
                }
                else
                {
                    k = k - (n / 2) - 1;
                    Console.WriteLine(2 * k);
                }
            }
        }
    }
}
