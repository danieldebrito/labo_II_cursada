/*
 * el metodo de extension se usa para agregarle metodos a clases selladas de las cuales no tenemos acceso
 * en este ejemplo se creo una clase sellada y luego se refencio a este proyecto desde el archivo dll que genera
 * mediante esta clase STATICA se crean los metodos de extension para ser impelentado en un proyecto de consola, clase Program
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libreriaSellada;

namespace persona
{
    public static class MetodExtension
    {
        public static string Mostrar(this PersonaSellada ps)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("edad: " + ps.edad.ToString());
            sb.AppendLine("nombre: " + ps.Nombre);

            return sb.ToString();
        }
    }
}