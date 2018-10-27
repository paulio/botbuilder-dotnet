using System;

namespace Microsoft.Bot.Builder.Dialogs
{

    public class TimeSlot : SlotDefinition<DateTime>
    {
        public TimeSlot() { }

        public DateTime MinValue { get; set; }

        public DateTime MaxValue { get; set; }
    }



}
