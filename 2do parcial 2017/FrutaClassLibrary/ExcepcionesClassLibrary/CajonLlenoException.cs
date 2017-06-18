using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesClassLibrary
{
    public class CajonLlenoException : Exception
    {
        public CajonLlenoException(string mensaje)
            : base(mensaje)
        {        }
    }
}
