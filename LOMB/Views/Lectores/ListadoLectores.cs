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
    public partial class ListadoLectores : Form
    {
        public ListadoLectores()
        {
            InitializeComponent();
        }

        private void radBtnAlumno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbAlumno_Click(object sender, EventArgs e)
        {

        }

        private void radBtnProfesor_CheckedChanged(object sender, EventArgs e)
        {

        }

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
    }
}
