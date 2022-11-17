using LOMB.Entities;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace LOMB.Views
{
    public partial class PrestamosEnCurso : Form
    {
        public PrestamosEnCurso()
        {
            InitializeComponent();
        }

        void getPrestamos()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.2.2.15:5000/api/v1/prestamo";
                client.DefaultRequestHeaders.Clear();

                string lector = "";

                if (Form1.prestamos == null) // Si el libro no tiene nada, hace la petición
                {
                    var response = client.GetAsync(url).Result;
                    var res = response.Content.ReadAsStringAsync().Result;
                    matListView.Items.Clear();

                    List<Prestamo> prestamos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Prestamo>>(res);
                    Form1.instanciaPrestamos(prestamos); // Le pasa la lista que acaba de obtener de la 

                    foreach (var val in prestamos)
                    {
                        ListViewItem item = new ListViewItem(val.libro.nombre.ToString());
                        item.SubItems.Add(val.ejemplar.codigo.ToString());

                        lector = val.lector.nombre.ToString() + " - " + val.lector.curso_departamento.ToString();
                        item.SubItems.Add(lector);

                        item.SubItems.Add(val.fecha_prestamo.ToString());
                        item.SubItems.Add(val.fecha_devolucion.ToString());
                        matListView.Items.Add(item);
                    }
                }
                else // En caso contrario, carga lo que ya hay (ya se había cargado previamente)
                {
                    foreach (var val in Form1.prestamos) // Recorre variable global
                    {
                        ListViewItem item = new ListViewItem(val.libro.nombre.ToString());
                        item.SubItems.Add(val.ejemplar.codigo.ToString());

                        lector = val.lector.nombre.ToString() + " - " + val.lector.curso_departamento.ToString();
                        item.SubItems.Add(lector);

                        item.SubItems.Add(val.fecha_prestamo.ToString());
                        item.SubItems.Add(val.fecha_devolucion.ToString());
                        matListView.Items.Add(item);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxLibro.Text = string.Empty;
            txtBoxLector.Text = string.Empty;
            txtBoxEjemplar.Text = string.Empty;
            txtBoxCorreo.Text = string.Empty;
        }

        private void PrestamosEnCurso_Load(object sender, EventArgs e)
        {
            getPrestamos();
        }
    }
}
