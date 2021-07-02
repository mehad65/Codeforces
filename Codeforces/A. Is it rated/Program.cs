using System;
using System.Text;

namespace A._Is_it_rated
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] ResultOne = new int[a];
            int[] ResultTwo = new int[a];

            for (int i = 0; i < a; i++)
            {
                string[] arr=Console.ReadLine().Split(" ");
                ResultOne[i] = Convert.ToInt32(arr[0]);
                ResultTwo[i] = Convert.ToInt32(arr[1]);

            }
           
            for (int i = 0; i < a; i++)
            {
                if (ResultOne[i] != ResultTwo[i])
                {
                    Console.WriteLine("rated");
                    return;
                }
               
            }
            for (int i = 1; i < a; i++)
            {
                if (ResultOne[i] > ResultOne[i - 1])
                {
                    Console.WriteLine("unrated");
                    return;
                }
            }
            Console.WriteLine("maybe");

        }
    }
}
