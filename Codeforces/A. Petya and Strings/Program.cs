using System;

namespace A._Petya_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine().ToLower();
            string b = Console.ReadLine().ToLower();
            if (a == b)
            {
                Console.WriteLine("0");

            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == b[i])
                    {
                        continue;
                    }else if (a[i] > b[i])
                    {
                        Console.WriteLine("1");
                        break;
                    }
                    else if(a[i] < b[i])
                    {
                        Console.WriteLine("-1");
                        break;
                    }
                }
            }
        }
    }
}
