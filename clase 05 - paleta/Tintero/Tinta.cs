using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletaLibreria
{

    public enum ETipo { comun, china, conBrillitos };

    public class Tinta
    {
        private ConsoleColor _color;
        private ETipo _tipo;

        public Tinta() 
        {
            this._color = ConsoleColor.Black;
            this._tipo = ETipo.comun;
        }

        public Tinta(ConsoleColor color):this()
        {
            this._color = color;
        }

        public Tinta(ConsoleColor color, ETipo tipo):this(color)
        {
            this._tipo = tipo;
        }

        private string Mostrar()
        {
            return "color : " + this._color + "tipo: " + this._tipo;
        }

        public static string Mostrar(Tinta t)
        {
            return t.Mostrar();
        }

        public static bool operator == (Tinta t1, Tinta t2)
        {
            if (t1._color == t2._color && t1._tipo == t2._tipo)
            {
                return true;
            }   
            return false;
        }

        public static bool operator != (Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }

        public static explicit operator string (Tinta t)
        {
            return t.Mostrar();
        }

        /*
         *  Console.WriteLine((string)t);
         * 
        */






    }
}
