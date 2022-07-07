using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             serializationdemo srObj = new serializationdemo();
            // srObj.XmlSerialize();
           // srObj.XmlDeSerialize();
            srObj.JsonSerialize();
          
            Console.ReadLine();
            
            

        }
    }
}
