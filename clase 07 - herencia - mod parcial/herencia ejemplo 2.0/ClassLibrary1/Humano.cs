using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public enum ENacionalidad { argentino, uruguayo, paraguayo, boliviano, peruano, ecuatoriano, brasilero, chileno}


    public abstract class Humano
    {
        public string nombre;
        public ENacionalidad nacionalidad;

        public Humano(string nomb, ENacionalidad nac)
        {
            this.nombre = nomb;
            this.nacionalidad = nac;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("NOMBRE: " + this.nombre);
            sb.Append("NACIONALIDAD: " + this.nacionalidad.ToString());

            return sb.ToString();
        }

    }
}
