using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesClassLibrary;
using VehiculoClassLibrary;

namespace GestionClassLibrary
{
    public static class GestionMetExtArchivos
    {


        public static bool Serializar(this ISerializableXML<Vehiculo> e)
        {
            return e.guardar();
        }

        public static double Deserializar(this ISerializableXML<Vehiculo> e)
        {
            return e.leer();
        }
    }
}