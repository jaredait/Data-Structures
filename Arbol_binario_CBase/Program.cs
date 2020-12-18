// NOMBRE DEL PROGRAMA: Implementacion de arboles mediante nodos
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 16/nov/2020
// PROPOSITO DE ULTIMA MODIFICACION: codificacion del programa principal y metodos descritos en las instrucciones del trabajo 
// FECHA DE ULTIMA MODIFICACION: 15/nov/2020

using System;

namespace Arbol_binario_CBase
{
    // Definicion de la clse Nodo
    class Nodo
    {
        // Atributos
        public int data;
        public Nodo izquierdo;
        public Nodo derecho;
        public Nodo padre;

        // Constructor
        public Nodo()
        {
            data = 0;
            izquierdo = null;
            derecho = null;
        }
    }

    // Definicion de la clse Arbol
    class Arbol
    {
        // Atributo
        public Nodo raiz;

        // Constructor
        public Arbol()
        {
            raiz = null;
        }

        // Nombre: SetNode (metodos sobrecargados)
        // Proposito: agregar un nuevo nodo al arbol de forma binaria
        public void SetNode(int data)
        {
            raiz = SetNode(raiz, data, raiz);
        }
        private Nodo SetNode(Nodo temp, int x, Nodo papi)
        {
            if (temp == null)
            {
                temp = new Nodo();
                temp.data = x;
                temp.padre = papi;
            }
            else
            {
                if (x < temp.data)
                {
                    temp.izquierdo = SetNode(temp.izquierdo, x, temp);
                }
                else
                {
                    temp.derecho = SetNode(temp.derecho, x, temp);
                }
            }
            return temp;
        }

        // Nombre: Contiene (metodos sobrecargados)
        // Proposito: retorna true si es que el argumento se encuentra en el arbol (primera ocurrencia). False en caso contrario
        public Boolean Contiene(int num)
        {
            return Contiene(raiz, num);
        }
        private Boolean Contiene(Nodo temp, int num)
        {
            // Si no lo encuentra
            if (temp == null)
                return false;
            // Si encuentra la primera ocurrencia
            if (temp.data == num)
                return true;

            if (num < temp.data)
                return Contiene(temp.izquierdo, num);
            else
                return Contiene(temp.derecho, num);
        }

        // Nombre: ContieneNVeces (metodos sobrecargados)
        // Proposito: retorna el numero de ocurrencias que el argumento tiene en el arbol
        public int ContieneNVeces(int num)
        {
            return ContieneNVeces(raiz, num, 0);
        }
        private int ContieneNVeces(Nodo temp, int num, int contador)
        {
            // Si llega a la ultima hoja
            if (temp == null)
                return contador;
            // Si encuentra una ocurrencia
            if (temp.data == num)
                contador++;

            if (num < temp.data)
                return ContieneNVeces(temp.izquierdo, num, contador);
            else
                return ContieneNVeces(temp.derecho, num, contador);
        }

        // Nombre: EsHermano
        // Proposito: retorna true si es que los nodos enviados como argumentos tienen el mismo atributo padre. False en caso contrario
        public bool EsHermano (Nodo hermano1, Nodo hermano2)
        {
            if (hermano1.padre == hermano2.padre)
                return true;
            return false;
        }

        // Nombre: Padre
        // Proposito: retorna el atributo padre del nodo que es enviado como argumento
        public Nodo Padre (Nodo p)
        {
            return p.padre;
        }

        // Nombre: EsIzquierdo
        // Proposito: retorna true si es que el nodo enviado como argumento es el hijo izquierdo de su padre. False en caso contrario
        public bool EsIzquierdo (Nodo actual)
        {
            Nodo papi = Padre(actual);
            if (papi == null)
                return false; // apunta a la raiz 
            else
                if (Izquierdo(papi) == actual)
                return true;
            return false;
        }

        // Nombre: EsDerecho
        // Proposito: retorna true si es que el nodo enviado como argumento es el hijo derecho de su padre. False en caso contrario
        public bool EsDerecho (Nodo actual)
        {
            Nodo papi = Padre(actual);
            if (papi == null)
                return false; // apunta a la raiz
            if (papi.derecho == actual)
                return true;
            return false;
        }

        // Nombre: Izquierdo
        // Proposito: retorna el hijo izquierdo del nodo enviado como argumento
        public Nodo Izquierdo(Nodo p)
        {
            return p.izquierdo;
        }

        // Nombre: Derecho
        // Proposito: retorna el hijo derecho del nodo enviado como argumento
        public Nodo Derecho(Nodo p)
        {
            return p.derecho;
        }

