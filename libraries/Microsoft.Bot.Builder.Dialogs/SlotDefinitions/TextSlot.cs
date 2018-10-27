namespace Microsoft.Bot.Builder.Dialogs
{

    public class TextSlot : SlotDefinition<string>
    {
        public TextSlot() { }

        public int MinLength { get; set; }

        public int MaxLength { get; set; }

        public string Pattern { get; set; }

        public string TooShort { get; set; }

        public string TooLong { get; set; }

        public string PatternWrong { get; set; }
        
    }



}
