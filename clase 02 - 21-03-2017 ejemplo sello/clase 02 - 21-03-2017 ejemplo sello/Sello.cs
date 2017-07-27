using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02Sello
{
    class Sello
    {
        public string mensage;
        public ConsoleColor color;

        public string Imprimir()
        {
            return this.mensage;
        }
        public string Borrar()
        {
            return this.mensage="";
        }
        public void ImprimirEnColor()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(this._ArmarMensage());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        private string _ArmarMensage()
        {
            if (mensage.Length == 0)
                return "";

            StringBuilder sb = new StringBuilder();
            StringBuilder sbLine = new StringBuilder();

            for (int i = 0; i <= (this.mensage.Length + 1); i++)
                sbLine.Append("*");

            sb.AppendLine(sbLine.ToString());
            sb.AppendLine("*" + this.Imprimir() + "*");
            sb.AppendLine(sbLine.ToString());
            
            return sb.ToString();
        }
    }
}
