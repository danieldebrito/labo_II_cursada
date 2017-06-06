using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecNrosLib
{
    public class ColectoraDeNumeros
    {
        protected List<Numero> _numeros;
        public ETipoNumero TipoNumero { get; set; }

        private ColectoraDeNumeros()
        {
            this._numeros = new List<Numero>();
        }

        public ColectoraDeNumeros(ETipoNumero tipo)
            : this()
        {
            TipoNumero = tipo;
        }

        public double SumaPriConTodos
        {
            get 
            {
                bool flag = false;
                double acum = 0;

                for (int i = 0;i<this._numeros.Count;i++)
                { 
                    if(flag == true)
                       acum += this._numeros[0] + this._numeros[i];
                    flag = true;
                }
                return acum;
            } 
        }
        public double RestaPriConTodos
        {
            get
            {
                bool flag = false;
                double acum = 0;

                for (int i = 0; i < this._numeros.Count; i++)
                {
                    if (flag == true)
                        acum += this._numeros[0] - this._numeros[i];
                    flag = true;
                }
                return acum;
            }
        }
        public double ProductoPriConTodos
        {
            get
            {
                bool flag = false;
                double acum = 0;

                for (int i = 0; i < this._numeros.Count; i++)
                {
                    if (flag == true)
                        acum += this._numeros[0] * this._numeros[i];
                    flag = true;
                }
                return acum;
            }
        }
        public double DivPriConTodos
        {
            get
            {
                bool flag = false;
                double acum = 0;

                for (int i = 0; i < this._numeros.Count; i++)
                {
                    if (flag == true)
                    {
                        if (this._numeros[i].GetNumero == 0)
                            throw new Exception("Error, uno de los nros de la colectora es cero\nNo se puede dividir");
                        acum += this._numeros[0] / this._numeros[i];
                    }
                    flag = true;
                }
                return acum;
            }
        }

        public static bool operator == (ColectoraDeNumeros cn, Numero nro)
        {
            foreach (Numero nroAux in cn._numeros)
                if (nroAux == nro)
                    return true;
            return false;
        }
        public static bool operator != (ColectoraDeNumeros cn, Numero nro)
        {
            return !(cn == nro);
        }
        public static ColectoraDeNumeros operator + (ColectoraDeNumeros c, Numero n)
        {
            switch (c.TipoNumero)
            {
                case ETipoNumero.Par:
                    if (n.GetNumero % 2 == 0)
                        c._numeros.Add(n);
                    break;
                case ETipoNumero.Impar:
                    if(n.GetNumero % 2 != 0)
                        c._numeros.Add(n);
                    break;
                case ETipoNumero.Positivo:
                    if(n.GetNumero > 0)
                        c._numeros.Add(n);
                    break;
                case ETipoNumero.Negativo:
                    if(n.GetNumero < 0)
                        c._numeros.Add(n);
                    break;
                case ETipoNumero.Cero:
                    if(n.GetNumero == 0)
                        c._numeros.Add(n);
                    break;
                default:
                    throw new Exception("el numero no coincide con el tipo\n, no se puede agregar");
                    //break;
            }
            return c;
        }
        public static ColectoraDeNumeros operator - (ColectoraDeNumeros cn, Numero nro)
        {
           if (cn == nro)
                cn._numeros.Remove(nro);
            else
                throw new Exception("El numero no esta en la colectora");

            return cn;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Numero nro in this._numeros )
            {
                sb.AppendLine(nro.ToString());
            }
            
            return sb.ToString();
        }

        protected static double ObtenerResultado(ColectoraDeNumeros cn, ETipoResultado tipo)
        {
            switch (tipo)
            {
                case ETipoResultado.Suma:
                    return cn.SumaPriConTodos;
                case ETipoResultado.Resta:
                    return cn.RestaPriConTodos;
                case ETipoResultado.Multiplicacion:
                    return cn.ProductoPriConTodos;
                default:
                    return cn.DivPriConTodos;
            }
        }
    }
}
