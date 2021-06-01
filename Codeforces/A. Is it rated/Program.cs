using System;
using System.Text;

namespace A._Is_it_rated
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < a; i++)
            {
                str.AppendLine(Console.ReadLine());
            }

            Console.WriteLine(str.ToString());

        }
    }
}
