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

namespace LOMB
{
    public partial class Form1 : Form
    {
        public static List<Libro> libros; // Propiedad global por sí se cae la API
        public static List<Lector> lectores;

        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            libros = null;
            lectores = null;
            //this.MaximizeBox = false;
            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        public static void instanciaLibros(List<Libro> librosPasado)
        {
            libros = librosPasado;
        }
        public static void instanciaLectores(List<Lector> lectoresPasado)
        {
            lectores = lectoresPasado;
        }

        private void customizeDesign()
        {
            panelPrestamosSubmenu.Visible = false;
            panelLibrosSubmenu.Visible = false;
            panelLectoresSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelPrestamosSubmenu.Visible)
                panelPrestamosSubmenu.Visible = false;
            if (panelLibrosSubmenu.Visible)
                panelLibrosSubmenu.Visible = false;
            if (panelLectoresSubmenu.Visible)
                panelLectoresSubmenu.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false) 
            {
                hideSubMenu();
                subMenu.Visible = true;
            } else
            {
                subMenu.Visible = false;
            }
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPrestamosSubmenu);
        }
        #region PrestamoSubMenu
        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            Views.NuevoPrestamo frmNuevoPrestamo = new Views.NuevoPrestamo();
            openChildForm(frmNuevoPrestamo);

            hideSubMenu();
        }

        private void btnEnCurso_Click(object sender, EventArgs e)
        {
            Views.PrestamosEnCurso frmPrestamosEnCurso = new Views.PrestamosEnCurso();
            openChildForm(frmPrestamosEnCurso);

            hideSubMenu();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            Views.Devolucion frmDevolucion = new Views.Devolucion();
            openChildForm(frmDevolucion);

            hideSubMenu();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Views.HistorialPrestamo frmHistorialPrestamo = new Views.HistorialPrestamo();
            openChildForm(frmHistorialPrestamo);

            hideSubMenu();
        }
        #endregion
        private void btnLibros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLibrosSubmenu);
        }
        #region LibroSubMenu
        private void btnNuevoLibro_Click(object sender, EventArgs e)
        {
            Views.NuevoLibro frmNuevoLibro = new Views.NuevoLibro();
            openChildForm(frmNuevoLibro);
            hideSubMenu();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            Views.Libros.ListadoAutores frmListadoAutores = new Views.Libros.ListadoAutores();
            openChildForm(frmListadoAutores);
            hideSubMenu();
        }

        private void btnListadoLibros_Click(object sender, EventArgs e)
        {
            Views.ListadoLibro frmNuevoLibro = new Views.ListadoLibro();
            openChildForm(frmNuevoLibro);

            hideSubMenu();
        }
        #endregion
        private void btnLectores_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLectoresSubmenu);
        }
        #region LectorSubMenu
        private void btnNuevoLector_Click(object sender, EventArgs e)
        {
            Views.Lectores.NuevoLector frmNuevoLector = new Views.Lectores.NuevoLector();
            openChildForm(frmNuevoLector);
            hideSubMenu();
        }

        private void btnListadoLectores_Click(object sender, EventArgs e)
        {
            Views.Lectores.ListadoLectores frmListadoLectores = new Views.Lectores.ListadoLectores();
            openChildForm(frmListadoLectores);
            hideSubMenu();
        }
        #endregion

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

            hideSubMenu();
        }

        private void btnHomeDevolucion_Click(object sender, EventArgs e)
        {
            Views.Devolucion frmDevolucion = new Views.Devolucion();
            openChildForm(frmDevolucion);

            hideSubMenu();
        }

        private void btnHomePrestamosEnCurso_Click(object sender, EventArgs e)
        {
            Views.PrestamosEnCurso frmPrestamosEnCurso = new Views.PrestamosEnCurso();
            openChildForm(frmPrestamosEnCurso);

            hideSubMenu();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Views.Home home = new Views.Home();
            openChildForm(home);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Views.Home home = new Views.Home();
            openChildForm(home);
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctLogout_MouseEnter(object sender, EventArgs e)
        {
            pctLogout.BackColor = Color.FromArgb(255, 190, 118);
        }

        private void pctLogout_MouseLeave(object sender, EventArgs e)
        {
            pctLogout.BackColor = Color.FromArgb(253, 247, 237);
        }
    }
}
