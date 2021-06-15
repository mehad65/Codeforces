using System;

namespace A._Soldier_and_Bananas
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arr = input.Split(" ");
            int k = Convert.ToInt32(arr[0]);
            int n = Convert.ToInt32(arr[1]);
            int w= Convert.ToInt32(arr[2]);
            int rate = 0;
            for (int i = 1; i <= w; i++)
            {
                rate = rate+(i * k);
            }

            if (rate >= n)
            {
                Console.WriteLine(rate - n);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
