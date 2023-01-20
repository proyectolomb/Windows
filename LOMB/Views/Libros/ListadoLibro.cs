using LOMB.ControlUsuario;
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
        /// <summary>
        ///   <para> Recupera los datos de los libros.</para>
        /// </summary>
        public void getLibro()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.2.2.15:5000/api/v1/libro";
                client.DefaultRequestHeaders.Clear();

                string autores = "", categorias = "";

                if (Form1.libros == null) // Si el libro no tiene nada, hace la petición
                {
                    var response = client.GetAsync(url).Result;
                    var res = response.Content.ReadAsStringAsync().Result;
                    matListview.Items.Clear();

                    List<Libro> libros = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Libro>>(res);
                    Form1.instanciaLibros(libros); // Le pasa la lista que acaba de obtener de la API

                    foreach (var val in libros)
                    {
                        ListViewItem item = new ListViewItem(val.isbn.ToString());
                        item.SubItems.Add(val.nombre.ToString());

                        // AUTOR -> recorre cada autor del valor actual del bucle
                        autores = ""; // Se deja vacío para meter valores nuevos
                        foreach (var autor in val.autores)
                        {
                            autores += autor.nombre + " "; // Y lo añade a los autores que ya hay (si es que tiene)
                        }
                        item.SubItems.Add(autores);

                        // CATEGORÍA
                        categorias = "";
                        foreach (var categoria in val.categorias)
                        {
                            categorias += categoria.nombre + " "; // Y lo añade a los autores que ya hay (si es que tiene)
                        }
                        item.SubItems.Add(categorias);
                        item.SubItems.Add(val.editorial.nombre.ToString());
                        item.SubItems.Add(val.fecha_publicacion.ToString());
                        // Ejemplares de un libro
                        getEjemplaresDeUnLibro(val.isbn, item);

                        matListview.Items.Add(item);
                    }
                } else // En caso contrario, carga lo que ya hay (ya se había cargado previamente)
                {
                    foreach (var val in Form1.libros) // Recorre variable global
                    {
                        ListViewItem item = new ListViewItem(val.isbn.ToString());
                        item.SubItems.Add(val.nombre.ToString());

                        // AUTOR -> recorre cada autor del valor actual del bucle
                        autores = ""; // Se deja vacío para meter valores nuevos
                        foreach (var autor in val.autores)
                        {
                            autores += autor.nombre + " "; // Y lo añade a los autores que ya hay (si es que tiene)
                        }
                        item.SubItems.Add(autores);

                        // CATEGORÍA
                        categorias = "";
                        foreach (var categoria in val.categorias)
                        {
                            categorias += categoria.nombre + " "; // Y lo añade a los autores que ya hay (si es que tiene)
                        }
                        item.SubItems.Add(categorias);
                        item.SubItems.Add(val.editorial.nombre.ToString());
                        item.SubItems.Add(val.fecha_publicacion.ToString());
                        // Ejemplares de un libro
                        getEjemplaresDeUnLibro(val.isbn, item);

                        matListview.Items.Add(item);
                    }
                }
            }
        }

        /// <summary>Devuelve los ejemplares de un libro en cuestión.</summary>
        /// <param name="isbn">ISBN del libro en cuestión</param>
        /// <param name="item">Registro de la tabla</param>
        void getEjemplaresDeUnLibro(string isbn, ListViewItem item)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();

                string url = $"http://10.2.2.15:5000/api/v1/ejemplar/byisbn/{isbn}"; // Y se lo pasa al endpoint para consultar los ejemplares

                string ejemplares = "";

                var response = client.GetAsync(url).Result;
                var res = response.Content.ReadAsStringAsync().Result;

                List<Ejemplar> ejemplaresLista = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Ejemplar>>(res);

                foreach (var ejemplar in ejemplaresLista)
                {
                    ejemplares += ejemplar.codigo.ToString() + " ";
                }

                item.SubItems.Add(ejemplares);
            }
        }

        /// <summary>Rellena el combobox de categorías con todas las existentes.</summary>
        void fillCategorias()
        {
            HashSet<string> categorias = new HashSet<string>();
            foreach(Libro libro in Form1.libros){
                foreach(Categoria c in libro.categorias)
                {
                    categorias.Add(c.nombre);
                }
            }

            List<string> d = new List<string>();
            foreach(string z in categorias)
            {
                d.Add(z);
            }

            filtro1.cmbBoxCategoria.DataSource = d;

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>Todas las instrucciones dentro de este método s ejecutarán al carga el formulario.</summary>
        /// <param name="sender">Objeto que envía el evento</param>
        /// <param name="e">Argumentos del evento.</param>
        private void ListadoLibro_Load(object sender, EventArgs e)
        {
            getLibro();
            fillCategorias();
        }

        private void filtro1_Load(object sender, EventArgs e)
        {

        }
    }
}
