using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class Caballo : Vehiculo
    {
        private string _raza;
        private string  _color;

        // propiedades

        public override string Detalle { get { return this.ToString(); } }

        // constructor

        public Caballo(int cantPasajeros, EVelocidad velocidadMaxima, string raza, string color)
            :base(cantPasajeros, velocidadMaxima)
        {
            this.cantPasajeros = cantPasajeros;
            this._velocidadMaxima = velocidadMaxima;
            this._raza = raza;
            this._color = color;
        }

        // metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Raza: " + this._raza);
            sb.AppendLine("Color: " + this._color);

            return sb.ToString();
        }

        public override string frenar()
        {
            return "El caballo esta frenando";
        }

    }
}

