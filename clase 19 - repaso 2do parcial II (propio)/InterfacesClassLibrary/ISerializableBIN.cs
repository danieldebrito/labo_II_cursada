using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClassLibrary
{
    public interface ISerializableBIN
    {
        bool DesSerializarBin(string archivo);
        bool SerializarBin(string archivo);
    }
}
