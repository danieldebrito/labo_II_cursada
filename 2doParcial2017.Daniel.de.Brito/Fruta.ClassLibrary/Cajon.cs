using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExepcionesClassLibrary;
using InterfacesClassLibrary;
using System.Xml.Serialization;
using System.Xml;

namespace FrutasClassLibrary
{
    public class Cajon<T> : ISerializable
    {
        private int _capacidad;
        private List<T> _frutas;
        public T atr;
        private float _precioUnitario;

        public List<T> Frutas { get { return this._frutas; } }
        public float PrecioTotal { get { return this._precioUnitario; } }

        // para serializar y deserializar ==============
        public int Capacidad
        {
            get { return this._capacidad; }
            set { this._capacidad = value; }
        }
        public List<T> Lista
        {
            get { return this._frutas; }
            set { this._frutas = value; }
        }
        public float PrecioUnit
        {
            get { return this._precioUnitario; }
            set { this._precioUnitario = value; }
        }
        //==============================================

        public Cajon()
        {
            this._frutas = new List<T>();
            this.atr = default(T);
        }
        public Cajon(int capac, float prec)
            : this()
        {
            this._capacidad = capac;
            this._precioUnitario = prec;
        }

        public static Cajon<T> operator + (Cajon<T> c, T f)
        {
            if (c._capacidad > c.Frutas.Count)
            {
                c.Frutas.Add(f);
                return c;
            }
            else
                throw new CajonLLenoExcepcion("El Cajon Esta LLeno");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAPACIDAD" + this._capacidad.ToString());
            sb.AppendLine("CANT DE FRUTAS: " + this._frutas.Count.ToString());
            sb.AppendLine("PRECIO TOTAL" + this._precioUnitario.ToString());

            sb.AppendLine("LISTADO DE FRUTAS");

            foreach (T t in this._frutas)
            {
                sb.AppendLine("*************************************");
                sb.AppendLine(t.ToString());
                sb.AppendLine("*************************************");
                
            }

            return sb.ToString();
        }

        // implementacion de la interface
        public string RutaArchivo
        {
            get;
            set;
        }
        public bool Deserializar()
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(Cajon<T>));
                XmlTextReader xmlRD = new XmlTextReader(this.RutaArchivo);
                Cajon<T> c = (Cajon<T>)xmls.Deserialize(xmlRD);

                // asigno a la instancia lo deserializado //
                this.Capacidad = c.Capacidad;
                this.PrecioUnit = c.PrecioUnit;
                this.Lista = c.Lista;

                xmlRD.Close();
                Console.ReadKey();

                return true;
            }
            catch (Exception e)
            {
                // this = null;
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool SerializarXML()
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(Cajon<T>));
                XmlTextWriter xmlTW = new XmlTextWriter(this.RutaArchivo, UTF8Encoding.UTF8);
                xmls.Serialize(xmlTW, this);
                xmlTW.Close();
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
