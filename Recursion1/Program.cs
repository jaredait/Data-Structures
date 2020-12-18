// NOMBRE DEL PROGRAMA: Implementacion de funciones recursivas
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 29/oct/2020
// PROPOSITO DE ULTIMA MODIFICACION: creacion de funciones y documentacion
// FECHA DE ULTIMA MODIFICACION: 29/oct/2020

using System;

namespace Recursion1
{
    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            byte opcion;
            string menu = "\t\tOpciones\n1. Factorial de un numero\n2. Multiplicacion por sumas" +
                "\n3. Serie Fibonacci\n0. Finalizar programa";
            int n, m;
            Console.Title = "Recursividad - Jared Ampudia";
            do
            {
                // Desplegar menu y lectura de la opcion
                Console.Clear();
                Console.WriteLine(menu);
                opcion = Convert.ToByte(Console.ReadLine());
                switch (opcion)
                {
                    // Calculo del factorial del numero ingresado
                    case 1:
                        Console.Write("\tAplicacion funcion factorial\nIngresa el valor de n.\nn = ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("n! = {0}", Factorial(n));
                        Console.WriteLine("\nPresiona cualquier tecla para volver al menu...");
                        Console.ReadKey();
                        break;
                    // Multimplicacion por sumas de los dos numeros ingresados
                    case 2:
                        Console.Write("\tMultiplicacion por sumas:\nIngresa los valores de n y m\nn = ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("m = ");
                        m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} * {1} = {2}", n, m, MultPorSumas(n, m));
                        Console.WriteLine("\nPresiona cualquier tecla para volver al menu...");
                        Console.ReadKey();
                        break;
                    // Imprimir el n termino de la sucesion Fibonacci
                    case 3:
                        Console.Write("\tNumeros de Fibonacci\nIngresa el numero de termino para calcularlo\nn = ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Termino No. {0} = {1}", n, Fibonacci(n));
                        Console.WriteLine("\nPresiona cualquier tecla para volver al menu...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Programa finalizado con exito.");
                        break;
                }

            } while (opcion == 1 || opcion == 2 || opcion == 3);
        }

        // Definicion de funciones

        // Nombre: Factorial
        // Proposito: Calcular el factorial de n recursivamente
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        // Nombre: MultPorSumas
        // Proposito: Calcular el producto de dos numeros mediante sumas recursivamente
        public static int MultPorSumas(int a, int b)
        {
            if (b == 1)
                return a;
            else
                return a + MultPorSumas(a, b - 1);
        }

        // Nombre: Fibonacci
        // Proposito: Calcular el n termino de la sucesion Fibonacci recursivamente
        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }
}