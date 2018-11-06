using System;

namespace Hospital
{
    class Lista
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public Lista()
        {
            Primero = null;
            Ultimo = null;
        }

        public void InsertarNodo()
        {
            String id, Nombre, Celular, Email, Direccion, Txt = null;
            Nodo Nuevo = new Nodo();
            Console.WriteLine("Ingresa la siguiente informacion");
            Console.Write("ID: ");
            id = Console.ReadLine();
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Celular: ");
            Celular = Console.ReadLine();
            Console.Write("Email: ");
            Email = Console.ReadLine();
            Console.Write("Direccion: ");
            Direccion = Console.ReadLine();
            Txt = ("\n------------------------" +
                "\n ID: " + id +
                "\n Nombre: " + Nombre +
                "\n Dirección: " + Direccion +
                "\n Celular: " + Celular +
                "\n Email: " + Email);
            Nuevo.Dato = Txt;
            
            if(Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }
            Console.WriteLine("Nodo ingresado con exito");
        }

        public void DesplegarLista()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            if(Primero!= null)
            {
                //hay nodos en la lista
                while(Actual != null)
                {
                    Console.WriteLine(" {0} ", Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                //no hay nodos en la lista
                Console.WriteLine("La lista esta vacia");
            }
        }

        public void EliminarNodo()
        {
            Nodo Actual = new Nodo();
            Nodo Anterior = new Nodo();
            Actual = Primero;
            int x = 1;
            bool Encontrado = false;
            Console.WriteLine("Posicion de los datos que desea borrar en la lista");
            int NodoBuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                //hay nodos en la lista
                while (Actual != null && Encontrado != true)
                {
                    if (x == NodoBuscado) //Para buscar la posicion solicitada
                    {
                        Console.WriteLine("Registro encontrado!");
                        if(Actual == Primero) //En caso de que la posicion sea la primera
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if (Actual == Ultimo) //En caso de que la posicion sea la ultima
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else //En caso de que sea una de las posiciones del medio
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                        Console.WriteLine("Nodo eliminado");
                        Encontrado = true;
                    }
                    else //En caso de que no sea la posicion deseada, se incrementa el contador
                    {
                        x++;
                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado) //Si la posicion no existe
                {
                    Console.WriteLine("POSICION DESCONOCIDA\nNodo no encontrado");
                }
            }
            else
            {
                //no hay nodos en la lista
                Console.WriteLine("La lista esta vacia");
            }
        }

        public void ModificarNodo()
        {
            Nodo Actual = new Nodo();
            Nodo Anterior = new Nodo();
            Actual = Primero;
            int x = 1;
            bool Encontrado = false;
            String id, Nombre, Celular, Email, Direccion, Txt = null;            
            Console.WriteLine("Posicion de los datos que desea modificar en la lista");
            int NodoBuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                //hay nodos en la lista
                while (Actual != null && Encontrado != true)
                {
                    if (x == NodoBuscado) //Para buscar la posicion solicitada
                    {
                        Console.WriteLine("Ingresa los siguientes datos");
                        Console.Write("Clave: ");
                        id = Console.ReadLine();
                        Console.Write("Nombre: ");
                        Nombre = Console.ReadLine();
                        Console.Write("Telefono: ");
                        Celular = Console.ReadLine();
                        Console.Write("Correo: ");
                        Email = Console.ReadLine();
                        Console.Write("Direccion: ");
                        Direccion = Console.ReadLine();
                        Txt = ("\n------------------------" +
                            "\n Clave: " + id +
                            "\n Nombre: " + Nombre +
                            "\n Dirección: " + Celular +
                            "\n Correo: " + Email +
                            "\n Telefono: " + Celular);
                        Actual.Dato = Txt;
                        Console.WriteLine("Nodo modificado!");
                        Encontrado = true;
                    }
                    else //En caso de que no sea la posicion deseada, se incrementa el contador
                    {
                        x++;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado) //Si la posicion no existe
                {
                    Console.WriteLine("POSICION DESCONOCIDA\nNodo no encontrado");
                }
            }
            else
            {
                //no hay nodos en la lista
                Console.WriteLine("La lista esta vacia");
            }
        }
    }
}
