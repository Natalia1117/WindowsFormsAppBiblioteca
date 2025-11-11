using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBiblioteca.Estructuras
{
    public class NodoDoble<T>
    {
        public T Datos;
        public NodoDoble<T> Anterior;
        public NodoDoble<T> Siguiente;

        public NodoDoble(T datos)
        {
            Datos = datos;
            Anterior = null;
            Siguiente = null;
        }
    }
}
