using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inicio
{
    public class Persona : Humano
    {
        //Persona (+ apellido:string; + edad:Sbyte)
        //Entidades.Inicio.Persona p = new Entidades.Inicio.Persona("Brian", "Lopez", ERaza.Cabeza, 17);

        public string apellido;
        public sbyte edad;

        public Persona(string nomb, string apell, ERaza raza, sbyte edd)
            : base(nomb, raza)
        {
            this.apellido = apell;
            this.edad = edd;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TIPO: PERSONA");
            sb.AppendLine(base.ToString());
            sb.AppendLine("APELLIDO: " + this.apellido);
            sb.Append("EDAD: " + this.edad);

            return sb.ToString();
        }

    }
}
