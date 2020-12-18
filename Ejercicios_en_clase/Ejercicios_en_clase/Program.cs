using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_en_clase
{
    class Program
    {
        //Cifra una sola letra y devuelve la letra cifrada
        //Mueve n caracteres a la derecha
        static char CifrarLetra(char letra, int n)
        {
            int i;
            int inicial = 0; //Posición inicial de la letra en el alfabeto
            char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (i = 0; i < alfabeto.Length; i++) //Se busca la letra en el alfabeto
            {
                if (letra == alfabeto[i])
                {
                    inicial = i;
                    break;
                }
            }
            i = 0;
            while (i < n)
            {
                inicial++;
                if (inicial == alfabeto.Length)
                    inicial = 0;
                i++;
            }
            return alfabeto[inicial];
        }

        //Cifra cadena moviendo mov caracteres a la derecha
        static string Cifrar(string cadena, int mov)
        {
            int i;
            string cifrada = "";
            cadena = cadena.ToUpper(); //Transforma a mayúsculas
            for (i = 0; i < cadena.Length; i++) //Se busca la letra en el alfabeto
            {
                if (cadena[i] == ' ')
                    cifrada += ' ';
                else
                    cifrada += CifrarLetra(cadena[i], mov);
            }
            return cifrada;
        }
        //Descifra una sola letra y devuelve la letra original
        //Mueve n caracteres a la izquierda
        static char DescifrarLetra(char letra, int n)
        {
            int i;
            int inicial = 0; //Posición inicial de la letra en el alfabeto
            char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (i = 0; i < alfabeto.Length; i++)
            {
                if (letra == alfabeto[i])
                {
                    inicial = i;
                    break;
                }
            }
            i = 0;
            while (i < n)
            {
                inicial--;
                if (inicial < 0)
                    inicial = alfabeto.Length - 1;
                i++;
            }
            return alfabeto[inicial];
        }

        //Descifra cadena moviendo mov caracteres a la derecha
        static string Descifrar(string cadena, int mov)
        {
            int i;
            string descifrada = "";
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
            string cad;
            cad = "Un Texto y algo MAS";
            cad = Cifrar(cad, 3);
            cad = Descifrar(cad, 3);
        }
    }
}
