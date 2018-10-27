using System;

namespace Microsoft.Bot.Builder.Dialogs
{

    public interface ISlotDefinition
    {
        string Name { get; set; }

        Type Type { get; set; }

        string EmptyDescription { get; set; }

        string Description { get; set; }
    }

    public class SlotDefinition<T> : ISlotDefinition
    {
        public SlotDefinition() { }

        public string Name { get; set; }

        public Type Type { get; set; }

        public T DefaultValue { get; set; }

        public string EmptyDescription { get; set; }

        public string Description { get; set; }

        public string Changed { get; set; }

    }
}
