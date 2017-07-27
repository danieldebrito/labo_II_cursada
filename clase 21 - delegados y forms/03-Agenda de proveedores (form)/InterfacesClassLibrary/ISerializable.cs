using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ProveedorClassLibrary;


namespace InterfacesClassLibrary
{
    public interface ISerializableXML<T>
    {
        bool serializar(string ruta);
        bool deserealizar(string RutaArchivo);
        // no se como hacer para pasarle el tipo de dato agenda, no lo toma, buee
        //bool deserealizar(string RutaArchivo, out Agenda<Provedores> ag);
    }
}
