using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zh_21._22._1
{
    internal class Bolygo : Egitest
    {
        int holdakSzama;
        public Bolygo(bool elheto, string nev, int tomeg, int holdakszama) : base(holdakszama <=2, nev, tomeg)
        {
            this.holdakSzama = holdakszama;
        }

    }
}
