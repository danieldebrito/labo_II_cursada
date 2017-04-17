using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassLibraryPaletaIndex
{
    public class Tempera
    {
        #region atributos
        private int _tamaño;
        private int _index;
        private ConsoleColor _color;
        static int _ultimaTempera;
        #endregion

        #region propiedades
        public int Tamaño
        { get { return this._tamaño; } }

        public ConsoleColor Color
        { get { return this._color; } }
        #endregion

        #region constructores
        static Tempera()
        {
            _ultimaTempera = 1;
        }

        private Tempera(int index, ConsoleColor color)
        {
            Random rd = new Random();
            _ultimaTempera++;
            this._index = index;
            this._color = color;
            Thread.Sleep(20); // pausa para que labure la funcion ramdon, si no tira todos valores iguales
            this._tamaño = rd.Next(10,50); // numero ramdon para cantidad
        }
        #endregion

        #region sobrecarga
        public static implicit operator Tempera(ConsoleColor color)
        {
        return new Tempera (_ultimaTempera, color);
        }
        #endregion
    }
}
