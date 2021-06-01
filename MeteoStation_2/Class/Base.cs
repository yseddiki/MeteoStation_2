using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoStation_2.Class
{
    class Base
    {
        public int id { get; set; }
        public int cptOctet { get; set; }
        public int Type { get; set; }
        public int checksum { get; set; }
        public UInt32 data{ get; set; }
        internal bool isConfigured { get; set; } = false;
    }
}
