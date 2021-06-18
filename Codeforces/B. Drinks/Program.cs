using System;

namespace B._Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] inputlist = input.Split(" ");
            decimal total = 0;
            for (int i = 0; i < a; i++)
            {
                total += Convert.ToInt64(inputlist[i]);
            }
            
            Console.WriteLine(Math.Round(total / a,5));
        }
    }
}
