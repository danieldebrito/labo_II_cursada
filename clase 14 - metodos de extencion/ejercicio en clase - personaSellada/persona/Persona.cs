using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace personaLibreria
{
    public enum ESexo { Masculino, Femenino, Indefinido}

    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;


        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._sexo = sexo;
        }

        public string Nombre
        {
            get { return this._nombre; }
        }
        public string getNombre()
        {
            return this._nombre;
        }
        public string Apellido
        {
            get { return this._apellido; }
        }
        public string getApellido()
        {
            return this._apellido;
        }
        public string obtenerInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("Edad: " + this._edad.ToString());
            sb.AppendLine("Sexo : " + this._sexo.ToString());

            return sb.ToString();
        }
        public string ObtenerInfo
        {
            get { return this.obtenerInfo(); }
        }
    }
}
