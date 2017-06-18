using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace VehiculoClassLibrary
{
    [Serializable]
    public class Auto : Vehiculo
    {
        #region ---------------ATRIBBUTOS--------------
        private string _patente;
        #endregion

        #region ---------------PROPIEDADES-------------
        public string Patente
        {
            get { return _patente; }
            set { _patente = value; }
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Auto() { }
        public Auto(double precio, string patente)
        :base(precio)
        {
            this._patente = patente;
        }
        #endregion

        #region -----------------METODOS---------------
        public void MostrarPatente() 
        {
            Console.WriteLine("PATENTE: " + this._patente);
        }
        public override void MostrarPrecio()
        {
            Console.WriteLine("PRECIO: " + base.Precio);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTO");
            sb.AppendLine(base.ToString());
            sb.Append("PATENTE: " + this._patente.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
