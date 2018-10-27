using System;

namespace Microsoft.Bot.Builder.Dialogs
{

    public class TimeSpanSlot : SlotDefinition<TimeSpan>
    {
        public TimeSpanSlot() { }

        public TimeSpan MinValue { get; set; }

        public TimeSpan MaxValue { get; set; }
    }
}
