using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeszMilan
{
    internal class Bolygo
    {
        public string Nev { get; set; }
        public int HoldSzama { get; set; }
        public string TerfogatAranyF { get; set; }


        public Bolygo(string sor)
        {

            var v = sor.Split(';');
            Nev = v[0];
            HoldSzama = int.Parse(v[1]);
            TerfogatAranyF =v[2];

        }
       
    }
}
