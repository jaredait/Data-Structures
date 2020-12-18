using System;
using System.Collections.Generic;
using System.Text;

namespace ADT_Matriz
{
    class ADT
    {
        public static void Main(string[] args)
        {
            // Declaracion de variables
            Matriz x, y, z;

            // Indicaciones y lectura de datos
            Console.WriteLine("Matriz X");
            x = LecturaElementos();
            Console.WriteLine("\nMatriz Y");
            y = LecturaElementos();

            // Impresion de las matrices ingresadas
            Console.WriteLine("\nMatriz X:");
            ImprimirMatriz(x);
            Console.WriteLine("\nMatriz Y:");
            ImprimirMatriz(y);

            // Suma
            Console.WriteLine("\nX + Y = Z");
            z = SumaMatriz(x, y);
            ImprimirMatriz(z);

            // Resta
            Console.WriteLine("\nX - Y = Z");
            z = RestaMatriz(x, y);
            ImprimirMatriz(z);
        }

        //Tipo ADT
        public struct Matriz
        {
            public int filas;
            public int columnas;
            public int[,] datos;

            public Matriz(int fil, int col)
            {
                filas = fil;
                columnas = col;
                datos = new int[filas, columnas];
            }
        }

        // Funcion que lee los elementos de una matriz por consola y retorna su resultado
        static public Matriz LecturaElementos()
        {
            Matriz elemento;

            // Lectura de la dimension de la matriz
            Console.Write("Número de filas: ");
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número de columnas: ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            // Intanciacion de la matriz que almacenara el resultado
            elemento.datos = new int[filas, columnas];
            elemento.filas = filas;
            elemento.columnas = columnas;

            // Lectura de cada elemento de la matriz
            for (int i = 0; i < elemento.filas; i++)
            {
                for (int j = 0; j < elemento.columnas; j++)
                {
                    Console.Write("elemento[{0},{1}]: ", i + 1, j + 1);
                    elemento.datos[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return elemento;
        }

        // Impresion del los elementos de un ADT Matriz
        static public void ImprimirMatriz(Matriz a)
        {
            for (int i = 0; i < a.filas; i++)
            {
                for (int j = 0; j < a.columnas; j++)
                {
                    Console.Write("{0,5}", a.datos[i, j]);
                }
                Console.WriteLine();
            }
        }


        // Sumar 2 ADT Matriz
        static public Matriz SumaMatriz(Matriz a, Matriz b)
        {
            Matriz c = new Matriz(a.filas, a.columnas);
            c.datos = new int[a.filas, a.columnas];

            for (int i = 0; i < a.datos.GetLength(0); i++)
                for (int j = 0; j < a.datos.GetLength(1); j++)
                    c.datos[i, j] = a.datos[i, j] + b.datos[i, j];

            return c;
        }

        // Restar 2 ADT Matriz
        static public Matriz RestaMatriz(Matriz a, Matriz b)
        {
            Matriz c = new Matriz(a.filas, a.columnas);
            c.datos = new int[a.filas, a.columnas];

            for (int i = 0; i < a.datos.GetLength(0); i++)
                for (int j = 0; j < a.datos.GetLength(1); j++)
                    c.datos[i, j] = a.datos[i, j] - b.datos[i, j];

            return c;
        }

    }
}
