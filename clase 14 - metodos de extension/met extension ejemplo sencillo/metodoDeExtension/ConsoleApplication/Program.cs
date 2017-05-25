using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libreriaSellada;  // namespace de la clase sellada refenciada desde el archivo dll
using persona;          // namespace de la libreria de clases que contiene la clase con los metodos de extension

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaSellada p = new PersonaSellada("Raul de Brito", 78);

            // implementacion del metodo de extension
            Console.WriteLine(p.Mostrar());

            Console.ReadKey();
        }
    }
}

