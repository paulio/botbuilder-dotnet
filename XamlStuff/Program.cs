using System;
using System.Reflection;
using Microsoft.Bot.Builder.Dialogs;
using Newtonsoft.Json;
using Portable.Xaml;

namespace XamlStuff
{

    public class App
    {
        public static JsonSerializerSettings jsonSettings = new JsonSerializerSettings()
        {
            NullValueHandling = NullValueHandling.Ignore,
            TypeNameHandling = TypeNameHandling.Objects,
            Formatting = Formatting.Indented
        };

        private static void Main(string[] args)
        {
            var reader = new XamlXmlReader(@"..\..\..\intentDialog.xaml", settings: new XamlXmlReaderSettings() { LocalAssembly = Assembly.GetExecutingAssembly() });
            var result = (ComponentDialog)XamlServices.Load(reader);

            // serialize to json for giggles
            Console.WriteLine(JsonConvert.SerializeObject(result, jsonSettings));

            Console.ReadKey();
        }
    }
}

//var turnContext = new Microsoft.Bot.Builder.TurnContext(new TestAdapter(), new Activity());
//foreach (var dialog in result.Dialogs.Where(d => d is TextPrompt).Cast<TextPrompt>())
//{
//    Console.WriteLine("----------");
//    var json = JsonConvert.SerializeObject(dialog.InitialPrompt.GetActivity(turnContext), jsonSettings);
//    Console.WriteLine(json);
//    json = JsonConvert.SerializeObject(dialog.RetryPrompt.GetActivity(turnContext), jsonSettings);
//    Console.WriteLine(json);
//}

//StringBuilder sb = new StringBuilder();
//XamlServices.Save(new StringWriter(sb), new Dictionary<string, DateTime>());
//Console.WriteLine(sb.ToString());

