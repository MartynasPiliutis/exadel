namespace TextMatchLibrary
{
    public class OutputText
    {
        public string SubText { get; private set; }
        public int CharNo { get; private set; }

        public OutputText(string subText, int charNo)
        {
            SubText = subText;
            CharNo = charNo;
        }
    }

}
