// NOMBRE DEL PROGRAMA: Conversion de notacion prefija a postfija mediante recursion
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 09/nov/2020
// PROPOSITO DE ULTIMA MODIFICACION: generacion de la funcion de conversion recursiva y del programa principal
// FECHA DE ULTIMA MODIFICACION: 08/nov/2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefijo_a_sufijo_recursivo
{
    class Program
    {
        // Programa principal
        public static void Main(String[] args)
        {
            Console.Title = "Expresión prefija a postfija mediante recursion";

            Console.WriteLine("\tConversión de expresiones mediante recursión\n1. Prefija a postfija recursivamente\n2. Infija a postfija recursivamente");
            byte opc = Convert.ToByte(Console.ReadLine());
            switch (opc)
            {
                // Prefija a postfija
                case 1:
                    string prefija;

                    // Lectura de la cadena prefija
                    Console.Write("Ingresa la expresión prefija\nPREFIJA  = ");
                    prefija = Console.ReadLine();

                    // Llamada a la funcion de conversion e impresion del resultado
                    Console.WriteLine("POSTFIJA = {0}", PreAPost(prefija));
                    break;
                // Infija a postfija
                case 2:
                    int i = 0;
                    string Infijo;
                    string prueba = "";
                    int aux = 0;

                    // Lectura de la expresion
                    Console.WriteLine("Ingrese su cadena infija");
                    Infijo = Console.ReadLine().ToUpper();

                    Stack<string> Posfijo = new Stack<string>();
                    Stack<string> opstk = new Stack<string>();

                    // Llamada a la funcion y conversion de la expresion
                    Console.WriteLine("\nConversión de infijo a posfijo: ");
                    Conversion(Infijo, Posfijo, opstk, i, aux);
                    break;
                // Si la opcion ingresada no es valida
                default:
                    Console.WriteLine("Opcion inválida. Fin del programa");
                    break;
            }
            Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
            Console.ReadKey();
        }

        // Funcion PreAPost. Convierte una expresion en notacion PREFIJA A POSTFIJA RECURSIVAMENTE
        public static String PreAPost(String prefijo)
        {
            // Si es que prefijo es el ultimo caracter de la cadena
            if (prefijo.Length <= 1)
                return prefijo;
            
            // Si es que el primer caracter es un operador, se lo mueve a la derecha recursivamente y se convierte el resto de la 
            // cadena mediante recursion.
            if (char.IsLetter(prefijo[0]) == false)
            {
                String a = PreAPost(prefijo.Substring(1)) + prefijo[0];
                String b = PreAPost(prefijo.Substring(a.Length));
                return a + b;
            }

            // Si los primeros dos caracteres son un operador y una letra solo se retorna la letra
            else if (char.IsLetter(prefijo[1]) == false)
                return prefijo.Substring(0, 1);
            
            // Si se encuentran dos letras se retornan las dos letras
            else
                return prefijo.Substring(0, 2);
        }


        // XXXXXXXXXXXXXXXXX    FUNCIONES PARA CONVERTIR DE INFIJO A POSTFIJO RECURSIVAMENTE   XXXXXXXXXXXXXXXXXXXXXX


        // Funcion que imprime la expresion postfija
        static void Imprimir(Stack<string> Posfijo, int aux)
        {
            string prueba = "";

            for (int j = 0; j < aux; j++)
                prueba += Posfijo.Pop();

            for (int j = prueba.Length; j != 0; j--)
                Console.Write(prueba.Substring(j - 1, 1));
        }
        // Funcion que lleva el contador de la cadena infija
        static int Contador(string Infijo)
        {
            int cont = 0;

            for (int j = 0; j < Infijo.Length; j++)
            {
                if (Infijo.Substring(j, 1) == "(" || Infijo.Substring(j, 1) == ")")
                    cont++;
            }
            return cont;
        }
        // Funcion que convierte una expresion infija en una postfija mediante recursion
        static void Conversion(string Infijo, Stack<string> Posfijo, Stack<string> opstk, int i, int aux)
        {
            if (i < Infijo.Length)
            {
                if (Infijo.Substring(i, 1) == ")")
                {
                    Posfijo.Push(opstk.Pop());
                    i = i + 1;
                    Conversion(Infijo, Posfijo, opstk, i, aux);
                }
                else if ((Encoding.ASCII.GetBytes(Infijo.Substring(i, 1).ToString())[0] < 64 || Encoding.ASCII.GetBytes(Infijo.Substring(i, 1).ToString())[0] > 91) && Infijo.Substring(i, 1) != "(" && Infijo.Substring(i, 1) != ")")
                {
                    opstk.Push(Infijo.Substring(i, 1));
                    i = i + 1;
                    Conversion(Infijo, Posfijo, opstk, i, aux);
                }
                else if (Encoding.ASCII.GetBytes(Infijo.Substring(i, 1).ToString())[0] > 64 && Encoding.ASCII.GetBytes(Infijo.Substring(i, 1).ToString())[0] < 91)
                {
                    Posfijo.Push(Infijo.Substring(i, 1));
                    i = i + 1;
                    Conversion(Infijo, Posfijo, opstk, i, aux);
                }
                else if (Infijo.Substring(i, 1) == "(")
                {
                    i = i + 1;
                    Conversion(Infijo, Posfijo, opstk, i, aux);
                }
            }
            else
            {
                if (Posfijo.Count != 0 && opstk.Count != 0)
                {
                    Posfijo.Push(opstk.Peek());
                    opstk.Pop();
                    i = i + 1;
                    Conversion(Infijo, Posfijo, opstk, i, Posfijo.Count);
                }
                else if (opstk.Count == 0 && aux != Infijo.Length - Contador(Infijo))
                {
                    i = i + 1;
                    Conversion(Infijo, Posfijo, opstk, i, Posfijo.Count);
                }
                if (aux == Infijo.Length - Contador(Infijo))
                {
                    Imprimir(Posfijo, aux);
                }
            }
        }
    }
}
