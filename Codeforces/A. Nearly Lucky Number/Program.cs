using System;

namespace A._Nearly_Lucky_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]=='4' || input[i] == '7')
                {
                    a++;
                }
            }
            if (a==4 || a==7)
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
