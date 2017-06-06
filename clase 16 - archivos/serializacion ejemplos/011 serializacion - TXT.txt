using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ArchivoDeTexto02
{
    class Program
    {
        //Creo una constante con el path del archivo
        private const string FILE_NAME = "C:\\TestFile2.txt";
        
        //Creo un atributo para indicar el tipo de codificación
        private static Encoding miCodificacion;

        static void Main(string[] args)
        {
            try
            {
                miCodificacion = Encoding.UTF8;

                //Utilizo métodos estáticos de la clase File
                if (File.Exists(FILE_NAME))
                {
                    char rta;
                    Console.WriteLine("El archivo {0} ya existe. Desea sobre escribir?", 
                                         FILE_NAME);
                    
                    rta = char.Parse(Console.ReadLine());

                    if (rta == 's')
                    {
                        //El bloque using asegura que el objeto invocará al método Dispose()
                        using (StreamWriter sw = new StreamWriter(@"C:\TestFile2.txt", false, 
                                                                    miCodificacion))
                        {
                            sw.Write("Este es el ");
                            sw.WriteLine("Encabezado para el archivo.");
                            sw.WriteLine("-----------------------------");
                            sw.WriteLine("ARCHIVO SOBRESCRITO....");
                        }
                    }
                    else
                    {
                        //Al colocar el parámetro append en true, agrego datos
                        using (StreamWriter sw = new StreamWriter(FILE_NAME, true, miCodificacion))
                        {
                            sw.WriteLine("Línea agregada al archivo original...");
                        }
                    }
                }
                else
                {
                    //Si no existe el archivo genero uno con 
                    //codificación UTF8
                    using (StreamWriter sw = new StreamWriter("C:\\TestFile2.txt", false, 
                                                                miCodificacion))
                    {
                        sw.Write("Este es el ");
                        sw.WriteLine("Encabezado para el archivo.");
                        sw.WriteLine("-----------------------------");
                        sw.Write("Este archivo está codificado en: ");
                        sw.WriteLine(miCodificacion.BodyName);
                        sw.WriteLine("Coloco caracteres: ñ í ó");
                        sw.WriteLine("ARCHIVO NUEVO");
                    }
                }

                Console.WriteLine("El archivo fue escrito exitosamente.....");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                //Leo el archivo y le indico la codificación
                using (StreamReader sr = new StreamReader(FILE_NAME, miCodificacion))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Datos recuperados desde el archivo.....");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error en el archivo ubicado en {0}", FILE_NAME);
                Console.WriteLine(e.Message);
            }

            finally 
            {
                Console.ReadLine();
            }
        }
    }
}
