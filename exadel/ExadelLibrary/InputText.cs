namespace TextMatchLibrary
{
    public class InputText
    {
        public string Text { get; private set; }
        public string SubText { get; private set; }

        public InputText(string text, string subText)
        {
            Text = text;
            SubText = subText;
        }
    }

}
