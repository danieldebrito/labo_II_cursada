using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehiculos;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            Cohete c1 = new Cohete(5, EVelocidad.Hiper, "apollo11");

            Auto a1 = new Auto(5,EVelocidad.Super,4);

            Caballo ca1 = new Caballo (2,EVelocidad.Minima,"Carrera","Marron");


            Console.WriteLine(c1.ToString());
            Console.WriteLine(ca1.ToString());
            Console.WriteLine(a1.ToString());

            Console.ReadKey();
            Console.Clear();


            lista.Add(a1);
            lista.Add(ca1);
            lista.Add(c1);


            foreach (Vehiculo v in lista)
            {
                Console.WriteLine(v.ToString());
                Console.WriteLine(v.acelerar());
                Console.WriteLine(v.frenar());
                Console.WriteLine("");
                Console.WriteLine("=====================================");
            }


            Console.ReadKey();
            Console.Clear();





            Console.ReadKey();



        }
    }
}
