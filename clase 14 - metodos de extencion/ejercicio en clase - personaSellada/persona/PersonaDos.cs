using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace persona
{
    public class PersonaDos : PersonaExterna
    {
        public PersonaDos(string nombre, string apellido, int edad, Entidades.Externa.ESexo sexo)
            : base(nombre, apellido, edad, sexo)
        { }

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
