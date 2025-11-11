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
    public partial class FrmPrestamo : Form
    {
        private BibliotecaServices servicio;
        public FrmPrestamo(BibliotecaServices s)
        {
            InitializeComponent();
            servicio = s;
            ActualizarLista();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario
                {
                    Nombre = txtNombre.Text.Trim(),
                    TituloLibro = txtTitulo.Text.Trim()
                };

                servicio.SolicitarPrestamo(u);
                MessageBox.Show("Préstamo registrado (en cola).");
                txtNombre.Clear(); txtTitulo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ActualizarLista()
        {
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = servicio.ColaPrestamos.ObtenerTodos().ToList();
        }
        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if (servicio.ColaPrestamos.EstaVacia())
            {
                MessageBox.Show("No hay préstamos pendientes.");
                return;
            }

            var usuarioAtendido = servicio.ColaPrestamos.Desencolar();
            MessageBox.Show($"Préstamo autorizado a: {usuarioAtendido.Nombre}");
            ActualizarLista();
        }
    }
}
