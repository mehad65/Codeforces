using System;

namespace A._Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = 0;
            int b = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]>='a' && input[i] <= 'z')
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }
            if (a >= b)
            {
                Console.WriteLine(input.ToLower());
            }
            else
            {
                Console.WriteLine(input.ToUpper());
            }
        }
    }
}
