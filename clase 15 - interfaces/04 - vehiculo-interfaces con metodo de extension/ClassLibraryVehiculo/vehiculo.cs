using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehiculo
{
    public abstract class vehiculo
    {
        protected double _precio;

        public vehiculo(double precio)
        {
            this._precio = precio;
        }

        public abstract void MostrarPrecio();
    }
}
