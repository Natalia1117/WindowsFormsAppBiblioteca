using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBiblioteca.Estructuras
{
    public class Pila<T>
    {
        private NodoSimple<T> tope;
        public int Count { get; private set; }

        public void Apilar(T item)
        {
            var nuevo = new NodoSimple<T>(item);
            nuevo.Siguiente = tope;
            tope = nuevo;
            Count++;
        }

        public T Desapilar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila está vacía.");
            var valor = tope.Datos;
            tope = tope.Siguiente;
            Count--;
            return valor;
        }

        public bool EstaVacia() => Count == 0;
    }
}
