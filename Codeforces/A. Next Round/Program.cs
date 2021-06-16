using System;

namespace A._Next_Round
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inarr = input.Split(" ");

            int a = int.Parse(inarr[0]);
            int b = int.Parse(inarr[1]);

            string line = Console.ReadLine();
            string[] linearr = line.Split(" ");
            int count = 0;
            for (int i = 0; i < a; i++)
            {
                
                    if (int.Parse(linearr[i]) >= int.Parse(linearr[b-1]) && int.Parse(linearr[i]) != 0)
                    {
                       count++;
                    }
               

                
            }
       
                Console.WriteLine(count);
           
        }
    }
}
