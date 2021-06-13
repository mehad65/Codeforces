using System;
using System.Text;

namespace A._String_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            for (char c = 'a';  c<='z'; c++)
            {
                if (c == 'a')
                {
                    input = input.Replace(c + "", "");
                }
                else if (c == 'e')
                {
                    input = input.Replace(c + "", "");
                }
                else if (c == 'i')
                {
                    input = input.Replace(c + "", "");
                }
                else if (c == 'o')
                {
                    input = input.Replace(c + "", "");
                }
                else if (c == 'u')
                {
                    input = input.Replace(c + "", "");
                }
                else if (c == 'y')
                {
                    input = input.Replace(c + "", "");
                }
            }
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append("."+input[i]);
            }
            Console.WriteLine(sb);
        }
    }
}
