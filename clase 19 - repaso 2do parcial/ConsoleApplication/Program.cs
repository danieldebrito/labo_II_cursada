using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Goma g0 = new Goma("Faber", 5.25, true);
            Goma g1 = new Goma("Stander",5.60, false);
            Goma g2 = new Goma("faber", 7.60, true);

            Lapicera l0 = new Lapicera("bic", 5.60, ConsoleColor.Black, "fino");
            Lapicera l1 = new Lapicera("Faber", 7.60, ConsoleColor.Red, "medio");
            Lapicera l2 = new Lapicera("Pelican", 8.30, ConsoleColor.Blue, "grueso");

            Cartuchera<Utiles> c = new Cartuchera<Utiles>(5);

            #region agregados
            try
            {
                if (c + l0)
                    Console.WriteLine("agregado");
                if (c + l1)
                    Console.WriteLine("agregado");
                if (c + l2)
                    Console.WriteLine("agregado");
                if (c + g0)
                    Console.WriteLine("agregado");
                if (c + g1)
                    Console.WriteLine("agregado");
                if (c + g2)
                    Console.WriteLine("agregado");
            }
            catch (CartucheraLLenaException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\archList.xml";
            c.SerializarXML(path);
            Console.ReadLine();
            
            Console.WriteLine(c.ToString());
            Console.ReadLine();

        }
    }
}
