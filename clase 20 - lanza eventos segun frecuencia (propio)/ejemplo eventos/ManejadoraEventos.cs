using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_eventos
{
    public class ManejadoraEventos
    {
        // metodo de igual firma que el delegado, devuelve void y recibe obj y eventargs igual que el delegado
        public static void manejador(object obj, EventArgs ev)
        {
            // imprimo esto por pantalla, esto hace el metodo
            Console.WriteLine("vuelta que lanza evento: " + ((LanzaEventos)obj).vuelta.ToString());
        }
    }
}
