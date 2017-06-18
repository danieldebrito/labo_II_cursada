using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClassLibrary
{
    public interface ISerializable
    {

        string RutaArchivo{get;set;}

        bool serializar();
        bool deserealizar();
    }
}
