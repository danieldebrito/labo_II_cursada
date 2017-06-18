using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace FrutaClassLibrary
{
    [XmlInclude(typeof(Platano))]
    [XmlInclude(typeof(Manzana))]
    public abstract  class Fruta
    {
        protected ConsoleColor _color;
        protected float _peso;

        public ConsoleColor Color { get { return this._color; } set { this._color = value; } }
        public float Peso { get { return this._peso; } set { this._peso = value; } }

        public Fruta() { }

        public Fruta(float peso, ConsoleColor color)
        {
            this._color = color;
            this._peso = peso;
        }

        public abstract bool TieneCarozo { get; }

        protected virtual string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("COLOR: " + this._color.ToString());
            sb.Append("PESO: " + this._peso.ToString());

            return sb.ToString();
        }
    }
}
