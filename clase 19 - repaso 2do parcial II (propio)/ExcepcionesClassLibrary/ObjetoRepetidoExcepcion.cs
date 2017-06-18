using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExcepcionesClassLibrary
{
    public class ObjetoRepetidoExcepcion : Exception
    {
        public ObjetoRepetidoExcepcion()
            :base("Objeto repetido")
        { }


    }
}
