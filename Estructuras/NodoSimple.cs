using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBiblioteca.Estructuras
{
    public class NodoSimple<T>
    {
        public T Datos;
        public NodoSimple<T> Siguiente;

        public NodoSimple(T datos)
        {
            Datos = datos;
        }
    }
}
