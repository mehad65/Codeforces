using System;

namespace B._Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string input = Console.ReadLine().Replace(" ", "");
            int countOne = 0;
            int  countTwo = 0;
            int countThree = 0;
            int countFour = 0;
            int countTaxi = 0;
            for (int i = 0; i < a; i++)
            {
                if (input[i] == '1')
                {
                    countOne++;
                }
                else if (input[i] == '2')
                {
                    countTwo++;
                }
                else if (input[i] == '3')
                {
                    countThree++;
                }
                else if (input[i] == '4')
                {
                    countFour++;
                }
            }
            countTaxi = countFour;
            while (countOne != 0 && countThree!=0)
            {
                countThree = countThree - 1;
                countOne = countOne - 1;
                countTaxi++;
            }
            if (countTwo != 0)
            {
                countTaxi = countTwo / 2 + countTaxi;
                if (countTwo % 2 != 0)
                {
                    if (countOne >1)
                    {
                        countOne = countOne - 2;
                        countTaxi = countTaxi + 1;
                        countTwo = 0;
                    }
                    else
                    {
                        countTaxi++;
                        countTwo = 0;
                    }
                }
            }
            if (countThree != 0)
            {
                countTaxi = countTaxi + countThree;
            }
            if (countOne != 0)
            {
                countTaxi = countTaxi + countOne / 4;
                if (countOne % 4 != 0)
                {
                    countTaxi = countTaxi + countOne;
                    countOne = 0;
                }
            }
            Console.WriteLine(countTaxi);
            

        }
    }
}
