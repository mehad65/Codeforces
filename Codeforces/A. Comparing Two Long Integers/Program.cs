using System;
using System.Numerics;

namespace A._Comparing_Two_Long_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(">");
            }
            else if (a == b)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine("<");
            }
        }
    }
}
