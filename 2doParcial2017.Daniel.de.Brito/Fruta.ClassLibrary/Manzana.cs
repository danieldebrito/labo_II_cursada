using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using InterfacesClassLibrary;

namespace FrutasClassLibrary
{
    [Serializable]
    public class Manzana : Fruta, ISerializable
    {
        public string distribuidora;

        public override bool TieneCarozo { 
            get {return true;}
            // para serializar necesito el set
            //set;// { this.TieneCarozo = value; }
        }
        public string Tipo { 
            get { return "MANZANA"; }
            // para serializar necesito el set
            //set;// { this.Tipo = value; }
        }

        // constructor por dafault para serializar =================
        public Manzana() { }
        //==========================================================
        public Manzana(float peso, ConsoleColor color, string distr)
            : base(peso, color)
        {
            this.distribuidora = distr;
        }

        // to string
        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TIPO: " + this.Tipo);
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("DISTRIBUIDORA: " + this.distribuidora.ToString());

            return sb.ToString();
        }
        public override string ToString()
        { 
            return this.FrutaToString();
        }

        //implementacion de la interface
        public string RutaArchivo { get; set; }
        public bool Deserializar()
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(Manzana));
                XmlTextReader xmlRD = new XmlTextReader(this.RutaArchivo);
                Manzana m = (Manzana)xmls.Deserialize(xmlRD);


                // asigno a la instancia lo deserializado //
                this.Color = m.Color;
                this.Peso = m.Peso;
                //this.TieneCarozo = m.TieneCarozo;
                this.distribuidora = m.distribuidora;
                //this.Tipo = m.Tipo;

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
    }
}
