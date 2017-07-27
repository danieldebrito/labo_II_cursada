using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProveedorClassLibrary
{
    public interface ISerializableXML<T>
    {
        bool serializar(string ruta);
        bool deserealizar(string RutaArchivo, out Agenda<T> ag);
        bool deserealizar(string RutaArchivo);
    }
}
