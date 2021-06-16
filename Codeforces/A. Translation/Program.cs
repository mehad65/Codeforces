using System;
using System.Linq;

namespace A._Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            string c = new string(a.Reverse().ToArray());
            if (b == c)
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
