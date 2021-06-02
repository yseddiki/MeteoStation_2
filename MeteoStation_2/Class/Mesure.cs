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
        internal int Minint{ get; set; }
        internal int Maxint { get; set; }
        internal int MinAlarm{ get; set; }
        internal int MaxAlarm { get; set; }   
        internal double DataConvert { get; set; }
        
        internal int getDataConvert()
        {
            ///////////////////////////////////////////////
            ////Cette méthode sert à  convertir les données
            int DataConvert;
            double denomiteur = Math.Pow(2, cptOctet * 8) - 1;
            DataConvert = (int)((data / denomiteur) * (Maxint - Minint)) + Minint;
            return DataConvert;
        }
    }

}
