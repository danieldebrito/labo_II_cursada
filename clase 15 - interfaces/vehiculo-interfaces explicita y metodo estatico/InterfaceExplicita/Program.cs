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
            Deportivo d = new Deportivo(15487, "exp123", 45);

            // invoco a la interface explicita
            Console.WriteLine("impuestos Deportivo");
            Console.WriteLine(((IAFIP)d).CalcularImpuesto());
            Console.WriteLine(((IARBA)d).CalcularImpuesto());

            Console.ReadKey();
        }
    }
}