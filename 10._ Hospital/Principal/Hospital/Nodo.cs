using System;

namespace Hospital
{
    class Nodo
    {
        private String dato;
        private Nodo siguiente;

        public String Dato
        {
            get { return dato; }
            set { dato = value;  }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
