using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaBiblioteku
{
    internal class Korisnici
    {
        public Korisnici(int oIB, string ime, string prezime)
        {
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
        }

        int OIB { get; set; }
        string Ime { get; set; }
        string Prezime { get; set; }
    }
}
