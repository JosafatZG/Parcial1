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

        public void InsertarF(int item)
        {
            nodo auxiliar = new nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;

            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
            }
        }

        public void InsertarI(int item)
        {
            nodo auxiliar = new nodo();
            auxiliar.dato = item;
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

        public void EliminarI()
        {
            if (inicio == null)
                Console.WriteLine("Lista vacía, no se puede eliminar elemento");
            else
                inicio = inicio.siguiente;
        }

        public void EliminarF()
        {
            if (inicio == null)
                Console.WriteLine("Lista vacía, no se puede eliminar elemento");
            else
            {
                nodo punteroant, punteropost;
                punteroant = inicio;
                punteropost = inicio;

                while (punteropost.siguiente != null)
                {
                    punteroant = punteropost;
                    punteropost = punteropost.siguiente;
                }
                punteroant.siguiente = null;
            }
        }

        public void InsertarP(int item, int pos)
        {
            nodo auxiliar = new nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;

            if (inicio == null)
            {
                Console.WriteLine("La lista está vacia, por lo tanto se va a insertar en la 1ra posición");
                inicio = auxiliar;
            }
            else
            {
                nodo puntero;
                puntero = inicio;

                if (pos == 1)
                {
                    inicio = auxiliar;
                    auxiliar.siguiente = puntero;
                }
                else
                {
                    for (int i = 1; i < pos - 1; i++)
                    {
                        puntero = puntero.siguiente;
                        if (puntero.siguiente == null)
                            break;
                    }

                    nodo punteronext;
                    punteronext = puntero.siguiente;
                    puntero.siguiente = auxiliar;
                    auxiliar.siguiente = punteronext;
                }
            }
        }

        public void mostrar()
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
    }
}
