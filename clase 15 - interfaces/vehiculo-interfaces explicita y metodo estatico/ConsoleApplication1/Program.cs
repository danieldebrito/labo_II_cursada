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

            Console.WriteLine("deportivo afip");
            Console.WriteLine(Gestion.MostrarImpuestoNacional(d));

            Console.WriteLine("deportivo arba");
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(d));

            Console.ReadKey();
        }
    }
}