using System;

namespace A._Wrong_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(" ");
            int a = Convert.ToInt32(arr[0]);
            for (int i = 0; i < Convert.ToInt32(arr[1]); i++)
            {
                if (a%10 == 0)
                {
                    a = a / 10;
                }
                else
                {
                    a = a - 1;
                }
            }

            Console.WriteLine(a);
        }
    }
}
