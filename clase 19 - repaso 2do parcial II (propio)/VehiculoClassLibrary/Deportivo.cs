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
    public class Deportivo : Auto, IAfip, IArba
    {
        #region ---------------ATRIBBUTOS--------------
        private int _caballosDeFuerza;
        #endregion

        #region ---------------PROPIEDADES-------------
        public int CaballosDeFuerza
        {
            get { return _caballosDeFuerza; }
            set { _caballosDeFuerza = value; }
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Deportivo() { }
        public Deportivo(double precio, string patente, int hp)
            :base(precio, patente)
        {
            this._caballosDeFuerza = hp;
        }
        #endregion

        #region -----------------METODOS---------------
        public override void MostrarPrecio()
        {
            Console.WriteLine("PRECIO: " + base.Precio);
        }
        double IAfip.CalcularImpuesto()
        {
            return this.Precio * .24;
        }
        double IArba.CalcularImpuesto() 
        {
            return this.Precio * .23;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DEPORTIVO");
            sb.AppendLine(base.ToString());
            sb.AppendLine("HP: " + this.CaballosDeFuerza);

            return sb.ToString();
        }
        #endregion
    }
}
