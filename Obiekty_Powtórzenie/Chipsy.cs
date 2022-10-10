using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiekty_Powtórzenie
{
    public class Chipsy
    {
        public int gramatura;
        public string smak;
        public double wartoscOdzywcza;
        public void WypiszInformacje()
        {
            Console.WriteLine("Informacje o Chipsach:");
            Console.WriteLine($"Smak chipsów to {smak}");
            Console.WriteLine($"Paczka waży: {gramatura}g");
            Console.WriteLine($"Wrtość odżywcza: {wartoscOdzywcza}kcal");
            Console.WriteLine();
        }
    }
}
