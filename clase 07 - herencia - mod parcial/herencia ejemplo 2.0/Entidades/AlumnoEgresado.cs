using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inicio
{
    public class AlumnoEgresado : Alumno 
    {
        //AlumnoEgresado (+ promedio: float; promocion: Short)
        //Entidades.Inicio.AlumnoEgresado ae = new Entidades.Inicio.AlumnoEgresado(a, 4.5f, 2017);

        public float promedio;
        public short promocion;

        public AlumnoEgresado(Alumno a, float prom, short anio)
            : base((Persona)a, a.legajo, a.nivel)
        {
            this.promedio = prom;
            this.promocion = anio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TIPO: ALUMNO EGRESADO");
            sb.AppendLine(base.ToString());
            sb.AppendLine("PROMEDIO: " + this.promedio);
            sb.Append("PROMOCION: " + this.promocion);

            return sb.ToString();
        }



    }
}
