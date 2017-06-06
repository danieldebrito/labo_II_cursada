using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SerializacionXml3
{
    class Program
    {
        const string FILE_NAME ="C:\\DatosLista.xml";
        
        static void Main(string[] args)
        {
            //Declaro una variable de tipo Lista
            Lista listaDatoXML;

            Console.WriteLine("Busqueda y ordenamiento");
            Console.WriteLine("Preparado para Deserializar pulse una tecla....");
            Console.ReadLine();

            try
            {
                Console.WriteLine("Deserializando...");
                Console.ReadLine();
                Console.Clear();
                
                using (XmlTextReader reader = new XmlTextReader(FILE_NAME))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(Lista)));
                    
                    listaDatoXML = (Lista)ser.Deserialize(reader);
                }

                Console.WriteLine("Datos recuperados desde XML...");

                //Muestro los datos contenidos en la lista
                foreach (Dato miDato in listaDatoXML.Items)
                {
                    Console.WriteLine(miDato.ToString());
                }

                Console.ReadLine();

                Console.WriteLine("Busqueda...Ingrese un nombre: ");

                string name = Console.ReadLine();
                bool encontro = false;

                foreach (Dato miDato in listaDatoXML.Items)
                {
                    if (String.Compare(miDato.nombre, name) == 0)
                    {
                        Console.WriteLine("Ingrese nueva edad:");

                        miDato.edad = int.Parse(Console.ReadLine());
                        //                        listaDatoXML.Items.RemoveAt(i);
                        //                        listaDatoXML.Items.Insert(i, vec[i]);

                        Program.Guardar(listaDatoXML);

                        encontro = true;
                        break;
                    }
                }

                if (!encontro)
                {
                    Console.WriteLine("No se encontro el dato...");
                    Console.ReadLine();
                }

                //Recorro y observo las modificaciones
                for (int i = 0; i < listaDatoXML.Items.Count; i++)
                {
                    Console.WriteLine(listaDatoXML.Items[i].ToString());
                }

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Ordenando...por nombre");
                Console.ReadLine();

                listaDatoXML.Items.Sort(Dato.CompararNombre);

                //Muestro los datos contenidos en la lista
                foreach (Dato miDato in listaDatoXML.Items)
                {
                    Console.WriteLine(miDato.ToString());
                }
                                
                Console.ReadLine();

                Console.WriteLine("Ordenando...por edad");
                Console.ReadLine();

                listaDatoXML.Items.Sort(Dato.CompararEdad);

                //Muestro los datos contenidos en la lista
                foreach (Dato miDato in listaDatoXML.Items)
                {
                    Console.WriteLine(miDato.ToString());
                }


                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Error al Serializar/Deserializar los Datos");
            }

            finally
            {
                Console.WriteLine("Saliendo del programa...");
                Console.ReadLine();
            }
        }
        
        public static void Guardar(Lista listaPasada)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(FILE_NAME, 
                                                                System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(Lista)));
                    ser.Serialize(writer, listaPasada);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
