using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_P1
{
    class Program
    {
        static Pila c1 = new Pila();
        static Pila c2 = new Pila();
        static void Main(string[] args)
        {
            Pila mipila = new Pila();
            int opcion = 0;

            do
            {
                Console.Clear();
                //menu
                Console.WriteLine("ALMACÉN");
                Console.WriteLine("1. Agregar contenedor");
                Console.WriteLine("2. Eliminar un contenedor");
                Console.WriteLine("3. Eliminar contenedor específico");
                Console.WriteLine("4. Mostrar pila");
                Console.WriteLine("5. Salir");
                Console.WriteLine("\n Escriba la opción que necesita: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: //Agregar contenedor
                        Console.WriteLine("Ingrese el dato del contenedor: ");
                        int vallor = Convert.ToInt32(Console.ReadLine());
                        c1.agregar(vallor);
                        break;
                    case 2: //Eliminar un contenedor
                        c1.eliminar();
                        break;
                    case 3: //Eliminar contenedor específico (por VALOR)
                        Console.WriteLine("Número del contendor a eliminar: ");
                        int contenedor = Convert.ToInt32(Console.ReadLine());
                        c1.eliminar_especifico(contenedor);
                        break;
                    case 4: //Mostrar pila
                        c1.mostrar();
                        break;
                    case 5: //Salir
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción inexistente");
                        Console.WriteLine("\n Presione cualquier tecla para regresar al menu");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != 0);
        }
    }
}
