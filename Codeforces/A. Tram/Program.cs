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
                arr[i] = arr[i].Replace(" ", "");
                s = (s - arr[i][0]) + arr[i][1];
                mx = Math.Max(mx, s);
            }
            Console.WriteLine(mx);
        }
    }
}
