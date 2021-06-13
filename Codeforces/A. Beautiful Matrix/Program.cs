using System;

namespace A._Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];
            int row = 0;
            int coll = 0;
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Console.ReadLine();
                arr[i] = arr[i].Replace(" ", "");
                if (arr[i].Contains("1"))
                {
                    row = i + 1;
                    //break;
                }
                    
            }
            for (int i = 0; i < 5; i++)
            {
                if (arr[row - 1][i] == '1')
                {
                    coll = i + 1;
                    break;
                }
                    
            }

            int result = Math.Abs((row - 3)) + Math.Abs((coll - 3));
            Console.WriteLine(result);
        }

        }
    }
