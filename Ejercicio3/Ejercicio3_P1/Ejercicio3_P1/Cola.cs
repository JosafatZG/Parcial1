using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_P1
{
    class Cola
    {
        public nodo primero;
        public nodo ultimo;

        public Cola()
        {
            primero = ultimo = null;
        }

        public void Encolar(string valor)
        {
            nodo aux = new nodo();
            aux.info = valor;
            if (primero == null)
            {
                primero = ultimo = aux;
                aux.sgte = null;
            }
            else
            {
                ultimo.sgte = aux;
                aux.sgte = null;
                ultimo = aux;
            }
        }

        public int Count()
        {
            int cant = 0;
            if (primero != null)
            {
                nodo auxiliar = new nodo();
                auxiliar = primero;
                do
                {
                    auxiliar = auxiliar.sgte;
                    cant++;
                } while (auxiliar != null);
            }
            return cant;
        }

        public void Desencolar()
        {
            if (primero == null)
            {
                Console.WriteLine("La cola está vacía");
            }
            else
            {
                primero = primero.sgte;
            }
        }

        public void Mostrar()
        {
            if (primero == null)
            {
                Console.WriteLine("La cola está vacía");
            }
            else
            {
                nodo puntero;
                puntero = primero;
                do
                {
                    if (puntero == primero)
                    {
                        Console.WriteLine("Inicio: ");
                    }

                    Console.Write("{0} -> ", puntero.info);
                    puntero = puntero.sgte;
                } while (puntero != null);
            }
            Console.WriteLine("\n");
        }
    }
}
