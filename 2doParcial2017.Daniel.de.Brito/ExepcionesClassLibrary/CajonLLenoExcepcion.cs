using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionesClassLibrary
{
    public class CajonLLenoExcepcion : Exception
    {
        public CajonLLenoExcepcion(string message)
            : base(message)
        { }
    }
}
