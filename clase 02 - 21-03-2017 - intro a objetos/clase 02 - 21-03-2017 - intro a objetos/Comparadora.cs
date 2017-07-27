using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02
{
    class Comparadora
    {
        public static int RetornarMayor (int num1, int num2)
        {
            if(num1<num2)
                return num2;
            return num1;
        }

        public static void MostrarElDelMedio(int nro1, int nro2, int nro3)
        {
            if ((nro1 < nro2 && nro3 > nro2) || (nro1 > nro2 && nro3 < nro2))
               Console.WriteLine(nro2);

            if ((nro2 < nro1 && nro3 > nro1) || (nro2 > nro1 && nro3 < nro1))
                Console.WriteLine(nro1);

            if ((nro1 < nro3 && nro2 > nro3) || (nro1 > nro3 && nro2 < nro3))
                Console.WriteLine(nro3);
        }




    }
}
