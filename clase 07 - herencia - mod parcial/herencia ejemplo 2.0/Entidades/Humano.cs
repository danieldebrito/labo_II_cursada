using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inicio
{
    public enum ERaza {Aria, Mestiza, Negra, Cabeza}
    public enum ENivelDeEstudio { Primaria, Secundaria, Terciaria, Universitaria }


    public class Humano
    {
        //Humano (+ nombre:string; + raza:ERaza)

        public string nombre;
        public ERaza raza;

        public Humano(string nomb, ERaza raz)
        {
            this.nombre = nomb;
            this.raza = raz;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TIPO: HUMANO");
            sb.AppendLine("NOMBRE: " + this.nombre);
            sb.Append("RAZA: " + this.raza);
        
            return sb.ToString();
        }











    }
}
