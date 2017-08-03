using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassLibrary
{
    public delegate void DelegadoCorrenCallBack (int avance, Persona p);

    public class Persona : Corredor
    {
        private string _nombre;
        public event DelegadoCorrenCallBack EventoCorriendo;

        public Persona(string nombre, short velMax, ECarril carril)
            : base(velMax, carril)
        {
            this._nombre = nombre;
        }
        public override void CorrerLanzaEventos()
        {
            for (int i = 0 ; i < 100 ; i += Corredor._avance.Next(0, this.VelocidadMaxima))
            {
                this.EventoCorriendo(i,this);
                System.Threading.Thread.Sleep(300);
            }
        }
        public override string ToString()
        {
            return string.Format("{0} en carril {1} a una velocidad máxima de {2}",this._nombre,this._carriElegido,this.VelocidadMaxima);
        }
    }
}
