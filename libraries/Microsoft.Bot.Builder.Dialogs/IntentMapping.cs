using System.Collections.Generic;
using Portable.Xaml.Markup;

namespace Microsoft.Bot.Builder.Dialogs
{
    public class IntentMapping
    {
        public IntentMapping() { }

        public string IntentId { get; set; }

        public string DialogId { get; set; }
    }
}
