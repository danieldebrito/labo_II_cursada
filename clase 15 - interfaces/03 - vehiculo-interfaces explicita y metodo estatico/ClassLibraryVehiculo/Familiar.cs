using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehiculo
{
    public class Familiar:Auto     
    {
        protected int _cantAsientos;


        public Familiar(double precio, string patente, int cantAsiontos)
            :base(precio,patente)
        {
            this._cantAsientos = cantAsiontos;
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
