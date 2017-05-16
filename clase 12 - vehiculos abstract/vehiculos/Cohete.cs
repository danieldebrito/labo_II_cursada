using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class Cohete:Vehiculo
    {
        private string _modelo;

        // propiedades

        public override string Detalle { get { return this.ToString(); } }

        // constructor

        public Cohete(int cantPasajeros, EVelocidad velocidadMaxima, string modelo)
            :base(cantPasajeros, velocidadMaxima)
        {
            this._modelo = modelo;
        }

        // metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Modelo: " + this._modelo);

            return sb.ToString();
        }

        public override string frenar()
        {
            return "El Cohete esta frenando";
        }
    }
}
