using System;

namespace A._Magnets
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int count = 1;
            int[] intarr = new int[a];
            for (int i = 0; i < a; i++)
            {
                intarr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a-1; i++)
            {
                if (intarr[i] != intarr[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
