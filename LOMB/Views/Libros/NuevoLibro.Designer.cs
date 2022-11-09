
namespace LOMB.Views
{
    partial class NuevoLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbBoxAutor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbTitleNuevoPrestamo = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbIsbn = new System.Windows.Forms.Label();
            this.txtBoxIsbn = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbBoxCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbEditorial = new System.Windows.Forms.Label();
            this.txtBoxEditorial = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbFechaPublicacion = new System.Windows.Forms.Label();
            this.lbIdioma = new System.Windows.Forms.Label();
            this.cmbBoxIdioma = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAniadir = new Guna.UI2.WinForms.Guna2Button();
            this.lbEjemplar = new System.Windows.Forms.Label();
            this.btnNuevoEjemplar = new Guna.UI2.WinForms.Guna2Button();
            this.dateNacimiento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // cmbBoxAutor
            // 
            this.cmbBoxAutor.BackColor = System.Drawing.Color.Transparent;
            this.cmbBoxAutor.BorderRadius = 5;
            this.cmbBoxAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxAutor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBoxAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxAutor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxAutor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxAutor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBoxAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBoxAutor.ItemHeight = 30;
            this.cmbBoxAutor.Items.AddRange(new object[] {
            "Miguel de Cervantes",
            "Unamuno",
            "Melendi"});
            this.cmbBoxAutor.Location = new System.Drawing.Point(272, 305);
            this.cmbBoxAutor.Name = "cmbBoxAutor";
            this.cmbBoxAutor.Size = new System.Drawing.Size(243, 36);
            this.cmbBoxAutor.TabIndex = 25;
            // 
            // lbTitleNuevoPrestamo
            // 
            this.lbTitleNuevoPrestamo.AutoSize = true;
            this.lbTitleNuevoPrestamo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleNuevoPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbTitleNuevoPrestamo.Location = new System.Drawing.Point(444, 44);
            this.lbTitleNuevoPrestamo.Name = "lbTitleNuevoPrestamo";
            this.lbTitleNuevoPrestamo.Size = new System.Drawing.Size(245, 54);
            this.lbTitleNuevoPrestamo.TabIndex = 24;
            this.lbTitleNuevoPrestamo.Text = "Nuevo libro";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbAutor.Location = new System.Drawing.Point(195, 305);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(66, 28);
            this.lbAutor.TabIndex = 22;
            this.lbAutor.Text = "Autor";
            // 
            // lbIsbn
            // 
            this.lbIsbn.AutoSize = true;
            this.lbIsbn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbIsbn.Location = new System.Drawing.Point(203, 178);
            this.lbIsbn.Name = "lbIsbn";
            this.lbIsbn.Size = new System.Drawing.Size(58, 28);
            this.lbIsbn.TabIndex = 23;
            this.lbIsbn.Text = "ISBN";
            // 
            // txtBoxIsbn
            // 
            this.txtBoxIsbn.BorderRadius = 5;
            this.txtBoxIsbn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxIsbn.DefaultText = "";
            this.txtBoxIsbn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxIsbn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxIsbn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxIsbn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxIsbn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxIsbn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxIsbn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxIsbn.Location = new System.Drawing.Point(272, 174);
            this.txtBoxIsbn.Name = "txtBoxIsbn";
            this.txtBoxIsbn.PasswordChar = '\0';
            this.txtBoxIsbn.PlaceholderText = "";
            this.txtBoxIsbn.SelectedText = "";
            this.txtBoxIsbn.Size = new System.Drawing.Size(243, 32);
            this.txtBoxIsbn.TabIndex = 21;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbNombre.Location = new System.Drawing.Point(634, 174);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(89, 28);
            this.lbNombre.TabIndex = 27;
            this.lbNombre.Text = "Nombre";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BorderRadius = 5;
            this.txtBoxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxNombre.DefaultText = "";
            this.txtBoxNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxNombre.Location = new System.Drawing.Point(733, 174);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.PasswordChar = '\0';
            this.txtBoxNombre.PlaceholderText = "";
            this.txtBoxNombre.SelectedText = "";
            this.txtBoxNombre.Size = new System.Drawing.Size(243, 32);
            this.txtBoxNombre.TabIndex = 26;
            // 
            // cmbBoxCategoria
            // 
            this.cmbBoxCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cmbBoxCategoria.BorderRadius = 5;
            this.cmbBoxCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBoxCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBoxCategoria.ItemHeight = 30;
            this.cmbBoxCategoria.Items.AddRange(new object[] {
            "Novela",
            "Ciencia Ficción",
            "Aventura",
            "Humor"});
            this.cmbBoxCategoria.Location = new System.Drawing.Point(733, 301);
            this.cmbBoxCategoria.Name = "cmbBoxCategoria";
            this.cmbBoxCategoria.Size = new System.Drawing.Size(243, 36);
            this.cmbBoxCategoria.TabIndex = 29;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbCategoria.Location = new System.Drawing.Point(624, 305);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(103, 28);
            this.lbCategoria.TabIndex = 28;
            this.lbCategoria.Text = "Categoría";
            // 
            // lbEditorial
            // 
            this.lbEditorial.AutoSize = true;
            this.lbEditorial.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbEditorial.Location = new System.Drawing.Point(169, 434);
            this.lbEditorial.Name = "lbEditorial";
            this.lbEditorial.Size = new System.Drawing.Size(92, 28);
            this.lbEditorial.TabIndex = 31;
            this.lbEditorial.Text = "Editorial";
            // 
            // txtBoxEditorial
            // 
            this.txtBoxEditorial.BorderRadius = 5;
            this.txtBoxEditorial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEditorial.DefaultText = "";
            this.txtBoxEditorial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEditorial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEditorial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEditorial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEditorial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEditorial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxEditorial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEditorial.Location = new System.Drawing.Point(272, 430);
            this.txtBoxEditorial.Name = "txtBoxEditorial";
            this.txtBoxEditorial.PasswordChar = '\0';
            this.txtBoxEditorial.PlaceholderText = "";
            this.txtBoxEditorial.SelectedText = "";
            this.txtBoxEditorial.Size = new System.Drawing.Size(243, 32);
            this.txtBoxEditorial.TabIndex = 30;
            // 
            // lbFechaPublicacion
            // 
            this.lbFechaPublicacion.AutoSize = true;
            this.lbFechaPublicacion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaPublicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbFechaPublicacion.Location = new System.Drawing.Point(51, 546);
            this.lbFechaPublicacion.Name = "lbFechaPublicacion";
            this.lbFechaPublicacion.Size = new System.Drawing.Size(210, 28);
            this.lbFechaPublicacion.TabIndex = 33;
            this.lbFechaPublicacion.Text = "Fecha de publicacion";
            // 
            // lbIdioma
            // 
            this.lbIdioma.AutoSize = true;
            this.lbIdioma.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbIdioma.Location = new System.Drawing.Point(630, 546);
            this.lbIdioma.Name = "lbIdioma";
            this.lbIdioma.Size = new System.Drawing.Size(77, 28);
            this.lbIdioma.TabIndex = 35;
            this.lbIdioma.Text = "Idioma";
            // 
            // cmbBoxIdioma
            // 
            this.cmbBoxIdioma.BackColor = System.Drawing.Color.Transparent;
            this.cmbBoxIdioma.BorderRadius = 5;
            this.cmbBoxIdioma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxIdioma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBoxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxIdioma.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxIdioma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxIdioma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBoxIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBoxIdioma.ItemHeight = 30;
            this.cmbBoxIdioma.Items.AddRange(new object[] {
            "Español",
            "Inglés",
            "Francés"});
            this.cmbBoxIdioma.Location = new System.Drawing.Point(733, 546);
            this.cmbBoxIdioma.Name = "cmbBoxIdioma";
            this.cmbBoxIdioma.Size = new System.Drawing.Size(243, 36);
            this.cmbBoxIdioma.TabIndex = 36;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnLimpiar.BorderRadius = 10;
            this.btnLimpiar.BorderThickness = 2;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnLimpiar.Location = new System.Drawing.Point(594, 659);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(153, 44);
            this.btnLimpiar.TabIndex = 37;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAniadir
            // 
            this.btnAniadir.BorderRadius = 10;
            this.btnAniadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAniadir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAniadir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAniadir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAniadir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAniadir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.btnAniadir.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAniadir.ForeColor = System.Drawing.Color.White;
            this.btnAniadir.Location = new System.Drawing.Point(395, 659);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(161, 44);
            this.btnAniadir.TabIndex = 38;
            this.btnAniadir.Text = "Añadir";
            // 
            // lbEjemplar
            // 
            this.lbEjemplar.AutoSize = true;
            this.lbEjemplar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEjemplar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbEjemplar.Location = new System.Drawing.Point(624, 430);
            this.lbEjemplar.Name = "lbEjemplar";
            this.lbEjemplar.Size = new System.Drawing.Size(95, 28);
            this.lbEjemplar.TabIndex = 39;
            this.lbEjemplar.Text = "Ejemplar";
            // 
            // btnNuevoEjemplar
            // 
            this.btnNuevoEjemplar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnNuevoEjemplar.BorderRadius = 20;
            this.btnNuevoEjemplar.BorderThickness = 2;
            this.btnNuevoEjemplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEjemplar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoEjemplar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoEjemplar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevoEjemplar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevoEjemplar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.btnNuevoEjemplar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnNuevoEjemplar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnNuevoEjemplar.Location = new System.Drawing.Point(750, 426);
            this.btnNuevoEjemplar.Name = "btnNuevoEjemplar";
            this.btnNuevoEjemplar.Size = new System.Drawing.Size(214, 44);
            this.btnNuevoEjemplar.TabIndex = 40;
            this.btnNuevoEjemplar.Text = "Nuevo ejemplar";
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Animated = true;
            this.dateNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.dateNacimiento.BorderColor = System.Drawing.Color.White;
            this.dateNacimiento.BorderRadius = 5;
            this.dateNacimiento.FillColor = System.Drawing.Color.White;
            this.dateNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateNacimiento.Location = new System.Drawing.Point(272, 546);
            this.dateNacimiento.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.dateNacimiento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(243, 36);
            this.dateNacimiento.TabIndex = 48;
            this.dateNacimiento.Value = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            // 
            // NuevoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1173, 778);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.btnNuevoEjemplar);
            this.Controls.Add(this.lbEjemplar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.cmbBoxIdioma);
            this.Controls.Add(this.lbIdioma);
            this.Controls.Add(this.lbFechaPublicacion);
            this.Controls.Add(this.lbEditorial);
            this.Controls.Add(this.txtBoxEditorial);
            this.Controls.Add(this.cmbBoxCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.cmbBoxAutor);
            this.Controls.Add(this.lbTitleNuevoPrestamo);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbIsbn);
            this.Controls.Add(this.txtBoxIsbn);
            this.Name = "NuevoLibro";
            this.Text = "NuevoLibro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbBoxAutor;
        private System.Windows.Forms.Label lbTitleNuevoPrestamo;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbIsbn;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxIsbn;
        private System.Windows.Forms.Label lbNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxNombre;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBoxCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbEditorial;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEditorial;
        private System.Windows.Forms.Label lbFechaPublicacion;
        private System.Windows.Forms.Label lbIdioma;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBoxIdioma;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnAniadir;
        private System.Windows.Forms.Label lbEjemplar;
        private Guna.UI2.WinForms.Guna2Button btnNuevoEjemplar;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNacimiento;
    }
}