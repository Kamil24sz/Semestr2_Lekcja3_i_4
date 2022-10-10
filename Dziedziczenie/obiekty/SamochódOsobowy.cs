using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.obiekty
{
    //zapis oznaczjący dziedziczenie    nazwaKlasy : klasaNadrzędna
    //odziedziczone zostają wszystkie właściwości oraz metody
    public class SamochódOsobowy : Pojazdy
    {

        //konstruktor 
        //służy do tworzenia obiektu na podstawie przyjętych argumentów
        //dziedziczenie konstruktora jest opcjonalne
        public SamochódOsobowy(int moc, string kolor, string marka) : base(moc, kolor, marka)
        {
        }

        public void UruchomSilnik()
        {
            Console.WriteLine("Silnik samochodu został uruchomiony...");
        }
    }
}
