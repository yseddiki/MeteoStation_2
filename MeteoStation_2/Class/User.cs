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
        internal String name;
        internal String pwd;
        internal int Access;
        public User(int iD, string type, string etat, int access)
        {
            ID = iD;
            name = type;
            pwd = etat;
            Access = access;
        }
    }
}
