using System;

namespace A._Vanya_and_Fence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string h = Console.ReadLine();
            string[] arr = new string[2];
            arr =input.Split(" ");

            string[] arrok = new string[Convert.ToInt32(arr[0])];
            arrok = h.Split(" ");
           

            int result = 0;
            for (int i = 0; i < Convert.ToInt32(arr[0]) ; i++)
            {
                if (Convert.ToInt32(arr[1]) >= Convert.ToInt32(arrok[i]))
                {
                    result += 1;
                }
                else
                {
                    result += 2;
                }
            }
            Console.WriteLine(result);
        }
    }
}
