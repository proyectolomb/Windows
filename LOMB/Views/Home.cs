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
    /// <summary>Ventana principal. Contiene el menú y  un formulario hijo en el que se abren el resto de ventanas.</summary>
    public partial class Home : Form
    {
        /// <summary>constructor para inicializar la home.</summary>
        public Home()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        /// <summary>Abre el formulario pasado por parámetro en el formulario hijo.</summary>
        /// <param name="childForm">Formulario a abrir.</param>
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

        /// <summary>Método que se ejecuta cuando se hace clic en el botón de "Nuevo préstamo"</summary>
        /// <param name="sender">Objeto que envía el evento</param>
        /// <param name="e">
        ///   <para>
        /// Argumentos del evento</para>
        /// </param>
        private void btnHomeNuevoPrestamo_Click(object sender, EventArgs e)
        {
            Views.NuevoPrestamo frmNuevoPrestamo = new Views.NuevoPrestamo();
            openChildForm(frmNuevoPrestamo);
        }

        /// <summary>Método que se ejecuta cuando se hace clic en el botón de "Devolución"</summary>
        /// <param name="sender">Objeto que envía el evento</param>
        /// <param name="e">
        ///   <para>
        /// Argumentos del evento</para>
        /// </param>
        private void btnHomeDevolucion_Click(object sender, EventArgs e)
        {
            Views.Devolucion frmDevolucion = new Views.Devolucion();
            openChildForm(frmDevolucion);
        }

        /// <summary>Método que se ejecuta cuando se hace clic en el botón de "Préstamos en curso"</summary>
        /// <param name="sender">Objeto que envía el evento</param>
        /// <param name="e">
        ///   <para>
        /// Argumentos del evento</para>
        /// </param>
        private void btnHomePrestamosEnCurso_Click(object sender, EventArgs e)
        {
            Views.PrestamosEnCurso frmPrestamosEnCurso = new Views.PrestamosEnCurso();
            openChildForm(frmPrestamosEnCurso);
        }
    }
}
