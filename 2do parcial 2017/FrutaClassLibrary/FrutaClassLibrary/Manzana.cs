using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesClassLibrary;
using System.Xml.Serialization;
using System.Xml;

namespace FrutaClassLibrary
{
    [Serializable]
    public class Manzana : Fruta, ISerializable
    {
        
        public string distribuidora;

        public override bool TieneCarozo
        {
            get { return true;}
        }

        public Manzana() { }

        public Manzana(float peso, ConsoleColor color, string distribuidor)
           :base(peso, color)
        {
            this.distribuidora = distribuidor;
        }

        public string Tipo
        {
            get { return "Manzana"; }
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TIPO: " + this.Tipo);
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("DISTRIBUIDOR: " + this.distribuidora);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        public string RutaArchivo
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\archManzana.xml"; }
            set { /*this.RutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\archivo.xml";*/ }
        }

        public bool serializar()
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(Manzana));
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
        public bool deserealizar()
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<Fruta>));
                XmlTextReader xmlRD = new XmlTextReader(this.RutaArchivo);
                Manzana m;
                m = (Manzana)xmls.Deserialize(xmlRD);

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
