using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_en_clase
{
    class Cadena
    {
        const int MAXLONG = 20;

        private char[] cadena;
        
        // Constructor
        public Cadena()
        {
            cadena = new char[MAXLONG];
        }

        // Leer el contenido de la cadena
        public void Leer()
        {
            int i = 0;
            do
            {
                cadena[i] = Console.ReadKey().KeyChar;
                if (cadena[i] == '\0')
                    break;
                i++;

            } while (i < MAXLONG);
        }

        // Imprimir cadena
        public void Imprimir()
        {
            for (int i = 0; i < cadena.Length; i++)
                Console.Write(cadena[i]);
        }








        /*
        // Ordenar cadena
        static public void Ordenar(Cadena array)
        {
            char aux;
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        aux = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = aux;
                    }
                }
            }
        }
        */
    }
}
