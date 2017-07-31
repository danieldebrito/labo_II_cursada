using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void FinAtencionPaciente(Paciente p, Medico m);

    public abstract class Medico : Persona
    {
        private Paciente pacienteAcutual;
        protected static Random tiempoAleatorio;

        public virtual string EscaAtendiendoA { get { return this.pacienteAcutual.ToString(); } }
        public Paciente AtenderA { set { this.pacienteAcutual = value; } }

        public event FinAtencionPaciente AtencionFinalizada;

        static Medico()
        {
            tiempoAleatorio = new Random();
        }
        public Medico(string nombre, string apellido)
        :base(nombre, apellido)
        { }

        protected abstract void Atender();
        protected void FinalizarAtencion()
        {
            this.AtencionFinalizada(this.pacienteAcutual, this);
            this.pacienteAcutual = null;
        }
    }
}
