using System;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseStr("Code Academy"));
        }

        static StringBuilder ReverseStr(string text)
        {
            StringBuilder yazi = new StringBuilder();
            foreach (var soz in text.Split(' '))
            {
                for (int i = soz.Length-1; i >= 0 ; i--)
                {
                    yazi.Append(soz[i]);
                }
                yazi.Append(" ");
                
            }
            
            return yazi;
        }
    }
}
