using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;

        public Persona() { }
        public Persona(string nomb, string apell)
        {
            this.nombre = nomb;
            this.apellido = apell;
        }

        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }


    }
}
