using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public abstract class Vehiculo
    {
        // atributos
        
        protected int cantPasajeros;
        protected EVelocidad _velocidadMaxima;
       
        // propiedades

        public abstract string Detalle { get;}

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
            sb.AppendLine(this.frenar());
            sb.Append(this.acelerar());

            return sb.ToString();
        }

        public virtual string acelerar()
        {
            int VelocidadValue = (int)Enum.Parse(typeof(EVelocidad), this._velocidadMaxima.ToString());

            return "Velocidad Maxima: " + this._velocidadMaxima.ToString() + " = "+ VelocidadValue.ToString() + "km/h";
        }

        public abstract string frenar();
    }
}

