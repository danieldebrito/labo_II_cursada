using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface ISerializable
    {
        bool SerializarXML(string archivo);
        //bool SerializarBin(string archivo);
        bool DesSerializarXML(string archivo);
        //bool DesSerializarBin(string archivo);
    }
}
