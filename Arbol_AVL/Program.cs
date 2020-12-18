using System;

namespace Arbol_AVL
{
    // Definicion de la clase Program
    class Program
    {
        // Programa principal
        static void Main(string[] args)
        {
            (new Program()).Prueba();
        }

        // Metodo que ingresa valores al arbol AVL
        private void Prueba()
        {
            AVLArbol<int> tree = new AVLArbol<int>();
            // Cambiar el arreglo para verificar la insersión en un árbol AVL
            int[] numeros = { 55, 30, 75, 4, 41, 85, 54, 25, 44, 28, 35, 31 };

            foreach (int n in numeros)
            {
                ImprimirProcedimiento(tree, n);
            }
        }

        // Metodo que demuestra la funcionalidad del arbol AVL
        void ImprimirProcedimiento(AVLArbol<int> tree, int item)
        {
            Console.Write("Agrega : {0}\n", item.ToString());
            tree.Agregar(item);
            Console.WriteLine("---------------------------------------------------------------------------------------------\n");
            tree.Imprimir();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }

    }
}
