using System;

namespace A._Football
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(input.Contains("1111111") || input.Contains("0000000"))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
