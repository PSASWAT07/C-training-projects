using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
    }
    public class Employee
    {
        public int Id = 1;
        public string name = "John smith";
        public string subject = "physics";
    }
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public string city {get; set; }

        
    }
    internal class serializationdemo
    {
        public void JsonSerialize()
        {
            var bs = new Person();
            
            Console.WriteLine("enter name");
            bs.name = Console.ReadLine();
            Console.WriteLine("enter age :");
            bs.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter city :");
            bs.city = Console.ReadLine();
        
            //how to serialize from object  to json
            string jsonString = JsonSerializer.Serialize(bs);
            Console.WriteLine(jsonString);
            var person = JsonSerializer.Deserialize<Person>(jsonString); // how to deserialize from json to object
            Console.WriteLine(bs.name);
            Console.WriteLine(bs.age);
            Console.WriteLine(bs.city);
        }
        public void XmlSerialize()
        {
            Person bs = new Person();
            Console.WriteLine("enter name");
            bs.name =Console.ReadLine();
            Console.WriteLine("enter age :");
            bs.age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter city :");
            bs.city =Console.ReadLine();

            XmlSerializer xs = new XmlSerializer(typeof(Person));
            TextWriter txtWriter = new StreamWriter(@"C:\Users\sapani\Documents\XML\Seialization.xml");
            xs.Serialize(txtWriter, bs);
            txtWriter.Close();



        }
        public void XmlDeSerialize() //convert back from xml file to the original one
        {
            Person bs = new Person();
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            StreamReader reader = new StreamReader(@"C:\Users\sapani\Documents\XML\Seialization.xml");
            bs = (Person)xs.Deserialize(reader); //deserialize mein reader object and seralize mein writer object
            Console.WriteLine("Person details");
            Console.WriteLine("Name:" + bs.name);
            Console.WriteLine("Age" + bs.age);
            Console.WriteLine("City" + bs.city);

        }
    }
}
