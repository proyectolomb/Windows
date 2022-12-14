using LOMB.Entities;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace LOMB.Views.Libros
{
    public partial class ListadoAutores : Form
    {
        public ListadoAutores()
        {
            InitializeComponent();
        }
        void getAutores()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.2.2.15:5000/api/v1/autor";
                client.DefaultRequestHeaders.Clear();
                string categorias = "";

                if (Form1.autores == null) // Si el libro no tiene nada, hace la petición
                {
                    var response = client.GetAsync(url).Result;
                    var res = response.Content.ReadAsStringAsync().Result;
                    matListView.Items.Clear();

                    List<Autor> autores = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Autor>>(res);
                    Form1.instanciaAutores(autores); // Le pasa la lista que acaba de obtener de la 

                    foreach (var val in autores)
                    {
                        ListViewItem item = new ListViewItem(val.nombre.ToString());
                        item.SubItems.Add(val.pais_origen.ToString());
                        //  Categorías
                        categorias = "";
                        foreach (var categoria in val.categorias)
                        {
                            categorias += categoria.nombre + " "; // Y lo añade a los autores que ya hay (si es que tiene)
                        }
                        item.SubItems.Add(categorias);

                        item.SubItems.Add("Alfarra");
                        matListView.Items.Add(item);
                    }
                }
                else // En caso contrario, carga lo que ya hay (ya se había cargado previamente)
                {
                    foreach (var val in Form1.autores) // Recorre variable global
                    {
                        ListViewItem item = new ListViewItem(val.nombre.ToString());
                        item.SubItems.Add(val.pais_origen.ToString());
                        //  Categorías
                        categorias = "";
                        foreach (var categoria in val.categorias)
                        {
                            categorias += categoria.nombre + " "; // Y lo añade a los autores que ya hay (si es que tiene)
                        }
                        item.SubItems.Add(categorias);

                        item.SubItems.Add("Alfarra");
                        matListView.Items.Add(item);
                    }
                }
            }
        }

        void getAutoresCategorias()
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Text = string.Empty;
            txtBoxApellidos.Text = string.Empty;
            cmbBoxCategoria.Items.Clear();
        }

        private void ListadoAutores_Load(object sender, EventArgs e)
        {
            getAutores();

            // Carga las categorías
            foreach (var autor in Form1.autores)
            {
                cmbBoxCategoria.Items.Add(autor.categorias);
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
