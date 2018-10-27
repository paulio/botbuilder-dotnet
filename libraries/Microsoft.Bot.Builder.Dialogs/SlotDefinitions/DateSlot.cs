using System;

namespace Microsoft.Bot.Builder.Dialogs
{

    public class DateSlot : SlotDefinition<DateTime>
    {
        public DateSlot() { }

        public DateTime MinValue { get; set; }

        public DateTime MaxValue { get; set; }

        public string TooSmall { get; set; }

        public string TooLarge { get; set; }

    }



}
