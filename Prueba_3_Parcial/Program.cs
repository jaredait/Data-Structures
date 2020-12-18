// NOMBRE DEL PROGRAMA: Implementacion de metodos recursivos (examen 3er parcial)
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 16/nov/2020
// PROPOSITO DE ULTIMA MODIFICACION: codificacion del programa completo
// FECHA DE ULTIMA MODIFICACION: 16/nov/2020

using System;

namespace Prueba_3_Parcial
{
    // Definicion de la clase Program
    class Program
    {
        // PROGRAMA PRINCIPAL
        static void Main(string[] args)
        {
            byte opc;
            string menu = "\tOPCIONES\n1. Cálculo de número de dígitos de un número entero\n2. Cálculo de la función potencia para " +
                "un exponente entero mayor o igual a cero\n3. Salir";

            // Despliegue del menu y opciones segun corresponde
            do
            {
                Console.Clear();
                Console.WriteLine(menu);
                Console.Write("\nOpcion: ");
                opc = Convert.ToByte(Console.ReadLine());

                switch (opc)
                {
                    // Calculo del numero de digitos de un entero
                    case 1:
                        Digito.Op1_Digitos();
                        break;
                     // Calculo de un entero elevado a un exponente entero mayor igual a 0
                    case 2:
                        Potencias.Op2_Potencia();
                        break;
                    // Finalizar
                    case 3:
                        break;
                    // Si la opcion ingresada no es correcta
                    default:
                        Console.WriteLine("Error, ingresa una opcion correcta.");
                        break;
                }
                if(opc != 3)
                {
                    Console.Write("Presiona cualquier tecla para volver al menu...");
                    Console.ReadKey();
                }    
            } while (opc != 3);
            Console.WriteLine("Programa finalizado con exito!");
            Console.ReadKey();
        }

        // Definicion de la clase Digito
        class Digito
        {
            // Nombre: CalcularDigitos
            // Proposito: devuelve un entero indicando cuantas cifras contiene un numero de forma recursiva
            public static int CalcularDigitos(int n, int digitos = 0)
            {
                // Paso base
                if (n % 10 <= 0)
                    return digitos;

                // Paso recursivo
                return CalcularDigitos(n / 10, digitos + 1);
            }

            // Nombre: Op1_Digitos
            // Proposito: demostrar la funcionalidad del metodo CalcularDigitos en el metodo main
            public static void Op1_Digitos()
            {
                int n;
                // Instrucciones al usuario y lectura del numero
                Console.Write("Ingresa el numero \"n\" calcular su numero de digitos.\nn = ");
                n = Convert.ToInt32(Console.ReadLine());
                // Llamada al metodo CalcularDigitos e impresion de resultados
                Console.WriteLine("\nEl numero {0} tiene {1} digitos\n", n, CalcularDigitos(n));
            }
        }

        // Definicion de la clase Potencias
        class Potencias
        {
            // Nombre: Potencia
            // Proposito: calcular el entero 'b' elevado al exponente 'n' de forma recursiva
            public static int Potencia(int b, int n)
            {
                // Paso base
                if (n == 0)
                    return 1;

                // Paso recursivo
                // Si el exponente es par
                if (n % 2 == 0)
                    return Potencia(b, n / 2) * Potencia(b, n / 2);
                // Si el exponente es impar
                else
                    return Potencia(b, (n - 1) / 2) * Potencia(b, (n - 1) / 2) * b;
            }

            // Nombre: Op2_Potencia
            // Proposito: demostrar la funcionalidad del metodo Potencia en el metodo main
            public static void Op2_Potencia()
            {
                int b;
                int exp;
                // Instrucciones al usuario y lectura de la base y el exponente
                Console.Write("Ingresa la base y el exponente\nbase = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("exponenete = ");
                exp = LeerExponente();
                //exp = Convert.ToInt32(Console.ReadLine());
                // Llamada al metodo Potencia e impresion de resultados
                Console.WriteLine("\n{0}^{1} = {2}\n", b, exp, Potencia(b, exp));
            }

            // Nombre: LeerExponente
            // Proposito: leer un entero hasta que este sea mayor o igual que cero de forma recursiva
            public static int LeerExponente()
            {
                int exp = Convert.ToInt32(Console.ReadLine());
                if (exp < 0)
                {
                    Console.Write("\n'exponente' debe ser un entero mayor o igual que 0\nexponente = ");
                    return LeerExponente();
                }
                return exp;
            }
        }
    }
}
