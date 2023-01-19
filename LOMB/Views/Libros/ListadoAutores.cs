using LOMB.Entities;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace LOMB.Views.Libros
{

    /// <summary>Formulario para el listado de autores.</summary>
    public partial class ListadoAutores : Form
    {

        /// <summary>Constructor para inicializar el formulario.</summary>
        public ListadoAutores()
        {
            InitializeComponent();
        }
        /// <summary>Recupera todos los autores de la base de datos.</summary>
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
        /// <summary>Limpia todos los campos de filtrado de la vista.</summary>
        /// <param name="sender">Elemento que genera el evento.</param>
        /// <param name="e">Agumentos del evento</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Text = string.Empty;
            txtBoxApellidos.Text = string.Empty;
            cmbBoxCategoria.Items.Clear();
        }


        /// <summary>Todas las instrucciones dentro de este método s ejecutarán al carga el formulario.</summary>
        /// <param name="sender">Objeto que envía el evento</param>
        /// <param name="e">Argumentos del evento.</param>
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

        private void lbPersona_Click(object sender, EventArgs e)
        {

        }
    }
}
