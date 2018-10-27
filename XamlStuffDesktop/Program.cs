using System;
using System.IO;
using System.Reflection;
using System.Xaml;
using Foobar;
using Newtonsoft.Json;

namespace XamlStuffDesktop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var settings = new XamlSchemaContext(new XamlSchemaContextSettings()
            //{
            //    SupportMarkupExtensionsWithDuplicateArity = true
            //});

            //var dealer = new Dealership();
            //dealer.Vehicles.Add(new Car()
            //{
            //    Age = 10,
            //    Name = "booboo",
            //    Brand = "Ford"
            //});

            //dealer.Vehicles.Add(new Car()
            //{
            //    Age = 13,
            //    Name = "Neon",
            //    Brand = "Dodge"
            //});

            //var bike = new Bike()
            //{
            //    Age = 2,
            //    Name = "Shasta",
            //    Brand = "Puch",
            //    Recumbent = true
            //};
            //bike.TirePressure.Add(15);
            //bike.TirePressure.Add(30);
            //dealer.Vehicles.Add(bike);

            //var xamlOut = System.Xaml.XamlServices.Save(dealer);
            //Console.WriteLine(xamlOut);
            //var result2 = XamlServices.Load(new StringReader(xamlOut));
            //Console.WriteLine(JsonConvert.SerializeObject(result2, Formatting.Indented));

            //	// Make the XmlSerializer and StringWriter.
            //	string data;
            //	XmlSerializer xmlSerializer = new XmlSerializer(typeof(Dealership), new Type[] { typeof(Bike), typeof(Car)});
            //	using (StringWriter stringWriter = new StringWriter())
            //	{
            //		// Serialize.
            //		xmlSerializer.Serialize(stringWriter, dealer);
            //
            //		// Display the serialization.
            //		data = stringWriter.ToString();
            //	}
            //
            //	data.Dump();
            //	var settings =new JsonSerializerSettings();
            //	settings.TypeNameHandling = TypeNameHandling.None;
            //	JsonConvert.SerializeObject(dealer, Newtonsoft.Json.Formatting.Indented, settings).Dump();
            //
            var reader = new XamlXmlReader(@"..\..\dialog.xaml", settings: new XamlXmlReaderSettings()
            {
                LocalAssembly = Assembly.GetExecutingAssembly()
            });
            //, new XamlSchemaContext(AppDomain.CurrentDomain.GetAssemblies()));
            var result = XamlServices.Load(reader);

            var json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);

        }
    }
}
