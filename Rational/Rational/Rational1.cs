using System;
using System.Collections.Generic;
using System.Text;

namespace Rational
{
    class Rational1
    {
        private int numerador;
        private int denominador;
        
        // NOMBRE: Rational1 (Constructor)
        // PROPOSITO: Constructor sobrecargado sin parametros
        public Rational1()
        {
            numerador = 0;
            denominador = 1;
        }

        // NOMBRE: Rational1 (Constructor)
        // PROPOSITO: Constructor sobrecargado con 1 parametro
        public Rational1(int num)
        {
            numerador = num;
            denominador = 1;
        }
        
        // NOMBRE: Rational1 (Constructor)
        // PROPOSITO: Constructor sobrecargado con 2 parametros
        public Rational1(int num, int den)
        {
            numerador = num;
            denominador = den;
        }


        // NOMBRE: Imprimir
        // PROPOSITO: Imprime el objeto Rational1 simulando un numero fraccionario
        public void Imprimir()
        {
            Console.WriteLine("{0}/{1}", numerador, denominador);
        }

        // IMPLEMENTACION DE LA CLASE
        static void Main(string[] args)
        {
            Rational1 x = new Rational1();
            Rational1 y = new Rational1(3);
            Rational1 z = new Rational1(7, 4);

            x.Imprimir();
            y.Imprimir();
            z.Imprimir();

            Console.ReadKey();
        }
    }
}
