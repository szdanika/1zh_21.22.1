using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zh_21._22._1
{
    internal class Meteoroid : Egitest
    {
        int sebesseg;
        Random rnd = new Random();

        public Meteoroid(bool elheto, string nev, int tomeg) : base(false, nev, tomeg)
        {
            sebesseg = rnd.Next(1, 101);
        }
    }
}
