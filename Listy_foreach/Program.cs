using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tworzymy tablicę na 5 elementów
            //int[] liczby = new int[5];

            //listy - nie musimy podawać ich rozmiaru
            List<int> liczby2 = new List<int>();

            double suma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj nową ocenę");
                int ocena = int.Parse(Console.ReadLine());
                //liczby[i] = ocena;

                //dodwanie przedmiotu na koniec listy
                liczby2.Add(ocena);
                suma = suma + ocena;

                Console.WriteLine($"Obecna średnia to {suma / (i+1)}");
                Console.WriteLine();
            }
            //Plusy Listy
            //nie musimy znać końcowej ilości elemetnów
            //nie musimy operować na indeksach

            //Minusy Listy
            //zużywa więcej pamięci
            //bardziej skąplikowana składnia

            
            



            Console.ReadLine();





        }
    }
}
