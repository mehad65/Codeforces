using System;
using System.Collections.Generic;

namespace A._Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            //Dictionary<int, int> coll = new Dictionary<int, int>();
            string[] inputlist = input.Split(" ");
            int[] resultarr = new int[a];
            for (int i = 1; i <=a; i++)
            {
                resultarr[Convert.ToInt32(inputlist[i - 1])-1] = i;
            }
            foreach (var item in resultarr)
            {
                Console.Write(item + " ");
            }


        }
    }
}
