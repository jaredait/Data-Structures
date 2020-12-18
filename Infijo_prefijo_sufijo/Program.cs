// NOMBRE DEL PROGRAMA: Conversion de notacion infija a postfija
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 09/nov/2020
// PROPOSITO DE ULTIMA MODIFICACION: La cadena infija ingresada por el usuario puede contener parentesis. La funcion APostfija convierte
//                                   e imprime por consola la cadena postfija correctamente
// FECHA DE ULTIMA MODIFICACION: 16/oct/2020

// Observacion: el programa utiliza la libreria System.Collections para hacer uso de la clase Stack.

using System;
using System.Collections;

namespace Infijo_prefijo_sufijo
{
    class Program
    {
        static void Main(string[] args)
        {
            string infija;

            Console.Title = "Expresión infija a postfija";

            // Lectura de la cadena infija
            Console.Write("Ingresa la expresión infija\nINFIJA =   ");
            infija = Console.ReadLine();

            // Llamada a la funcion de conversion e impresion del resultado
            Console.WriteLine("POSTFIJA = {0}", APostfija(infija));

            Console.ReadKey();
        }

        // Funcion que convierte una expresion infija a postfija
        public static string APostfija(string infija)
        {
            string postfija = string.Empty;
            Stack opstk = new Stack();
            char symb;
            char topSymb;

            // Recorre todos los caracteres de la cadena infija pasada como argumento a la funcion
            for (int i = 0; i < infija.Length; i++)
            {
                symb = infija[i];
                // Si symb almacena un operando (variable) es concatenado a la cadena postfija
                if (char.IsLetter(symb))
                    postfija += symb;
                // Si es que symb almacena un operador
                else
                {
                    // Si la pila no esta vacia y el operador en el tope de la pila tiene mayor precedencia que el que symb almacena, 
                    // se lo concatena a la cadena postfija
                    while (opstk.Count > 0 && Precedencia((char)opstk.Peek(), symb))
                    {
                        topSymb = (char)opstk.Pop();
                        postfija += topSymb;
                    }
                    // Si la pila esta vacia o symb almancena un caracter diferente que ')', se lo inserta en la pila. 
                    // Si no, topSymb adquiere el operador de mayor precedencia de la pila mediante un Pop
                    if (opstk.Count == 0 || symb != ')')
                        opstk.Push(symb);
                    else
                        topSymb = (char)opstk.Pop();
                }
            }
            // Concatena los operadores que quedaron en la pila a la cadena postfija
            while(opstk.Count > 0)
            {
                topSymb = (char)opstk.Pop();
                postfija += topSymb;
            }

            return postfija;
        }

        // Funcion que verifica la precedencia de dos operadores recibidos como parametros
        public static bool Precedencia(char a, char b)
        {
            bool prec = false;
            switch(a)
            {
                // Precedencia de operadores algebraicos
                case '+':
                    if (b == '+' || b == '-' || b == ')')
                        prec = true;
                    else
                        prec = false;
                    break;
                case '-':
                    if (b == '+' || b == '-' || b == ')')
                        prec = true;
                    else
                        prec = false;
                    break;
                case '*':
                    if (b == '+' || b == '-' || b == '*' || b == '/' || b == ')')
                        prec = true;
                    else
                        prec = false;
                    break;
                case '/':
                    if (b == '+' || b == '-' || b == '*' || b == '/' || b == ')')
                        prec = true;
                    else
                        prec = false;
                    break;
                case '$':
                    if (b == ')')
                        prec = true;
                    else
                        prec = false;
                    break;
                // Precedencia de parentesis
                case '(':
                    prec = false;
                    break;
                case ')':
                    if (b == '(')
                        prec = true;
                    else
                        prec = false;
                    break;
            }
            return prec;
        }
    }
}
