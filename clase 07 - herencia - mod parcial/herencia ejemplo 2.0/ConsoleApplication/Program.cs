using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona p = new Persona("jay key", ENacionalidad.argentino, 38, "M");
            Alumno a = new Alumno(p, 10);
            AlumnoEgresado ae = new AlumnoEgresado(a, "verdulero");

            Console.WriteLine("---------persona-------------");
            Console.WriteLine(p.ToString());
            Console.WriteLine("---------alumno-------------");
            Console.WriteLine(a.ToString());
            Console.WriteLine("---------alumno egresado-------------");
            Console.WriteLine(ae.ToString());

            Console.ReadKey();
        }
    }
}
