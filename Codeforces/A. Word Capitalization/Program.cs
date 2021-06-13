using System;
using System.Globalization;

namespace A._Word_Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            str = str.Replace(str[0], char.ToUpper(str[0]));
            //TextInfo currenttextinfo = CultureInfo.CurrentCulture.TextInfo;
            //string result=currenttextinfo.ToTitleCase(str);
            Console.WriteLine(str);
        }
    }
}
