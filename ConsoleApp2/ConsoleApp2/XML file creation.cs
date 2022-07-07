using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    public class Employee
    {
        public int Id = 1;
        public string name = "John smith";
        public string subject = "physics";
    }
    internal class SerializationDemo
    {
    public void JsonSerialize()
    {

    }
    public void XmlSerialize()
    {
        Employee bs = new Employee();
        XmlSerializer xs = new XmlSerializer(typeof(Employee));
        TextWriter txtWriter = new StreamWriter(@"C:\Users\sapani\Documents\XML\Seialization.xml");
        xs.Serialize(txtWriter, bs);
            txtWriter.Close();

        
          
    }
    }
}
