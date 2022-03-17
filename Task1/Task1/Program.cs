using System;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.method
            Console.WriteLine(IndeksOf1("lam"));

            // 2.method
            Console.WriteLine(IndeksOf2("S", 1));

            // 3.method
            Console.WriteLine(IndeksOf3("a", 2, 2 ));
        }


        // 1.method

        static int IndeksOf1(string text)
        {
            int reserve = 0;
            StringBuilder yazi = new StringBuilder("Salam");
            for (int i = 0; i < yazi.Length; i++)
            {
                if (text[0] == yazi[i])
                {
                    reserve = i;
                    break;
                }
                else
                {
                    reserve = -1;
                }
            }
            return reserve;
        }

        // 2.method

        static int IndeksOf2(string text, int index)
        {
            int reserve = 0;
            StringBuilder yazi = new StringBuilder("Salam");
            for (int i = index; i < yazi.Length; i++)
            {
                if (text[0] == yazi[i])
                {
                    reserve = i;
                    break;
                }
                else
                {
                    reserve = -1;

                }
            }
            return reserve;
        }


        // 3.method

        static int IndeksOf3(string text, int index, int count)
        {
            int reserve = 0;
            StringBuilder yazi = new StringBuilder("Salam");
            for (int i = index; i <= yazi[count]; i++)
            {
                if (text[0] == yazi[i])
                {
                    reserve = i;
                    break;
                }
                else
                {
                    reserve = -1;
                }
            }
            return reserve;
        }


    }
}
