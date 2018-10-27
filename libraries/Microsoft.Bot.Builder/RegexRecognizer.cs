using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Portable.Xaml.Markup;

namespace Microsoft.Bot.Builder
{
    public class RegexPattern
    {
        public RegexPattern()
        {
        }

        public string IntentId { get; set; }

        public string Pattern { get; set; }
    }

    public class RegexPatterns : List<RegexPattern>
    {
        public RegexPatterns() { }
    }

    [ContentProperty("Patterns")]
    public class RegexRecognizer : IRecognizer
    {
        public RegexRecognizer() { }

        public RegexPatterns Patterns { get; set; } = new RegexPatterns();

        public Task<RecognizerResult> RecognizeAsync(ITurnContext turnContext, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> RecognizeAsync<T>(ITurnContext turnContext, CancellationToken cancellationToken) 
            where T : IRecognizerConvert, new()
        {
            throw new NotImplementedException();
        }
    }
}
