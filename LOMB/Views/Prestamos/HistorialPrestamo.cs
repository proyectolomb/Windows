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
    public partial class HistorialPrestamo : Form
    {
        public HistorialPrestamo()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxLibro.Text = string.Empty;
            txtBoxLector.Text = string.Empty;
            txtBoxEjemplar.Text = string.Empty;
            txtBoxCorreo.Text = string.Empty;
        }
    }
}
