using System;

namespace A._Young_Physicist
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] arr = new string[a];
            string[] arrtest = new string[3];
            int b = 0;
            int c = 0;
            int d = 0;
            for (int i = 0; i < a; i++)
            {
                arr[i] = Console.ReadLine();
                
                arrtest = arr[i].Split(" ");
                b = b + Convert.ToInt32(arrtest[0]);
                c = c + Convert.ToInt32(arrtest[1]);
                d = d + Convert.ToInt32(arrtest[2]);

            }
            if (b==0 && c==0 && d==0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
