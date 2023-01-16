using LOMB.Entities;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace LOMB.Views
{
    public partial class Devolucion : Form
    {
        public Devolucion()
        {
            InitializeComponent();
        }

        /// <summary>Elimina el préstamo cuyo código de ejemplar coincide con el parámetro.</summary>
        /// <param name="ejemplar">Código el ejemplar cuyo péstamo se quiere eliminar.</param>
        public async void deletePrestamo(string ejemplar)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    string url = "http://10.2.2.15:5000/api/v1/prestamo";
                    client.DefaultRequestHeaders.Clear();

                    await client.DeleteAsync($"{url}/delete/{ejemplar}");

                    MessageBox.Show("Devolución realizada", "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception ex)
                {
                    MessageBox.Show("El código no existe");
                }
                
            }
        }

        /// <summary>Método que se ejecuta cuando se pulsa el botón de devolver préstamo. Llama al método deletePrestamo().</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if(txtBoxLector.Text != "" || txtBoxLector.Text!=" ")
                deletePrestamo(txtBoxLector.Text.Trim());
        }
    }
}
