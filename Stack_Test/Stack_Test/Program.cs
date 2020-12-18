using System;
using System.Collections;

namespace Stack_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();

            Console.WriteLine("inicialmente hay {0} elementos", pila.Count);

            pila.Push(1);
            pila.Push(2);
            pila.Push(4);

            foreach (Object obj in pila)
                Console.WriteLine(obj);

            Console.WriteLine("ahora hay {0} elementos", pila.Count);

            if (pila.Contains(3))
                Console.WriteLine("si esta el 3");
            else
                Console.WriteLine("no esta el 3");
            Console.WriteLine("stack de tipo {0}", pila.GetType());

            Console.WriteLine("ultimo elemento ingresado a la pila: {0}", pila.Peek());

            for (int i = 0; i < 3; i++)
                Console.WriteLine(pila.ToArray()[i]);

        }
    }
}
