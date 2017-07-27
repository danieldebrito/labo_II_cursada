using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehiculo
{
    public class Deportivo:Auto,IAFIP,IARBA
    {
        protected int _caballosFuerza;


        public Deportivo(double precio, string patente, int caballosFuerza)
            :base(precio,patente)
        {
            this._caballosFuerza = caballosFuerza;
        }

        // lo hago para castear en el program, ver ahi....

        double IAFIP.CalcularImpuesto()
        {
            return this._precio * 0.28;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.23;
        }

        public override void MostrarPatente()
        {
            Console.WriteLine("patente: " + this._patente);
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this._precio.ToString());
        }

    }
}
