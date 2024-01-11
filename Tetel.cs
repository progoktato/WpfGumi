using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGumi
{
    public class Tetel
    {
        String tipus; // Téli, nyári, négyévszakos
        int szelesseg;
        int magassag;
        string atmero;
        int darab;

        public Tetel(string tipus, int szelesseg, int magassag, string atmero, int darab)
        {
            this.tipus = tipus;
            this.szelesseg = szelesseg;
            this.magassag = magassag;
            this.atmero = atmero;
            this.darab = darab;
        }

        public string Típus { get => tipus; set => tipus = value; }
        public int Szélesség { get => szelesseg; set => szelesseg = value; }
        public int Magasság { get => magassag; set => magassag = value; }
        public string Átmérő { get => atmero; set => atmero = value; }
        public int Darab { get => darab; set => darab = value; }
    }
}
