using System;
using System.Text;

namespace A._Stones_on_the_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            string input = Console.ReadLine().ToUpper();
            int R = 0;

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i + 1])
                    R++;
            }
            Console.WriteLine();
            Console.WriteLine(R);
        }
    }
}
