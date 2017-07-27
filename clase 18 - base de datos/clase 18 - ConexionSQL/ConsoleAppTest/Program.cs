using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionSQLLibrary;


namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // muestro info con metodo
            if (ConexionSQL.TestConetion())
                Console.WriteLine(ConexionSQL.traerInfo());

            Console.ReadKey();
            Console.Clear();

            //obtengo y muestro una lista generica a partir del archivo
            Console.WriteLine(ConexionSQL.getLista().ToString());

            Console.ReadKey();
            Console.Clear();

            // agrego una persona
            Persona p1 = new Persona(4, "John", "Lennon", 68);

            ConexionSQL.agregarPersona(p1);
            Console.WriteLine(ConexionSQL.getLista().ToString());

            Console.ReadKey();
            Console.Clear();

            //modifico una persona

            Persona pID = ConexionSQL.ObtenerPersonaPorID(5);

            Console.WriteLine("persona a modificar: ");
            try
            {
                Console.WriteLine(pID.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Nueva persona: ");
            Persona pNew = new Persona(pID.ID, "Deborah", "Harry", 65);
            Console.WriteLine(pNew.ToString());

            ConexionSQL.ModificarPersona(pNew);

            Console.WriteLine("Lista actualizada: ");
            Console.WriteLine(ConexionSQL.getLista());

            Console.ReadKey();
            Console.Clear();





        }
    }
}
