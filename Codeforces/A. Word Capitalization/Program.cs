using System;

namespace A._Word_Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            
            if (str[0]>='a' && str[0]<='z')
            {
                str = str.Substring(0,1).ToUpper()+ str.Substring(1, str.Length-1);
            }
            Console.WriteLine(str);
        }
    }
}
