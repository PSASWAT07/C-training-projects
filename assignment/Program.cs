using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_NetworkLog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Network testUsage = new Network();
            testUsage.gatherNetworkLog();
            Console.WriteLine("Program Completed Successfully");
        }
    }
}
