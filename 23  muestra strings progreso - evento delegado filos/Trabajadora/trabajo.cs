using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // delegado que retorna void y recibe un string
    public delegate void DelegadoWork(string notificacion);

    public class trabajo
    {
        // evento declaracion del tipo delegado
        public event DelegadoWork EventoWonrking;

        //metodo que lanza eventos, no recibe parametros y retorna void para asi despues asociar a un hilo
        public void LanzaEventosTrabajando()
        {
            // lanza un evento
            this.EventoWonrking("empezamo!!"); 

            for (int i = 0; i < 10000; i++)
            {
                if (i % 500 == 0) // lanza eventos cada 500
                    this.EventoWonrking("vamo avanzando po el numero " + i.ToString());
            }
        }
    }
}
