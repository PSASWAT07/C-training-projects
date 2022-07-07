using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson
{

    public class NetworkLog
    {
        public int Id { get; set; }
        public long Source { get; set; }
        public long Destination { get; set; }
        public DateTime TheDate { get; set; }
        public string Status { get; set; }
        public string Network { get; set; }
    }




}