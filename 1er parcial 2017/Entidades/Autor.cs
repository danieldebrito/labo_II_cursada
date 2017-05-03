using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        private string _nombre;
        private string _apellido;

        public Autor(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        public static implicit operator string(Autor a)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Autor:" + a._nombre + " " + a._apellido);

            return sb.ToString();
        }
        public static bool operator == (Autor a, Autor b)
        {
            if (0 == string.Compare(a, b))
                return true;
            return false;
        }
        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }
    }
}
