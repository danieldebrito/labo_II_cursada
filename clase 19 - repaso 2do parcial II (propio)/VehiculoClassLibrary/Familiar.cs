using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using InterfacesClassLibrary;

namespace VehiculoClassLibrary
{
    [Serializable]
    public class Familiar : Auto
    {
        #region ---------------ATRIBBUTOS--------------
        private int _CantAsioentos;  
        #endregion

        #region ---------------PROPIEDADES-------------
        public int CantAsientos
        {
            get { return _CantAsioentos; }
            set { _CantAsioentos = value; }
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Familiar() { }
        public Familiar(double precio, string patente, int cantAsientos)
            :base(precio, patente)
        {
            this._CantAsioentos = cantAsientos;
        }
        #endregion

        #region -----------------METODOS---------------
        public override void MostrarPrecio()
        {
            Console.WriteLine("PRECIO: " + base.Precio);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("FAMILIAR");
            sb.AppendLine(base.ToString());
            sb.AppendLine("CANT ASIENTOS: " + this._CantAsioentos.ToString());

            return sb.ToString();
        }
        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------
        #endregion




    }
}
