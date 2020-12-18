using System;

// NOMBRE DEL PROGRAMA: Implementacion de Colas
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA: 30/sep/2020
// PROPOSITO DE ULTIMA MODIFICACION:  Implementacion de ADT Colas
// FECHA DE ULTIMA MODIFICACION: 30/sep/2020


namespace Cola_test
{
    // DEFINICION DE CLASES

    // DEFINICION CLASE COLA
    class Program
    {
        static void Main(string[] args)
        {
            Cola Cola1 = new Cola();
            Cola1.Ingresa(1);
            Cola1.Ingresa(2);
            Cola1.Ingresa(3);
            Cola1.Ingresa(4);
            Console.WriteLine("Esta es la cola con elementos ingresados");
            Cola1.ImprimeCola();
            Console.WriteLine("Se extrae un elemento de la cola");
            Console.WriteLine("{0}", Cola1.Retira());
            Console.WriteLine("Esta es la cola luego de haber extraido un elemento");
            Cola1.ImprimeCola();
            Console.WriteLine("Se extrae un elemento de la cola");
            Console.WriteLine("{0}", Cola1.Retira());
            Console.WriteLine("Esta es la cola luego de haber extraido un elemento");
            Cola1.ImprimeCola();
            Console.WriteLine("En este punto la cola SI tiene elementos, por lo que la función Vacio retorna {0}", Cola1.Vacio());
            Console.WriteLine("Se extrae un elemento de la cola");
            Cola1.Ingresa(1);
            Console.WriteLine("Esta es la cola luego de haber ingresado un elemento");
            Cola1.ImprimeCola();
            Console.WriteLine("En este punto la cola SI tiene elementos, por lo que la función Vacio retorna {0}", Cola1.Vacio());
        }
    }
}
