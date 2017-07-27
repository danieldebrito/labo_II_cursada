using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AlumnoEgresado : Alumno
    {
        public string titulo;

        public AlumnoEgresado(Alumno a, string titul)
            :base(a, a.nota)
        {
            this.titulo = titul;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("NOTA: " + this.titulo.ToString());

            return sb.ToString();
        }


    }
}
