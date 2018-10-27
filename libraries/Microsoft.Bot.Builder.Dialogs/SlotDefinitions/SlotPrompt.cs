using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Bot.Builder.Dialogs
{
    public class SlotPrompt : Dialog
    {
        public SlotPrompt() { }

        public int Retries { get; set; } = 3;

        /// <summary>
        /// Gets or sets the initial prompt to send the user as <seealso cref="Activity"/>Activity.
        /// </summary>
        /// <value>
        /// The initial prompt to send the user as <seealso cref="Activity"/>Activity.
        /// </value>
        public ActivityTemplate InitialPrompt { get; set; }

        /// <summary>
        /// Gets or sets the retry prompt to send the user as <seealso cref="Activity"/>Activity.
        /// </summary>
        /// <value>
        /// The retry prompt to send the user as <seealso cref="Activity"/>Activity.
        /// </value>
        public ActivityTemplate RetryPrompt { get; set; }

        /// <summary>
        /// Gets or sets the retry prompt to send the user as <seealso cref="Activity"/>Activity.
        /// </summary>
        /// <value>
        /// The retry prompt to send the user as <seealso cref="Activity"/>Activity.
        /// </value>
        public ActivityTemplate TooManyTriesPrompt { get; set; }

        public override Task<DialogTurnResult> BeginDialogAsync(DialogContext dc, object options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
