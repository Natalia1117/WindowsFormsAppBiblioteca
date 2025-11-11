using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBiblioteca.Estructuras
{
    public class ListaDoble<T>
    {
        private NodoDoble<T> inicio;
        private NodoDoble<T> fin;
        public int Count { get; private set; }

        public void AgregarAlFinal(T item)
        {
            var nuevo = new NodoDoble<T>(item);
            if (inicio == null)
                inicio = fin = nuevo;
            else
            {
                fin.Siguiente = nuevo;
                nuevo.Anterior = fin;
                fin = nuevo;
            }
            Count++;
        }

        public IEnumerable<T> ObtenerTodos()
        {
            var actual = inicio;
            while (actual != null)
            {
                yield return actual.Datos;
                actual = actual.Siguiente;
            }
        }

        public NodoDoble<T> Buscar(Func<T, bool> criterio)
        {
            var actual = inicio;
            while (actual != null)
            {
                if (criterio(actual.Datos))
                    return actual;
                actual = actual.Siguiente;
            }
            return null;
        }

        public void Ordenar(Comparison<T> comparador)
        {
            if (inicio == null) return;

            bool cambiado;
            do
            {
                cambiado = false;
                var actual = inicio;
                while (actual.Siguiente != null)
                {
                    if (comparador(actual.Datos, actual.Siguiente.Datos) > 0)
                    {
                        var temp = actual.Datos;
                        actual.Datos = actual.Siguiente.Datos;
                        actual.Siguiente.Datos = temp;
                        cambiado = true;
                    }
                    actual = actual.Siguiente;
                }
            } while (cambiado);
        }
    }
}
