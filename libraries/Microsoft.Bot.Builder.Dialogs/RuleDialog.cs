using System.Collections.Generic;
using Portable.Xaml.Markup;

namespace Microsoft.Bot.Builder.Dialogs
{
    /// <summary>
    /// Stubbed out rule definition
    /// </summary>
    public class Rule
    {
        public Rule() { }

        public string Intent { get; set; }

        public string Expression { get; set; }

        public string DialogId { get; set; }

        public bool FireOnce { get; set; }

        public bool FireUnique { get; set; }
    }

    /// <summary>
    /// Typed collection of rules
    /// </summary>
    public class Rules : List<Rule>
    {
        public Rules() { }
    }

    /// <summary>
    /// Stubbed out version of what a rule based dialog might look like
    /// </summary>
    [ContentProperty("Rules")]
    public class RuleDialog : ComponentDialog
    {
        public RuleDialog()
        {
        }

        public IRecognizer Recognizer { get; set; }


        public Rules Rules { get; set; } = new Rules();
    }
}
