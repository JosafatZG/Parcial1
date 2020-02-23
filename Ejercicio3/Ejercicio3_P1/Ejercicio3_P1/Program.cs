using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_P1
{
    class Program
    {
        static Cola Cola1 = new Cola();
        static Cola Cola2 = new Cola();
        static Cola Cola3 = new Cola();
        static Cola Cola4 = new Cola();
        static Cola Cola5 = new Cola();
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                //menu
                Console.WriteLine("SIMULACIÓN DE 5 COLAS BANCARIAS");
                Console.WriteLine("1. Agregar cliente");
                Console.WriteLine("2. Agregar cliente en cajero específico");
                Console.WriteLine("3. Quitar cliente");
                Console.WriteLine("4. Mostrar colas");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Escriba la opción que necesita: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                //Trabajando opciones
                switch (opcion)
                {
                    case 1: //Agregar cliente"
                        Console.Write("Nombre del cliente: ");
                        string cliente = Console.ReadLine();
                        Console.Clear();
                        Contar();
                        Console.WriteLine("Cajero 1: " + c1.ToString());
                        Console.WriteLine("Cajero 2: " + c2.ToString());
                        Console.WriteLine("Cajero 3: " + c3.ToString());
                        Console.WriteLine("Cajero 4: " + c4.ToString());
                        Console.WriteLine("Cajero 5: " + c5.ToString() + " \n");
                        int men = Menor();
                        switch (men)
                        {
                            case 0:
                                Console.WriteLine("Todos los cajeros están vacíos, se agregará al cajero 1");
                                Cola1.Encolar(cliente);
                                break;
                            case 1:
                                Console.WriteLine("Cajero 1 más vacío. AGREGADO");
                                Cola1.Encolar(cliente);
                                break;
                            case 2:
                                Console.WriteLine("Cajero 2 más vacío. AGREGADO");
                                Cola2.Encolar(cliente);
                                break;
                            case 3:
                                Console.WriteLine("Cajero 3 más vacío. AGREGADO");
                                Cola3.Encolar(cliente);
                                break;
                            case 4:
                                Console.WriteLine("Cajero 4 más vacío. AGREGADO");
                                Cola4.Encolar(cliente);
                                break;
                            case 5:
                                Console.WriteLine("Cajero 5 más vacío. AGREGADO");
                                Cola5.Encolar(cliente);
                                break;

                        }
                        break;

                    case 2: //Agregar cliente en cajero específico
                        Console.Write("Nombre del cliente: ");
                        string cliente_especifico = Console.ReadLine();
                        Console.Write("Número de cajero a agregar: ");
                        int cajero = Convert.ToInt32(Console.ReadLine());

                        switch (cajero)
                        {
                            case 1:
                                Console.WriteLine("Se agregará a la cola del cajero 1");
                                Cola1.Encolar(cliente_especifico);
                                break;
                            case 2:
                                Console.WriteLine("Se agregará a la cola del cajero 2");
                                Cola2.Encolar(cliente_especifico);
                                break;
                            case 3:
                                Console.WriteLine("Se agregará a la cola del cajero 3");
                                Cola3.Encolar(cliente_especifico);
                                break;
                            case 4:
                                Console.WriteLine("Se agregará a la cola del cajero 4");
                                Cola4.Encolar(cliente_especifico);
                                break;
                            case 5:
                                Console.WriteLine("Se agregará a la cola del cajero 5");
                                Cola5.Encolar(cliente_especifico);
                                break;
                            default:
                                Console.WriteLine("Cajero inexistente");
                                break;
                        }
                        break;

                    case 3: //Quitar cliente
                        Console.WriteLine("Número del cajero a eliminar cliente: ");
                        int cajero_quitar = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        switch (cajero_quitar)
                        {
                            case 1:
                                Console.WriteLine("Cajero 1. ELIMINADO");
                                Cola1.Desencolar();
                                break;
                            case 2:
                                Console.WriteLine("Cajero 2. ELIMINADO");
                                Cola2.Desencolar();
                                break;
                            case 3:
                                Console.WriteLine("Cajero 3. ELIMINADO");
                                Cola3.Desencolar();
                                break;
                            case 4:
                                Console.WriteLine("Cajero 4. ELIMINADO");
                                Cola4.Desencolar();
                                break;
                            case 5:
                                Console.WriteLine("Cajero 5. ELIMINADO");
                                Cola5.Desencolar();
                                break;
                            default:
                                Console.WriteLine("Cajero inexistente");
                                break;
                        }
                        break;

                    case 4: //Mostrar colas
                        Contar();
                        Console.WriteLine("Cajero 1: " + c1.ToString());
                        Cola1.Mostrar();
                        Console.WriteLine("Cajero 2: " + c2.ToString());
                        Cola2.Mostrar();
                        Console.WriteLine("Cajero 3: " + c3.ToString());
                        Cola3.Mostrar();
                        Console.WriteLine("Cajero 4: " + c4.ToString());
                        Cola4.Mostrar();
                        Console.WriteLine("Cajero 5: " + c5.ToString());
                        Cola5.Mostrar();
                        break;

                    case 5: //Salir
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opción no existe");
                        break;
                }
                Console.WriteLine("Presione cualquier letra para regresar al menú");
                Console.ReadKey();
            } while (opcion != 0);
        }

        static int c1, c2, c3, c4, c5;
        public static void Contar()
        {
            c1 = Cola1.Count();
            c2 = Cola2.Count();
            c3 = Cola3.Count();
            c4 = Cola4.Count();
            c5 = Cola5.Count();
        }

        public static int Menor()
        {
            int colamenos = 0;
            if (c1 == 0 && c2 == 0 && c3 == 0 && c4 == 0 && c5 == 0)
            {
                colamenos = 0;
            }
            else if (c1 <= c2 && c1 <= c3 && c1 <= c4 && c1 <= c5)
            {
                colamenos = 1;
            }
            else if (c2 <= c1 && c2 <= c3 && c2 <= c4 && c2 <= c5)
            {
                colamenos = 2;
            }
            else if (c3 <= c1 && c3 <= c2 && c3 <= c4 && c3 <= c5)
            {
                colamenos = 3;
            }
            else if (c4 <= c1 && c4 <= c2 && c4 <= c3 && c4 <= c5)
            {
                colamenos = 4;
            }
            else if (c5 <= c1 && c5 <= c2 && c5 <= c3 && c5 <= c4)
            {
                colamenos = 5;
            }
            return colamenos;
        }
    }
}
