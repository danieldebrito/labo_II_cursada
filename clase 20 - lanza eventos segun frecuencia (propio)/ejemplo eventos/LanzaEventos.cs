using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_eventos
{
    // declaro el delegado
    public delegate void delegadoEventoLanzador(object obj, EventArgs ev);

    public class LanzaEventos
    {
        public int iteracines;
        public int frecuencia;
        public int vuelta;
        // declaro el evento que se lanzara del tipo delegado ya declarado
        public event delegadoEventoLanzador eventoLanzado;

        public LanzaEventos(int iter, int frec)
        {
            this.iteracines = iter;
            this.frecuencia = frec;
            this.vuelta = 0;
        }
        public void ContadorLanzador(LanzaEventos l)
        {
            for (int i = 1; i < l.iteracines+1; i++)
            {
                if ((i % l.frecuencia) == 0)
                {
                    this.vuelta = i; 
                    // lanzo el evento segun lo que configure en el if, cada x iteraciones, le paso los parametros obj y event....
                    this.eventoLanzado(this, new EventArgs());
                }
            }
        }
    }
}
