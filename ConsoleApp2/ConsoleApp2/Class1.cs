using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ArrayDemo
    {
        public void GetTotalTickets()
        {
            //what is jagged array? easy to customize
            string[][] counter = new string[3][];
            counter[0] = new string[3];
            counter[1] = new string[2];
            counter[2] = new string[4];
            counter[0][0] = Console.ReadLine();
            counter[0][1] = "P2";
            counter[0][2] = "P3";
        }
    }
}
