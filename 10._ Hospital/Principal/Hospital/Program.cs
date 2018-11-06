using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int op;
            do
            {
                Console.WriteLine("\n###################################################\n#######       Seattle Grace  Hospital       #######");
                Console.WriteLine("#          M E N U      P R I N C I P A L         #");
                Console.WriteLine("# 1.- Agregar un nuevo registro                   #");
                Console.WriteLine("# 2.- Modificar registro de pacientes existentes  #");
                Console.WriteLine("# 3.- Eliminar datos de un paciente               #");
                Console.WriteLine("# 4.- Observar los registros                      #");
                Console.WriteLine("# 5.- Terminar                                    #");
                Console.WriteLine("###################################################\n");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        l.InsertarNodo();
                        Console.WriteLine("Presione espacio para regresar al menu");
                        break;
                    case 2:
                        Console.Clear();
                        l.ModificarNodo();
                        Console.WriteLine("Presione espacio para regresar al menu");
                        break;
                    case 3:
                        Console.Clear();
                        l.EliminarNodo();
                        Console.WriteLine("Presione espacio para regresar al menu");
                        break;
                    case 4:
                        Console.Clear();
                        l.DesplegarLista();
                        Console.WriteLine("Presione espacio para regresar al menu");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Presiona cualquier tecla para terminar el programa");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida!");
                        Console.WriteLine("Presiona cualquier tecla para volver al menu");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (op != 5);
        }
    }
}
