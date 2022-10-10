using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.obiekty
{
    public class Pojazdy
    {
        //właściwości
        public int moc;
        public string kolor;
        public string marka;

        //konstruktor
        public Pojazdy(int moc, string kolor, string marka)
        {
            this.moc = moc;
            this.kolor = kolor;
            this.marka = marka;
        }

        //Metoda opisująca
        public virtual void Info()
        {
            Console.WriteLine("Jestem klasą pojazd");
        }

    }
}
