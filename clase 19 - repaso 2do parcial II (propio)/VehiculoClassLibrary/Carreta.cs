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
    public class Carreta : Vehiculo, IArba
    {
        #region --------------CONSTRUCTORES------------
        public Carreta(){}
        public Carreta(double precio)
            :base(precio)
        {}
        #endregion
        
        #region -----------------METODOS---------------
        public override void MostrarPrecio()
        {
            Console.WriteLine("PRECIO: " + base.Precio);
        }
        public double CalcularImpuesto()
        {
        return this.Precio * 0.18;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CARRETA: ");
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }
        #endregion

        




    }
}
