using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool ret = false;

            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(c);
                ret = true;
            }
            return ret;
        }

        private int GetIndice(Cocina c)
        {
            return this._lista.IndexOf(c);
        }


        public static bool operator - (DepositoDeCocinas d, Cocina c)
        {
            bool ret = false;
            if (d.GetIndice(c) > 0)
            {
                d._lista.Remove(c);
                ret = true;
            }

            return ret;
        }

        public bool Agregar(Cocina c)
        {
            return this + c;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad Maxima:  " + this._capacidadMaxima + " Cocinas");

            sb.AppendLine("Listado de Cocinas");

            foreach (Cocina c in this._lista)
            {
                sb.AppendLine(c.ToString());
            }

            return sb.ToString();
        }
    }
}
