using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBiblioteca.Estructuras
{
    public class Cola<T>    
    {
        private NodoSimple<T> frente;
        private NodoSimple<T> fin;
        public int Count { get; private set; }

        public void Encolar(T item)
        {
            var nuevo = new NodoSimple<T>(item);
            if (fin == null)
                frente = fin = nuevo;
            else
            {
                fin.Siguiente = nuevo;
                fin = nuevo;
            }
            Count++;
        }

        public T Desencolar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");
            var valor = frente.Datos;
            frente = frente.Siguiente;
            if (frente == null) fin = null;
            Count--;
            return valor;
        }

        public bool EstaVacia() => Count == 0;
    }
}
