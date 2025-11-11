using System;
using WindowsFormsAppBiblioteca.Modelos;
using WindowsFormsAppBiblioteca.Servicios;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBiblioteca.Servicios
{
    public partial class FrmRegistrarLibro : Form
    {
        private BibliotecaServices servicio;
        public FrmRegistrarLibro()
        {
            InitializeComponent();
            servicio = s;
        }
    }
}
