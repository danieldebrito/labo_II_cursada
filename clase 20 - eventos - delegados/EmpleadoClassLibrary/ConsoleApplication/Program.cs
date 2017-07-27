using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpleadoClassLibrary;

namespace ConsoleApplication
{
    class Program
    {
        //manejador de eventos estatico
        public static void manejadorEventos()
        {
            Console.WriteLine("manejador de eventos");
            Console.WriteLine("empleado con sueldo mayor a 9500");
        }

        // manejador de eventos de instancia
        public void manejadorEventosInstancia()
        {
            Console.WriteLine("manejador de eventos de instancia");
            Console.WriteLine("empleado con sueldo mayor a 9500");
        }

        // main
        static void Main(string[] args)
        {
            Program p = new Program();

            Empleado e1 = new Empleado("Bob", "Marley", 100);
            Empleado e2 = new Empleado("Petter", "tosh", 101);

            // instancio el evento y le paso el nombre del manejador
            // en este caso le paso la direccion de memoria
            // no le pongo () justamente por que le paso la dir de memonria

            // asigno manejador estatico
            e1.SueldoEvent += manejadorEventos;
            //asigno manejador de instancia
            e1.SueldoEvent += p.manejadorEventosInstancia;

            //asigno sueldo superior a 9500 para que lance el evento
            e1.Sueldo = 100000;

            Console.ReadKey();

            //quito manejador de instancia
            e1.SueldoEvent -= p.manejadorEventosInstancia;

            e1.Sueldo = 100000;

            try
            {
                e2.Sueldo = -100000;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
            Console.WriteLine(e1);
            Console.ReadKey();
        }
    }
}
