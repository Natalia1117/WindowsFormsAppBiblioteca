using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBiblioteca.Modelos
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }
        public bool Prestado { get; set; } = false;

        public override string ToString()
        {
            return $"{Titulo} - {Autor} ({Anio})";
        }
    }
}
