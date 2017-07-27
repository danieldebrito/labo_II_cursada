using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inicio
{
    public class Alumno : Persona
    {
        //Alumno (+ legajo: Short; + nivel: ENivelDeEstudio)
        //Entidades.Inicio.Alumno a = new Entidades.Inicio.Alumno(p, 123, ENivelDeEstudio.Primaria);

        public short legajo;
        public ENivelDeEstudio nivel;

        public Alumno(Persona p, short legg, ENivelDeEstudio nivv)
            : base(p.nombre, p.apellido, p.raza, p.edad)
        {
            this.legajo = legg;
            this.nivel = nivv;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TIPO: ALUMNO");
            sb.AppendLine(base.ToString());
            sb.AppendLine("LEGAJO: " + this.legajo);
            sb.Append("NIVEL: " + this.nivel);

            return sb.ToString();
        }
    }
}
