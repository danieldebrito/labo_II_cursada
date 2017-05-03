using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _GeneradorDePaginas;
        protected float _precio;
        protected string _titulo;

        static Libro()
        {
            _GeneradorDePaginas = new Random();
        }
        public Libro(float precio, string titulo, string nombre, string apellido)
        {
            this._autor = new Autor(nombre, apellido);
            this._cantidadDePaginas = this.CantidadDePaginas;
            this._precio = precio;
            this._titulo = titulo;
        }
        public Libro(string titulo, Autor autor, float precio)
        {
            this._autor = autor;
            this._titulo = titulo;
            this._precio = precio;
        }
        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }
        public int CantidadDePaginas
        { 
            get 
            {
                //_GeneradorDePaginas = new Random();
                if (this._cantidadDePaginas == 0)
                    return this._cantidadDePaginas = _GeneradorDePaginas.Next(10,580);
                else
                    return this._cantidadDePaginas;
            }
        }
        private static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TITULO: " + l._titulo);
            sb.AppendLine("CANTIDAD DE PAGINAS: " + l.CantidadDePaginas.ToString());
            sb.AppendLine("AUTOR: " + l._autor);
            sb.Append("PRECIO: " + l._precio.ToString());

            return sb.ToString();
        }
        public static bool operator ==(Libro a, Libro b)
        {
            if (a._titulo == b._titulo && a._autor == b._autor)
                return true;
            return false;
        }
        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }
    }
}
