using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace ClassLibrary
{
    [Serializable]
    [XmlInclude(typeof(Lapicera))]
    [XmlInclude(typeof(Goma))]
    public class Cartuchera <T> 
    {
        public string marca;
        private int _capacidad;
        protected List<T> _elementos;
        

        public int Capacidad { get { return this._capacidad; } set { this._capacidad = value; } }
        public List<T> Elementos { get { return this._elementos; } set { this._elementos = value;} }

        public Cartuchera() { _elementos = new List<T>(); }


        public Cartuchera(int capacidad)
		{
			this._capacidad = capacidad;
            _elementos = new List<T>();

		}
		public static bool operator + (Cartuchera <T> d, T a)
		{
			bool ret = false;

            if (d._capacidad > d._elementos.Count)
            {
                d._elementos.Add(a);
                ret = true;
            }
            else
                throw new CartucheraLLenaException();
			return ret;
		}
		private int GetIndice(T a)
		{
			foreach (T aux in this._elementos)
			{
				if (aux.Equals(a))  // utilizo la sobrecarga del equals para verificar
					return this._elementos.IndexOf(a);
				break;
			}
				
			return -1;
		}
		public static bool operator - (Cartuchera<T> d, T a)
		{
			bool ret = false;
			if (d.GetIndice(a) > 0)
			{
				d._elementos.Remove(a);
				ret = true;
			}
			return ret;
		}
		public bool Agregar(T a)
		{
			return this + a;
		}
		public bool Remover(T a)
		{
			return this - a;
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("Capacidad Maxima:  " + this._capacidad + " Utiles");

			sb.AppendLine("Listado de Utiles");

			foreach (T a in this._elementos)
			{
				sb.AppendLine(a.ToString());
			}

			return sb.ToString();
		}
        public bool SerializarXML(string archivo)
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<T>));

                XmlTextWriter xmlTW = new XmlTextWriter(archivo, UTF8Encoding.UTF8);
                xmls.Serialize(xmlTW, this._elementos);
                xmlTW.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool DesSerializarXML(string archivo)
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<Utiles>));

                XmlTextReader xmlRD = new XmlTextReader(archivo);
                List<T> listaAux = (List<T>)xmls.Deserialize(xmlRD);

                foreach (T p in listaAux)  // recorro la lista deserializada
                {
                    Console.WriteLine(p.ToString());
                }

                xmlRD.Close();
                Console.ReadKey();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            
            }

        
        }
    }
}
