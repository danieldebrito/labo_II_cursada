using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pila
{
    class Program
    {
        static void Main(string[] args)
        {

            #region pila - cola
            Stack pila = new Stack(3);
            Queue cola = new Queue();

            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(5);

            cola.Enqueue(1);
            cola.Enqueue(2);
            cola.Enqueue(3);
            cola.Enqueue(4);
            cola.Enqueue(5);



            Console.WriteLine("Pila");
            for (int i = pila.Count; i >0; i--)
            {                
                Console.WriteLine(pila.Pop().ToString());
            }

            Console.WriteLine("queue");
            for (int i = cola.Count; i > 0; i--)
            {
                Console.WriteLine(cola.Dequeue().ToString());
            }
            #endregion

            #region hastable
            Hashtable ht = new Hashtable();

            ht.Add(1, 33);
            ht.Add(2, 34);
            ht.Add(3, 36);
            ht.Add(4, 55);
            ht.Add(5, 45);

            foreach(DictionaryEntry entry in ht)
            {
                 Console.WriteLine(entry.Key + ":" + entry.Value);
            }
            #endregion

            #region hastable II
            Hashtable ht2 = new Hashtable();

            ht2.Add(108, 33);
            ht2.Add(-99, 34);
            ht2.Add(33, 36);


            foreach (var i in ht2.Keys)
            {
                Console.WriteLine("clave {0} : valor: {1}",i,ht2[i]);
            }
            #endregion
            
            
            
            Console.ReadKey();

        }
    }
}
