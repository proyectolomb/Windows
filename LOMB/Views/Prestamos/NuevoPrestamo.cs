using LOMB.Entities;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace LOMB.Views
{
    public partial class NuevoPrestamo : Form
    {
        public NuevoPrestamo()
        {
            InitializeComponent();
        }

        private void cmbBoxEjemplar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxLector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbBoxLibro.Items.Clear();
            cmbBoxEjemplar.Items.Clear();
            cmbBoxLector.Items.Clear();
            getLibros();
            getLectores();
        }

        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            lbFechaDate.Text = DateTime.Now.AddDays(15).ToString("dd/MM/yyyy");

            getLibros();
            getLectores();
        }

        public void getLibros()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.2.2.15:5000/api/v1/libro";
                client.DefaultRequestHeaders.Clear();


                if (Form1.libros == null) // Si el libro no tiene nada, hace la petición
                {
                    var response = client.GetAsync(url).Result;
                    var res = response.Content.ReadAsStringAsync().Result;
                    cmbBoxLibro.Items.Clear();

                    List<Libro> libros = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Libro>>(res);
                    Form1.instanciaLibros(libros); // Le pasa la lista que acaba de obtener de la API

                    foreach (var val in libros)
                    {
                        cmbBoxLibro.Items.Add(val.isbn.ToString() + " ~ " + val.nombre.ToString());
                    }
                }
                else // En caso contrario, carga lo que ya hay (ya se había cargado previamente)
                {
                    foreach (var val in Form1.libros) // Recorre variable global
                    {
                        cmbBoxLibro.Items.Add(val.isbn.ToString() + " ~ " + val.nombre.ToString());
                    }
                }
            }
        }

        void getLectores()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.2.2.15:5000/api/v1/lector";
                client.DefaultRequestHeaders.Clear();

                if (Form1.lectores == null) // Si el lector no tiene nada, hace la petición
                {
                    var response = client.GetAsync(url).Result;
                    var res = response.Content.ReadAsStringAsync().Result;
                    cmbBoxLector.Items.Clear();

                    List<Lector> lectores = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Lector>>(res);
                    Form1.instanciaLectores(lectores); // Le pasa la lista que acaba de obtener de la API

                    foreach (var val in lectores)
                    {
                        cmbBoxLector.Items.Add(val.nombre + " - "  + val.curso_departamento);
                    }
                }
                else // En caso contrario, carga lo que ya hay (ya se había cargado previamente)
                {
                    foreach (var val in Form1.lectores) // Recorre variable global
                    {
                        cmbBoxLector.Items.Add(val.nombre + " - " + val.curso_departamento);
                    }
                }
            }
        }

        void getEjemplaresDeUnLibro()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();

                string selectedLibro = "";
                
                selectedLibro = cmbBoxLibro.Text.Split('~').GetValue(0).ToString().Trim(); // Coge el ISBN

                string url = $"http://10.2.2.15:5000/api/v1/ejemplar/byisbn/{selectedLibro}"; // Y se lo pasa al endpoint para consultar los ejemplares

                var response = client.GetAsync(url).Result;
                var res = response.Content.ReadAsStringAsync().Result;

                cmbBoxEjemplar.Items.Clear();

                List<Ejemplar> ejemplares = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Ejemplar>>(res);

                foreach (var ejemplar in ejemplares)
                {
                    cmbBoxEjemplar.Items.Add(ejemplar.codigo +"\t" + ejemplar.balda);
                }

            }
        }
        // Cuando elige un elemento del comboBox
        private void cmbBoxLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            getEjemplaresDeUnLibro();
        }
    }
}
