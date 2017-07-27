using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejemplo_eventos;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            LanzaEventos l = new LanzaEventos(10000, 2);

            // asigno al evento la dir de memoria del metodo "manejador" la clase ManejadoraEventos
            l.eventoLanzado += ManejadoraEventos.manejador;

            // invoco al metodo que lanzara los eventos
            l.ContadorLanzador(l);

            Console.ReadKey();
        }
    }
}
