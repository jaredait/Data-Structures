using System;

namespace Busqueda_Binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int terminoB;
            int hi, low, mid;
            int pos = 0;

            // Lectura del termino a buscar
            Console.WriteLine("Ingresa el termino de busqueda");
            terminoB = Convert.ToInt32(Console.ReadLine());

            // Llenar el arreglo
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine($"{i}: {array[i]}");
            }


            hi = array.Length - 1;
            low = 0;
            while(low <= hi)
            {
                mid = (hi + low) / 2;
                if (terminoB == mid)
                     pos = mid;
                if (terminoB > mid)
                    low = mid + 1;
                else
                    low = mid - 1;
            }

            Console.WriteLine("El termino esta en la posicion {0}", pos);
            
        }
    }
}
