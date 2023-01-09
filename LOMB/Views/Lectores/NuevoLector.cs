using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOMB.Views.Lectores
{

    /// <summary>Formulario para añadir nuevo lector.</summary>
    public partial class NuevoLector : Form
    {
        public NuevoLector()
        {
            InitializeComponent();
        }

        private void radBtnAlumno_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>Limpia todos los campos de filtrado de la vista.</summary>
        /// <param name="sender">Elemento que genera el evento.</param>
        /// <param name="e">Agumentos del evento</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Text = string.Empty;
            txtBoxApellidos.Text = string.Empty;
            txtBoxCorreo.Text = string.Empty;
            cmbBoxCategoria.Items.Clear();
            dateNacimiento.ResetText();
        }
    }
}
