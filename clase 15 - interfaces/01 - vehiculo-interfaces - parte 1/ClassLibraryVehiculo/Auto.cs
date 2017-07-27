using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehiculo
{
    public abstract class Auto :vehiculo
    {
        protected string _patente;

        public Auto(double precio, string patente)
            :base(precio)
        {
            this._patente = patente;
        }

        public abstract void MostrarPatente();
    }
}
