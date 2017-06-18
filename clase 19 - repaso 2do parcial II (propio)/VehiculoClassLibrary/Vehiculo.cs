using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;


namespace VehiculoClassLibrary
{
    [XmlInclude(typeof(Auto))]
    [XmlInclude(typeof(Carreta))]
    [XmlInclude(typeof(Avion))]
    [XmlInclude(typeof(Deportivo))]
    [XmlInclude(typeof(Familiar))]
    [XmlInclude(typeof(Privado))]
    [XmlInclude(typeof(Comercial))]
    public abstract class Vehiculo
    {
        #region ---------------ATRIBBUTOS--------------
        private double _precio;
        #endregion

        #region ---------------PROPIEDADES-------------
        public double Precio { get { return this._precio; } set { this._precio = value; } }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Vehiculo() { }
        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
        #endregion

        #region -----------------METODOS---------------
        public abstract void MostrarPrecio();
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("PRECIO" + this._precio);

            return sb.ToString();
        }
        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------
        #endregion
    }
}
