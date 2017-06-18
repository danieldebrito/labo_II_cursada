using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace FrutaClassLibrary
{
    [Serializable]
    public class Platano : Fruta
    {
        
        public string paisOrigen;

        public override bool TieneCarozo
        {
            get { return false; }
        }

        public string Tipo 
        {
            get { return "Platano"; }
        }

        public Platano() { }

        public Platano(float peso, ConsoleColor color, string pais)
            : base(peso, color)
        {
            this.paisOrigen = pais;
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TIPO: " + this.Tipo);
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("PAIS DE ORIGEN: " + this.paisOrigen);

        return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
