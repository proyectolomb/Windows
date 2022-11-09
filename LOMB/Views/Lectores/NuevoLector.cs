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
    public partial class NuevoLector : Form
    {
        public NuevoLector()
        {
            InitializeComponent();
        }

        private void radBtnAlumno_CheckedChanged(object sender, EventArgs e)
        {

        }

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
