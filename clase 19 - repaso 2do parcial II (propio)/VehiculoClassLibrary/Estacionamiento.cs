using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcepcionesClassLibrary;
using InterfacesClassLibrary;
using System.Xml.Serialization;
using System.Xml;


namespace VehiculoClassLibrary
{
    public class Estacionamiento <T> : ISerializableXML<T>
    {
        private int _capacidadMaxima;
        public T atr;
        private List<T> _lista;

        public List<T> Lista
        {
            get { return _lista; }
            set { _lista = value; }
        }
        
        public Estacionamiento()
        {
            this._lista = new List<T>();
            this.atr = default(T);
        }
        public Estacionamiento(int capacidadMaxima)
            :this()
        {
            this._capacidadMaxima = capacidadMaxima;
        }
        public static bool operator + (Estacionamiento<T> d, T a)
        {
            bool ret = false;

            if (d._capacidadMaxima > d._lista.Count)
            {
                if (!d._lista.Contains(a))
                {
                    d._lista.Add(a);
                    ret = true;
                }
                else
                {
                    throw new ObjetoRepetidoExcepcion();
                }
            }
            else
            {
                throw new ListaLLenaException();
            }
            return ret;
        }
        private int GetIndice(T a)
        {
            foreach (T aux in this._lista)
            {
                if (aux.Equals(a))
                    return this._lista.IndexOf(a);
                break;
            }
            
            return -1;
        }
        public static bool operator - (Estacionamiento<T> d, T a)
        {
            bool ret = false;
            if (d.GetIndice(a) > 0)
            {
                d._lista.Remove(a);
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

            sb.AppendLine("Capacidad Maxima: " + this._capacidadMaxima);
            sb.AppendLine("|************CONTENIDO************|\n");
            sb.AppendLine("|*********************************|");

            foreach (T a in this._lista)
            {
                sb.AppendLine(a.ToString());
                sb.AppendLine("|*********************************|");
            }

            return sb.ToString();
        }

        public List<T> GetLista()
        {
            return this._lista;
        }

        public bool guardar(string archivo, List<T> Lista)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<T>));
                XmlTextWriter xmlTW = new XmlTextWriter(path + archivo, UTF8Encoding.UTF8);
                xmls.Serialize(xmlTW, Lista);
                xmlTW.Close();
				Console.ReadKey();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool  leer(string archivo, out List<T> Lista) 
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<Vehiculo>));
                XmlTextReader xmlRD = new XmlTextReader(path + archivo);
                Lista = (List<T>)xmls.Deserialize(xmlRD);

                xmlRD.Close();
                Console.ReadKey();

                return true;
            }
            catch (Exception e)
            {
                Lista = null;
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
