using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estante
{
    public class Jugo:Producto
    {
        protected ESaborJugo _sabor;

        public Jugo(int codigo, EMarcaProducto marca, float precio, ESaborJugo sabor)
            :base(codigo,marca,precio)
        {
            this._sabor = sabor;
        }

        public string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Jugo:"); 
            sb.AppendLine(Producto.MostrarProducto(this));
            sb.AppendLine("Sabor: " + this._sabor.ToString());

            return sb.ToString();
        }
    }
}
