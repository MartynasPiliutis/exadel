namespace TextMatchLibrary
{
    public class InputText
    {
        public string InputToCheck { get; private set; }
        public int InputCharNo { get; private set; }

        public InputText(string inputToCheck, int inputCharNo)
        {
            InputToCheck = inputToCheck;
            InputCharNo = inputCharNo;
        }
    }


}
