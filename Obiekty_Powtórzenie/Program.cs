using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiekty_Powtórzenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chipsy lays = new Chipsy();
            lays.smak = "paprykowe";
            lays.gramatura = 300;
            lays.wartoscOdzywcza = 400;

            Chipsy crunchips = new Chipsy();
            crunchips.smak = "cebulkowe";
            crunchips.gramatura = 150;
            crunchips.wartoscOdzywcza = 200;

            lays.WypiszInformacje();
            crunchips.WypiszInformacje();

            Console.ReadLine();
        }
    }
}
