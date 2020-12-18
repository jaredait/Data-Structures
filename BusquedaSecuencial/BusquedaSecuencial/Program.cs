using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace BusquedaSecuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable que almacena la posicion en la que se encuentra el valor de busqueda
            int posicion;

            Console.WriteLine("\tBÚSQUEDA SECUENCIAL\nJared Ampudia\n10/septiembre/2020\n\n");
            
            // Llamada a las funciones para llenar arreglo, introducir el valor de busqueda y buscarlo en el arreglo
            posicion = BusquedaSecuencial(InicializarArreglo(), ValorBusqueda());

            // Impresion de resultados
            Console.WriteLine("\nEl elemento se encuentra en la posicion: {0}", posicion);
        }

        // Inicializa un arreglo tipo entero de dimension 10 (LONGMAX) y lee los elementos por la consola
        static public int[] InicializarArreglo()
        {
            const int LONGMAX = 10;
            int[] arreglo = new int[LONGMAX];

            Console.WriteLine("Ingresa los elementos del arreglo");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write("Elemento[{0}]: ", i+1);
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arreglo;
        }

        // Lee por consola el valor que se va a buscar
        static public int ValorBusqueda()
        {
            Console.WriteLine("\nIngresa el término de búsqueda:");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        // Funcion que recibe un arreglo de enteros y un valor de busqueda entero. Devuelve la posicion de la primera ocurrencia
        static public int BusquedaSecuencial(int[] b, int m)
        {
            for(int i = 0; i < b.Length; i++)
                if (m == b[i])
                    return i+1;
            return -1;
        }
    }
}
