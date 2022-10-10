using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dziedziczenie.obiekty;
using static Dziedziczenie.obiekty.Autobus;

namespace Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //samochód osobowy
            SamochódOsobowy s1 = new SamochódOsobowy(40, "czerwony", "honda");
            s1.UruchomSilnik();

            //ciężarkówka
            Ciężarówka c1 = new Ciężarówka(600, "szary", "man", 5000);
            c1.UruchomSilnik();

            //autobus
            Autobus a1 = new Autobus(500, "biały", "mercedes-benz", 60);
            a1.UruchomSilnik();

            //po co jest dziedziczenie?
            // - mniej kodu, bardziej przejżysty kod
            // - gruopowanie elementów w przypadku ich przechowywania (tablice oogólniejszego typu)

            //wszystkie obiekty dziedziczą po najogólnieszej klasie jaką jest Object
            Object Autobus = new Autobus(200, "ciemny", "man", 80);


            Console.WriteLine();
            Console.WriteLine("Metody dziedziczone z klasy Object:");
            //metody dziedziczone z klasy Object

            //1.reprezentajca znakowa obiektu (może być spersonalizowana)
            Console.WriteLine(s1.ToString());
            //2.typ obiektu
            Console.WriteLine(s1.GetType());
            //3.unikalny kod obiektu
            Console.WriteLine(s1.GetHashCode());

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Nowa lekcja");
            Console.WriteLine("--------------------------------------");

            Autobus autobus1 = new Autobus(300, "czarny", "man", 40);
            autobus1.Info();
            //nadpisana metoda ToString()    -   override
            Console.WriteLine(autobus1.ToString());

            Osoba o1 = new Osoba("Adam", "Kowalski", 20);
            Osoba.WypiszLicznik();

            Osoba o2 = new Osoba("Paweł", "Pawłowski", 21);
            Osoba.WypiszLicznik();

            Console.WriteLine(o2.Unikatowy_kod);

            Console.ReadLine();

        }
    }
}
