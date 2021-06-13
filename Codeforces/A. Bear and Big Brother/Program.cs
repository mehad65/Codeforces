using System;

namespace A._Bear_and_Big_Brother
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] number=input.Split(" ");

            int a = int.Parse(number[0]);
            int b = int.Parse(number[1]);

            int lion = a;
            int bear = b;
            for (int i = 1; i < 10; i++)
            {
                lion = lion * 3;
                bear = bear * 2;
                if (lion > bear)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}
