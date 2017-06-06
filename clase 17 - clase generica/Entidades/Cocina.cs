using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo { get { return this._codigo; } set { this._codigo = value;} }
        public bool EsIndustrial { get { return this._esIndustrial; } set { this._esIndustrial = value;} }
        public double Precio { get { return this._precio; } set { this._precio = value;} }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;
        }

        public override bool Equals(object obj)
        {
            if (obj is Cocina && ((Cocina)obj).EsIndustrial == this.EsIndustrial && ((Cocina)obj).Codigo == this.Codigo)
                return true;
            return false;
        }

        public static bool operator == (Cocina c1, Cocina c2)
        {
            if (c1.Codigo == c2.Codigo)
                return true;
            return false;
        }
        public static bool operator != (Cocina c1, Cocina c2)
        {
            return !(c1 == c2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Codigo: " + this.Codigo.ToString());
            sb.Append(" - Precio: " + this.Precio.ToString());
            sb.Append(" - Es Industrial: " + this.EsIndustrial.ToString());
            
            return sb.ToString();
        }
    }
}
