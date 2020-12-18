using System;

namespace Cifrado
{
    class Program
    {
        //Cifra una sola letra y devuelve la letra cifrada
        //Mueve n caracteres a la derecha
        static char CifrarLetra(char letra, int n)
        {
            int i;
            int inicial = 0; 
            char[] ALFABETO = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            // Buscar la letra en el alfabeto
            for (i = 0; i < ALFABETO.Length; i++)
            {
                if (letra == ALFABETO[i])
                {
                    inicial = i;
                    break;
                }
            }
            i = 0;
            while (i < n)
            {
                inicial++;
                if (inicial == ALFABETO.Length)
                    inicial = 0;
                i++;
            }
            return ALFABETO[inicial];
        }

        //Cifrar desplazando secuencialmente
        static string Cifrar(string cadena, int mov)
        {
            int i;
            string cifrada = string.Empty;
            // Convertir a mayusculas toda la frase
            cadena = cadena.ToUpper();
            // Busqueda en el arreglo alfabeto
            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')
                    cifrada += ' ';
                else
                    cifrada += CifrarLetra(cadena[i], mov);
            }
            return cifrada;
        }
        //DESCIFRA LETRA POR LETRA SECUENCIALMENTE HACIA LA IZQUIERDA
        static char DescifrarLetra(char letra, int mov)
        {
            int i;
            int inicial = 0;
            char[] ALFABETO = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (i = 0; i < ALFABETO.Length; i++)
            {
                if (letra == ALFABETO[i])
                {
                    inicial = i;
                    break;
                }
            }
            i = 0;
            while (i < mov)
            {
                inicial--;
                if (inicial < 0)
                    inicial = ALFABETO.Length - 1;
                i++;
            }
            return ALFABETO[inicial];
        }

        //dESCIFRAR CADENA CON MOVIMIENTO SECUENCIAL
        static string Descifrar(string cadena, int mov)
        {
            int i;
            string descifrada = string.Empty;
            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')
                    descifrada += ' ';
                else
                    descifrada += DescifrarLetra(cadena[i], mov);
            }
            return descifrada;
        }
        static void Main(string[] args)
        {
            string cadena;
            Console.WriteLine("Ingresa la frase:");
            cadena = Console.ReadLine();
            Console.WriteLine("Ingresa el numero de moviminetos:");
            int mov = Convert.ToInt32(Console.ReadLine());

            //Enviar cadena a los metodos e imprimirla
            Console.WriteLine("Cadena ingresada:");
            Console.WriteLine(cadena);
            cadena = Cifrar(cadena, mov);
            Console.WriteLine("Cadena cifrada:");
            Console.WriteLine(cadena);
            cadena = Descifrar(cadena, mov);
            Console.WriteLine("Cadena descifrada:");
            Console.WriteLine(cadena);

        }
    }
}
