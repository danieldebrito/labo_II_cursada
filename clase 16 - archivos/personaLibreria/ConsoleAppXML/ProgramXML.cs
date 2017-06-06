using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personaLibreria;
using System.Xml.Serialization;
using System.Xml;

namespace ConsoleAppXML
{
    class ProgramXML
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\archivo.xml";  // genero el path
            Persona pp = new Persona("Joey Ramone", 68, true);


            XmlSerializer xmls = new XmlSerializer(typeof(Persona));

            XmlTextWriter xmlTW = new XmlTextWriter(path, UTF8Encoding.UTF8);
            xmls.Serialize (xmlTW, pp);

            xmlTW.Close();


            XmlTextReader xmlRD = new XmlTextReader(path);
            Persona perAux =  (Persona)xmls.Deserialize(xmlRD);

            //xmlRD.ReadString();
            Console.WriteLine(perAux.ToString());

            xmlRD.Close();

            Console.ReadKey();
        }
    }
}
