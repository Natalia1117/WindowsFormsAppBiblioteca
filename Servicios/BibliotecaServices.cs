using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppBiblioteca.Estructuras;
using WindowsFormsAppBiblioteca.Modelos;

namespace WindowsFormsAppBiblioteca.Servicios
{
    public class BibliotecaServices
    {
        public ListaDoble<Libro> Libros { get; } = new ListaDoble<Libro>();
        public Cola<Usuario> ColaPrestamos { get; } = new Cola<Usuario>();
        public Pila<Libro> PilaDevoluciones { get; } = new Pila<Libro>();

        public void RegistrarLibro(Libro libro)
        {
            Libros.AgregarAlFinal(libro);
        }

        public IEnumerable<Libro> ObtenerLibros() => Libros.ObtenerTodos();

        public Libro BuscarPorTitulo(string titulo)
        {
            var nodo = Libros.Buscar(l => l.Titulo.ToLower().Contains(titulo.ToLower()));
            return nodo?.Datos;
        }

        public void OrdenarPorTitulo()
        {
            Libros.Ordenar((a, b) => a.Titulo.CompareTo(b.Titulo));
        }

        public void OrdenarPorAnio()
        {
            Libros.Ordenar((a, b) => a.Anio.CompareTo(b.Anio));
        }

        public void SolicitarPrestamo(Usuario u)
        {
            ColaPrestamos.Encolar(u);
        }

        public void RegistrarDevolucion(Libro l)
        {
            PilaDevoluciones.Apilar(l);
        }

        public IEnumerable<Libro> ObtenerDevoluciones()
        {
            var lista = new List<Libro>();
            while (!PilaDevoluciones.EstaVacia())
                lista.Add(PilaDevoluciones.Desapilar());
            return lista;
        }
    }
}
