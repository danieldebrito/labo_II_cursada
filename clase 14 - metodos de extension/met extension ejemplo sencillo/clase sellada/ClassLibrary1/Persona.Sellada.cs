using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreriaSellada
{
    public sealed class PersonaSellada
    {
        protected string _nombre;
        protected int _edad;

        public PersonaSellada(string nombre, int edad)
        {
            this._edad=edad;
            this._nombre=nombre;
        }

        public string Nombre { get { return this._nombre; } }
        public int edad { get { return this._edad; } }
    }
}
