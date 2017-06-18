using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using InterfacesClassLibrary;

namespace VehiculoClassLibrary
{
    [Serializable]
    public class Avion : Vehiculo , IAfip, IArba
    {
        #region ---------------ATRIBBUTOS--------------
        private double _velocidadMaxima;
        #endregion

        #region ---------------PROPIEDADES-------------
        public double VelocidadMaxima
        {
            get { return _velocidadMaxima; }
            set { _velocidadMaxima = value; }
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Avion() { }
        public Avion(double precio, double velmax)
            :base(precio)
        {
            this._velocidadMaxima = velmax;
        }
        #endregion

        #region -----------------METODOS---------------
        public override void MostrarPrecio()
        {
            Console.WriteLine("PRECIO: " + base.Precio);
        }
        double IAfip.CalcularImpuesto()
        {
            return this.Precio * .33;
        }
        double IArba.CalcularImpuesto()
        {
            return this.Precio * .27;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AVION");
            sb.AppendLine(base.ToString());
            sb.Append("VELOCIDAD MAXIMA: " + this._velocidadMaxima.ToString());

            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is Avion;
        }
        #endregion
    }
}
