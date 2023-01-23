using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOMB.Clases;

namespace LOMB.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario, contrasenna;
            usuario = txtBoxUsuario.Text;
            contrasenna = txtBoxContra.Text;

            if (InicioSesion.login(usuario, contrasenna))
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("USUARIO/CONTRASEÑA INCORRECTO");
            }
        }
    }
}
