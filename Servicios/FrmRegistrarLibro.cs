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
        public FrmRegistrarLibro(BibliotecaServices s)
        {
            InitializeComponent();
            servicio = s;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Libro libro = new Libro
                {
                    ISBN = txtISBN.Text.Trim(),
                    Titulo = txtTitulo.Text.Trim(),
                    Autor = txtAutor.Text.Trim(),
                    Anio = int.Parse(txtAnio.Text.Trim())
                };

                servicio.RegistrarLibro(libro);
                MessageBox.Show("Libro registrado correctamente.");
                txtTitulo.Clear(); txtAutor.Clear(); txtAnio.Clear(); txtISBN.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
