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

namespace WindowsFormsAppBiblioteca
{
    public partial class FrmMenuPrincipal : Form
    {
        private BibliotecaServices servicio = new BibliotecaServices();
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            new FrmRegistrarLibro(servicio).ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            new FrmMostrarLibros(servicio).ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            new FrmMostrarLibros(servicio, modoBusqueda: true).ShowDialog();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            new FrmPrestamo(servicio).ShowDialog();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            new FrmDevolucion(servicio).ShowDialog();
        }

        private void btnOrdenarTitulo_Click(object sender, EventArgs e)
        {
            servicio.OrdenarPorTitulo();
            MessageBox.Show("Libros ordenados por título correctamente.");
        }

        private void btnOrdenarAnio_Click(object sender, EventArgs e)
        {
            servicio.OrdenarPorAnio();
            MessageBox.Show("Libros ordenados por año correctamente.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
