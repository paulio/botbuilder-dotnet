using System;
using Microsoft.Bot.Schema;
using Portable.Xaml.Markup;

namespace XamlStuff
{
    [MarkupExtensionReturnType(typeof(Activity))]
    public class StaticResource : MarkupExtension
    {
        public StaticResource()
        {

        }
        /// <summary>
        ///  Constructor that takes the resource key that this is a static reference to.
        /// </summary>
        public StaticResource(object resourceKey)
        {
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var message = Activity.CreateMessageActivity();
            message.Text = "Yo";
            return message;
        }
    }
}
