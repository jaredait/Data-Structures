// NOMBRE DEL PROGRAMA: Busqueda binaria secuencial
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 4/nov/2020
// PROPOSITO DE ULTIMA MODIFICACION: diseño e implementacion del programa principal  
// FECHA DE ULTIMA MODIFICACION: 2/nov/2020

using System;

namespace Recursion2
{
    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos;
            int temp;
            int indice;

            // Lectura de la dimension del arreglo
            Console.Title = "Búsqueda binaria recursiva - Jared Ampudia";
            Console.WriteLine("¿Cuántos números vas a ingresar?");
            temp = Convert.ToInt32(Console.ReadLine());
            datos = new int[temp];

            // Lectura de los elementos del arreglo
            Console.WriteLine("Ingresa los elementos del arreglo:");
            for (int i = 0; i < temp; i++)
            {
                Console.Write("[{0}] = ", i);
                datos[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Lectura del numero a buscar
            Console.Write("\n¿Qué numero quieres buscar?\nNúmero = ");
            temp = Convert.ToInt32(Console.ReadLine());

            // Llamada a la funcio BBinaria e impresion de resultados
            indice = BBinaria(temp, datos, 0, datos.Length - 1);
            if (indice == -1)
                Console.WriteLine("\nEl elemento {0} no se encuentra en el arreglo", temp);
            else
                Console.WriteLine("\nEl elemento {0} esta en el Índice {1} del arreglo", temp, indice);
        }

        // Nombre de la funcion: BBinaria
        // Proposito: Buscar un entero en un arreglo pasados como argumentos
        public static int BBinaria(int x, int[] arreglo, int low, int high)
        {
            int medio;
            if (low > high)
                return -1;
            else
            {
                medio = (high + low) / 2;
                if (x == arreglo[medio])
                    return medio;
                else
                {
                    if(x > arreglo[medio])
                        return BBinaria(x, arreglo, medio + 1, high);
                    else
                        return BBinaria(x, arreglo, low, medio - 1);
                }
            }

        }
    }
}
