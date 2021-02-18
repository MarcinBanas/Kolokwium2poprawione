using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2poprawione
{
    class Pracownik
    {
        public string Imie { get; set; }
        public string Naziwsko { get; set; }
        public string Stanowisko { get; set; }

        public Pracownik(string imie,string nazwisko,string stanowisko)
        {
            Imie = imie;
            Naziwsko = nazwisko;
            Stanowisko = stanowisko;
        }
        public void Wyswietl()
        {
            Console.WriteLine(this.Imie+" "+this.Naziwsko+" "+this.Stanowisko);
        }
    }
}
