/*
 * Autor:                   JARED AMPUDIA
 * Materia:                 Estructura de Datos
 * Ultima modificacion:     26/sep/2020  20h46
 * Correo electronico:      jampudia@puce.edu.ec
 * Proposito del programa:  Verificar el balance de los signos de agrupacion de una expresion ingresada por consola.

Dado que la clase Pila almacena unicamente valores enteros, cada signo de agrupacion es manejado en su equivalente
valor ASCII. Para una mejor comprension del codigo, se incluye los valores con su respectiva representacion usada.

Valor ASCII   Representacion (caracter)
        40              (
        41              )
        91              [
        93              ]
       123              {
       125              }
 * */


using System;   

namespace Verificacion_Signos_de_Agrupacion
{
    // PROGRAMA PRINCIPAL
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            string expresion;
            bool valid = true;

            Console.Title = "Comparacion Agrupadores - Estructura de Datos";

            // Instrucciones y lectura de la expresion
            Console.WriteLine("\tVERIFICACIÓN DE SIGNOS DE AGRUPACIÓN EN EXPRESIONES ALGEBRAICAS");
            Console.WriteLine("Ingresa la expresión a evaluar:");
            expresion = Console.ReadLine().Trim();

            // Verificacion si es que cada signo de apertura se corresponde con uno de cerrada
            int i = 0;
            while(i < expresion.Length)
            {
                // Si el caracter es '(' '[' o '{'
                if ((int)expresion[i] == 40 || (int)expresion[i] == 91 || (int)expresion[i] == 123)
                    pila.Push((int)expresion[i]);

                // Si el caracter es ')' ']' o '}'
                if ((int)expresion[i] == 41 || (int)expresion[i] == 93 || (int)expresion[i] == 125)
                {
                    switch ((int)expresion[i])
                    {
                        // Caracter ')'
                        case 41:
                            if (pila.LeeTope() != 40)
                                valid = false;
                            pila.Pop();
                            break;
                        // Caracter ']'
                        case 93:
                            if (pila.LeeTope() != 91)
                                valid = false;
                            pila.Pop();
                            break;
                        // Caracter '}'
                        case 125:
                            if (pila.LeeTope() != 123)
                                valid = false;
                            pila.Pop();
                            break;
                    }
                }
                i++;
            }

            // Impresion por consola de la correspondencia de los signos de agrupacion. Si los signos no se corresponden, la pila aun
            // tiene elementos o si no se ingreso ninguna expresion, imprime un mensaje indicando que la expresion es incorrecta.
            if (expresion == string.Empty)
                Console.WriteLine("No se ingresó ninguna expresión para analizar");
            else if (valid && pila.Vacia())
                Console.WriteLine("\nLa expresión es correcta, existe un balance entre los signos de agrupación.");
            else
                Console.WriteLine("\nLa expresión es incorrecta, no existe un balance entre los signos de agrupación.");

        }
    }

    // CLASE PILA
    class Pila
    {
        // Atributos de la clase
        private int[] elemento = new int[20];
        private int tope;

        // CONSTRUCTOR de la clase
        // Inicializa los atributos, a todos los elementos del arreglo le son asignados el valor de 0
        public Pila()
        {
            for (int contador = 0; contador < 20; contador++)
                elemento[contador] = 0;
            tope = -1;
        }

        // ENTREGA TOPE
        // Devuelve el indice en el que se encuentra el ultimo elemento del objeto Pila
        public int EntregaTope()
        {
            return tope;
        }

        // VACIA
        // Segun el valor del tope del objeto Pila, indica si es que el objeto Pila contiene elementos
        public bool Vacia()
        {
            if (tope == -1)
                return true;
            else
                return false;
        }

        // IMPRIME PILA
        // Imprime por consola los elementos del objeto Pila
        public void ImprimePila()
        {
            if (Vacia() == false)
                for (int contador = 0; contador <= tope; contador++)
                    Console.WriteLine(elemento[contador]);
        }

        // LEE TOPE
        // Retorna el ultimo elemento ingresado del objeto Pila
        public int LeeTope()
        {
            if (Vacia())
            {
                Console.WriteLine("Pila vacia");
                return -1;
            }
            else
                return elemento[EntregaTope()];
        }

        // PUSH
        // El argumento de la llamada de la funcion es añadido al tope del objeto Pila
        public void Push(int a)
        {
            elemento[tope + 1] = a;
            tope = tope + 1;
        }

        // POP
        // Retorna el elemento situado en el tope del objeto Pila, el elemento retornado es eliminado de la estructura
        public int Pop()
        {
            int auxiliar;
            auxiliar = elemento[tope];
            elemento[tope] = 0;
            tope = tope - 1;
            return auxiliar;
        }

    }
}
