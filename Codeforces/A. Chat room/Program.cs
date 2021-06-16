using System;
using System.Text;

namespace A._Chat_room
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string hello = "hello";
            int x = 0;
            int y = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (x < 5)
                {
                    if (input[i] == hello[x])
                    {
                        x++;
                        y++;
                    }
                }
               

            }
            if (y == 5)
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
