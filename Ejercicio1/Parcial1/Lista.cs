using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class lista
    {

        public nodo inicio;

        public lista() { inicio = null; }

        public void Insertar()
        {
            nodo auxiliar = new nodo();

            Console.Write("Inserte el valor a insertar: ");
            auxiliar.dato = Console.ReadLine();
            auxiliar.siguiente = null;

            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                inicio = auxiliar;
                auxiliar.siguiente = puntero;
            }
        }

        public void Eliminar()
        {
            int contador = 0;
            if (inicio == null)
                Console.WriteLine("Lista vacía, no se puede eliminar elemento");
            else
            {
                Console.Write("Inserte el valor a eliminar: ");
                string k = Console.ReadLine();

                nodo puntero;
                puntero = inicio;

                if (k == puntero.dato)
                {
                    inicio = inicio.siguiente;
                    puntero = inicio;
                    contador++;
                }

                while (puntero.siguiente != null)
                {
                    if (k == puntero.siguiente.dato)
                    {
                        puntero.siguiente = puntero.siguiente.siguiente;
                        contador++;
                    }
                    else
                    {
                        puntero = puntero.siguiente;
                    }
                }

                if (contador == 0)
                {
                    Console.WriteLine("Ese valor no está contenido en la lista");
                    Console.ReadKey();
                }
            }
        }

        public void Mostrar()
        {
            if (inicio == null)
                Console.WriteLine("La lista está vacía");
            else
            {
                nodo puntero;
                puntero = inicio;
                Console.Write("{0} -> \t", puntero.dato);
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    Console.Write("{0} -> \t", puntero.dato);
                }
            }
            Console.ReadKey();
        }

        public void Longitud()
        {
            int contador = 0;
            if (inicio == null)
                Console.WriteLine("La lista está vacía");
            else
            {
                nodo puntero;
                puntero = inicio;
                contador++;

                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    contador++;
                }

                Console.WriteLine("Hay " + contador + " elementos en la lista");
            }
            Console.ReadKey();
        }
    }
}
