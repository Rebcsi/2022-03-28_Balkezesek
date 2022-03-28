using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_28_Balkezesek
{
    class sportoló
    {
        public string Név { get; set; }
        public string Első { get; set; }
        public string Utolsó { get; set; }
        public int Súly { get; set; }
        public int Magasság { get; set; }

        public sportoló(string sor)
        {
            string[] t = sor.Split(';');
            Név = t[0];
            Első = t[1];
            Utolsó = t[2];
            Súly = int.Parse(t[3]);
            Magasság = int.Parse(t[4]);
        }
    }
}
