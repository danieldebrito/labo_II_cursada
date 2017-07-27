using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Alumno : Persona
    {
        public int nota;

        //public Alumno(string nombre, ENacionalidad nacionalidad, int edad, string sex, int nota)
        //    : base(nombre, nacionalidad, edad, sex)
        //{
        //    this.nota = nota;
        //}

        //public Alumno(Persona p, int nota)
        //    : this(p.nombre, p.nacionalidad, p.edad, p.sexo, nota)
        //{
        //}

        ///

        public Alumno(Persona p, int nota)
            : base(p.nombre,p.nacionalidad,p.edad,p.sexo)
        {
            this.nota = nota;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.Append("NOTA: " + this.nota.ToString());


            return sb.ToString();
        }

    }
}
