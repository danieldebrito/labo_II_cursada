using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personaLibreria;
using Entidades.Externa;
using Entidades.Externa.Sellada;
using persona;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instancia de clase persona (desde dll)
            
            Persona p1 = new Persona("David", "Bowie", 56, personaLibreria.ESexo.Masculino);
            Console.WriteLine(p1.ObtenerInfo);

            Console.ReadKey();
            Console.Clear();

            // instancia de clase personaDos hereda de una clase externa desde una dll

            PersonaDos pd = new PersonaDos("Lou", "Reed", 68, Entidades.Externa.ESexo.Masculino);
            Console.WriteLine(pd.ObtenerInfo);


            Console.ReadKey();
            Console.Clear();

            // instancia de clase externa y sellada personaExternaSellada (desde dll) comn metodos de extension

            PersonaExternaSellada p = new PersonaExternaSellada("Iggy", "Pop", 64, Entidades.Externa.Sellada.ESexo.Masculino);
            Console.WriteLine(p.ObtenerInformacion());  // metodo de extension


            Console.ReadKey();
            Console.Clear();
        }
    }
}
