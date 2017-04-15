using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletaLibreria
{
    public class Paleta
    {
        // atributos

        private Tempera[] _temperas;
        private int _cantMaxColores;

        // construtores

        public Paleta():this(5)
        {
        }

        private Paleta(int cant)
        {
            this._cantMaxColores = cant;
            this._temperas = new Tempera[cant];
        }

        // metodos

        /// <summary>
        /// instanciar una paleta implicitamente con la cantidad de colores pasada por parametro
        /// </summary>
        /// <param name="cant"></param>
        /// <returns></returns>
        public static implicit operator Paleta (int cant)
        {
             Paleta p = new Paleta(cant);
             return p;
        }

        /// <summary>
        /// muestra los atributos de una paleta
        /// </summary>
        /// <returns></returns>
        private static string mostrar(Paleta p)
        {
            int index = 0; 
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Paleta con : " + p._cantMaxColores + " Colores\n");

            foreach (Tempera t in p._temperas)
            {
                if (!(Object.Equals(t, null)))
                    sb.AppendFormat("Tempera {0} :\n{1}\n", index, (string)t);
                else
                    sb.AppendFormat("Tempera {0} :\n{1}\n", index, "Sin Tempera");
                index++;
            }
            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga explicita de string para mostrar atributos de la paleta
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static explicit operator string(Paleta p)
        {
            return Paleta.mostrar(p);
        }

        /// <summary>
        /// true si una tempera existe en la paleta, false si no existe
        /// </summary>
        /// <param name="p"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool operator == (Paleta p, Tempera t)
        {
            foreach (Tempera t2 in p._temperas)
            {
                if (t == t2)
                    return true;
            }
            return false;
        }
        public static bool operator != (Paleta p, Tempera t)
        {
            return !(p == t);
        }

         //<summary>
         //si la tempera no existe la agrega, si existe suma la cantidad
         //</summary>
         //<param name="p"></param>
         //<param name="t"></param>
         //<returns></returns>
        public static Paleta operator + (Paleta p, Tempera t)
        {
            int indexNull = -1;

            for (int i = 0; i < p._cantMaxColores; i++)
            {
                if (p._temperas[i] == t)
                {
                    p._temperas[i] += t;
                    return p;
                }

                if (indexNull == -1 && Object.Equals(p._temperas[i],null))
                    indexNull = i;
            }

            if (indexNull != -1)
                p._temperas[indexNull] = t;
            
            return p;
        }

        /// <summary>
        /// si existe la tempera la quita y libera lugar en array de temperas, si no existe, nada
        /// </summary>
        /// <param name="p"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Paleta operator - (Paleta p, Tempera t)
        {
            for (int i = 0; i < p._cantMaxColores; i++)
            {
                if (p._temperas[i] == t)
                {
                    p._temperas[i] = null;
                    return p;
                }
            }
            return p;
        }

        /// <summary>
        /// combina las temperas de dos paletas
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static Paleta operator + (Paleta p1, Paleta p2)
        {
            for (int i = 0; i < p2._temperas.Length; i++)
            {
                if (p1 != p2._temperas[i])
                {
                    p1 += p2._temperas[i];
                }
            }
            return p1;
        }
    }
}
