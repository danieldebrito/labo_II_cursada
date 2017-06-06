using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        public static bool operator + (DepositoDeAutos d, Auto a)
        {
            bool ret = false;

            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                ret = true;
            }
            return ret;
        }

        private int GetIndice(Auto a)
        {
            return this._lista.IndexOf(a);
        }


        public static bool operator - (DepositoDeAutos d, Auto a)
        {
            bool ret = false;
            if(d.GetIndice(a)>0)
            {
                d._lista.Remove(a);
                ret = true;
            }

            return ret;
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad Maxima:  " + this._capacidadMaxima + " Autos" );

            sb.AppendLine("Listado de Autos");

            foreach (Auto a in this._lista)
            {
                sb.AppendLine(a.ToString());
            }
            
            return sb.ToString();
        }


    }
}
