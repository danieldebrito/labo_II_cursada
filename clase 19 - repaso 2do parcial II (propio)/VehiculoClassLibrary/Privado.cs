using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculoClassLibrary
{
    [Serializable]
    public class Privado : Avion
    {
        #region ---------------ATRIBBUTOS--------------
        private int _valoracionServicio;
        #endregion

        #region ---------------PROPIEDADES-------------
        public int ValoracionServicio
        {
            get { return _valoracionServicio; }
            set { _valoracionServicio = value; }
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Privado() { }
        public Privado(double precio, double velocidad, int valoracion)
            :base(precio, velocidad)
        {
            this._valoracionServicio = valoracion;
        }
        #endregion

        #region -----------------METODOS---------------
        public override void MostrarPrecio()
        {
            Console.WriteLine("PRECIO: " + base.Precio);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("PRIVADO");
            sb.AppendLine(base.ToString());
            sb.AppendLine("VALORACION: " + this.ValoracionServicio.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
