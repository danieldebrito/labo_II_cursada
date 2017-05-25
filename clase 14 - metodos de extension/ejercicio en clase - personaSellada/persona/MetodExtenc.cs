using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personaLibreria;
using Entidades.Externa.Sellada;


namespace persona
{
    public static class MetodExtenc
    {

        public static string ObtenerInformacion(this PersonaExternaSellada ps)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + ps.Nombre);
            sb.AppendLine("Apellido: " + ps.Apellido);
            sb.AppendLine("Edad: " + ps.Edad);
            sb.AppendLine("Sexo : " + ps.Sexo);

            return sb.ToString();
        }
    }
}
