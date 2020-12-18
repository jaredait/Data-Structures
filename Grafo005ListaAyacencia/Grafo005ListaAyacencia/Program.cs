// NOMBRE DEL PROGRAMA: Implementacion de grafos con listas
// NOMBRE DEL ESTUDIANTE: 
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 09/dic/2020
// PROPOSITO DE ULTIMA MODIFICACION:  generacion del menu y lectura de los datos
// FECHA DE ULTIMA MODIFICACION: 09/dic/2020


namespace Grafo005ListaAyacencia
{
	// C# code to demonstrate Graph representation 
	// using LinkedList in C# 
	using System;
	using System.Collections.Generic;

	class Graph
	{
		// A utility function to add an edge in an 
		// undirected graph 
		static void addEdge(LinkedList<int>[] adj, int u, int v)
		{
			adj[u].AddLast(v);
			adj[v].AddLast(u);
		}

		// A utility function to print the adjacency list 
		// representation of graph 
		static void printGraph(LinkedList<int>[] adj)
		{
			for (int i = 0; i < adj.Length; i++)
			{
				Console.WriteLine("\nLista de adyacencia de los vertices " + i);
				Console.Write("head");

				foreach (var item in adj[i])
				{
					Console.Write(" -> " + item);
				}
				Console.WriteLine();
			}
		}

		// Driver Code 
		public static void Main(String[] args)
		{
			// Lectura del numero de vertices
			Console.WriteLine("Ingresa el numero de vertices:");
			int V = Convert.ToInt32(Console.ReadLine());

			LinkedList<int>[] adj = new LinkedList<int>[V];

			for (int i = 0; i < V; i++)
				adj[i] = new LinkedList<int>();

			// Lectura de la opcion y proceso segun corresponda
			int opcion;
			do
			{
				Console.Clear();
				ImprimirMenu();
				opcion = Convert.ToInt32(Console.ReadLine());

				switch (opcion)
				{
					// Conectar
					case 1:
						Opc1_Conectar(adj);
						break;
					// Imprimir
					case 2:
						printGraph(adj);
						Console.ReadKey();
						break;
					// Finalizar
					case 0:
						Console.WriteLine("Programa finalizado con exito");
						break;
					default:
						Console.WriteLine("No se ingreso una opcion correcta");
						break;
				}

			} while (opcion != 0);

			Console.ReadKey();
		}
		
		// Imprime el menu por consola
		public static void ImprimirMenu()
        {
			Console.WriteLine("1. Agregar conexion");
			Console.WriteLine("2. Imprimir grafo");
			Console.WriteLine("0. Finalizar");
        }

		// Lectura de las conexiones de los vertices
		public static void Opc1_Conectar(LinkedList<int>[] adj)
        {
			// hacer control para que no exceda los limites
			Console.Write("u: ");
			int u = Convert.ToInt32(Console.ReadLine());
			Console.Write("v: ");
			int v = Convert.ToInt32(Console.ReadLine());

			addEdge(adj, u, v);
		}
	}
}
