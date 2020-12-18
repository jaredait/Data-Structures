// Funciona bien ok
using System;
using System.Globalization;

namespace ADT_Matriz
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            Matriz a, b, c;
            //a = new Matriz(LecturaElementos(2, 2));

            a.datos = LecturaElementos();
            b.datos = LecturaElementos();

            Console.WriteLine("Matriz a:");
            ImprimirMatriz(a);
            Console.WriteLine("Matriz b");
            ImprimirMatriz(b);

            Console.WriteLine("\nOPERACIONES\n");
            
            // Resta
            c.datos = RestaMatriz(a, b);
            Console.WriteLine("a - b =");
            ImprimirMatriz(c);

            // Suma
            c.datos = SumaMatriz(a, b);
            Console.WriteLine("a + b =");
            ImprimirMatriz(c);
            
            



        }
        */
        // ADT
        public struct Matriz
        {
            
            public int[,] datos;

            public Matriz(int[,] elementos)
            {
                datos = elementos;
            }
        }

        // Funcion que lee los elementos de una matriz por consola y retorna su referencia
        static public int[,] LecturaElementos()
        {
            int[,] elemento;
            int fil, col;

            // Lectura de la dimension de la matriz
            Console.Write("Número de filas: ");
            fil = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número de columnas: ");
            col = Convert.ToInt32(Console.ReadLine());

            // Inicializacion de la matriz
            elemento = new int[fil, col];

            // Lectura de cada elemento de la matriz
            for (int i = 0; i < fil; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("elemento[{0},{1}]: ", i+1, j+1);
                    elemento[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return elemento;
        }

        // Impresion del los elementos de un ADT Matriz
        static public void ImprimirMatriz(Matriz a)
        {
            for (int i = 0; i < a.datos.GetLength(0); i++)
            {
                for (int j = 0; j < a.datos.GetLength(1); j++)
                {
                    Console.Write("{0,-4}", a.datos[i, j]);
                }
                Console.WriteLine();
            }  
        }

        // Sumar 2 ADT Matriz
        static public int[,] SumaMatriz(Matriz a, Matriz b)
        {
            int[,] c = new int[a.datos.GetLength(0), b.datos.GetLength(1)];
            
            for(int i = 0; i < a.datos.GetLength(0); i++)
                for(int j = 0; j < a.datos.GetLength(1); j++)
                    c[i, j] =a.datos[i, j] + b.datos[i, j];

            return c;
        }

        // Restar 2 ADT Matriz
        static public int[,] RestaMatriz(Matriz a, Matriz b)
        {
            int[,] c = new int[a.datos.GetLength(0), b.datos.GetLength(1)];

            for (int i = 0; i < a.datos.GetLength(0); i++)
                for (int j = 0; j < a.datos.GetLength(1); j++)
                    c[i, j] = a.datos[i, j] - b.datos[i, j];

            return c;
        }
    }
}
