using System;
using System.Linq;

namespace A._Tram
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] arr = new string[a];
            int mx = -9999;
            //int[] number = new int[a];
            int s = 0;
            for (int i = 0; i < a; i++)
            {
                arr[i] = Console.ReadLine();
                string[] one = arr[i].Split();
                s = s -Convert.ToInt32( one[0]) + Convert.ToInt32(one[1]);
                mx = Math.Max(mx, s);
            }
            Console.WriteLine(mx);
        }
    }
}
