using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Arbol_heterogeneo_recorridos
{
    // Definicion de la case Conversion
    class Conversion
    {
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
                if (char.IsDigit(symb))
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
            while (opstk.Count > 0)
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
            switch (a)
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
