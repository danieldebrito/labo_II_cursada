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
    //[XmlInclude(typeof(Lapicera))]
    public class Lapicera : Utiles//, ISerializable
    {
        protected ConsoleColor _color;
        protected string _trazo;

        public ConsoleColor Color { get { return this._color; } set { this._color = value; } }
        public string Trazo {get{return this._trazo;} set{ this._trazo = value;}}

        public Lapicera()
        { }

        public Lapicera(string marca, double precio, ConsoleColor color, string trazo)
            : base(marca, precio)
        {
            this._color = color;
            this._trazo = trazo;
        }

        public override string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public override double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        protected override string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LAPICERA: ");
            sb.AppendLine(base.UtilesToString());
            sb.AppendLine("COLOR: " + this._color.ToString());
            sb.AppendLine("PRECIO: " + this._precio.ToString());

            return sb.ToString();
        
        }
        public override string ToString()
        {
     	    return this.UtilesToString();
        }

        //public bool SerializarXML(string archivo)
        //{
        //    try
        //    {
        //        XmlSerializer xmls = new XmlSerializer(typeof(List<T>));

        //        XmlTextWriter xmlTW = new XmlTextWriter(archivo, UTF8Encoding.UTF8);
        //        xmls.Serialize(xmlTW, _elementos);
        //        xmlTW.Close();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        return false;
        //    }
        //}
        //public bool DesSerializarXML(string archivo)
        //{
        //    try
        //    {
        //        XmlSerializer xmls = new XmlSerializer(typeof(List<Utiles>));

        //        XmlTextReader xmlRD = new XmlTextReader(archivo);
        //        List<T> listaAux = (List<T>)xmls.Deserialize(xmlRD);

        //        foreach (T p in listaAux)  // recorro la lista deserializada
        //        {
        //            Console.WriteLine(p.ToString());
        //        }

        //        xmlRD.Close();
        //        Console.ReadKey();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        return false;

        //    }


        //}



    }
}
