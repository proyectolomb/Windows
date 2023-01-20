using LOMB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOMB.ControlUsuario
{
    public partial class Filtro : UserControl
    {
        public List<Categoria> CmbBoxCategoriaDataSource
        {
            get { return null; }
            set { cmbBoxCategoria.DataSource = value; }
        }
        public string CmbBoxCategoriaSelected
        {
            get { return cmbBoxCategoria.SelectedText.ToString(); }
        }
        public Filtro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Filtro_Load(object sender, EventArgs e)
        {

        }

        private void cmbBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
