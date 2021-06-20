using System;

namespace A._In_Search_of_an_Easy_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string input = Console.ReadLine().Replace(" ","");
            if (input.Contains("1"))
            {
                Console.WriteLine("HARD");
            }
            else
            {
                Console.WriteLine("EASY");
            }

        }
    }
}
