using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionSQLLibrary
{
    public class Lista<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;
        public T atr;  // tengo que tener un atributo T para inicializar por default en el constructor

        public Lista()
        {
            this._lista = new List<T>();
            this.atr = default(T);
        }

        public Lista(int capacidadMaxima)
            : this()
        {
            this._capacidadMaxima = capacidadMaxima;
        }

        public static bool operator +(Lista<T> d, T a)
        {
            bool ret = false;

            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                ret = true;
            }
            return ret;
        }
        public static bool operator -(Lista<T> d, T a)
        {
            bool ret = false;
            if (d.GetIndice(a) > 0)
            {
                d._lista.Remove(a);
                ret = true;
            }
            return ret;
        }

        private int GetIndice(T a)
        {
            foreach (T aux in this._lista)
            {
                if (aux.Equals(a))  // utilizo la sobrecarga del equals para verificar
                    return this._lista.IndexOf(a);
                break;
            }

            return -1;
        }

        public bool Agregar(T a)
        {
            return this + a;
        }
        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad Maxima:  " + this._capacidadMaxima + " Objetos");

            sb.AppendLine("Listado de Objetos");

            foreach (T a in this._lista)
            {
                sb.AppendLine(a.ToString());
            }

            return sb.ToString();
        }
    }
}

