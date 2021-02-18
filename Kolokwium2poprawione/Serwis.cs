using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Kolokwium2poprawione
{
    class Serwis
    {
        public string Sciezka { get; set; }

        public Serwis(string sciezka)
        {
            Sciezka = sciezka;
           
        }

        public void Loguj(string Log)
        {
            
                FileStream log = new FileStream(this.Sciezka, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(log);

                sw.WriteLine(Log);
                sw.WriteLine("----");
                sw.Close();
            
        }
        public double jeden(int x,int y)
        {
            string Inf = ("Wywolano metode jeden, ktora przyjela parametry x:" + x + " oraz y:" + y);
            Loguj(Inf);
            string Inf2 = "Wynik:" + (x / y) + " JEDEN";
            Loguj(Inf2);
            return x/y;
        }
        public void dwa(List<int> a)
        {
            string x=null;
            for (int i = 0; i < a.Count; i++)
            {
                x+=a[i].ToString();
            }
            string Inf = "Wywolano metode dwa, ktora przyjela parametry:"+x;
            Loguj(Inf);
            Console.WriteLine("Ilosc elementow: "+a.Count);
        }
    }
}
