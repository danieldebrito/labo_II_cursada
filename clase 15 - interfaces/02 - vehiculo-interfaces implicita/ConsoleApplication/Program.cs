using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryVehiculo;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Carreta c = new Carreta(1656);

            Console.WriteLine(c.CalcularImpuesto());

            Console.ReadKey();
        }
    }
}
