using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listPerson = new List<Persona>();

            Alumno a1 = new Alumno("Daniel", "de Brito", 27303483);
            Empleado e1 = new Empleado("Ricardo", "Martinez", 25451254);
            Profesor p1 = new Profesor("Maximiliano", "Neiner", 2545125, 1245, 24125.33f, "Programacion II");


            listPerson.Add(a1);
            listPerson.Add(e1);
            listPerson.Add(p1);


            //Console.WriteLine(a1.MostrarAlumno());

            foreach(Persona p in listPerson)
            {
                if(p is Alumno)
                    Console.WriteLine(((Alumno)p).MostrarAlumno());
                if (p is Empleado)
                    Console.WriteLine(((Empleado)p).MostrarEmpleado());
                if (p is Profesor)
                    Console.WriteLine(((Profesor)p).MostrarProfesor());


            }

            Console.ReadKey();




        }
    }
}
