using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.obiekty
{
    public class Ciężarówka : Pojazdy
    {

        public int ladownosc;

        public Ciężarówka(int moc, string kolor, string marka, int ladownosc) : base(moc, kolor, marka)
        {
            this.ladownosc = ladownosc;
        }

        public void UruchomSilnik()
        {
            Console.WriteLine("Silnik ciężarówki został uruchomiony...");
        }

    }
}
