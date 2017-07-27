using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estante
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        private Estante()
        {
            _productos = new List<Producto>();
        }
        public Estante(sbyte capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> Productos{get{return this._productos;}}
        public string MostrarEstante(Estante est)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CONTENIDO DEL ESTANTE");
            sb.AppendLine("**********************************************");
            foreach (Producto p in est.Productos)
            {
                if(p is Jugo)
                    sb.AppendLine(((Jugo)p).MostrarJugo());
                if(p is Galletita)
                    sb.AppendLine(Galletita.MostrarGalletita((Galletita)p));
                if (p is Gaseosa)
                    sb.AppendLine(((Gaseosa)p).MostrarGaseosa());
            }
            
            return sb.ToString();
        }
        public static bool operator == (Estante e, Producto p)
        {
            if (e.Productos.Contains(p))
                return true;
            return false;
        }
        public static bool operator != (Estante e, Producto p)
        { 
            return !(e==p);
        }
        public static bool operator + (Estante e, Producto p)
        {
            if (e._capacidad > e.Productos.Count && e != p)
                return true;
            else
                Console.WriteLine("No se pudo agregar el prod al estante, no hay capacidad");
            return false;
        }
        public static Estante operator - (Estante e, Producto p)
        {
            if (e == p)
                e.Productos.Remove(p);

            return e;
        }
        public static Estante operator - (Estante e, ETipoProducto tipo)
        {
            for (int i=0; i < e.Productos.Count;i++ )
            {
                switch (tipo)
                {
                    case ETipoProducto.Galletita:
                        if (e.Productos[i] is Galletita)
                            e -= e.Productos[i]; //eAux.Productos.Remove(p);  seria lo mismo.
                        break;
                    case ETipoProducto.Gaseosa:
                        if (e.Productos[i] is Gaseosa)
                            e -= e.Productos[i];
                        break;
                    case ETipoProducto.Jugo:
                        if (e.Productos[i] is Jugo)
                            e -= e.Productos[i]; ;
                        break;
                    case ETipoProducto.Todos:
                            e -= e.Productos[i];
                        break;
                    default:
                        break;
                }
            }
            return e;
        }
        public float GetValorEstante(ETipoProducto tipo)
        {
            float acum = 0;

            foreach (Producto p in this.Productos)
            {
                if (p is Galletita && ETipoProducto.Galletita == (ETipoProducto)tipo)
                    acum += p.Precio;
                if (p is Gaseosa && ETipoProducto.Gaseosa == (ETipoProducto)tipo)
                    acum += p.Precio;
                if (p is Jugo && ETipoProducto.Jugo == (ETipoProducto)tipo)
                    acum += p.Precio;
                if (ETipoProducto.Todos == (ETipoProducto)tipo)
                    acum += p.Precio;
            }
            return acum;
        }
        private float GetValorEstante()
        {
            return this.GetValorEstante(ETipoProducto.Todos);
        }
        public float ValorEstanteTotal { get{return this.GetValorEstante();}}
        public int OrdenarPorCodigo(Producto p1, Producto p2)
        {
            if ((int)p1 == (int)p2)
                return 0;
            if ((int)p1 < (int)p2)
                return -1;
            else
                return 1;
        }
    }
}
