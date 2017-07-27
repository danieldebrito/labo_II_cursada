using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesClassLibrary
{
    public class AgendaLlenaException : Exception
    {
        public AgendaLlenaException(string mensaje)
            : base(mensaje)
        { }
    }
}

