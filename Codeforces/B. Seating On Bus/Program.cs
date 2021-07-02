using System;
using System.Text;

namespace B._Seating_On_Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            string rowSeat = Console.ReadLine();
            string[] rowSeatList = rowSeat.Split(" ");
            int n = Convert.ToInt32(rowSeatList[0]);
            int m = Convert.ToInt32(rowSeatList[1]);

            int math = ((4 * n) / 2);
            int diff = 4 * n - m;
            int mathcal = m - math;
            if (m <= math)
            {
                for (int i = 1; i <= m; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else 
            {
                    for (int i = 1; i <= mathcal; i++)
                    {
                        Console.Write($@"{math + i} {i} ");

                    }
                    for (int i = 1; i <= diff; i++)
                    {
                        Console.Write(mathcal + i + " ");
                    }           
            }            
        }
    }
}
