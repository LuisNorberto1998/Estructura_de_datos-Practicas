using System;

namespace _8.__ListasEnlazadas
{
    /// <summary>
    /// Clase principal Program, donde se ejecuta el programa
    /// </summary>
    class Program
    {
        /// <summary>
        /// Clase nodo para la creacion de un nodo
        /// </summary>
        class Nodo
        {
            public int value;
            public Nodo next;
            public Nodo(int value)
            {
                this.value = value;
            }
        }

        private Nodo first = null;
        void AddAtFront(Nodo nodo)
        {
            nodo.next = first;
            first = nodo;
        }

        void AddAtEnd(Nodo nodo)
        {
            if (first == null)
            {
                first = nodo;
            }
            else
            {
                Nodo ptr = first;
                while (ptr.next != null)
                {
                    ptr = ptr.next;
                }
                ptr.next = nodo;
            }
        }
        void RemoveFront()
        {
            first = first.next;
        }
        void Print()
        {
            Nodo ptr = first;
            while (ptr != null)
            {
                Console.Write(ptr.value + " | ");
                ptr = ptr.next;
            }
        }


        static void Main(string[] args)
        {
            Program prog = new Program();
            int x = 0;
            int total = 0;
            while (true)
            {
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
                Console.WriteLine("| Ingresa tu edad: ");
                int Edad = Convert.ToInt32(Console.ReadLine());
                if (Edad <= 4)
                {
                    Console.WriteLine("| Tendras un descuento del %15 ");
                    total += 85;
                }
                else if (Edad >= 65)
                {
                    Console.WriteLine("| Se te hace un descuento de %50 ");
                    total += 50;
                }
                else
                {
                    total += 100;
                }
                x++;
                prog.AddAtEnd(new Nodo(Edad));
                Console.WriteLine("Lista de edades ingresadas ");
                prog.Print();
                Console.WriteLine("Total de entradas vendidas: " + x);
                Console.WriteLine("Total en caja: " + total);
            }
        }
    }
}
