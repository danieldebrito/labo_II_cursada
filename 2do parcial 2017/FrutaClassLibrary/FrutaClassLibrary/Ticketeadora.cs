using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FrutaClassLibrary
{
    public static class  Ticketeadora
    {
        public static bool ImprimirTicket(this Cajon<Platano> c , string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    sw.WriteLine("FECHA: " + System.DateTime.Now);
                    sw.WriteLine("precio: " + c.PrecioTotal);
                    sw.WriteLine(" ----------------------------- ");

                    sw.WriteLine(c.ToString());
                }
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
