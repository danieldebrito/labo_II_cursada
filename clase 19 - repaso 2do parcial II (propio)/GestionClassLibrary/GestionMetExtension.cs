using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesClassLibrary;

namespace GestionClassLibrary
{
    public static class GestionMetExtension
    {
        public static double MostrarImpAFIPMetodoExtension(this IAfip bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }
        public static double MostrarImpARBAMetodoExtension(this IArba bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }
    }
}
