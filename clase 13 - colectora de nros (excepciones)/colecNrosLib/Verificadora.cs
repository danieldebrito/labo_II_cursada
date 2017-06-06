using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecNrosLib
{
    public class Verificadora
    {
        public static bool VerificarNumero(Numero nr, ETipoNumero tipo)
        {
            if (nr.GetNumero % 2 == 0 && tipo == ETipoNumero.Par)
                return true;
            return false;
        }
    }
}
