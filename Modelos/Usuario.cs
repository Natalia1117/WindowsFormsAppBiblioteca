using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBiblioteca.Modelos
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - {Documento}";
        }
    }
}
