using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoLibreria
{
    public class Auto:Vehiculo
    {
        protected int _cantidadAsientos;

        public Auto (string patente, byte cantRuedas, EMarcas marca, int cantAsientos)
            :base(patente,cantRuedas, marca)
            {
                this._cantidadAsientos = cantAsientos;
            }

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Cant Asientos: " + this._cantidadAsientos.ToString());
        
            return sb.ToString();
        }



    }
}
