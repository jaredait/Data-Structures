using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[] { 9, 5, 4, 7, 6, 8, 3, 1, 2 };
            foreach (int elemento in arreglo)
                Console.WriteLine(elemento);
            Console.WriteLine("Elementos arreglados:");
            BubbleSort(arreglo);
            foreach (int elemento in arreglo)
                Console.WriteLine(elemento);

        }

        public static void BubbleSort(int[] array)
        {
            int aux;

            
            for (int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 1; j < array.Length; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        aux = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = aux;
                    }
                }
            }
        }
    }
}
