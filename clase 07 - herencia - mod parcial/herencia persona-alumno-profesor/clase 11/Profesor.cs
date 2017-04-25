using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_11
{
    public class Profesor:Empleado
    {
        private string _materia;

        public Profesor(string nombre, string apellido,int dni, int legajo, float sueldo, string materia)
            :base(nombre, apellido, dni, legajo, sueldo)
        {
            this._materia = materia;
        }

        public string Materia
        {
            get { return this._materia;}
            set { this._materia = value;}
        }

        public string MostrarProfesor()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarEmpleado ());
            sb.AppendLine(this._materia.ToString());

            return sb.ToString();
        }



    }
}
