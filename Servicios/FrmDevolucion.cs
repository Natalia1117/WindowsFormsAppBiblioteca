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
    public partial class FrmDevolucion : Form
    {
        private BibliotecaServices servicio;
        public FrmDevolucion(BibliotecaServices s)
        {
            InitializeComponent();
            servicio = s;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();
            var libro = servicio.ObtenerLibros().FirstOrDefault(l => l.ISBN == isbn);

            if (libro == null)
            {
                MessageBox.Show("No se encontró un libro con ese ISBN.");
                return;
            }

            servicio.RegistrarDevolucion(libro);
            MessageBox.Show("Devolución registrada (en pila).");
            txtISBN.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = servicio.ObtenerDevoluciones().ToList();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
