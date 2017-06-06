using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEntidades
{
    class ProgramAuto
    {
       static void Main(string[] args)
        {
        Auto a1 = new Auto("Rojo", "Ferrari");
        Auto a2 = new Auto("Amarillo", "Porche");
        Auto a3 = new Auto("Negro", "BMW");
        Auto a4 = new Auto("Verde", "Ford");
        DepositoDeAutos da = new DepositoDeAutos(3);
        if ((da + a1))
        {
        Console.WriteLine("Se ha agregado el item!!!");
        }
        da.Agregar(a2);
        da.Agregar(a3);
        if (!da.Agregar(a4))
        {
        Console.WriteLine("No se pudo agregar el item!!!");
        }
        Console.WriteLine(da);
        da.Remover(a2);
        
          if (!(da - a4))
         {
        Console.WriteLine("No se pudo remover el item!!!");
        }
        Console.WriteLine(da);
        Console.ReadLine();
        }
    }
}
