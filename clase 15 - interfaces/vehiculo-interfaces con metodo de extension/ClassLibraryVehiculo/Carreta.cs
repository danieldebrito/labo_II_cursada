using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehiculo
{
    public class Carreta:vehiculo,IARBA
    {
        public Carreta(double precio)
        :base(precio)
        { }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this._precio.ToString());
        }

        public double CalcularImpuesto()
        {
            return this._precio * 0.18;
        }


    }
}
