using System;

namespace Arbol_heterogeneo_recorridos
{
    // Definicion de la clase Program
    class Program
    {
        // Programa principal
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();
            // Instrucciones y lectura de la expresion
            Console.WriteLine("Ingresa la expresion INFIJA: ");
            string expresion = Console.ReadLine();

            // Ingresar la expresion en el arbol
            arbol.SetNode(Conversion.APostfija(expresion));
            Console.Clear();

            // Impresion del arbol y diferentes notaciones.
            Console.WriteLine("Expresion ingresada:\n\n");
            arbol.Imprimir();
            Console.WriteLine("\n\nRocorridos/notaciones:\n");
            arbol.ImprimirInfija();
            arbol.ImprimirPrefija();
            arbol.ImprimirPostfija();
        }

    }
}
