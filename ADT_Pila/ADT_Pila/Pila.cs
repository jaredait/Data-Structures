using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ADT_Pila
{
    class Pila
    {
        public int[] elemento = new int[20];
        public int tope;

        public Pila()
        {
            for (int i = 0; i < elemento.Length; elemento[i++] = 0) ;
            tope = -1;
        }
        public void ImprimirPila()
        {
            for(int i = 0; i <= tope; i++)
            {
                Console.WriteLine(elemento[i]);
            }
        }
        public void Push(int a)
        {
            elemento[tope + 1] = a;
            tope++;
        }

        public int Pop()
        {
            int aux = elemento[tope];
            elemento[tope] = 0;
            tope--;
            return aux;
        }

        public static void Main(string[] args)
        {
            Pila miPila = new Pila();
            for (int i = 0; i < 15; miPila.Push(i++)) ;
            miPila.ImprimirPila();
            Console.WriteLine("fin");
        }

    }
}
