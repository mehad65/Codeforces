using System;

namespace A._Beautiful_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            while (true)
            {
                n++;
                input = n.ToString();
                int a = int.Parse(input[0].ToString());
                int b = int.Parse(input[1].ToString());
                int c = int.Parse(input[2].ToString());
                int d = int.Parse(input[3].ToString());

                if(a!=b && a!=c && a!=d && b!=c && b!=d && c!=d)
                {
                    break;
                }
            }
            Console.WriteLine(n);
        }
    }
}
