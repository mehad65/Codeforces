using System;

namespace A._Football_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] teamname = new string[a];
          
            for (int i = 0; i < a; i++)
            {
                teamname[i] = Console.ReadLine();
            }
            int first = 1;
            // int second = 0;
            //string name;
            Array.Sort(teamname);
            for (int i = 0; i < a-1; i++)
            {
                if (teamname[0] == teamname[i + 1])
                {
                    first++;
                }
            }
           if (first > a - first)
            {
                Console.WriteLine(teamname[0].ToString());
            }
            else
            {
                Console.WriteLine(teamname[a-1].ToString());
            }
        }
    }
}
