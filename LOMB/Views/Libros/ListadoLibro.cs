using LOMB.Entities;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace LOMB.Views
{
    public partial class ListadoLibro : Form
    {
        MaterialSkinManager skinManager;
        public ListadoLibro()
        {
            InitializeComponent();
            /*skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green900, Primary.Green900, Accent.LightBlue200, TextShade.WHITE)*/
        }
        void getLibro()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.2.2.15:5000/api/v1/libro";
                client.DefaultRequestHeaders.Clear();

                string autores = "";

                if (Form1.libros == null) // Si el libro no tiene nada, hace la petición
                {
                    var response = client.GetAsync(url).Result;
                    var res = response.Content.ReadAsStringAsync().Result;
                    matListview.Items.Clear();

                    List<Libro> libros = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Libro>>(res);
                    Form1.instanciaLibros(libros); // Le pasa la lista que acaba de obtener de la 

                    foreach (var val in libros) // Recorre variable local
                    {
                        ListViewItem item = new ListViewItem(val.isbn.ToString());
                        item.SubItems.Add(val.nombre.ToString());

                        // AUTOR -> recorre cada autor del valor actual del bucle
                        foreach (var autor in val.autores)
                        {
                            autores += autor.nombre + " "; // Y lo añade a los autores que ya hay (si es que tiene)
                        }
                        item.SubItems.Add(autores);

                        //item.SubItems.Add(val.categoria.ToString());
                        item.SubItems.Add(val.editorial.nombre.ToString());
                        item.SubItems.Add(val.fecha_publicacion.ToString());
                        //item.SubItems.Add(val.ejemplares.ToString());
                        matListview.Items.Add(item);
                    }
                } else // En caso contrario, carga lo que ya hay (ya se había cargado previamente)
                {
                    foreach (var val in Form1.libros) // Recorre variable global
                    {
                        ListViewItem item = new ListViewItem(val.isbn.ToString());
                        item.SubItems.Add(val.nombre.ToString());

                        // AUTOR -> recorre cada autor del valor actual del bucle
                        foreach (var autor in val.autores)
                        {
                            autores += autor.nombre + " "; // Y lo añade a los autores que ya hay (si es que tiene)
                        }
                        item.SubItems.Add(autores);

                        //item.SubItems.Add(val.categoria.ToString());
                        item.SubItems.Add(val.editorial.nombre.ToString());
                        item.SubItems.Add(val.fecha_publicacion.ToString());
                        //item.SubItems.Add(val.ejemplares.ToString());
                        matListview.Items.Add(item);
                    }
                }
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListadoLibro_Load(object sender, EventArgs e)
        {
            getLibro();
        }
    }
}
