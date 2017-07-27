using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estante
{
    public class Galletita:Producto
    {
        protected float _peso;

        public Galletita(int codigo, EMarcaProducto marca, float precio, float peso)
            :base(codigo, marca, precio)
        {
            this._peso = peso;
        }

        public static string MostrarGalletita(Galletita galleta)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Galletita:");
            sb.AppendLine(Producto.MostrarProducto(galleta));
            sb.AppendLine("Peso: " + galleta._peso.ToString());

            return sb.ToString();
        }
    }
}
