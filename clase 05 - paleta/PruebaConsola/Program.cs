using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaletaLibreria;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Paleta p1 = 3;

            Tempera t_roja = new Tempera(ConsoleColor.Red, "faber", 5);
            Tempera t_verde = new Tempera(ConsoleColor.Green, "pelican", 4);
            Tempera t_azul = new Tempera(ConsoleColor.Blue, "eding", 6);
            Tempera t_amarilla = new Tempera(ConsoleColor.Yellow, "faber", 7);
           
            p1 += t_roja;
            p1 += t_verde;
            p1 += t_verde;  // como esta repetida, suma la cantidad
            p1 += t_azul;
            p1 += t_amarilla; // no entra, paleta llena

            Console.WriteLine((string)p1);

            p1 -= t_verde;  // quito la verde, para que entre amarilla en su posicion
            p1 += t_amarilla;  // sumo nuevamente la amarilla

            Console.WriteLine((string)p1);
            
            Console.ReadKey();
        }
    }
}