        // Nombre: SetIzquierdo
        // Proposito: crea un nuevo nodo que almacena el dato x y lo asigna como hijo izquierdo del nodo p enviado como argumento
        public Nodo SetIzquierdo(Nodo p, int x)
        {
            if (p.izquierdo == null)
            {
                p.izquierdo = new Nodo();
                p.izquierdo.data = x;
            }

            return p.izquierdo;
        }

        // Nombre: SetDerecho
        // Proposito: crea un nuevo nodo que almacena el dato x y lo asigna como hijo derecho del nodo p enviado como argumento
        public Nodo SetDerecho(Nodo p, int x)
        {
            if (p.derecho == null)
            {
                p.derecho = new Nodo();
                p.derecho.data = x;
            }

            return p.derecho;
        }

        // Nombre: Imprimir (metodos sobrecargados)
        // Proposito: imprime por consola una representacion del arbol que llama al metodo.
        public void Imprimir()
        {
            Imprimir(raiz, 4);
        }
        public void Imprimir(Nodo p, int padding)
        {
            if (p != null)
            {
                if (p.derecho != null)
                {
                    Imprimir(p.derecho, padding + 4);
                }
                if (padding > 0)
                {
                    Console.Write(" ".PadLeft(padding));
                }
                if (p.derecho != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.data.ToString() + "\n ");
                if (p.izquierdo != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Imprimir(p.izquierdo, padding + 4);
                }
            }
        }
    }

    // Definicion de la clase Program
    class Program
    {
        // Programa principal
        static void Main(string[] args)
        {
            int aux;
            Arbol arbol = new Arbol();

            // Instrucciones al usuario y lectura inicial de los elementos del arbol
            Console.Title = "Arbol binario - Jared Ampudia";
            Console.WriteLine("Ingresa los elementos del arbol para continuar con las operaciones.");
            Op1_LecturaElementos(arbol);

            do
            {
                // Impresion del arbol y menu de opciones
                Console.Clear();
                Console.WriteLine("Arbol ingresado:");
                arbol.Imprimir();
                ImprimirMenu();
                aux = Convert.ToInt32(Console.ReadLine());

                switch (aux)
                {
                    // Finalizar programa
                    case 0:
                        Console.WriteLine("Programa terminado con exito!");
                        break;
                    // Agregar elementos al arbol
                    case 1:
                        Op1_LecturaElementos(arbol);
                        break;
                    // Verificar si existe
                    case 2:
                        Op2_ExisteElemento(arbol);
                        break;
                    // Consultar numero de ocurrencias
                    case 3:
                        Op3_ExisteNVeces(arbol);
                        break;
                    // Si la opcion no es correcta
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                if (aux != 0)
                {
                    Console.Write("Presiona cualquier tecla para volver al menu...");
                    Console.ReadKey();
                }
            } while (aux != 0);
        }
        
        // Nombre: ImprimirMenu
        // Proposito: Imprimir por consola las opciones del programa disponibles
        static void ImprimirMenu()
        {
            Console.WriteLine("\tOPCIONES");
            Console.WriteLine("1. Ingresar valores adicionales en el arbol");
            Console.WriteLine("2. Verificar si es que el valor \"n\" existe");
            Console.WriteLine("3. Verificar cuantas veces el valor \"n\" aparece");
            Console.WriteLine("0. Finalizar");
        }

        // Nombre: Op1_LecturaElementos
        // Proposito: leer los elementos del arbol por consola e imprimir el arbol ingresado
        public static void Op1_LecturaElementos(Arbol arbol)
        {
            int aux;
            Console.WriteLine("¿Cuantos valores vas a ingresar?");
            aux = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < aux; i++)
            {
                Console.Write("Valor {0} = ", i + 1);
                arbol.SetNode(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Valores ingresados con exito!");
        }

        // Nombre: Op2_ExisteElemento
        // Proposito: leer el elemento a buscar e imprimir por consola si es que existe o no
        public static void Op2_ExisteElemento(Arbol arbol)
        {
            int aux;
            Console.Write("n = ");
            aux = Convert.ToInt32(Console.ReadLine());
            if (arbol.Contiene(aux))
                Console.WriteLine("El numero {0} SI se encuentra en el arbol", aux);
            else
                Console.WriteLine("El numero {0} NO se encuentra en el arbol", aux);
        }
        
        // Nombre: Op3_ExisteNVeces
        // Proposito: lee el elemento a buscar e imprime por consola el numero de ocurrencias
        public static void Op3_ExisteNVeces(Arbol arbol)
        {
            int aux = 0;
            Console.Write("n = ");
            aux = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Encontrado {0} veces", arbol.ContieneNVeces(aux));
        }


    }
}




