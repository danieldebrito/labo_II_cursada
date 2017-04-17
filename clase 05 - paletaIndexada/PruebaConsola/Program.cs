using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPaletaIndex;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            PaletaArray miPaleta = new PaletaArray("Paleta Nueva");

            miPaleta[0] = ConsoleColor.Black;
            miPaleta[1] = ConsoleColor.Blue;
            miPaleta[2] = ConsoleColor.Cyan;
            miPaleta[3] = ConsoleColor.DarkBlue;
            miPaleta[4] = ConsoleColor.Green;
            miPaleta[5] = ConsoleColor.Red;
            miPaleta[6] = ConsoleColor.White;
            miPaleta[7] = ConsoleColor.Yellow;
            miPaleta[8] = ConsoleColor.DarkMagenta;

            Console.WriteLine(PaletaArray.Mostrar(miPaleta));
            Console.ReadKey();
        }
    }
}
