using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPaletaIndex
{
    public class PaletaArray
    {
        #region atributos
        private string _nombre;
        private Tempera[] _temperas;
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public int CantTemperas
        {
            get { return this._temperas.GetLength(0);}
        }
        #endregion

        #region constructor
        public PaletaArray(string nombre)
        {
            this._nombre = nombre;
            this._temperas = new Tempera[0];
        }
        #endregion

        #region sobrecarga
        public static Tempera[] operator + (PaletaArray paleta, int indice)
        {
            int i = indice >= paleta._temperas.GetLength(0) ? ++indice : --indice;

            Tempera[] aux = new Tempera[i];

            paleta._temperas.CopyTo(aux, 0);

            return aux;
        }
        #endregion

        #region indexador
        public Tempera this[int indice]
        {
            get
            {
                if (indice >= this._temperas.GetLength(0) || indice < 0)
                    return null;
                else
                    return this._temperas[indice];
            }
            set
            {        
                if (indice >= 0 && indice < this._temperas.GetLength(0)) // si el indice existe pisa
                    this._temperas[indice] = value;
                else if (indice == this._temperas.GetLength(0)) // si el indice es igual al tamaño (ya que no comtempla pos = 0 )incrementa 
                {
                    this._temperas = this + indice; // utilizo la sobrecarga de PaletaArray + indice, incrementa en indice
                    this[indice] = value; // carga la tempera en el array
                }
                else
                {
                    Console.WriteLine("No se puede asignar a este elemento");
                    Console.ReadLine();
                }
            }
        }
        #endregion

        #region metodos
        public static string Mostrar(PaletaArray p)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < p.CantTemperas; i++)
                sb.AppendFormat("Capitulo {0}: {1}\n", p[i].Color, p[i].Tamaño);
            return sb.ToString();
        }
        #endregion
    }
}
