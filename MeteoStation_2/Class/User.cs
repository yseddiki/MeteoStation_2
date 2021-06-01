using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoStation_2.Class
{
    class User
    {
        internal int ID;
        internal String Type;
        internal String Etat;
        internal int Access;
        public User(int iD, string type, string etat, int access)
        {
            ID = iD;
            Type = type;
            Etat = etat;
            Access = access;
        }
    }
}
