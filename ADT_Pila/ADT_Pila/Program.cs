using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace ADT_Pila
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            int[] pila = new int[MAXLENGTH];
            Console.WriteLine("longitud");
            LlenarArreglo(pila);

            Console.WriteLine("Tope: {0}", BuscaTope(pila));
            Console.WriteLine("fin");
        }
        */

        public const int MAXLENGTH = 10;

        public static void LlenarArreglo(int[] array)
        {
            for (int i = 0; i < MAXLENGTH; array[i++] = 0) ;
        }

        public static int BuscaTope(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == 0)
                    return --i;
            return array.Length - 1;
        }

        public static bool PilaVacia(int[] array)
        {
            return BuscaTope(array) == -1 ? true : false;
        }

        public static int LeeTope(int[] array)
        {
            if (PilaVacia(array))
            {
                Console.WriteLine("Pila vacia");
                return -1;
            }
            else
                return array[BuscaTope(array)];
        }

        public static void Push(int[] array, int elemento)
        {
            array[BuscaTope(array) + 1] = elemento;
        }

        public static void Pop(int[] array, int elemento)
        {
            array[BuscaTope(array)] = 0;
        }

    }
}
