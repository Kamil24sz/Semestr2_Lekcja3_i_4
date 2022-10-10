using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.obiekty
{
    public class Autobus : Pojazdy
    {
        //właściwość statyczna
        public static int LicznikAutobusów = 0;

        //zwykła właściwość
        public int liczbaMiejsc;

        public Autobus(int moc, string kolor, string marka, int liczbaMiejsc) : base(moc, kolor, marka)
        {
            this.liczbaMiejsc = liczbaMiejsc;
        }

        //zwykła metoda
        public void UruchomSilnik()
        {
            Console.WriteLine("Silnik autobusu został uruchomiony...");
        }

        //nadpisana metoda Info
        public override void Info()
        {
           Console.WriteLine("Jestem klasą autobus");
        }

        //nadpisana metoda ToString()
        public override string ToString()
        {
            return $"{moc}, {kolor}, {marka}, {liczbaMiejsc}";
        }

        //metoda statyczna
        public static void WypiszLicznik()
        {
            Console.WriteLine(LicznikAutobusów);
        }

    }
}
