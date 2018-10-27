using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;
using System.Xml.Serialization;

namespace XamlStuffDesktop
{
    public class Grobble
    {
        public Grobble()
        { }

        public string Text { get; set; }
    }

    public class Vehicle
    {
        public Vehicle() { }

        public string Name { get; set; }

    }

    public class VehicleCollection : List<Vehicle>
    {
        public VehicleCollection() { }
    }

    //[Markup.ContentProperty("Children")]
    [ContentProperty("Vehicles")]
    //[System.Xaml.ContentProperty("Vehicles")]
    public class Dealership
    {
        public Dealership()
        {
        }

        public VehicleCollection Vehicles { get; set; } = new VehicleCollection();
    }

}

namespace Foobar
{ 
    public class Car : XamlStuffDesktop.Vehicle
    {
        public Car() { }
        public Car(string text)
        {
            Name = text;
        }

        public int Age { get; set; }

        public string Brand { get; set; }
    }

    [ContentProperty("TirePressure")]
    public class Bike : XamlStuffDesktop.Vehicle
    {
        public Bike()
        {
        }
        public Bike(string text)
        {
            Name = text;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Brand { get; set; }

        public bool Recumbent { get; set; } = false;

        public List<int> TirePressure { get; set; } = new List<int>();
    }

}
