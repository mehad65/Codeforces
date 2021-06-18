using System;

namespace A._George_and_Accommodation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] inputlist = new string[a];
            int count = 0;
            string[] plist = new string[2];
            for (int i = 0; i < a; i++)
            {
                inputlist[i] = Console.ReadLine();
                plist = inputlist[i].Split(" ");
                if(Convert.ToInt32(plist[1])- Convert.ToInt32(plist[0]) > 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
