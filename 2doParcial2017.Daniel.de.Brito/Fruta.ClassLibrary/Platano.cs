using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrutasClassLibrary
{
    public class Platano : Fruta
    {
        public string paisOrigen;
        public override bool TieneCarozo {
            get {return false;}
            // para serializar necesito el set
           //set;// { this.TieneCarozo = value; }
        }
        public string Tipo { get { return "BANANA"; } }

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
            sb.AppendLine("PAIS ORIGEN: " + this.paisOrigen.ToString());

            return sb.ToString();
        }
        public override string ToString()
        { 
            return this.FrutaToString();
        }






    }
}
