using System;
using System.Text;

namespace A._Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();
            int zcount = 0;
            int ncount = 0;
            foreach(var c in str.ToLower())
            {
                if (c == 'z')
                {
                    zcount++;
                }else if (c == 'n')
                {
                    ncount++;
                }
            }
            for (int i = 0; i < ncount; i++)
            {
                Console.Write("1 ");
            }
            for (int i = 0; i < zcount; i++)
            {
                Console.Write("0 ");
            }
            
        }
    }
}
