using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estante
{
    public class Gaseosa:Producto
    {
        protected float _litros;

        public Gaseosa(Producto producto, float litros)
            :this((int)producto, producto.Marca, producto.Precio, litros)
        {
        }
        
        public Gaseosa(int codigo, EMarcaProducto marca, float precio, float litros)
            : base(codigo,marca,precio)
        {
            this._litros = litros;
        }

        public string MostrarGaseosa()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Gaseosa:");
            sb.AppendLine(Producto.MostrarProducto(this));
            sb.AppendLine("Litros: " + this._litros.ToString());

            return sb.ToString();
        }
    }
}
