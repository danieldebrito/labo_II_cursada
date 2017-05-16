using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class Auto:Vehiculo
    {
        private int _cantRuedas;

        // propiedades

        public string Detalle { get { return this.ToString(); } }

        // constructor

        public Auto(int cantPasajeros, EVelocidad velocidadMaxima, int cantRuedas)
            : base(cantPasajeros, velocidadMaxima)
        {
            this._cantRuedas = cantRuedas;
        }

        // metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Cant de Ruedas: " + this._cantRuedas.ToString());

            return sb.ToString();
        }
    }
}
