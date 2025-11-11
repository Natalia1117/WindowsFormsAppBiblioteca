using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBiblioteca.Modelos
{
    public class Usuario
    {
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }

        public string TituloLibro { get; set; } // Nuevo campo: el libro solicitado

        public override string ToString()
        {
            return $"{IdUsuario} - {Nombre} - {TituloLibro}";
        }
    }
}
