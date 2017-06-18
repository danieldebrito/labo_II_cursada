using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcepcionesClassLibrary;
using FrutaClassLibrary;
using InterfacesClassLibrary;



namespace ConsoleApplication
{
    class Program
    {
        private static bool Serializar(ISerializable obj)
        {
            return obj.serializar();
        }
        private static bool Deserializar(ISerializable obj)
        {
            return obj.deserealizar();
        }

        static void Main(string[] args)
        {

            Cajon<Fruta> cf = new Cajon<Fruta>(3, 354.12f);
            Cajon<Platano> cp = new Cajon<Platano>(3,245.50f);

            Manzana m1 = new Manzana(45, ConsoleColor.Red, "BS S.A.");
            Manzana m2 = new Manzana(55, ConsoleColor.Green, "SYD S.A.");

            Platano p1 = new Platano(35,ConsoleColor.Green, "Ecuador");
            Platano p2 = new Platano(45,ConsoleColor.Yellow, "Brasil");

            try
            {
                cf += m1;
                cf += m2;
                cf += p1;
                cf += p2;
            }
            catch (CajonLlenoException e)
            {
                Console.WriteLine(e.Message);
            }

            cp += p1;
            cp += p2;

            //---------------------------------------------------------------//

            Console.WriteLine(cf.ToString());
            Console.ReadKey();
            Console.Clear();

            //---------------------------------------------------------------//

            Console.WriteLine(cp.ToString());
            Console.ReadKey();
            Console.Clear();

            //----------------------------------------------------------------//

            if(Program.Serializar(m1))
                Console.WriteLine("serializo ok");
            if (Program.Serializar(cf))
                Console.WriteLine("serializo ok");

            if (Program.Deserializar(cf))
                Console.WriteLine("Deserializar ok");

            //----------------------------------------------------------------//


            Ticketeadora.ImprimirTicket(cp, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ticket.txt");
        }
    }
}
