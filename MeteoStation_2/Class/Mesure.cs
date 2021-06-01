using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MeteoStation_2.Class
{
    class Mesure : Base
    {
        internal int MinVal{ get; set; }
        internal int MaxVal { get; set; }
        internal int MinAlarm{ get; set; }
        internal int MaxAlarm { get; set; }   
        internal double DataConvert { get; set; }
    }

}
