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

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if(txtBoxLector.Text != "" || txtBoxLector.Text!=" ")
                deletePrestamo(txtBoxLector.Text.Trim());
        }
    }
}
