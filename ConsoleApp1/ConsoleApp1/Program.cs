using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  int a;
            //  int b;
            //  int c;
            //  Console.WriteLine("enter value a:");
            //  a =Convert.ToInt32(Console.ReadLine());                                                         
            //  Console.WriteLine("enter value b:");
            //   b =Convert.ToInt32(Console.ReadLine());
            //  c = a + b;
            // Console.Write("output:");

            // Console.Write(c); //how to print o/p?
            // Console.Read(); // how to read keyboard input?
            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            */
            Event eventobj=new Event();// how to create object?
            eventobj.CreateEvent();
            eventobj.SelectEvents();
            }
        }
    }
}
