using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesClassLibrary;

namespace GestionClassLibrary
{
    public static class GestionMetEstaticos
    {
        public static double MostrarImpuestoARBA( IArba bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }

        public static double MostrarImpuestoAFIP(IAfip bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }
    }
}
