using System;
using System.Collections.Generic;
using TextMatchLibrary;

namespace TextMatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            InputTextRepository InputTextRepository = new InputTextRepository();
            List<OutputText> OutputList = new List<OutputText>();
            string text = "";
            string subText = "";
            string error = "There is no output";
            Console.Write("Enter your Text: ");
            text = Console.ReadLine();

            Console.Write("Enter your Sub-Text: ");
            subText = Console.ReadLine();

            InputTextRepository.BuildTheList(text, subText);
            OutputList = InputTextRepository.BuildMatchList(subText);


            Console.WriteLine("The result:");
            Console.WriteLine("Your text: " + text);
            Console.WriteLine("Your sub-text: " + subText);
            Console.Write("The output: ");
            if (OutputList.Count == 0)
            {
                Console.Write(error);
            }
            else
            {
                foreach (var item in OutputList)
                {
                    Console.Write(item.CharNo + " ");
                }
            }
            Console.ReadLine();
        }

    }
}
