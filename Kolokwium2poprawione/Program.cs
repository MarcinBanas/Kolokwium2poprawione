using System;
using System.Collections.Generic;
using System.IO;

namespace Kolokwium2poprawione
{
    class Program
    {
        public static void DodajPracownika(List<Pracownik> Lista)
        {
            string imie, nazwisko, stanowisko;
            Console.WriteLine("Podaj Imie:");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj Nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj Stanowisko:");
            stanowisko = Console.ReadLine();
            Pracownik P = new Pracownik(imie, nazwisko, stanowisko);
            Lista.Add(P);
        }
        public static void UsunPracownika(List<Pracownik> Lista)
        {

            int i = 1;
            Console.WriteLine("Ktorego pracownika usunac?");
            foreach (var item in Lista)
            {
                Console.Write(i + " ");
                item.Wyswietl();
                i++;
            }
            Console.Write(":");
            int a = Convert.ToInt32(Console.ReadLine());
            Lista.RemoveAt(a - 1);


        }
        static void Main(string[] args)
        {
            //z1
            string DowolnyTekst = Console.ReadLine();
            List<char> lista = new List<char>();
            lista.AddRange(DowolnyTekst);
            lista.Sort();
            foreach (var item in lista)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            int Pojemnosc = (lista.Count) / 2;
            Console.WriteLine("Mediana: "+lista[Pojemnosc]);

            //z2
            Serwis s = new Serwis("C:\\Mar\\Log.txt");
            s.jeden(4, 2);
            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            a.Add(5);
            s.dwa(a);

            //z3
            List<Pracownik> ListaPracownikow = new List<Pracownik>();
            FileStream FSPlik = new FileStream("C:\\Mar\\ListaPracownikow.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader SRPlik = new StreamReader(FSPlik);

            while (!SRPlik.EndOfStream) 
            {
                string textline = SRPlik.ReadLine();
                string[] wyrazy = textline.Split(' ');
                string imie, nazwisko, stanowisko;
                imie = wyrazy[0];
                nazwisko = wyrazy[1];
                stanowisko = wyrazy[2];
                ListaPracownikow.Add(new Pracownik(imie, nazwisko, stanowisko));

            }
            SRPlik.Close();
            int i = 0;
            do
            {
                Console.WriteLine("1-Dodaj pracownika,2-Usun pracownika,3-Wyswietl liste,4-Zamknij program");
                i = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    DodajPracownika(ListaPracownikow);
                }
                else if (i == 2)
                {
                    if (ListaPracownikow.Count != 0)
                    {
                        UsunPracownika(ListaPracownikow);
                    }
                    else
                    {
                        Console.WriteLine("Lista pracownikow jest pusta");
                    }
                }
                else if (i == 3)
                {
                    if (ListaPracownikow.Count != 0)
                    {
                        foreach (var item in ListaPracownikow)
                        {
                            item.Wyswietl();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lista pracownikow jest pusta");
                    }
                }
                else if (i == 4)
                {
                    FileStream FSPlik2 = new FileStream("C:\\Mar\\ListaPracownikow.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamWriter SWPlik = new StreamWriter(FSPlik2);
                    foreach (var item in ListaPracownikow)
                    {
                        SWPlik.WriteLine(item.Imie + " " + item.Naziwsko + " " + item.Stanowisko);
                    }
                    SWPlik.Close();
                }
            }
            while (i != 4);
            
        }
    }
}
