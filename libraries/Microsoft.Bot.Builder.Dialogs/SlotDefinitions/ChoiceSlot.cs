using System;
using System.Collections.Generic;
using Portable.Xaml.Markup;

namespace Microsoft.Bot.Builder.Dialogs
{
    [ContentProperty("Choices")]
    public class ChoiceSlot : TextSlot
    {
        public ChoiceSlot() { }

        public List<string> Choices { get; set; } = new List<string>();

    }
}
