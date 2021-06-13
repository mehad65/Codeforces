using System;
using System.Text;

namespace A._Ultra_Fast_Mathematician
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            StringBuilder s = new StringBuilder();

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i])
                {
                    s.Append("0");
                }
                else
                {
                    s.Append("1");
                }
            }
            Console.WriteLine(s);
        }
    }
}
