using System;

namespace A._Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] arr= new string[a];
            int final = 0;
            int count = 0;
            for (int i = 0; i < a; i++)
            {
                arr[i] = Console.ReadLine().Replace(" ","");
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i][j] == '1')
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    final++;
                }
                count = 0;
            }

            Console.WriteLine(final);
        }
    }
}
