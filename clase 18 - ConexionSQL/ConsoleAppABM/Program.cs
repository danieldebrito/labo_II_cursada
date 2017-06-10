using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionSQLLibrary;

namespace ConsoleAppABM
{
    class Program
    {
        static void Main(string[] args)
        {
            string rta = "s";
            bool exit = false;
            int op;
            Persona p;

            while (string.Compare(rta, "s") == 0)
            {
                Console.WriteLine("ABM PERSONAS");

                Console.WriteLine("1 - ALTA");
                Console.WriteLine("2 - BAJA");
                Console.WriteLine("3 - MODIFICACION");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("4 - IMPRIMIR");
                Console.WriteLine("5 - SALIR");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1 /* ALTA */:
                        #region alta
                        Console.WriteLine();
                        Console.Write("Ingrese el ID:");
                        int ID = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Ingrese Nombre:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Ingrese Apellido:");
                        string apellido = Console.ReadLine();
                        Console.WriteLine(); 
                        Console.Write("Ingrese Edad:");
                        int edad = int.Parse(Console.ReadLine());

                        p = new Persona(ID, nombre, apellido, edad);
                        ConexionSQL.agregarPersona(p);
                        break;
                        #endregion
                    case 2 /* BAJA */:
                        #region baja
                        Console.WriteLine("Ingrese ID a buscar:");
                        int id = int.Parse(Console.ReadLine());
                        p = ConexionSQL.ObtenerPersonaPorID(id);

                        Console.WriteLine("===========================================================");
                            Console.WriteLine("{0,5} {1,15} {2,15} {3,15}", "ID", "APELLIDO", "NOMBRE", "EDAD");
                            Console.WriteLine("===========================================================");

                            Console.WriteLine("{0,5} {1,15} {2,15} {3,15}", p.ID, p.Apellido, p.Nombre, p.Edad);
                            
                            Console.WriteLine("Será eliminada, confirma?(s/n):");
                            string r = Console.ReadLine();

                        if (r.CompareTo("s") == 0)
                                if (ConexionSQL.DeletePersona(p))
                                    Console.WriteLine("Borrado ok");
                        break;
                        #endregion
                    case 4 /*IMPRIMIR*/:
                        Console.WriteLine(ConexionSQL.traerInfo());
                        break;
                    case 5 /* SALIR*/:
                        exit = true;
                        rta = "n";
                        break;
                    default:
                        break;
                }
                if(!exit)
                    Console.WriteLine("Continuar s/n");

                rta = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
