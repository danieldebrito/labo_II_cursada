using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClassLibrary
{
    public interface ISerializableXML<T>
    {
        bool guardar(string archivo, List<T> datos);
        bool leer(string archivo, out List<T> datos);
    }
}
