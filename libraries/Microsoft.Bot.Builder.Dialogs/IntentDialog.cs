using System.Collections.Generic;
using Portable.Xaml.Markup;

namespace Microsoft.Bot.Builder.Dialogs
{
    [ContentProperty("Intents")]
    public class IntentDialog : ComponentDialog
    {
        public IntentDialog()
        {
        }

        public IntentDialog(string id) : base(id) { }

        public IRecognizer Recognizer { get; set; }

        public IntentMappings Intents { get; set; } = new IntentMappings();
    }
}
