using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace VehiculoClassLibrary
{
    [Serializable]
    public class Comercial : Avion
    {
        #region ---------------ATRIBBUTOS--------------
        private int _capacidadPasajeros;
        #endregion

        #region ---------------PROPIEDADES-------------
        public int CapacidadPasajeros
        {
            get { return _capacidadPasajeros; }
            set { _capacidadPasajeros = value; }
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Comercial() { }
        public Comercial(double precio, double velocidad, int capacidad) 
        :base(precio, velocidad)
        {
            this.CapacidadPasajeros = capacidad;
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

            sb.AppendLine("COMERCIAL");
            sb.AppendLine(base.ToString());
            sb.AppendLine("CANT PASAJEROS: " + this.CapacidadPasajeros.ToString());
            
            return sb.ToString();
        }
        #endregion
    }
}
