using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaletaLibreria;

namespace PaletaLibreria
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma()
        {
            this._cantidad = 1;
            this._marca = "sin marca";
            this._tinta = null;
        }

        public Pluma(int cant):this()
        {
            this._cantidad = cant;
        }

        public Pluma(int cant, Tinta tinta)
            : this(cant)
        {
            this._tinta = tinta;
        }

        public Pluma(int cant, Tinta tinta, string marca)
            : this(cant,tinta)
        {
            this._marca = marca;
        }

        private string Mostrar()
        { 
            return "Marca: " + this._marca + "Cantidad: " + this._cantidad + "Tinta: " + (string)this._tinta;
        }

        public static bool operator == (Pluma p, Tinta t)
        {
            if (p._tinta == t)
                return true;
            return false;
        }

        public static bool operator != (Pluma p, Tinta t)
        {
            return !(p == t);
        }

        public static Pluma operator + (Pluma p, Tinta t)
        {
            if (p == t)
                p._cantidad++;
            
            return p;
        }

        public static Pluma operator - (Pluma p, Tinta t)
        {
            if (p._cantidad >= 0 && p == t)
                p._cantidad--;
            
            if (p._cantidad == 0 && p == t)
                p._tinta = null;

            return p;
        }

        // (==) (pluma ,pluma) : bool  -> true si tienen la misma tinta

        // (+) (pluma , pluma) : pluma -> suma cantidad si las plumas son iguales







    }
}
