using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum ECarril { Carril_1, Carril_2}

    public abstract class Corredor
    {
        protected static Random _avance;
        protected ECarril _carriElegido;
        private short _velocidadMax;

        public ECarril CarrilElegido
        {
            get { return this._carriElegido; }
        }
        public short VelocidadMaxima
        {
            get 
            {
                if (this._velocidadMax >= 10)
                    return 10;
                if (this._velocidadMax > 0 && this._velocidadMax < 10)
                    return this._velocidadMax;
                return 0;
            }
            set 
            {
                this._velocidadMax = value;
            }
        }

        static Corredor()
        {
            _avance = new Random();
        }
        protected Corredor(short velMax, ECarril carril)
        {
            this.VelocidadMaxima = velMax;
            this._carriElegido = carril;
        }
        public abstract void CorrerLanzaEventos();
        public virtual void Guardar(string path)
        {
            throw new NotImplementedException();
        }

    }
}
