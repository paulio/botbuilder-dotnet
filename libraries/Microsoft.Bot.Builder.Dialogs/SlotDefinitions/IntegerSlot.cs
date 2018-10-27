using System;

namespace Microsoft.Bot.Builder.Dialogs
{

    public class IntegerSlot : SlotDefinition<int>
    {
        public IntegerSlot() { }

        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        public string TooSmall { get; set; }

        public string TooLarge { get; set; }

    }



}
