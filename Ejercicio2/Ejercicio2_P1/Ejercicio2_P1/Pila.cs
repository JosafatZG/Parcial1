using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_P1
{
    class Pila
    {
        public nodo tope;

        public Pila()
        {
            tope = null;
        }
        public void agregar(int valor)
        {
            nodo nodito = new nodo();
            nodito.dato = valor;
            nodito.sgte = tope;
            tope = nodito;
            Console.WriteLine("\n Nodo ingresado \n Presione cualquier tecla para regresar al menu");
            Console.ReadLine();
        }

        public void mostrar()
        {
            nodo actual = new nodo();
            actual = tope;

            if (tope != null)
            {
                while (actual != null)
                {
                    if(actual.dato >= 0  && actual.dato < 10)
                    {
                        Console.WriteLine("|   0{0}   |", actual.dato);
                        Console.WriteLine("|________|");
                    }
                    else if (actual.dato >= 10 && actual.dato < 100)
                    {
                        Console.WriteLine("|   {0}   |", actual.dato);
                        Console.WriteLine("|________|");
                    }
                    else if (actual.dato >= 100 && actual.dato < 1000)
                    {
                        Console.WriteLine("|   {0}  |", actual.dato);
                        Console.WriteLine("|________|");
                    }
                    else if (actual.dato >= 1000)
                    {
                        Console.WriteLine("|  {0}  |", actual.dato);
                        Console.WriteLine("|________|");
                    }
                    actual = actual.sgte;
                }
            } else
            {
                Console.WriteLine("Pila vacía");
            }
            Console.WriteLine("\n Presione cualquier tecla para regresar al menu");
            Console.ReadLine();
        }

        public void eliminar_especifico(int valor)
        {
            nodo actual = new nodo();
            actual = tope;
            nodo anterior = new nodo();
            anterior = null;
            bool buscar = false;

            int contenedor_eliminar = valor;

            if (tope == null)
            {
                Console.WriteLine("La pila está vacía");
            } else
            {
                while (actual != null && buscar != true)
                {
                    if (actual.dato == contenedor_eliminar)
                    {
                        if (actual == tope)
                        {
                            tope = tope.sgte;
                        }
                        else
                        {
                            anterior.sgte = actual.sgte;
                        }
                        Console.WriteLine("\n Contenedor eliminado");
                        buscar = true;
                    }
                    anterior = actual;
                    actual = actual.sgte;
                }
                if (!buscar)
                {
                    Console.WriteLine("Contenedor inexistente");
                }
            }
            Console.WriteLine("\n Presione cualquier tecla para regresar al menu");
            Console.ReadLine();
        }

        public void eliminar()
        {
            if (tope == null)
            {
                Console.WriteLine("La pila está vacía");
            }
            else
            {
                tope = tope.sgte;
                Console.WriteLine("\n Contenedor eliminado");
            }
            Console.WriteLine("\n Presione cualquier tecla para regresar al menu");
            Console.ReadLine();
        }
    }
}
