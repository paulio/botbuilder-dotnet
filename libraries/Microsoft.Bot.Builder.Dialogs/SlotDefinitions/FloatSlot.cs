using System;

namespace Microsoft.Bot.Builder.Dialogs
{

    public class FloatSlot : SlotDefinition<float>
    {
        public FloatSlot() { }

        public float MinValue { get; set; }

        public float MaxValue { get; set; }
    }



}
