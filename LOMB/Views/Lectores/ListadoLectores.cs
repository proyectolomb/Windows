using LOMB.Entities;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace LOMB.Views.Lectores
{
    /// <summary>Clase correspondiente a la ventana para listar los lectores de la base de datos.</summary>
    public partial class ListadoLectores : Form
    {
        /// <summary>Constructor para el listado de los lectores. Inicializa los componentes.</summary>
        public ListadoLectores()
        {
            InitializeComponent();
        }

        /// <summary>Recupera todos los lectores de la base de datos.</summary>
        private List<Lector> apiLectores()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.2.2.15:5000/api/v1/lector";
                client.DefaultRequestHeaders.Clear();

                var response = client.GetAsync(url).Result;
                var res = response.Content.ReadAsStringAsync().Result;
                matListView.Items.Clear();

                List<Lector> lectores = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Lector>>(res);
                return lectores;
            }
        }

        private void fillLectoresTable()
        {
            List<Lector> lectores = apiLectores();
            if (Form1.lectores == null) // Si el lector no tiene nada, hace la petición
            {
                Form1.instanciaLectores(lectores); // Le pasa la lista que acaba de obtener de la 

                foreach (var val in lectores)
                {
                    ListViewItem item = new ListViewItem(val.nombre.ToString());
                    item.SubItems.Add(val.apellidos.ToString());
                    item.SubItems.Add(val.fecha_nacimiento.ToString());
                    item.SubItems.Add(val.fecha_alta.ToString());
                    item.SubItems.Add(val.curso_departamento.ToString());
                    matListView.Items.Add(item);
                }
            } else
            {
                foreach (var val in Form1.lectores) // Recorre variable global
                {
                    ListViewItem item = new ListViewItem(val.nombre.ToString());
                    item.SubItems.Add(val.apellidos.ToString());
                    item.SubItems.Add(val.fecha_nacimiento.ToString());
                    item.SubItems.Add(val.fecha_alta.ToString());
                    item.SubItems.Add(val.curso_departamento.ToString());
                    matListView.Items.Add(item);
                }
            }
        }

        private void radBtnAlumno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radBtnProfesor_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>Limpia todos los campos de filtrado de la vista.</summary>
        /// <param name="sender">Elemento que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Text = "";
            txtBoxCorreo.Text = "";
            txtBoxApellidos.Text = "";
            cmbBoxCursoAlumno.Items.Clear();
        }

        private void cmbBoxCursoAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>Llama al método getLectores() y carga los datos en la tabla.</summary>
        /// <param name="sender">Elemento que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void ListadoLectores_Load(object sender, EventArgs e)
        {
            apiLectores();
        }
    }
}
