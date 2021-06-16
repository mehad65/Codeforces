using System;

namespace A._Twins
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] arr = input.Split(" ");

            int[] iarr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                iarr[i] = int.Parse(arr[i]);
            }
            Array.Sort(iarr);
            int sum = add(arr) / 2;

            int sum2 = 0;
            int count = 0;
            for (int i = a - 1; i >= 0; i--)
            {
                sum2 += Convert.ToInt32(iarr[i]);
                count++;
                if (sum < sum2)
                    break;
               
            }

            Console.WriteLine(count);

        }
        static int add(params string[] a)
        {
            int b = 0;
            foreach (var item in a)
            {
                b += Convert.ToInt32(item);
            }
            return b;
        }
    }


    
   
}
