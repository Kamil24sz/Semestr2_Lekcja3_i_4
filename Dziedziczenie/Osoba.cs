using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Osoba
    {
        //właściwość statyczna
        private static int licznikOsób = 0; 
        private static string kodPracownika = "PRAC2022_";

        //zwykłe właściwości
        public string imie;
        public string nazwisko;
        public int wiek;
        public string Unikatowy_kod;

        //konstruktor
        public Osoba(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.Unikatowy_kod = kodPracownika + imie.Substring(0,1) + nazwisko.Substring(0,1) + wiek;
            licznikOsób++;
        }

        //metoda statyczna
        public static void WypiszLicznik()
        {
            Console.WriteLine($"Licznik osób wynosi: {licznikOsób}");
        }
    }
}
