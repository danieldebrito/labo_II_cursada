using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades

{
    public enum ELibro{Manual, Novela}

    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        private Biblioteca()
        {
            this._libros = new List<Libro>(this._capacidad);
        }
        private Biblioteca(int capacidad)
            :this()
        {
            this._capacidad = capacidad;
        }

        public static String Mostrar(Biblioteca e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad de la biblioteca: " + e._capacidad.ToString());
            sb.AppendLine("Total por manuales: " + e.ObtenerPrecio(ELibro.Manual));
            sb.AppendLine("Total por novelas: " + e.ObtenerPrecio(ELibro.Novela));
            sb.AppendLine("*************************");
            sb.AppendLine("LISTADO DE LIBROS");
            sb.AppendLine("*************************");

            foreach (Libro l in e._libros)
            {

                if (l is Novela)
                    sb.AppendLine(((Novela)l).Mostrar());
                if (l is Manual)
                    sb.AppendLine(((Manual)l).Mostrar());
            }
            return sb.ToString();
        }
        public static implicit operator Biblioteca(int capacidad)
        {
            return new Biblioteca(capacidad);
        }
        public static bool operator == (Biblioteca e, Libro l)
        {

            foreach (Libro li in e._libros)
            {

                if ( li == l)
                    return true;
            
            }
            return false;
        
        }
        public static bool operator != (Biblioteca e, Libro l)
        {
            return !(e == l);
        }
        public static Biblioteca operator + (Biblioteca e, Libro l)
        {
            if (e._libros.Count >= e._capacidad)
            {
                Console.WriteLine("No hay capacidad");
                return e;
            }
            if(e == l)
            {
                Console.WriteLine("El libro ya esta en la bilioteca");
            return e;
            }

            e._libros.Add(l);
                    return e;
        }
        private double ObtenerPrecio(ELibro tipoLibro)
        { 
            double acum = 0;

            foreach(Libro l in this._libros)
            {

                if ((ELibro)tipoLibro == ELibro.Novela && l is Novela)
                    acum += ((double)((Novela)l));
                if ((ELibro)tipoLibro == ELibro.Manual && l is Manual)
                    acum += ((double)((Manual)l));

        }

            return acum;
        
        }
    }
}
