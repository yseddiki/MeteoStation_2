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
        internal bool isConfigured { get; set; } = false;
        internal double DataConvert;      
    }

}
