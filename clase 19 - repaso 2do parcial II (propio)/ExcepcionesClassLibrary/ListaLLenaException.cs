using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesClassLibrary
{
    public class ListaLLenaException : Exception
    {
                private static string mensajeBase = "Lista LLena";
        

        public ListaLLenaException()
            : this(mensajeBase)
        {
        }

        public ListaLLenaException(Exception e)
            : this(e, mensajeBase)
        { }

        public ListaLLenaException(string message)
            : base(mensajeBase)
        { }

        public ListaLLenaException(Exception e, string message)
            : base(mensajeBase, e)
        { }



    }
}
