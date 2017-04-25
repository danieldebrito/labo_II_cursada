using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoLibreria
{
    public class Moto:Vehiculo
    {
        protected float _cilindrada;

                public Moto (string patente, byte cantRuedas, EMarcas marca, float cilindrada)
            :base(patente,cantRuedas, marca)
            {

                this._cilindrada = cilindrada;
            }

        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Cilindrada: " + this._cilindrada.ToString());
        
            return sb.ToString();
        }


    }
}
