using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personaLibreria;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleAppBinary
{
    class ProgramBin
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\archivo.dat";
            Persona pp = new Persona("Joey Ramone", 49, true);

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(path,FileMode.Create);

            bf.Serialize(fs, pp);
            fs.Close();

            BinaryFormatter bfo = new BinaryFormatter();
            FileStream fo = new FileStream(path, FileMode.Open);
                        
            Console.WriteLine(bfo.Deserialize(fo).ToString());
            fs.Close();
            Console.ReadKey();
        }
    }
}
