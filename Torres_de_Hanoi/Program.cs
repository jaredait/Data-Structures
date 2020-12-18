// NOMBRE DEL PROGRAMA: Solucion del problema "Torres de Hanoi" mediante recursividad
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 4/nov/2020
// PROPOSITO DE ULTIMA MODIFICACION: Implementacion del programa principal y funcion recursiva "algoritmoHanoi".
// FECHA DE ULTIMA MODIFICACION: 1/nov/2020

using System;
using System.Data.SqlTypes;
using System.Reflection;

namespace Torres_de_Hanoi
{
    class Program
    {
        // Programa principal
        static void Main(string[] args)
        {
            uint n;

            Console.Title = "Torres de Hanoi recursivo - Jared Ampudia";

            // Lectura del numero de discos
            Console.Write("Ingresa el numero de discos: ");
            while(uint.TryParse(Console.ReadLine(), out n) == false)
                Console.WriteLine("\nError, ingresa un entero mayor o igual que 0.\nIngresa el numero de discos: ");
            
            // Impresion de la solucion mediante la llamada al metodo AlgoritmoHanoi
            Console.WriteLine("\nSolución:\n");
            AlgoritmoHanoi(n, "Torre izquierda", "Torre central", "Torre derecha");
        }

        // Nombre: AlgoritmoHanoi
        // Proposito: Imprime por consola una solucion de las torres de Hanoi mediante recursividad
        public static void AlgoritmoHanoi(uint n, string from, string temp, string to)
        {
            if (n == 0)
                return;
            AlgoritmoHanoi(n - 1, from, to, temp);
            Console.WriteLine($"Mover disco {n} de la {from} a la {to}");
            AlgoritmoHanoi(n - 1, temp, from, to);
        }
    }
}
