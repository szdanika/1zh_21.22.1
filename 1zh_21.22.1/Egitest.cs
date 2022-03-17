using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zh_21._22._1
{
    internal class Egitest : IEgitest
    {
        public bool Elheto { get; private set; }
        public string Nev { get; private set; }
        int tomeg;

        public Egitest(bool elheto, string nev, int tomeg)
        {
            Elheto = elheto;
            Nev = nev;
            this.tomeg = tomeg;
        }

        public int CompareTo(object obj)
        {
            return 1;
        }
        public Egitest[] novekvo(Egitest[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                if(i+1 < tomb.Length-1 &&tomb[i].tomeg > tomb[i+1].tomeg)
                {
                    Egitest seged = tomb[i + 1];
                    tomb[i + 1] = tomb[i];
                    tomb[i] = seged;
                }    
            }
            return tomb;
        }
    }
}
