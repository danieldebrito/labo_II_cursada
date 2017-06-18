using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcepcionesClassLibrary;
using InterfacesClassLibrary;
using System.Xml.Serialization;
using System.Xml;


namespace FrutaClassLibrary
{
    public class Cajon<T> : ISerializable
    {
        private int _capacidad;
        public T atr;
        private float _precioUnitario;
        private List<T> _frutas;

        public List<T> Frutas
        {
            get { return this._frutas; }
        }
        public float PrecioTotal
        {
            get 
            {
                return this._precioUnitario;
            }
        
        }

        public Cajon()
        {
            this._frutas = new List<T>();
        }
        public Cajon(int capacidad)
            :this()
        {
            this._capacidad = capacidad;
        }
        public Cajon(int capacidad, float precio)
            :this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAPACIDAD: " + this._capacidad.ToString());
            sb.AppendLine("CANT DE FRUTAS : " + this.Frutas.Count.ToString());
            sb.AppendLine("PRECIO TOTAL: " + this._precioUnitario.ToString() + "\n");

            sb.AppendLine("LISTADO DE FRUTAS: \n");

            foreach (T item in this.Frutas)
            {
                sb.AppendLine(item.ToString());
            }
    
            return sb.ToString();
        }
        public static Cajon<T> operator + (Cajon<T> c, T f)
        {
            if (c._capacidad > c.Frutas.Count)
                    c.Frutas.Add(f);
            else
            {
                throw new CajonLlenoException("Cajon LLeno");
            }

            return c;
        
        }


        public string RutaArchivo
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\archivo.xml"; }
            set { this.RutaArchivo = value;}
        }

        public bool serializar()
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<T>));
                XmlTextWriter xmlTW = new XmlTextWriter(this.RutaArchivo, UTF8Encoding.UTF8);
                xmls.Serialize(xmlTW, this.Frutas);
                xmlTW.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool deserealizar()
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<Fruta>));
                XmlTextReader xmlRD = new XmlTextReader(this.RutaArchivo);
                List<T> RetFrutas = new List<T>();
                RetFrutas = (List<T>)xmls.Deserialize(xmlRD);

                xmlRD.Close();
                Console.ReadKey();

                return true;
            }
            catch (Exception e)
            {
                //RetFrutas = null;
                Console.WriteLine(e.Message);
                return false;
            }
        
        }
    }
}
