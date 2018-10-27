using System;
using System.ComponentModel;
using System.Globalization;
using Microsoft.Bot.Schema;

namespace Microsoft.Bot.Builder
{
    public interface IActivityTemplate
    {
        Activity GetActivity(TurnContext turnContext);
    }

    public class StringToActivityTemplateConverter : TypeConverter
    {
        public StringToActivityTemplateConverter() { }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return false;
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return false;
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                return new ActivityTemplate(value as string);
            }

            return base.ConvertFrom(context, culture, value);
        }
    }

    [TypeConverter(typeof(StringToActivityTemplateConverter))]
    public class ActivityTemplate : Activity, IActivityTemplate
    {
        private string templateId;

        public ActivityTemplate()
        {
            Type = ActivityTypes.Message;
        }

        public ActivityTemplate(string templateOrText)
        {
            if (templateOrText.ToLower().StartsWith("[[") && templateOrText.EndsWith("]]"))
            {
                this.templateId = templateOrText.Trim('[', ']').Trim();
            }
            else
            {
                this.Type = ActivityTypes.Message;
                this.Text = templateOrText;
            }
        }

        public Activity GetActivity(TurnContext turnContext)
        {
            if (this.templateId == null)
            {
                return this; // as the activity
            }

            return MessageFactory.Text($"This is template {this.templateId}");
        }
    }
}
