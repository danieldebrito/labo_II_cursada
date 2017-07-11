using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesClassLibrary;
using FrutasClassLibrary;
using ExepcionesClassLibrary;

namespace ConsoleApplication
{
    public class Program
    {
        private static bool Serializar(ISerializable obj)
        {
            return obj.SerializarXML();
        }
        private static bool Deserializar(ISerializable obj)
        {
            return obj.Deserializar();
        }

        static void Main(string[] args)
        {
            Platano p1 = new Platano(451, ConsoleColor.Yellow, "Brasil");
            Platano p2 = new Platano(456, ConsoleColor.Green, "Ecuador");
            Manzana m1 = new Manzana(452, ConsoleColor.Red, "Mz S.A.");
            Manzana m2 = new Manzana(448, ConsoleColor.Green, "Mz S.A.");
            Manzana m3 = new Manzana(478, ConsoleColor.Green, "Mz S.A.");

            Cajon<Fruta> c = new Cajon<Fruta>(4, 122);
            Cajon<Platano> cajonPlatanos = new Cajon<Platano>(2, 254);

            try
            {
                cajonPlatanos += p1;
                cajonPlatanos += p2;

                c += p1;
                c += p2;
                c += m1;
                c += m2;
                c += m3;
            }
            catch (CajonLLenoExcepcion e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(c.ToString());

            cajonPlatanos.RutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ticket.txt";
            Ticketeadora.ImprimirTicket(cajonPlatanos, cajonPlatanos.RutaArchivo);

            c.RutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\cajon.xml";
            if (Program.Serializar(c))
                Console.WriteLine("serializo ok");


            Cajon<Fruta> c2 = new Cajon<Fruta>(4, 122);
            c.RutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\cajon.xml";
            if (Program.Deserializar(c))
                Console.WriteLine("Deserializar ok");

            c.RutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\cajon2.xml";
            if (Program.Serializar(c))
                Console.WriteLine("serializo ok");

            Console.ReadKey();
        }
    }
}
