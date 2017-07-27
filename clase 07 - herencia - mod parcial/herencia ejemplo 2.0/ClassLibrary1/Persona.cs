using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Persona : Humano
    {
        public int edad;
        public string sexo;

        public Persona(string nombre, ENacionalidad nacio, int edad, string sexo)
            :base(nombre, nacio)
        {
            this.edad = edad;
            this.sexo = sexo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("EDAD: " + this.edad.ToString());
            sb.Append("SEXO: " + this.sexo.ToString());

            return sb.ToString();
        }



    }
}
