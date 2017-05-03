using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual:Libro
    {
        public ETipo _tipo;

        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo)
            : base(precio, titulo, nombre, apellido)
        {
            this._tipo = tipo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine( (string)((Libro)this));
            sb.AppendLine("tipo: " + this._tipo.ToString());

            return sb.ToString();
        }
        public static bool operator ==(Manual a, Manual b)
        { 
        if( a._autor == b._autor && a._titulo == b._titulo && a._tipo == b._tipo)
            return true;
        return false;
        }
        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }
        public static implicit operator double(Manual m)
        {
            return double.Parse(m._precio.ToString());
        }
    }
}
