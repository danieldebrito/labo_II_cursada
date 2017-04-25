using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_11
{
    public class Empleado:Persona
    {
        //atributos
        //private string _nombre;
        //private string _apellido;
        //private int _dni;
        private int _legajo;
        private float _sueldo;

        //propiedades
        //public string Nombre
        //{
        //    get{return this._nombre ;}
        //    set{ this._nombre = value;}
        //}
        //public string Apellido
        //{
        //    get { return this._apellido ; }
        //    set { this._apellido = value; }
        //}
        //public int DNI
        //{
        //    get { return this._dni; }
        //    set { this._dni = value; }
        //}
        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }
        public float Sueldo
        {
            get { return this._sueldo; }
            set { this._sueldo = value; }
        }

        //constructores
        public Empleado(string nombre, string apellido, int dni)
            : base(nombre, apellido, dni)
        {
        }

        public Empleado(string nombre, string apellido, int dni, int legajo, float sueldo)
            : this(nombre, apellido, dni)
        {
            this._legajo = legajo;
            this._sueldo = sueldo;
        }

        //metodos
        public string MostrarEmpleado()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarPersona());
            sb.AppendLine(this._legajo.ToString());
            sb.AppendLine(this._sueldo.ToString());

            return sb.ToString();
        }
    }
}
