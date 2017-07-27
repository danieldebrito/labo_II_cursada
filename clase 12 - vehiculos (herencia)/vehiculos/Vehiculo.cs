using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class Vehiculo
    {
        protected int cantPasajeros;
        protected EVelocidad _velocidadMaxima;
       

        // propiedades

        public string Detalle { get { return this.ToString(); } }

        // constructor

        public Vehiculo(int cantPasajeros, EVelocidad velocidadMaxima)
        {
            this.cantPasajeros = cantPasajeros;
            this._velocidadMaxima = velocidadMaxima;
        }

        // metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cant Pasajeros: " + this.cantPasajeros.ToString());
            sb.AppendLine(this.acelerar());
            sb.Append(this.frenar());

            return sb.ToString();
        }

        public string acelerar()
        {
            int VelocidadValue = (int)Enum.Parse(typeof(EVelocidad), this._velocidadMaxima.ToString());
            return "Velocidad Maxima: " + this._velocidadMaxima.ToString() + " = " + VelocidadValue.ToString() + "km/h";
        }

        public string frenar()
        {
            return "El Vehiculo esta frenando";
        }

    }
}

