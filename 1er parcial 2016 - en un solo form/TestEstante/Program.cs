using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estante;

namespace TestEstante
{
    class Program
    {
        static void Main(string[] args)
        {
            #region instancias
            Estante e1 = new Estante(4);
            Estante e2 = new Estante(6);


            Jugo j1 = new Jugo(1245, EMarcaProducto.Diversion, 2.50f, ESaborJugo.Asqueroso);
            Jugo j2 = new Jugo(4512, EMarcaProducto.Manaos, 2.50f, ESaborJugo.Pasable);
            Jugo j3 = new Jugo(5487, EMarcaProducto.Naranju, 2.50f, ESaborJugo.Rico);
            Jugo j4 = new Jugo(5487, EMarcaProducto.Pitusas, 2.50f, ESaborJugo.Asqueroso);

            Galletita g1 = new Galletita(4578, EMarcaProducto.Diversion, 10.00f, 500f);
            Galletita g2 = new Galletita(5469, EMarcaProducto.Manaos, 10.00f, 1000f);
            Galletita g3 = new Galletita(5214, EMarcaProducto.Naranju, 10.00f, 200f);
            Galletita g4 = new Galletita(5987, EMarcaProducto.Pitusas, 10.00f, 100f);

            Gaseosa gs1 = new Gaseosa(4515, EMarcaProducto.Diversion, 5.00f, 600f);
            Gaseosa gs2 = new Gaseosa(4578, EMarcaProducto.Manaos, 5.00f, 550f);
            Gaseosa gs3 = new Gaseosa(5548, EMarcaProducto.Swift, 5.00f, 550f);
            Gaseosa gs4 = new Gaseosa(3256, EMarcaProducto.Pitusas, 5.00f, 550f);
            #endregion

            if (e1 + j1)
                e1.Productos.Add(j1);
            if (e1 + j2)
                e1.Productos.Add(j2);
            if (e1 + g1)
                e1.Productos.Add(g1);
            if (e1 + gs1)
                e1.Productos.Add(gs1);
            if (e1 + gs2)
                e1.Productos.Add(gs2);

            Console.Write("Valor total del estante: ");
            Console.WriteLine(e1.ValorEstanteTotal.ToString());
            
            Console.ReadKey();
            Console.Clear();

            Console.Write("Valor solo de gaseosas: ");
            Console.WriteLine(e1.GetValorEstante(ETipoProducto.Gaseosa));

            Console.Write("Valor solo de Jugos: ");
            Console.WriteLine(e1.GetValorEstante(ETipoProducto.Jugo));

            Console.Write("Valor solo de galletitas: ");
            Console.WriteLine(e1.GetValorEstante(ETipoProducto.Galletita));

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(e1.MostrarEstante(e1));

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ordeno por codigo");
            e1.Productos.Sort(e1.OrdenarPorCodigo);
            Console.WriteLine(e1.MostrarEstante(e1));

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Quito un jugo y muestro de nuevo el estante");
            e1 -= j2;
            Console.WriteLine(e1.MostrarEstante(e1));

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Quito todos los jugos");
            e1 -= ETipoProducto.Jugo;
            Console.WriteLine(e1.MostrarEstante(e1));

            Console.ReadKey();
            Console.Clear();
        }
    }
}
