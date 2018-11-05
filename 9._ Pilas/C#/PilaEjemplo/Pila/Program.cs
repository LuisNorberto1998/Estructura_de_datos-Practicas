using System;
using System.Collections;
namespace Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack ejPila = new Stack();
            agregar(ref ejPila);

        }

        static void agregar(ref Stack pila)
        {
            int numero = 27;
            int i = 1;
            for (i = 1; i <= numero; i++)
            {

                Console.WriteLine("ingresa el abecedario letra por letra");
                String valor = Console.ReadLine();
                pila.Push(valor);
                imprimir(pila);

            }
            Console.WriteLine(pila.Pop());
            Console.ReadKey();
        }

        /** Imprime pila */
        static void imprimir(Stack pila)
        {

            Console.WriteLine("");
            foreach (String dato in pila)
            {
                Console.WriteLine(" ________");
                Console.WriteLine(" | {0}  |", dato);
                Console.WriteLine(" ________");
            }
            Console.WriteLine("\nPresione espacio tecla para continuar ...");
            Console.ReadKey();

        }
    }
}
