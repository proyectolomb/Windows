using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOMB.Views
{
    public partial class NuevoLibro : Form
    {
        public NuevoLibro()
        {
            InitializeComponent();
        }

        /// <summary>Limpia todos los campos de filtrado de la vista.</summary>
        /// <param name="sender">Elemento que genera el evento.</param>
        /// <param name="e">Agumentos del evento</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxIsbn.Text = string.Empty;
            txtBoxNombre.Text = string.Empty;
            cmbBoxAutor.Items.Clear();
            cmbBoxCategoria.Items.Clear();
            txtBoxEditorial.Text = string.Empty;
            dateNacimiento.ResetText();
            cmbBoxIdioma.Items.Clear();
        }
    }
}
