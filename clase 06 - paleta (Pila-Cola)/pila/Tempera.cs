using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletaLibreria
{
    public class Tempera
    {
        private ConsoleColor _color;
        private String _marca;
        private int _cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
    
            sb.Append("Color: ");
            sb.AppendLine(this._color.ToString());
            sb.Append("Marca: ");
            sb.AppendLine(this._marca.ToString());
            sb.Append("Cantidad: ");
            sb.AppendLine(this._cantidad.ToString());

            return sb.ToString();
        }

        public static implicit operator string (Tempera t)
        {
            if(!(Object.Equals(t,null))) // VALIDA != NULL, SI NO EXPLOTA!!       
                return t.Mostrar();
            return ""; // si es null retorna un string vacio
        }

        public static bool operator == (Tempera t, Tempera t1)
        {
            if (Object.Equals(null, t) || Object.Equals(null, t1))
                return false;
            return t._marca == t1._marca && t._color == t1._color;
        }

        public static bool operator != (Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static Tempera operator + (Tempera t, int cant)
        {
            t._cantidad += cant;
            return t;
        }

        public static Tempera operator + (Tempera t1, Tempera t2)
        {
            if (t1 == t2)
                t1._cantidad += t2._cantidad;
            return t1;
        }
    }
}