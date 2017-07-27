using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProveedorClassLibrary;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            bool cont = true;
            Agenda<Proveedor> agenda = new Agenda<Proveedor>(10);
            agenda.RutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "archivo.xml";
            
            do{
            Console.WriteLine("1 - CARGAR ARCHIVO");
            Console.WriteLine("2 - AGREGAR DATOS");
            Console.WriteLine("3 - GUARDAR ARCHIVO");
            Console.WriteLine("4 - MOSTRAR DATOS");
            Console.WriteLine("5 - SALIR");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1 :
                    if (agenda.deserealizar(agenda.RutaArchivo))
                    {
                        Console.WriteLine("archivo leido....");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;
                case 2 :
                    Proveedor p = new Proveedor();
                    
                    Console.WriteLine("Ingrese ID ");
                    p.ID = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Ingrese RZ ");
                    p.RazonSocial = Console.ReadLine();
                    
                    Console.WriteLine("Ingrese CUIT ");
                    p.CUIT = Console.ReadLine();
                    agenda += p;
                    break;
                case 3 :
                    if (agenda.serializar(agenda.RutaArchivo))
                    {
                        Console.WriteLine("guardado ok....");
                        Console.ReadKey();
                    }
                    break;
                case 4 :
                    Console.Clear();
                    Console.WriteLine(agenda.ToString());
                    Console.ReadKey();
                    
                    break;
                default:
                    cont = false;
                    break;
            }
            Console.Clear();
            }while(cont);
        }
    }
}
