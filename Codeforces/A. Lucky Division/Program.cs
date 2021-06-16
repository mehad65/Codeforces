using System;

namespace A._Lucky_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (IsLucky(input))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }


        static bool IsLucky(string a)
        {
            int num = int.Parse(a);
            a = a.Replace("4", "");
            a = a.Replace("7", "");

            if (a.Length==0)
            {
                return true;
            }

            if(num%4==0 || num% 7 == 0|| num%47==0)
            {
                return true;
            }
            return false;
        }
    }
}
