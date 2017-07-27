using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1 = 45, nro2 = 22, nro3 = 10;

            Comparadora.MostrarElDelMedio(nro1, nro2, nro3);
            Console.ReadKey();

            nro1 = 10;
            nro2 = 2; 
            nro3 = 100;
            Comparadora.MostrarElDelMedio(nro1, nro2, nro3);
            Console.ReadKey();

            nro1 = 100;
            nro2 = 10;
            nro3 = 65;
            Comparadora.MostrarElDelMedio(nro1, nro2, nro3);
            Console.ReadKey();

        }
    }
}
