using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color { get { return this._color; } set { this._color = value;} }
        public string Marca { get { return this._marca; } set { this._marca = value;} }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }


        public override bool Equals(object obj)
        {
            if (obj is Auto && ((Auto)obj).Color == this.Color && ((Auto)obj).Marca == this.Marca)
                return true;
            return false;
        }

        public static bool operator == (Auto a1, Auto a2)
        {
            if (a1.Marca == a2.Marca && a1.Color == a2.Color)
                return true;
            return false;
        }

        public static bool operator !=(Auto a1, Auto a2)
        {
            return !(a1 == a2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Marca: " + this.Marca);
            sb.Append(" - Color: " + this.Color);
            
            
            return sb.ToString();
        }



    }
}
