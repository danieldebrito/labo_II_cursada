using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personaLibreria
{
    [Serializable]
    public class Persona
    {
        public string _nombre;  // todo public para q pueda serializar el xml
        public int _edad;
        public bool esMayor;

        public Persona() { } // PARA EL XML necesita constructor por default
        public Persona(string nombre, int edad, bool esMayor)
        {
            this._nombre = nombre;
            this._edad = edad;
            this.esMayor = esMayor;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this._nombre);
            sb.AppendLine("Edad: " + this._edad.ToString());
            sb.AppendLine("Es mayor: " + this.esMayor);
            
            return sb.ToString();
        }
    }
}
