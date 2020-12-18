using System;
using System.Collections.Generic;
using System.Text;

namespace Arbol_heterogeneo_recorridos
{
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
}
