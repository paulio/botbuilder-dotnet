using System;

namespace Microsoft.Bot.Builder.Dialogs
{

    public class FileSlot
        : SlotDefinition<Byte[]>
    {
        public FileSlot() { }

        public string ContentType { get; set; }
    }
}
