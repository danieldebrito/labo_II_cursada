using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estante
{
    public class Producto
    {

        // atributos 
        protected int _codigoBarra;
        protected float _precio;
        protected EMarcaProducto _marca;
        
        // propiedades
        
        public EMarcaProducto Marca { get { return this._marca; }}
        public float Precio { get { return this._precio; } }

        // metodos

        public Producto(int codigo, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }
        protected static string MostrarProducto(Producto prod)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cod barra: " + prod._codigoBarra.ToString());
            sb.AppendLine("Precio: " + prod._precio.ToString());
            sb.Append("Marca: " + prod._marca.ToString());

            return sb.ToString();
        }

        // sobrecargas

        public static bool operator == (Producto prodUno, Producto prodDos)
        {
            if (prodUno.Marca == prodDos.Marca && prodUno._codigoBarra == prodDos._codigoBarra)
                return true;
            return false;
        }
        public static bool operator != (Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }
        public static bool operator == (Producto prodUno, EMarcaProducto marca)
        {
            return prodUno.Marca == (EMarcaProducto)marca;
        }
        public static bool operator != (Producto prodUno, EMarcaProducto marca)
        { 
            return!(prodUno == marca);
        }
        public static explicit operator int(Producto prod)
        {
            return prod._codigoBarra;
        }
    }
}
