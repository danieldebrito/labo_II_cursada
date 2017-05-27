using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehiculo
{
    public static class Gestion
    {
        public static double MostrarImpuestoNacional(IAFIP bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }

        public static double MostrarImpuestoProvincial(IAFIP bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }





    }
}
