using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace FrutasClassLibrary
{
    [XmlInclude(typeof(Platano))]
    [XmlInclude(typeof(Manzana))]
    public abstract class Fruta
    {
        protected ConsoleColor _color;
        protected float _peso;
        
        public abstract bool TieneCarozo
        {
            get;
            // para serializar necesito el set
            //set;
        }

        // nesesario para serializar y deserializar ===
        public ConsoleColor Color
        {
            get { return this._color; }
            set { this._color = value; }
        }
        public float Peso
        {
            get { return this._peso; }
            set { this._peso = value; }

        }
        public Fruta() { }
        //=============================================

        public Fruta(float peso, ConsoleColor color)
        {
            this._color = color;
            this._peso = peso;
        }
        protected virtual string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("COLOR: " + this._peso.ToString());
            sb.AppendLine("PESO: " + this._color.ToString());
            if (this.TieneCarozo)
                sb.AppendLine("TIENE CAROZO");
            else
                sb.AppendLine("NAO TEM CAROZO");

            return sb.ToString();
        }
    }
}

