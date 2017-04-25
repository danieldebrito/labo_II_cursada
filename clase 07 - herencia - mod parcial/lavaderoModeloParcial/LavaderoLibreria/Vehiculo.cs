using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoLibreria
{
    public class Vehiculo
    {
        private string _patente;
        public string Patente
        {
            get{return this._patente;}
        }
        private byte _cantRuedas;
        private EMarcas _marca;
        public EMarcas Marca
        {
            get { return this._marca; }
        }

        protected string Mostrar()
        { 
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Patente: " + this.Patente.ToString());
            sb.AppendLine("Cant Ruedas: " + this._cantRuedas.ToString());
            sb.AppendLine("Marca: " + this.Marca.ToString());

            return sb.ToString();
        }

        public Vehiculo(string patente, byte cantRuedas, EMarcas marca)
        {
            this._patente = patente;
            this._cantRuedas = cantRuedas;
            this._marca = marca;
        }

        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            if(!(Object.Equals(v1,null) && !(Object.Equals(v2,null))))
            {
            if (v1._patente == v2._patente && v1._marca == v2._marca)
                return true;
            }
            return false;
        }

        public static bool operator != (Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

    }
}
