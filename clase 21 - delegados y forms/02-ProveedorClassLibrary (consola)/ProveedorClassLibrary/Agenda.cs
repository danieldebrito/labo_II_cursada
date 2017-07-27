using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcepcionesClassLibrary;
using System.Xml.Serialization;
using System.Xml;


namespace ProveedorClassLibrary
{
    public class Agenda<T> : ISerializableXML<T>
    {
        private int _capacidad;
        public T atr;
        public string RutaArchivo { get; set; }
        private List<T> _proveedores;

        public List<T> ListadoProveedores
        {
            get { return this._proveedores; }
            set { this._proveedores = value; }
        }
        public int Capacidad
        {
            get { return this._capacidad; }
            set { this._capacidad = value; }
        }


        public Agenda()
        {
            this._proveedores = new List<T>();
        }
        public Agenda(int capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LISTADO DE PROVEEDORES: \n");

            foreach (T item in this.ListadoProveedores)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        public static Agenda<T> operator +(Agenda<T> agenda, T prov)
        {
            if (agenda._capacidad > agenda.ListadoProveedores.Count)
                agenda.ListadoProveedores.Add(prov);
            else
            {
                throw new AgendaLlenaException("Agenda llena");
            }

            return agenda;

        }
        public bool serializar(string RutaArchivo)
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(Agenda<T>));
                XmlTextWriter xmlTW = new XmlTextWriter(RutaArchivo, UTF8Encoding.UTF8);
                xmls.Serialize(xmlTW, this);
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
        public bool deserealizar(string RutaArchivo)
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(Agenda<T>));
                XmlTextReader xmlRD = new XmlTextReader(RutaArchivo);
                Agenda<T> proveedoresAux = (Agenda<T>)xmls.Deserialize(xmlRD);

                this._capacidad = proveedoresAux._capacidad;
                this._proveedores = proveedoresAux._proveedores;


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
        public bool deserealizar(string RutaArchivo, out Agenda<T> ag)
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(Agenda<T>));
                XmlTextReader xmlRD = new XmlTextReader(RutaArchivo);
                ag = (Agenda<T>)xmls.Deserialize(xmlRD);
                xmlRD.Close();
                Console.ReadKey();

                return true;
            }
            catch (Exception e)
            {
                ag = null;
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}

