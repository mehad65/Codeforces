using System;
using System.Text;

namespace A._Helpful_Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputarr = input.Split("+");
            int[] intarr = new int [inputarr.Length];
            for (int i = 0; i < inputarr.Length; i++)
            {
                intarr[i] = int.Parse(inputarr[i]);
            }

            Array.Sort(intarr);
            StringBuilder sb = new StringBuilder();
            sb.Append(intarr[0].ToString());
            for (int i = 1; i < inputarr.Length; i++)
            {
               sb.Append("+"+intarr[i].ToString());
            }
            Console.WriteLine(sb);




        }
    }
}
