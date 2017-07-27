using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personaLibreria;
using System.Xml.Serialization;
using System.Xml;

namespace ConsoleAppLista
{
    class Program
    {
        static void Main(string[] args)
        {
           string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\archList.xml";  // genero el path
           List<Persona> listaPersona = new List<Persona>();
           List<Persona> listaPersonaAux;  // lista de persona vacia aux para tirarle la deserializada

           Persona pp1 = new Persona("Joey Ramone", 49, true);
           Persona pp2 = new Persona("Johnny Ramone", 55, true);
           Persona pp3 = new Persona("Tommy Ramone", 65, true);
           Persona pp4 = new Persona("Dee Dee Ramone",51,true);

           listaPersona.Add(pp1);
           listaPersona.Add(pp2);
           listaPersona.Add(pp3);
           listaPersona.Add(pp4);

           XmlSerializer xmls = new XmlSerializer(typeof(List<Persona>));

           XmlTextWriter xmlTW = new XmlTextWriter(path, UTF8Encoding.UTF8);
           xmls.Serialize(xmlTW, listaPersona);
           xmlTW.Close();

           XmlTextReader xmlRD = new XmlTextReader(path);
           listaPersonaAux = (List<Persona>)xmls.Deserialize(xmlRD);

           foreach (Persona p in listaPersonaAux)  // recorro la lista deserializada
           {
               Console.WriteLine(p.ToString());
           }

           xmlRD.Close();
           Console.ReadKey();
        }
    }
}
