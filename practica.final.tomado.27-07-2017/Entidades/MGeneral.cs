using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MGeneral : Medico, IMedico
    {
        public MGeneral(string nombre, string apellido)
        :base(nombre, apellido)
        { }

        protected override void Atender()
        {
            Thread.Sleep(tiempoAleatorio.Next(1500, 2200));
            base.FinalizarAtencion();
        }

        public void IniciarAtencion(Paciente p)
        {
            this.AtenderA = p;
            Thread hl = new Thread(this.Atender);
            hl.Start();
        }
    }
}
