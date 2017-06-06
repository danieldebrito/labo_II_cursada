using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecNrosLib
{
    public class Numero
    {
        protected int _numero;

        public int GetNumero { get { return this._numero; } }

        public Numero(int numero)
        {
            this._numero = numero;
        }
        public static int operator + (Numero nro1, Numero nro2)
        {
            return nro1.GetNumero + nro2.GetNumero;
        }
        public static int operator - (Numero nro1, Numero nro2)
        {
            return nro1.GetNumero - nro2.GetNumero;
        }
        public static double operator / (Numero nro1, Numero nro2)
        {
            double ret = 0;
            try
            {
                ret = nro1.GetNumero / nro2.GetNumero;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            return ret;
        }
        public static int operator * (Numero nro1, Numero nro2)
        {
            return nro1.GetNumero * nro2.GetNumero;
        }
    }
}
