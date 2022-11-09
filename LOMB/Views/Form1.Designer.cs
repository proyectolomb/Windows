
namespace LOMB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.pctLogout = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLectoresSubmenu = new System.Windows.Forms.Panel();
            this.btnListadoLectores = new System.Windows.Forms.Button();
            this.btnNuevoLector = new System.Windows.Forms.Button();
            this.btnLectores = new System.Windows.Forms.Button();
            this.panelLibrosSubmenu = new System.Windows.Forms.Panel();
            this.btnListadoLibros = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnNuevoLibro = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.panelPrestamosSubmenu = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnEnCurso = new System.Windows.Forms.Button();
            this.btnNuevoPrestamo = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogout)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelLectoresSubmenu.SuspendLayout();
            this.panelLibrosSubmenu.SuspendLayout();
            this.panelPrestamosSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.panelSideMenu.Controls.Add(this.panel2);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.panelLectoresSubmenu);
            this.panelSideMenu.Controls.Add(this.btnLectores);
            this.panelSideMenu.Controls.Add(this.panelLibrosSubmenu);
            this.panelSideMenu.Controls.Add(this.btnLibros);
            this.panelSideMenu.Controls.Add(this.panelPrestamosSubmenu);
            this.panelSideMenu.Controls.Add(this.btnPrestamo);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(207, 817);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pctUsuario);
            this.panel2.Controls.Add(this.pctLogout);
            this.panel2.Controls.Add(this.lbUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 59);
            this.panel2.TabIndex = 8;
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pctUsuario.Image")));
            this.pctUsuario.Location = new System.Drawing.Point(5, 18);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(24, 30);
            this.pctUsuario.TabIndex = 10;
            this.pctUsuario.TabStop = false;
            // 
            // pctLogout
            // 
            this.pctLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctLogout.Image = ((System.Drawing.Image)(resources.GetObject("pctLogout.Image")));
            this.pctLogout.Location = new System.Drawing.Point(168, 16);
            this.pctLogout.Name = "pctLogout";
            this.pctLogout.Size = new System.Drawing.Size(33, 30);
            this.pctLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctLogout.TabIndex = 0;
            this.pctLogout.TabStop = false;
            this.pctLogout.MouseEnter += new System.EventHandler(this.pctLogout_MouseEnter);
            this.pctLogout.MouseLeave += new System.EventHandler(this.pctLogout_MouseLeave);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbUsuario.Location = new System.Drawing.Point(33, 21);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(107, 20);
            this.lbUsuario.TabIndex = 9;
            this.lbUsuario.Text = "USUARIO_API";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 619);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 66);
            this.panel1.TabIndex = 7;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(207, 45);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Menú principal";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLectoresSubmenu
            // 
            this.panelLectoresSubmenu.AccessibleDescription = "Prestamos";
            this.panelLectoresSubmenu.BackColor = System.Drawing.Color.White;
            this.panelLectoresSubmenu.Controls.Add(this.btnListadoLectores);
            this.panelLectoresSubmenu.Controls.Add(this.btnNuevoLector);
            this.panelLectoresSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLectoresSubmenu.Location = new System.Drawing.Point(0, 421);
            this.panelLectoresSubmenu.Name = "panelLectoresSubmenu";
            this.panelLectoresSubmenu.Size = new System.Drawing.Size(207, 85);
            this.panelLectoresSubmenu.TabIndex = 6;
            // 
            // btnListadoLectores
            // 
            this.btnListadoLectores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListadoLectores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListadoLectores.FlatAppearance.BorderSize = 0;
            this.btnListadoLectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoLectores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoLectores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnListadoLectores.Location = new System.Drawing.Point(0, 40);
            this.btnListadoLectores.Name = "btnListadoLectores";
            this.btnListadoLectores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListadoLectores.Size = new System.Drawing.Size(207, 40);
            this.btnListadoLectores.TabIndex = 1;
            this.btnListadoLectores.Text = "Listado de lectores";
            this.btnListadoLectores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoLectores.UseVisualStyleBackColor = true;
            this.btnListadoLectores.Click += new System.EventHandler(this.btnListadoLectores_Click);
            // 
            // btnNuevoLector
            // 
            this.btnNuevoLector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoLector.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoLector.FlatAppearance.BorderSize = 0;
            this.btnNuevoLector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoLector.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoLector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnNuevoLector.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoLector.Name = "btnNuevoLector";
            this.btnNuevoLector.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNuevoLector.Size = new System.Drawing.Size(207, 40);
            this.btnNuevoLector.TabIndex = 0;
            this.btnNuevoLector.Text = "Nuevo lector";
            this.btnNuevoLector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoLector.UseVisualStyleBackColor = true;
            this.btnNuevoLector.Click += new System.EventHandler(this.btnNuevoLector_Click);
            // 
            // btnLectores
            // 
            this.btnLectores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLectores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLectores.FlatAppearance.BorderSize = 0;
            this.btnLectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLectores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLectores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnLectores.Location = new System.Drawing.Point(0, 376);
            this.btnLectores.Name = "btnLectores";
            this.btnLectores.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLectores.Size = new System.Drawing.Size(207, 45);
            this.btnLectores.TabIndex = 5;
            this.btnLectores.Text = "Lectores";
            this.btnLectores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLectores.UseVisualStyleBackColor = true;
            this.btnLectores.Click += new System.EventHandler(this.btnLectores_Click);
            // 
            // panelLibrosSubmenu
            // 
            this.panelLibrosSubmenu.AccessibleDescription = "Prestamos";
            this.panelLibrosSubmenu.BackColor = System.Drawing.Color.White;
            this.panelLibrosSubmenu.Controls.Add(this.btnListadoLibros);
            this.panelLibrosSubmenu.Controls.Add(this.btnAutores);
            this.panelLibrosSubmenu.Controls.Add(this.btnNuevoLibro);
            this.panelLibrosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLibrosSubmenu.Location = new System.Drawing.Point(0, 253);
            this.panelLibrosSubmenu.Name = "panelLibrosSubmenu";
            this.panelLibrosSubmenu.Size = new System.Drawing.Size(207, 123);
            this.panelLibrosSubmenu.TabIndex = 4;
            // 
            // btnListadoLibros
            // 
            this.btnListadoLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListadoLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListadoLibros.FlatAppearance.BorderSize = 0;
            this.btnListadoLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoLibros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnListadoLibros.Location = new System.Drawing.Point(0, 80);
            this.btnListadoLibros.Name = "btnListadoLibros";
            this.btnListadoLibros.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListadoLibros.Size = new System.Drawing.Size(207, 40);
            this.btnListadoLibros.TabIndex = 2;
            this.btnListadoLibros.Text = "Listado de libros";
            this.btnListadoLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoLibros.UseVisualStyleBackColor = true;
            this.btnListadoLibros.Click += new System.EventHandler(this.btnListadoLibros_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutores.FlatAppearance.BorderSize = 0;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnAutores.Location = new System.Drawing.Point(0, 40);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAutores.Size = new System.Drawing.Size(207, 40);
            this.btnAutores.TabIndex = 1;
            this.btnAutores.Text = "Autores";
            this.btnAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnNuevoLibro
            // 
            this.btnNuevoLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoLibro.FlatAppearance.BorderSize = 0;
            this.btnNuevoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoLibro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnNuevoLibro.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoLibro.Name = "btnNuevoLibro";
            this.btnNuevoLibro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNuevoLibro.Size = new System.Drawing.Size(207, 40);
            this.btnNuevoLibro.TabIndex = 0;
            this.btnNuevoLibro.Text = "Nuevo libro";
            this.btnNuevoLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoLibro.UseVisualStyleBackColor = true;
            this.btnNuevoLibro.Click += new System.EventHandler(this.btnNuevoLibro_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnLibros.Location = new System.Drawing.Point(0, 208);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLibros.Size = new System.Drawing.Size(207, 45);
            this.btnLibros.TabIndex = 3;
            this.btnLibros.Text = "Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // panelPrestamosSubmenu
            // 
            this.panelPrestamosSubmenu.AccessibleDescription = "Prestamos";
            this.panelPrestamosSubmenu.BackColor = System.Drawing.Color.White;
            this.panelPrestamosSubmenu.Controls.Add(this.btnHistorial);
            this.panelPrestamosSubmenu.Controls.Add(this.btnDevolucion);
            this.panelPrestamosSubmenu.Controls.Add(this.btnEnCurso);
            this.panelPrestamosSubmenu.Controls.Add(this.btnNuevoPrestamo);
            this.panelPrestamosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrestamosSubmenu.Location = new System.Drawing.Point(0, 45);
            this.panelPrestamosSubmenu.Name = "panelPrestamosSubmenu";
            this.panelPrestamosSubmenu.Size = new System.Drawing.Size(207, 163);
            this.panelPrestamosSubmenu.TabIndex = 2;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnHistorial.Location = new System.Drawing.Point(0, 120);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHistorial.Size = new System.Drawing.Size(207, 40);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevolucion.FlatAppearance.BorderSize = 0;
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnDevolucion.Location = new System.Drawing.Point(0, 80);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDevolucion.Size = new System.Drawing.Size(207, 40);
            this.btnDevolucion.TabIndex = 2;
            this.btnDevolucion.Text = "Devolución";
            this.btnDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnEnCurso
            // 
            this.btnEnCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnCurso.FlatAppearance.BorderSize = 0;
            this.btnEnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnCurso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnEnCurso.Location = new System.Drawing.Point(0, 40);
            this.btnEnCurso.Name = "btnEnCurso";
            this.btnEnCurso.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEnCurso.Size = new System.Drawing.Size(207, 40);
            this.btnEnCurso.TabIndex = 1;
            this.btnEnCurso.Text = "En curso";
            this.btnEnCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnCurso.UseVisualStyleBackColor = true;
            this.btnEnCurso.Click += new System.EventHandler(this.btnEnCurso_Click);
            // 
            // btnNuevoPrestamo
            // 
            this.btnNuevoPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPrestamo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoPrestamo.FlatAppearance.BorderSize = 0;
            this.btnNuevoPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPrestamo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnNuevoPrestamo.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            this.btnNuevoPrestamo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNuevoPrestamo.Size = new System.Drawing.Size(207, 40);
            this.btnNuevoPrestamo.TabIndex = 0;
            this.btnNuevoPrestamo.Text = "Nuevo préstamo";
            this.btnNuevoPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPrestamo.UseVisualStyleBackColor = true;
            this.btnNuevoPrestamo.Click += new System.EventHandler(this.btnNuevoPrestamo_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrestamo.FlatAppearance.BorderSize = 0;
            this.btnPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnPrestamo.Location = new System.Drawing.Point(0, 0);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPrestamo.Size = new System.Drawing.Size(207, 45);
            this.btnPrestamo.TabIndex = 1;
            this.btnPrestamo.Text = "Préstamos";
            this.btnPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogo.Location = new System.Drawing.Point(0, 685);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(207, 132);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(181)))));
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(207, 0);
            this.panelHome.MinimumSize = new System.Drawing.Size(727, 678);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1189, 817);
            this.panelHome.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 817);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComercioTeca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogout)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelLectoresSubmenu.ResumeLayout(false);
            this.panelLibrosSubmenu.ResumeLayout(false);
            this.panelPrestamosSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelPrestamosSubmenu;
        private System.Windows.Forms.Button btnNuevoPrestamo;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnEnCurso;
        private System.Windows.Forms.Panel panelLibrosSubmenu;
        private System.Windows.Forms.Button btnListadoLibros;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnNuevoLibro;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Panel panelLectoresSubmenu;
        private System.Windows.Forms.Button btnListadoLectores;
        private System.Windows.Forms.Button btnNuevoLector;
        private System.Windows.Forms.Button btnLectores;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.PictureBox pctLogout;
        private System.Windows.Forms.PictureBox pctUsuario;
    }
}

