using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehiculo
{
    class Privado:Avion
    {
        protected int _valorServicioDeAbordo;

        public Privado(double precio, double velocidad, int valoracion)
            :base(precio, velocidad)
    {
        this._valorServicioDeAbordo = valoracion;
    }


    }
}
