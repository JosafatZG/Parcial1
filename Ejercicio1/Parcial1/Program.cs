using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vuelta = true;
            lista MiLista = new lista();

            do
            {
                int op;
                string dato;

                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("-               LISTA                -");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("-      Operaciones disponibles:      -");
                Console.WriteLine("-                                    -");
                Console.WriteLine("-         1) Insertar valor          -");
                Console.WriteLine("-         2) Eliminar valor          -");
                Console.WriteLine("-         3) Mostrar Elementos       -");
                Console.WriteLine("-         4) Longitud de la Lista    -");
                Console.WriteLine("-         5) Salir                   -");
                Console.WriteLine("-                                    -");
                Console.WriteLine("--------------------------------------");

                Console.Write("\nDigite el numero de operacion que desea realizar: ");
                dato = Console.ReadLine();

                int.TryParse(dato, out op);

                switch (op)
                {
                    case 1:
                        MiLista.Insertar();
                        break;

                    case 2:
                        MiLista.Eliminar();
                        break;

                    case 3:
                        MiLista.Mostrar();
                        break;

                    case 4:
                        MiLista.Longitud();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            } while (vuelta);
        }
    }
}