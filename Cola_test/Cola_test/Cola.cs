using System;
using System.Collections.Generic;
using System.Text;

namespace Cola_test
{
    // DEFINICION CLASE COLA
    class Cola
    {
        // Definicion de Propiedades del ADT en implementacion de clase
        private const int NumElementos = 20;
        private int[] elemento = new int[NumElementos];
        private int inicio, final;

        //DEFINICION DE METODOS DEL ADT IMPREMENTACION DE CLASE Cola
        //Definicion de constructor de clase cola
        public Cola()
        {
            inicio = -1;
            final = -1;
        }

        public bool Vacio()
        {
            return inicio == final ? true : false;
        }
        public void ImprimeCola()
        {

            for (int contador = inicio + 1; contador <= final; contador++)
                Console.WriteLine("{0}", elemento[contador]);

            Console.WriteLine("Esto es todo!");
        }

        public void Ingresa(int a)
        {

            if (final == NumElementos - 1)
                final = 0;
            else
                final++;
            //elemento[final + 1] = a;
            //final++;
            elemento[final] = a;
            if (inicio == final)
            {
                Console.WriteLine("Cola Llena, no admite adicionar elementos.");
                return;
            }
        }


        public int Retira()
        {

            if (Vacio())
            {
                Console.WriteLine("Cola Vacia, no es posible extraer un elemento");
                return 0;
            }

            int auxiliar = elemento[inicio + 1];
            elemento[inicio + 1] = 0;
            if (inicio == NumElementos - 1)
                inicio = 0;
            else
                inicio++;
            return auxiliar;
        }


    }
}
