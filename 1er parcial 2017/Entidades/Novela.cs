using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela:Libro
    {
        public EGenero _genero;

        public Novela(string titulo, float precio, Autor autor, EGenero genero)
            : base(titulo, autor, precio)
        {
            this._genero = genero;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine((string)((Libro)this));
            sb.AppendLine("Genero: " + this._genero.ToString());

            return sb.ToString();
        }
        public static bool operator ==(Novela a, Novela b)
        {
            return ((Libro)a == (Libro)b && a._genero == b._genero);
        }
        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }
        public static implicit operator double(Novela m)
        {
            return double.Parse(m._precio.ToString());
        }
    }


}
