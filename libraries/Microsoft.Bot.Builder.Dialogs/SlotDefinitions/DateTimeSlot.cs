using System;

namespace Microsoft.Bot.Builder.Dialogs
{

    public class DateTimeSlot : SlotDefinition<DateTime>
    {
        public DateTimeSlot() { }

        public DateTime MinValue { get; set; }

        public DateTime MaxValue { get; set; }
    }
}
