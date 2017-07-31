using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public enum EEspecialidad { Traumatologo, Odontologo};

    public class MEspecialista: Medico, IMedico
    {
        private EEspecialidad especialidad;

        public MEspecialista(string nombre, string apellido, EEspecialidad esp)
        :base(nombre, apellido)
        {
            this.especialidad = esp;
        }

        protected override void Atender()
        {
            Thread.Sleep(tiempoAleatorio.Next(5000, 10000));
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
