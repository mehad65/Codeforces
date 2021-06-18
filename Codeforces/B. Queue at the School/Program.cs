using System;
using System.Text;

namespace B._Queue_at_the_School
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputlist = input.Split(" ");
            int bg = Convert.ToInt32(inputlist[0]);
            int second = Convert.ToInt32(inputlist[1]);
            string position = Console.ReadLine();
            StringBuilder sb = new StringBuilder(position);
            for (int i = 0; i < second; i++)
            {
                for (int j = 0; j < bg - 1; j++)
                {
                    if (sb[j] < sb[j + 1])
                    {
                        sb[j] = 'G';
                        sb[j + 1] = 'B';
                        j++;
                    }
                }
            }
            Console.WriteLine(sb);


        }
    }
}
