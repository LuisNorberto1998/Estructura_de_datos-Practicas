using System;
using System.Collections;
namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            String romper = "No";
            while (true)
            {
                if (romper == "no" || romper == "No")
                {
                    Stack pilaExamen = new Stack();
                    Console.WriteLine("Agrega la cantidad de numeros que conformaran la pila");
                    int x = Convert.ToInt32(Console.ReadLine());
                    insertarPila(ref pilaExamen, x);
                    verPila(pilaExamen);
                    vaciarPila(ref pilaExamen, x);
                    Console.WriteLine("- Todos los numeros impares han sido eliminados");
                    verPila(pilaExamen);

                    Console.WriteLine("Quieres terminar el programa (Si / No)");
                    romper = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
        }

        static void insertarPila(ref Stack pila, int x)
        {
            int n = 0;
            do
            {
                Console.WriteLine("\n> Ingresa un numero: ");
                try
                {
                    int value = Convert.ToInt32(Console.ReadLine());
                    if (value < 0)
                    {
                        Console.WriteLine(">  Solo se permiten numeros positivos");
                        Console.WriteLine("> Presiona cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                    else
                    {
                        pila.Push(value);
                        Console.WriteLine("El numero ha sido agregado: " + Convert.ToString(value));
                        n++;
                    }
                }
                catch
                {
                    Console.WriteLine("Solo se permiten numeros enteros positivos");
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (n != x);

        }

        static void vaciarPila(ref Stack pila, int x)
        {
            if (pila.Count > 0)
            {
                int[] vs = new int[x];
                for (int y = 0; y < x; y++)
                {
                    int valor = (int)pila.Peek();
                    if (valor % 2 != 0)
                    {
                        pila.Pop();
                    }
                    else
                    {
                        int arr = (int)pila.Peek();
                        vs[y] = arr;
                        pila.Pop();
                    }
                }
                foreach (int dato in vs)
                {
                    pila.Push(dato);
                }
            }
            else
            {
                Console.WriteLine("Esta vacia la pila");
            }
        }

        static void verPila(Stack pila)
        {
            if (pila.Count > 0)
            {
                Console.WriteLine("");
                foreach (int dato in pila)
                {
                    Console.WriteLine(" |   |");
                    Console.WriteLine(" | {0} |", dato);
                    Console.WriteLine(" |   |");
                }
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
            }
            Console.WriteLine("- Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
