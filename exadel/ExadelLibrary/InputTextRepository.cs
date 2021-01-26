using System;
using System.Collections.Generic;

namespace TextMatchLibrary
{
    public class InputTextRepository
    {
        List<InputText> InputList = new List<InputText>();
        List<OutputText> OutputList = new List<OutputText>();

        public List<InputText> BuildTheList(string text, string subText)
        {

            string textHold = text;
            string rezult = "";
            string textHoldTemp = "";
            int lenght = subText.Length;
            int count = 0;
            int count1 = 1;
            int resultNo = 1;
            foreach (var item in text)
            {
                count++;
                textHoldTemp = "";
                count1 = 1;
                rezult = "";
                foreach (var item1 in textHold)
                {

                    if (count1 <= lenght)
                    {
                        rezult = rezult + item1;
                        if (lenght - count1 < lenght - 1)
                        {
                            textHoldTemp = textHoldTemp + item1;
                        }
                    }
                    else
                    {
                        textHoldTemp = textHoldTemp + item1;
                    }
                    count1++;
                    textHold = textHoldTemp;
                }
                textHold = textHoldTemp;

                InputList.Add(new InputText(rezult, resultNo));
                resultNo++;

                if (count == text.Length - subText.Length + 1)
                {
                    break;
                }
            }
            return InputList;
        }

        public List<OutputText> BuildMatchList(string subText)
        {
            foreach (var item in InputList)
            {
                string toCheck = item.InputToCheck;
                bool check = subText.Equals(toCheck, StringComparison.OrdinalIgnoreCase);
                if (check == true)
                {
                    OutputList.Add(new OutputText(item.InputToCheck, item.InputCharNo));
                }
            }
            return OutputList;
        }
    }
}
