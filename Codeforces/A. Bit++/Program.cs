using System;

namespace A._Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] str = new string[a];
            int x = 0;
            for (int i = 0; i < a; i++)
            {
                str[i] = Console.ReadLine();
                if (str[i].ToLower() == "++x")
                {
                    x=x+1;
                }else if (str[i].ToLower() == "--x")
                {
                    x = x - 1;
                }
                else if (str[i].ToLower() == "x++")
                {
                    x = x + 1;
                }
                else if (str[i].ToLower() == "x--")
                {
                    x = x - 1;
                }
            }

            Console.WriteLine(x);
        }
    }
}
