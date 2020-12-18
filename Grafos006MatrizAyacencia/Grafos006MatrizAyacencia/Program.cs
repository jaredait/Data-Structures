// NOMBRE DEL PROGRAMA: Implementacion de Matriz de Adyacencia
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 4/dic/2020
// PROPOSITO DE ULTIMA MODIFICACION: Codificacion de la interfaz por consola y metodo principal 
// FECHA DE ULTIMA MODIFICACION: 4/dic/2020

using System;

namespace Grafos006MatrizAyacencia
{
	// Programa que agrega y elimina vertices en la matriz de adyacencia
	using System;

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

		public void ImprimirMatrizAdyacencia()
		{
			Console.Write("Matriz de adyacencia:");

			// Imprimir el arreglo en 2D
			for (int i = 0; i < n; ++i)
			{
				Console.WriteLine();
				for (int j = 0; j < n; ++j)
				{
					Console.Write(" " + g[i, j]);
				}
			}
		}

		public void AgregarArco(int x, int y)
		{
			// Verifica si es que el vertice existe en la matriz
			if ((x >= n) || (y > n))
			{
				Console.WriteLine("El vertice no existe!");
			}

			// Verifica si es que el vertice se conecta a si mismo
			if (x == y)
			{
				Console.WriteLine("Mismo vertice!");
			}
			else
			{
				// Conectar los vertices
				g[y, x] = 1;
				g[x, y] = 1;
			}
		}

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

		public void RemoverVertice(int x)
		{
			// Verificar si es que el vertice esta presente
			if (x > n)
			{
				Console.WriteLine("Vertice no presente!");
				return;
			}
			else
			{
				int i;

				// Remover vertice
				while (x < n)
				{

					// sMover las filas a la izquierda
					for (i = 0; i < n; ++i)
					{
						g[i, x] = g[i, x + 1];
					}

					// Mover las columnas hacia arriba
					for (i = 0; i < n; ++i)
					{
						g[x, i] = g[x + 1, i];
					}
					x++;
				}

				// Disminuir el numero de vertices
				n--;
			}
		}
	}

	public class GFG
	{
		// Programa principal
		public static void Main(String[] args)
		{
			Driver();
		}

		// Imprime las opciones por consola
		private static void ImprmimirMenu()
        {
			Console.WriteLine("\n\n1. Agregar vertice");
			Console.WriteLine("2. Agregar arco");
			Console.WriteLine("3. Eliminar vertice");
			Console.WriteLine("0. Finalizar");
		}

		// Lee la opcion del menu
		private static int LeerOpcion()
        {
			Console.Write("Opcion: ");
			int opc = Convert.ToInt32(Console.ReadLine());
			if (opc < 0 || opc > 3)
				return LeerOpcion();      
			return opc;
        }

		// Driver code
		public static void Driver()
		{
			Console.WriteLine("Ingresa el numero de vertices del grafo");
			int nVertices = Convert.ToInt32(Console.ReadLine());

			//Crear un nuevo objeto tipo grafo
			Grafo obj = new Grafo(nVertices);
			int opc;

			do
			{
				Console.Clear();
				obj.ImprimirMatrizAdyacencia();

				// Impresion del menu y lectura de la opcion
				ImprmimirMenu();
				opc = LeerOpcion();

				// Acciones a segun la opcion
				switch (opc)
				{
					// Agregar vertice
					case (1):
						obj.AgregarVertice();
						break;

				    // Agregar arco
					case (2):
						Console.Write("x: ");
						int x = Convert.ToInt32(Console.ReadLine());
						Console.Write("y: ");
						int y = Convert.ToInt32(Console.ReadLine());
						obj.AgregarArco(x, y);
						break;
					
					// Eliminar vertice
					case (3):
						Console.Write("Vertice a eliminar: ");
						int vEliminar = Convert.ToInt32(Console.ReadLine());
						obj.RemoverVertice(vEliminar);
						break;

					// Ingreso de opcion incorrecta
					default:
						Console.WriteLine("Opcion no encontrada");
						break;
				}
			} while (opc != 0);
		}
	}
}
