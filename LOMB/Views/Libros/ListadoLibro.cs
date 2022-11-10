using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using Dapper;
using System.Net.Http;
using LOMB.Entities;

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
        void peticionLibro()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.2.2.15:5000/api/v1/libro";
                client.DefaultRequestHeaders.Clear();

                if (Form1.libros == null) // Si el libro no tiene nada, hace la petición
                {
                    var response = client.GetAsync(url).Result;
                    var res = response.Content.ReadAsStringAsync().Result;
                    materialListView1.Items.Clear();

                    List<Libro> libros = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Libro>>(res);
                    Form1.instanciaLibros(libros); // Le pasa la lista que acaba de obtener de 

                    foreach (var val in libros) // Recorre variable local
                    {
                        ListViewItem item = new ListViewItem(val.isbn.ToString());
                        item.SubItems.Add(val.nombre.ToString());
                        materialListView1.Items.Add(item);
                    }
                } else // En caso contrario, carga lo que ya hay (ya se había cargado previamente)
                {
                    foreach (var val in Form1.libros) // Recorre variable global
                    {
                        ListViewItem item = new ListViewItem(val.isbn.ToString());
                        item.SubItems.Add(val.nombre.ToString());
                        materialListView1.Items.Add(item);
                    }
                }
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListadoLibro_Load(object sender, EventArgs e)
        {
            peticionLibro();
        }
    }
}
