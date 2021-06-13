using System;

namespace A._Boy_or_Girl
{
    class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();

            int count = 0;
            int finalcount = 0;
            for (char c = 'a'; c <= 'z'; c++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == c)
                        count++;
                  
                    
                }
                if (count>0)
                    finalcount++;
                count = 0;
            }

            if (finalcount % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
        }
    }
}
