using System;
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
    public partial class FrmMostrarLibros : Form
    {
        private BibliotecaServices servicio;
        private bool modoBusqueda;
        public FrmMostrarLibros(BibliotecaServices s, bool modoBusqueda = false)
        {
            InitializeComponent();
            servicio = s;
            this.modoBusqueda = modoBusqueda;
            CargarLibros();
        }
        private void CargarLibros()
        {
            dgvLibros.DataSource = servicio.ObtenerLibros().ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string texto = txtBuscar.Text.Trim().ToLower();
            var resultado = servicio.ObtenerLibros()
                .Where(l => l.Titulo.ToLower().Contains(texto) || l.Autor.ToLower().Contains(texto))
                .ToList();

            dgvLibros.DataSource = resultado;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrdenarTitulo_Click(object sender, EventArgs e)
        {
            servicio.OrdenarPorTitulo();
            MessageBox.Show("Libros ordenados por título correctamente.");
        }

        private void btnOrdenarAnio_Click(object sender, EventArgs e)
        {
            servicio.OrdenarPorAnio();
            MessageBox.Show("Libros ordenados por año correctamente.")
        }
    }
}
