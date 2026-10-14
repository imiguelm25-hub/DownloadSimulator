using System;
using System.Collections.Generic;
using System.Text;

namespace Ariketa8
{
    public class Fitxategia
    {

        public string Izena { get; set; }
        public int Tamaina { get; set; }


        public Fitxategia(string izena, int tamaina)
        {
            Izena = izena;
            Tamaina = tamaina;
        }
    }
}