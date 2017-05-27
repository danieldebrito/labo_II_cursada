using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehiculo
{
    public class Avion:vehiculo,IAFIP
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax)
            :base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        public double CalcularImpuesto()
        {
            return this._precio * 1.33;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this._precio.ToString());
        }


    }
}
