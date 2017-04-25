using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LavaderoLibreria;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region instancio vehiculos
            Auto a1 = new Auto("EXP-123", 4, EMarcas.Fiat, 4);
            Auto a2 = new Auto("CAM-934", 4, EMarcas.Ford, 6);
            Auto a3 = new Auto("AKL-279", 4, EMarcas.Fiat, 2);
            Auto a4 = new Auto("DQW-469", 4, EMarcas.Ford, 4);

            Moto m1 = new Moto("SDE-587",2,EMarcas.Honda,125);
            Moto m2 = new Moto("DER-874",2,EMarcas.Zanella,650);
            Moto m3 = new Moto("BOB-077",2,EMarcas.Honda,100);
            Moto m4 = new Moto("CFK-678",2,EMarcas.Zanella,1250);

            Camion c1 = new Camion("SYD-023",6,EMarcas.Iveco,8542.22f);
            Camion c2 = new Camion("PAN-079",18, EMarcas.Scania, 78442.22f);
            Camion c3 = new Camion("SAB-085",4, EMarcas.Scania, 1442.22f);
            Camion c4 = new Camion("DAN-079",8, EMarcas.Iveco, 6542.22f);
            #endregion

            Lavadero l1 = new Lavadero(200.00f,350.00f,125.50f);

            l1 += a1;
            l1 += a2;
            l1 += c1;
            l1 += c4;
            l1 += m2;
            l1 += m3;
            
            Console.WriteLine("Muestro el listado de vehiculos");
            Console.WriteLine(l1.LavaderoInfo);

            Console.WriteLine("Total facturado de autos");
            Console.WriteLine(l1.MostrarTotalFacturado(EVehiculos.auto).ToString() );

            Console.WriteLine("Total facturado de motos");
            Console.WriteLine(l1.MostrarTotalFacturado(EVehiculos.moto).ToString());

            Console.WriteLine("Total facturado de camiones");
            Console.WriteLine(l1.MostrarTotalFacturado(EVehiculos.camion).ToString());

            Console.WriteLine("Quito un camion");
            l1 -= c4;
            Console.WriteLine("Total facturado de camiones");
            Console.WriteLine(l1.MostrarTotalFacturado(EVehiculos.camion).ToString());

            Console.WriteLine("Ordeno por marca");
            l1.Vehiculos.Sort(l1.OrdenarVehiculosPorMarca);
            Console.WriteLine(l1.LavaderoInfo);

            Console.WriteLine("Ordeno por patente");
            l1.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine(l1.LavaderoInfo);

            Console.ReadKey();
        }
    }
}
