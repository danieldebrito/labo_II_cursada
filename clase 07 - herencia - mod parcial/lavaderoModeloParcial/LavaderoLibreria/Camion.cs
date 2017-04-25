using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoLibreria
{
    public class Camion:Vehiculo
    {
        protected float _tara;

                public Camion (string patente, byte cantRuedas, EMarcas marca, float tara)
            :base(patente,cantRuedas, marca)
            {

                this._tara = tara;
            }

        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Tara: " + this._tara.ToString());
        
            return sb.ToString();
        }


    }
}
