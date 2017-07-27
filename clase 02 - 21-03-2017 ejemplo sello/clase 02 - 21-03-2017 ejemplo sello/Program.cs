using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02Sello
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello s1 = new Sello();

            s1.mensage = "Daniel de Brito";
            s1.color = ConsoleColor.Red;

            Console.WriteLine(s1.Imprimir());
            s1.ImprimirEnColor();
            Console.WriteLine(s1.Imprimir());
            s1.Borrar();
            Console.WriteLine(s1.Imprimir());
            Console.ReadKey();

            s1.ImprimirEnColor();

            Console.ReadKey();
        }
    }
}
