using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1_NetworkLog
{
    internal class Network
    {
        public void gatherNetworkLog()
        {

            FileStream fileStream = new FileStream("C:\Users\sapani\Documents\Csharp application\assignment", FileMode.Open, FileAccess.Read); // 'new' allocates new memory

            StreamReader streamReader = new StreamReader(fileStream);

            Console.WriteLine("ID\tSource\t\tDestination\t\tDate\t\tStatus\tNetwork\n");

            string temp = "";
            string[] util = new string[10];

            while (streamReader.Peek()> 0){ 
                temp = streamReader.ReadLine();

                if (temp.StartsWith("Id:"))
                {
                    util = temp.Split(':');
                    Console.Write(util[1] + "\t");
                }
                else if (temp.StartsWith("Source:"))
                {
                    util = temp.Split(':');
                    Console.Write(util[1] + "\t");
                }
                else if (temp.StartsWith("Destination:"))
                {
                    util = temp.Split(':');
                    Console.Write(util[1] + "\t");
                }
                else if (temp.StartsWith("Date:"))
                {
                    util = temp.Split(':');
                    Console.Write(util[1] + ":" + util[2] + ":" + util[3] + "\t");
                }
                else if (temp.StartsWith("Status:"))
                {
                    util = temp.Split(':');
                    Console.Write(util[1] + "\t");
                }
                else if (temp.StartsWith("Network:"))
                {
                    util = temp.Split(':');
                    Console.Write(util[1] + "\t");
                }
                else {
                    Console.WriteLine("");
                }
            }


            streamReader.Close();
            fileStream.Close();

            Console.WriteLine("\nFile Operation Completed!\n");
            Console.ReadLine();

        }
    }
}
