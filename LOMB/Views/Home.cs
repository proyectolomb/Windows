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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHome.Controls.Add(childForm);
            panelHome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHomeNuevoPrestamo_Click(object sender, EventArgs e)
        {
            Views.NuevoPrestamo frmNuevoPrestamo = new Views.NuevoPrestamo();
            openChildForm(frmNuevoPrestamo);
        }

        private void btnHomeDevolucion_Click(object sender, EventArgs e)
        {
            Views.Devolucion frmDevolucion = new Views.Devolucion();
            openChildForm(frmDevolucion);
        }

        private void btnHomePrestamosEnCurso_Click(object sender, EventArgs e)
        {
            Views.PrestamosEnCurso frmPrestamosEnCurso = new Views.PrestamosEnCurso();
            openChildForm(frmPrestamosEnCurso);
        }
    }
}
