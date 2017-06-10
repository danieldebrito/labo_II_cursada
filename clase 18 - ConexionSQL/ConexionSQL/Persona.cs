using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionSQLLibrary
{
    public class Persona
    {
        public int _id;
        public string _nombre;
        public string _apellido;
        public int _edad;

        public Persona(int id, string nombre, String apellido, int edad)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._id = id;
            this._edad = edad;
        }

        public int ID { get { return this._id; } }
        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }
        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }
        public int Edad { get { return this._edad; } set { this._edad = value; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ID: " + this.ID);
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("Edad: " + this.Edad);

            return sb.ToString();
        }
    }
}