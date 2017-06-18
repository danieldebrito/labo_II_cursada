using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionClassLibrary;
using VehiculoClassLibrary;
using InterfacesClassLibrary;
using ExcepcionesClassLibrary;



namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region instancias
            Carreta c1 = new Carreta(100);
            Carreta c2 = new Carreta(150);
            Carreta c3 = new Carreta(170);

            Avion a1 = new Avion(600, 1200);
            Avion a2 = new Avion(700, 2200);
            Avion a3 = new Avion(800, 3200);

            Deportivo d1 = new Deportivo(400, "exp123", 20);
            Deportivo d2 = new Deportivo(500, "ett155", 80);
            Deportivo d3 = new Deportivo(600, "dfs785", 70);

            Familiar f1 = new Familiar(250, "dsf456", 5);
            Familiar f2 = new Familiar(750, "xzc458", 4);
            Familiar f3 = new Familiar(850, "cfr894", 2);

            Privado p1 = new Privado(500, 4512, 517);
            Privado p2 = new Privado(700, 4782, 577);
            Privado p3 = new Privado(900, 4252, 587);

            Comercial co1 = new Comercial(457, 4787, 6);
            Comercial co2 = new Comercial(477, 4147, 5);
            Comercial co3 = new Comercial(487, 4967, 4);
            #endregion

            #region prueba impuestos
            Console.WriteLine("CARRETA HEREDA UNA SOLA INTERFACE");
            Console.WriteLine(c1.CalcularImpuesto());

            Console.WriteLine("\n<--------------------------------->\n");

            Console.WriteLine("AVION HEREDA LAS DOS INTERFACES, MUESTRO POR METODO ESTATICO");
            Console.WriteLine(GestionMetEstaticos.MostrarImpuestoAFIP(a1));
            Console.WriteLine(GestionMetEstaticos.MostrarImpuestoARBA(a2));

            Console.WriteLine("\n<--------------------------------->\n");

            Console.WriteLine("DEPORTIVO HEREDA TAMBIEN LAS DOS INTERFACES, MUESTRO POT METODO DE EXTENSION");

            Console.WriteLine(a1.MostrarImpAFIPMetodoExtension());
            Console.WriteLine(a2.MostrarImpARBAMetodoExtension());

            Console.WriteLine("\n<--------------------------------->\n");

            Console.WriteLine("MUESTRO UNO DE CADA PARA PROBAR TO STRING");

            Console.WriteLine(a1.ToString());
            Console.WriteLine(d1.ToString());
            Console.WriteLine(f1.ToString());
            Console.WriteLine(co1.ToString());
            Console.WriteLine(c1.ToString());
            Console.WriteLine(p1.ToString());

            Console.WriteLine("\n<--------------------------------->\n");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region prueba lista generica con excepciones

            Estacionamiento<Vehiculo> e = new Estacionamiento<Vehiculo>(3);
            
            try
            {
                if(e.Agregar(a1))
                    Console.WriteLine("agregado ok");
            }
            catch (ObjetoRepetidoExcepcion ex)
            {
            Console.WriteLine(ex.Message);
            }
            catch (ListaLLenaException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                if (!e.Agregar(a1))
                    Console.WriteLine("agregado ok");
            }
            catch (ObjetoRepetidoExcepcion ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ListaLLenaException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                if(e.Agregar(f1))
                    Console.WriteLine("agregado ok");
            }
            catch (ObjetoRepetidoExcepcion ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ListaLLenaException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            try
            {
            if (e.Agregar(f1))
                Console.WriteLine("agregado ok");
            }
            catch (ObjetoRepetidoExcepcion ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ListaLLenaException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            try
            {
                if (e.Agregar(d1))
                    Console.WriteLine("agregado ok");
            }
            catch (ObjetoRepetidoExcepcion ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ListaLLenaException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            try
            {
                if (!e.Agregar(d2))
                    Console.WriteLine("se lleno");
            }
            catch (ObjetoRepetidoExcepcion ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ListaLLenaException ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.WriteLine(e.ToString());

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region prueba archivos xml bin

            // guardo lista
            e.guardar("archivo.xml", e.Lista);

            //creo una nueva lista
            List<Vehiculo> e2 = new List<Vehiculo>();

            //desderializo el xml generado antes y lo guardo en la nueva lista
            e.leer("archivo.xml", out e2);

            //guardo la lista nueva en un nuevo archivo, deberia ser igual al archivo anterior
            // si es igual deserializa y serializa bien!!!
            e.guardar("archivoII.xml", e2);


            Console.ReadKey();
            Console.Clear();
            #endregion

        }
    }
}
