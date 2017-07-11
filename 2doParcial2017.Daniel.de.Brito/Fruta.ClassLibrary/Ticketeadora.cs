using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FrutasClassLibrary
{
    public static class Ticketeadora
    {
        public static bool ImprimirTicket(this Cajon<Platano> c, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                try
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine("PRECIO: " + c.PrecioTotal.ToString());
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
}
