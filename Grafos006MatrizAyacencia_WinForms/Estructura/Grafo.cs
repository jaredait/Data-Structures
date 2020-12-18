// NOMBRE DEL PROGRAMA: Implementacion de Matriz de Adyacencia
// NOMBRE DEL ESTUDIANTE: Jared Ampudia
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 09/dic/2020
// PROPOSITO DE ULTIMA MODIFICACION: Generacion de la intergfaz grafica
// FECHA DE ULTIMA MODIFICACION: 7/nov/2020

using System;
using System.Windows.Forms;

namespace Grafos006MatrizAyacencia_WinForms.Estructura
{
	// Definicion de la clase 
    // Programa que agrega y elimina vertices en la matriz de adyacencia
	public class Grafo
	{
		// Numero de vertices
		private int n;

		// Matriz de Adyacencia
		private int[,] g = new int[10, 10];

		// Constructor 
		public Grafo(int x)
		{
			this.n = x;
			int i, j;

			// Inicializar cada elemento de la matriz en cero
			for (i = 0; i < n; ++i)
			{
				for (j = 0; j < n; ++j)
				{
					g[i, j] = 0;
				}
			}
		}

		// Retorna un string que contiene la matriz de adyacencia
		public string ImprimirMatrizAdyacencia()
		{
			string matriz = string.Empty;
			// Imprimir el arreglo en 2D
			for (int i = 0; i < n; ++i)
			{
				Console.WriteLine();
				for (int j = 0; j < n; ++j)
				{
					matriz += "  " + g[i, j];
				}
				matriz += "\r\n";
			}
			return matriz;
		}

		// Traza un camino entre un par de vertices
		public void AgregarArco(int x, int y)
		{
			// Verifica si es que el vertice existe en la matriz
			if ((x >= n) || (y > n))
			{
				MessageBox.Show("El vertice no existe!");
			}

			// Verifica si es que el vertice se conecta a si mismo
			if (x == y)
			{
				MessageBox.Show("Mismo vertice!");
			}
			else
			{
				// Conectar los vertices
				g[y, x] = 1;
				g[x, y] = 1;
			}
		}

		// Aumenta la cantidad de vertices en 1
		public void AgregarVertice()
		{
			// Ingresar un nuevo verice
			n++;
			int i;

			// Inicializar los nuevos elementos en cero 
			for (i = 0; i < n; ++i)
			{
				g[i, n - 1] = 0;
				g[n - 1, i] = 0;
			}
		}

		// Elimina el numero de vertice indicado
		public void RemoverVertice(int x)
		{
			// Verificar si es que el vertice esta presente
			if (x > n)
			{
				return;
			}
			else
			{
				int i;

				// Remover vertice
				while (x < n)
				{

					// Mover las filas a la izquierda
					for (i = 0; i < n; ++i)
					{
						g[i, x] = g[i, x];
					}

					// Mover las columnas hacia arriba
					for (i = 0; i < n; ++i)
					{
						g[x, i] = g[x, i];
					}
					x++;
				}

				// Disminuir el numero de vertices
				n--;
			}
		}
	}
}
