// NOMBRE DEL PROGRAMA: Implementacion de recorridos en arboles heterogeneos
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 23/nov/2020
// PROPOSITO DE ULTIMA MODIFICACION: Codificacion de la clase Program, Nodo, Arbol y Conversiones 
// FECHA DE ULTIMA MODIFICACION: 22/nov/2020

/*
using System;
using System.Collections.Generic;
using System.Text;

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

    // Definicion de la clse Nodo
    class Nodo
    {
        // Atributos
        public double Numero;   // operando
        public char Signo;      // operador
        public Nodo Izquierdo;
        public Nodo Derecho;

        // Constructores sobrecargados
        public Nodo(double valor)
        {
            Numero = valor;
            Izquierdo = null;
            Derecho = null;
        }
        public Nodo(char valor)
        {
            Signo = valor;
            Izquierdo = null;
            Derecho = null;
        }
    }
    // Definicion de la clase Arbol
    class Arbol
    {
        // Atributos
        public Nodo Raiz;

        // Constructor
        public Arbol()
        {
            Raiz = null;
        }

        // Nombre SetNode (sobrecargado)
        // Proposito: ingresar la expresion al arbol de forma recursiva
        public void SetNode(string expresion)
        {
            Stack pilaNumeros = new Stack();
            Stack<Nodo> pilaNodos = new Stack<Nodo>();
            Raiz = SetNode(expresion, Raiz, pilaNumeros, pilaNodos);
        }
        private Nodo SetNode(string expresion, Nodo temp, Stack pilaNumeros, Stack<Nodo> pilaNodos)
        {
            // Si la expresion esta vacia
            if (expresion == string.Empty)
            {
                return pilaNodos.Pop();
            }

            // Si el primer caracter es un numero
            if (char.IsDigit(expresion[0]))
            {
                pilaNumeros.Push(Convert.ToString(expresion[0]));
                return SetNode(expresion.Substring(1, expresion.Length - 1), temp, pilaNumeros, pilaNodos);
            }

            // Si el primer caracter es un operador aritmetico
            if (EsOperador(expresion[0]))
            {
                // Crear un nuevo nodo. Su dato almacenado es el signo
                temp = new Nodo(Convert.ToChar(expresion[0]));
                Nodo right = null;
                Nodo left = null;

                // Obtener los datos almacenados en las pilas
                if (pilaNumeros.Count > 0)
                    right = new Nodo(Convert.ToDouble(pilaNumeros.Pop()));
                else
                    right = pilaNodos.Pop();

                if
                (pilaNumeros.Count > 0)
                    left = new Nodo(Convert.ToDouble(pilaNumeros.Pop()));
                else
                    left = pilaNodos.Pop();

                // Asignar al nodo temp los nodos creados a partir de la obtencion de los datos de las pilas
                temp.Izquierdo = left;
                temp.Derecho = right;
            }
            // Ingresar el nodo creado en la pila de nodos
            pilaNodos.Push(temp);
            // Retornar el nodo que la pila almacena. Este nodo es la nueva raiz del arbol
            return SetNode(expresion[1..], temp, pilaNumeros, pilaNodos);
        }

        // Nombre: EsOperador
        // Proposito: determinar si un caracter es un operador aritmetico elemental
        public bool EsOperador(char op)
        {
            if (op == '+' || op == '-' || op == '*' || op == '/')
                return true;
            return false;
        }

        // Nombre: Imprimir (sobrecargado)
        // Proposito: imprime el arbol por consola de forma grafica
        public void Imprimir()
        {
            Imprimir(Raiz, 4);
        }
        private void Imprimir(Nodo p, int padding)
        {
            if (p != null)
            {
                if (p.Derecho != null)
                    Imprimir(p.Derecho, padding + 4);
                if (padding > 0)
                    Console.Write(" ".PadLeft(padding));
                if (p.Derecho != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                if (p.Numero != 0)
                    Console.Write(p.Numero.ToString() + "\n ");
                else
                    Console.Write(p.Signo.ToString() + "\n ");
                if (p.Derecho != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Imprimir(p.Izquierdo, padding + 4);
                }
            }
        }

        // Nombre: ImprimirPostfijo (sobrecargado)
        // Proposito: imprimir la expresion ingresada en notacion postfija mediante un recorrido postorden del arbol
        public void ImprimirPostfija()
        {
            Console.WriteLine("Postfija: {0}", ImprimirPostfija("", Raiz));
        }
        private string ImprimirPostfija(string expression, Nodo temp)
        {
            if (temp.Izquierdo != null)
                expression = ImprimirPostfija(expression, temp.Izquierdo);
            if (temp.Derecho != null)
                expression = ImprimirPostfija(expression, temp.Derecho);

            if (temp.Numero != 0)
                return expression + temp.Numero;
            else
                return expression + temp.Signo;
        }

        // Nombre: ImprimirPrefijo (sobrecargado)
        // Proposito: imprimir la expresion ingresada en notacion prefija mediante un recorrido preorden del arbol
        public void ImprimirPrefija()
        {
            Console.WriteLine("Prefija: {0}", ImprimirPrefija("", Raiz));
        }
        private string ImprimirPrefija(string expression, Nodo temp)
        {
            if (temp.Numero != 0)
                expression += temp.Numero;
            else
                expression += temp.Signo;

            if (temp.Izquierdo != null)
                expression = ImprimirPrefija(expression, temp.Izquierdo);
            if (temp.Derecho != null)
                expression = ImprimirPrefija(expression, temp.Derecho);

            return expression;
        }

        // Nombre: ImprimirInfijo (sobrecargado)
        // Proposito: imprimir la expresion ingresada en notacion infija mediante un recorrido inorden del arbol
        public void ImprimirInfija()
        {
            Console.WriteLine("Infija: {0}", ImprimirInfija("", Raiz));
        }
        private string ImprimirInfija(string expression, Nodo temp)
        {
            if (temp.Izquierdo != null)
                expression = ImprimirInfija(expression, temp.Izquierdo);

            if (temp.Numero != 0)
                expression += temp.Numero;
            else
                expression += temp.Signo;
            if (temp.Derecho != null)

                expression = ImprimirInfija(expression, temp.Derecho);

            return expression;
        }
    }

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
*/