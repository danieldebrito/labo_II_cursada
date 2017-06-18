using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace ClassLibrary
{
    [Serializable]
    [XmlInclude(typeof(Goma))]
    public class Goma : Utiles
    {
        protected bool _soloLapiz;

        public bool SoloLapiz { get{return this._soloLapiz;} set{this._soloLapiz = value;} }

        public Goma()
        { }

        public Goma(string marca, double precio, bool sl)
            : base(marca, precio)
        {
            this._soloLapiz = sl;
        }

        public override string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public override double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        protected override string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("GOMA: ");
            sb.AppendLine(base.UtilesToString());
            sb.AppendLine("SOLO LAPIZ?: " + this._soloLapiz.ToString());
            
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.UtilesToString();
        }
    }
}
