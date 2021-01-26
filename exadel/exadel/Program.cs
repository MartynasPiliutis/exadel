using System;
using System.Collections.Generic;

namespace TextMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "";
            string subText1 = "";

            Console.Write("Text1: ");
            text1 = Console.ReadLine();

            Console.Write("SubText1: ");
            subText1 = Console.ReadLine();

            List<string> Input = new List<string>();
            string textHold = text1;
            string rezult = "";
            int lenght = subText1.Length;
            int count = 1;
            foreach (var item in text1)
            {
                string textHoldTemp = "";
                foreach (var item1 in textHold)
                {
                    if (count <= lenght)
                    {
                        rezult = rezult + item1;
                    }
                    else
                    {
                        textHoldTemp = textHoldTemp + item1;
                    }
                    count++;
                }
                textHold = textHoldTemp;

                Console.WriteLine(rezult);
                Console.WriteLine(textHoldTemp);
            }
            Console.ReadLine();
        }
    }
}
