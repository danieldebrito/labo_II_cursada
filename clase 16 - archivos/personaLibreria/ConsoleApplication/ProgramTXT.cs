using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personaLibreria;
using System.IO;

namespace ConsoleApplication
{
    class ProgramTXT
    {
        static void Main(string[] args)
        {

            #region 1ra parte
            /*Persona p = new Persona("Joey Ramone", 68);

            using(StreamWriter sw = new StreamWriter(@"E:\miArchiVO.txt"))
            {
            //StreamWriter sw = new StreamWriter("E:\\miArchiVO.txt");

            sw.WriteLine("El objeto es: ");
            sw.WriteLine(p.ToString());

            //sw.Close();  // no hace falta por el using

            }*/
            #endregion

            /* *********************************** FORMAS DE INDICAR EL PATH ********************************************
             * Guarda en una ruta especifica (se usa @ para que tome la \ como caracter de escape):
             * @"E:\miArchiVO.txt"
             * 
             * Guarda en la carpeta raiz del proyecto:
             * AppDomain.CurrentDomain.BaseDirectory + @"\archivo.txt"
             * 
             * Guarda en carpetas comunes del sistema, desktop, mis documentos, etc... :
             * Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\archivo.txt"
             */

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\archivo.txt";  // genero el path
            Persona p = new Persona("Joey Ramone", 49, true);

            /* ****************************** FORMAS DE LEER EL ARCHIVO ******************************/

            using (StreamWriter sw = new StreamWriter(path, true)) // con true me permite agregar info a la info existente del archivo
            {                                                      // el bloque using, se una para evitar cerrar el archivo con sr.Close();
                sw.WriteLine("Escritura de archivo: " + DateTime.Now);
                sw.WriteLine(p.ToString());
            }

            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine("Leyendo con metodo => sr.ReadToEnd() - lee hasta el final del archivo");
                Console.WriteLine(sr.ReadToEnd());
                Console.ReadKey();
                Console.Clear();
            }

            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(" Leyendo con sr.Read() - lee de a un solo caracter, retorna el ascii del mismo y -1 al final del archivo ");
                
                while (sr.Read() >= 0)
                {
                    Console.Write(sr.Read());
                }

                Console.ReadKey();
                Console.Clear();
            }
            
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine("Leyendo con sr.ReadLine() - lee hasta un salto de linea, la retorna en formato string, -1 al final del archivo");

                /* 
                 * Peek()
                 * devuelve un valor entero para determinar si se ha producido el final del archivo o de otro error.
                 * Esto permite que un usuario compruebe primero si el valor devuelto es -1 
                 * antes de convertirlo a un Char tipo.
                 */

                while (sr.Peek() >= 0)
                {
                    Console.WriteLine(sr.ReadLine());
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
