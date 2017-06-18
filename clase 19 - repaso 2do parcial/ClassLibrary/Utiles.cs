using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace ClassLibrary
{
    [XmlInclude(typeof(Lapicera))]
    [XmlInclude(typeof(Goma))]
    public abstract class Utiles
    {
        protected string _marca;
        protected double _precio;

        public Utiles(){ }

        public Utiles(string marca, double precio)
        {
            this._marca = marca;
            this._precio = precio;
        }

        public abstract string Marca{get;set;}
        public abstract double Precio {get;set;}

        protected virtual string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MARCA: " + this._marca);
            sb.Append("PRECIO: " + this._precio);

            return sb.ToString();
        }
    }
}
