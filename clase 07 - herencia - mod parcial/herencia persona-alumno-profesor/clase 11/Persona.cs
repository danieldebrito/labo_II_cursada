using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_11
{
    public class Persona
    {
        //atributos
        private string _nombre;
        private string _apellido;
        private int _dni;

        //propiedades
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        public int DNI
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

        //constructor
        public Persona(string nombre, string apellido, int dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
        }

        //metodos

        public string MostrarPersona()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this._nombre);
            sb.AppendLine(this._apellido);
            sb.AppendLine(this._dni.ToString());

            return sb.ToString();

        }

    }
}
