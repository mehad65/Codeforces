using System;

namespace A._Anton_and_Danik
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamenumber = int.Parse(Console.ReadLine());
            string gameresult = Console.ReadLine();
            int countA = 0;
            int countD = 0;
            for (int i = 0; i < gamenumber; i++)
            {
                if (gameresult[i] == 'A')
                {
                    countA++;
                }
                else
                {
                    countD++;
                }
            }
            if (countA == countD)
            {
                Console.WriteLine("Friendship");
            }else if (countA > countD)
            {
                Console.WriteLine("Anton");
            }
            else
            {
                Console.WriteLine("Danik");
            }
        }
    }
}
