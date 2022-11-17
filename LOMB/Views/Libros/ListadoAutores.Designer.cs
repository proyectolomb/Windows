
namespace LOMB.Views.Libros
{
    partial class ListadoAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoAutores));
            this.matListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTitleAutores = new System.Windows.Forms.Label();
            this.lbFiltros = new System.Windows.Forms.Label();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAplicar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbEntidad = new System.Windows.Forms.Label();
            this.radBtnEntidad = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.lbPersona = new System.Windows.Forms.Label();
            this.radBtnPersona = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cmbBoxCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbLector = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtBoxApellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matListView
            // 
            this.matListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.matListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.matListView.Depth = 0;
            this.matListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.matListView.FullRowSelect = true;
            this.matListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.matListView.HideSelection = false;
            this.matListView.Location = new System.Drawing.Point(59, 268);
            this.matListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matListView.MouseState = MaterialSkin.MouseState.OUT;
            this.matListView.Name = "matListView";
            this.matListView.OwnerDraw = true;
            this.matListView.Size = new System.Drawing.Size(946, 489);
            this.matListView.TabIndex = 34;
            this.matListView.UseCompatibleStateImageBehavior = false;
            this.matListView.View = System.Windows.Forms.View.Details;
            this.matListView.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "País origen";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Categoría";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Editorial";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // lbTitleAutores
            // 
            this.lbTitleAutores.AutoSize = true;
            this.lbTitleAutores.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleAutores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbTitleAutores.Location = new System.Drawing.Point(497, 24);
            this.lbTitleAutores.Name = "lbTitleAutores";
            this.lbTitleAutores.Size = new System.Drawing.Size(171, 54);
            this.lbTitleAutores.TabIndex = 33;
            this.lbTitleAutores.Text = "Autores";
            // 
            // lbFiltros
            // 
            this.lbFiltros.AutoSize = true;
            this.lbFiltros.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbFiltros.Location = new System.Drawing.Point(76, 111);
            this.lbFiltros.Name = "lbFiltros";
            this.lbFiltros.Size = new System.Drawing.Size(71, 28);
            this.lbFiltros.TabIndex = 32;
            this.lbFiltros.Text = "Filtros";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BorderRadius = 10;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnLimpiar.Location = new System.Drawing.Point(352, 102);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 37);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.BorderRadius = 10;
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAplicar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAplicar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAplicar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAplicar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.btnAplicar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.Location = new System.Drawing.Point(196, 102);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(129, 37);
            this.btnAplicar.TabIndex = 30;
            this.btnAplicar.Text = "Aplicar";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.lbEntidad);
            this.guna2Panel1.Controls.Add(this.radBtnEntidad);
            this.guna2Panel1.Controls.Add(this.lbPersona);
            this.guna2Panel1.Controls.Add(this.radBtnPersona);
            this.guna2Panel1.Controls.Add(this.cmbBoxCategoria);
            this.guna2Panel1.Controls.Add(this.lbCategoria);
            this.guna2Panel1.Controls.Add(this.lbLector);
            this.guna2Panel1.Controls.Add(this.lbNombre);
            this.guna2Panel1.Controls.Add(this.txtBoxApellidos);
            this.guna2Panel1.Controls.Add(this.txtBoxNombre);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2Panel1.Location = new System.Drawing.Point(59, 145);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(666, 113);
            this.guna2Panel1.TabIndex = 31;
            // 
            // lbEntidad
            // 
            this.lbEntidad.AutoSize = true;
            this.lbEntidad.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbEntidad.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEntidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbEntidad.Location = new System.Drawing.Point(194, 63);
            this.lbEntidad.Name = "lbEntidad";
            this.lbEntidad.Size = new System.Drawing.Size(84, 28);
            this.lbEntidad.TabIndex = 35;
            this.lbEntidad.Text = "Entidad";
            // 
            // radBtnEntidad
            // 
            this.radBtnEntidad.Animated = true;
            this.radBtnEntidad.BackColor = System.Drawing.Color.Transparent;
            this.radBtnEntidad.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.radBtnEntidad.CheckedState.BorderThickness = 0;
            this.radBtnEntidad.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.radBtnEntidad.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radBtnEntidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radBtnEntidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.radBtnEntidad.Location = new System.Drawing.Point(168, 69);
            this.radBtnEntidad.Name = "radBtnEntidad";
            this.radBtnEntidad.Size = new System.Drawing.Size(20, 20);
            this.radBtnEntidad.TabIndex = 34;
            this.radBtnEntidad.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radBtnEntidad.UncheckedState.BorderThickness = 2;
            this.radBtnEntidad.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radBtnEntidad.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lbPersona
            // 
            this.lbPersona.AutoSize = true;
            this.lbPersona.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbPersona.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbPersona.Location = new System.Drawing.Point(56, 63);
            this.lbPersona.Name = "lbPersona";
            this.lbPersona.Size = new System.Drawing.Size(86, 28);
            this.lbPersona.TabIndex = 33;
            this.lbPersona.Text = "Persona";
            // 
            // radBtnPersona
            // 
            this.radBtnPersona.Animated = true;
            this.radBtnPersona.BackColor = System.Drawing.Color.Transparent;
            this.radBtnPersona.Checked = true;
            this.radBtnPersona.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.radBtnPersona.CheckedState.BorderThickness = 0;
            this.radBtnPersona.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.radBtnPersona.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radBtnPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radBtnPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.radBtnPersona.Location = new System.Drawing.Point(30, 69);
            this.radBtnPersona.Name = "radBtnPersona";
            this.radBtnPersona.Size = new System.Drawing.Size(20, 20);
            this.radBtnPersona.TabIndex = 32;
            this.radBtnPersona.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radBtnPersona.UncheckedState.BorderThickness = 2;
            this.radBtnPersona.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radBtnPersona.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
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
            this.cmbBoxCategoria.Location = new System.Drawing.Point(446, 65);
            this.cmbBoxCategoria.Name = "cmbBoxCategoria";
            this.cmbBoxCategoria.Size = new System.Drawing.Size(190, 36);
            this.cmbBoxCategoria.TabIndex = 31;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbCategoria.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbCategoria.Location = new System.Drawing.Point(337, 69);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(103, 28);
            this.lbCategoria.TabIndex = 30;
            this.lbCategoria.Text = "Categoría";
            // 
            // lbLector
            // 
            this.lbLector.AutoSize = true;
            this.lbLector.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbLector.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbLector.Location = new System.Drawing.Point(340, 22);
            this.lbLector.Name = "lbLector";
            this.lbLector.Size = new System.Drawing.Size(100, 28);
            this.lbLector.TabIndex = 8;
            this.lbLector.Text = "Apellidos";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbNombre.Location = new System.Drawing.Point(25, 22);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(89, 28);
            this.lbNombre.TabIndex = 8;
            this.lbNombre.Text = "Nombre";
            // 
            // txtBoxApellidos
            // 
            this.txtBoxApellidos.BorderRadius = 5;
            this.txtBoxApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxApellidos.DefaultText = "";
            this.txtBoxApellidos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxApellidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxApellidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxApellidos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxApellidos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxApellidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxApellidos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxApellidos.Location = new System.Drawing.Point(446, 18);
            this.txtBoxApellidos.Name = "txtBoxApellidos";
            this.txtBoxApellidos.PasswordChar = '\0';
            this.txtBoxApellidos.PlaceholderText = "";
            this.txtBoxApellidos.SelectedText = "";
            this.txtBoxApellidos.Size = new System.Drawing.Size(190, 32);
            this.txtBoxApellidos.TabIndex = 6;
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
            this.txtBoxNombre.Location = new System.Drawing.Point(120, 18);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.PasswordChar = '\0';
            this.txtBoxNombre.PlaceholderText = "";
            this.txtBoxNombre.SelectedText = "";
            this.txtBoxNombre.Size = new System.Drawing.Size(190, 32);
            this.txtBoxNombre.TabIndex = 6;
            // 
            // guna2Button11
            // 
            this.guna2Button11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button11.AnimatedGIF = true;
            this.guna2Button11.BorderRadius = 10;
            this.guna2Button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.guna2Button11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button11.ForeColor = System.Drawing.Color.White;
            this.guna2Button11.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button11.Image")));
            this.guna2Button11.Location = new System.Drawing.Point(1071, 662);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.Size = new System.Drawing.Size(43, 45);
            this.guna2Button11.TabIndex = 46;
            // 
            // guna2Button12
            // 
            this.guna2Button12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button12.AnimatedGIF = true;
            this.guna2Button12.BorderRadius = 10;
            this.guna2Button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button12.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.guna2Button12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button12.ForeColor = System.Drawing.Color.White;
            this.guna2Button12.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button12.Image")));
            this.guna2Button12.Location = new System.Drawing.Point(1021, 662);
            this.guna2Button12.Name = "guna2Button12";
            this.guna2Button12.Size = new System.Drawing.Size(43, 45);
            this.guna2Button12.TabIndex = 45;
            // 
            // guna2Button9
            // 
            this.guna2Button9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button9.AnimatedGIF = true;
            this.guna2Button9.BorderRadius = 10;
            this.guna2Button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button9.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button9.Image")));
            this.guna2Button9.Location = new System.Drawing.Point(1071, 592);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Size = new System.Drawing.Size(43, 45);
            this.guna2Button9.TabIndex = 44;
            // 
            // guna2Button10
            // 
            this.guna2Button10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button10.AnimatedGIF = true;
            this.guna2Button10.BorderRadius = 10;
            this.guna2Button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.guna2Button10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button10.ForeColor = System.Drawing.Color.White;
            this.guna2Button10.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button10.Image")));
            this.guna2Button10.Location = new System.Drawing.Point(1021, 592);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.Size = new System.Drawing.Size(43, 45);
            this.guna2Button10.TabIndex = 43;
            // 
            // guna2Button7
            // 
            this.guna2Button7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button7.AnimatedGIF = true;
            this.guna2Button7.BorderRadius = 10;
            this.guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button7.Image")));
            this.guna2Button7.Location = new System.Drawing.Point(1071, 524);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(43, 45);
            this.guna2Button7.TabIndex = 42;
            // 
            // guna2Button8
            // 
            this.guna2Button8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button8.AnimatedGIF = true;
            this.guna2Button8.BorderRadius = 10;
            this.guna2Button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button8.Image")));
            this.guna2Button8.Location = new System.Drawing.Point(1021, 524);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(43, 45);
            this.guna2Button8.TabIndex = 41;
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button5.AnimatedGIF = true;
            this.guna2Button5.BorderRadius = 10;
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.Location = new System.Drawing.Point(1071, 458);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(43, 45);
            this.guna2Button5.TabIndex = 40;
            // 
            // guna2Button6
            // 
            this.guna2Button6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button6.AnimatedGIF = true;
            this.guna2Button6.BorderRadius = 10;
            this.guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button6.Image")));
            this.guna2Button6.Location = new System.Drawing.Point(1021, 458);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(43, 45);
            this.guna2Button6.TabIndex = 39;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button3.AnimatedGIF = true;
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.Location = new System.Drawing.Point(1071, 389);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(43, 45);
            this.guna2Button3.TabIndex = 38;
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button4.AnimatedGIF = true;
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.Location = new System.Drawing.Point(1021, 389);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(43, 45);
            this.guna2Button4.TabIndex = 37;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button2.AnimatedGIF = true;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Location = new System.Drawing.Point(1071, 318);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(43, 45);
            this.guna2Button2.TabIndex = 36;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button1.AnimatedGIF = true;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(1021, 318);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(43, 45);
            this.guna2Button1.TabIndex = 35;
            // 
            // ListadoAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1173, 778);
            this.Controls.Add(this.guna2Button11);
            this.Controls.Add(this.guna2Button12);
            this.Controls.Add(this.guna2Button9);
            this.Controls.Add(this.guna2Button10);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.guna2Button8);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.matListView);
            this.Controls.Add(this.lbTitleAutores);
            this.Controls.Add(this.lbFiltros);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ListadoAutores";
            this.Text = "ListadoAutores";
            this.Load += new System.EventHandler(this.ListadoAutores_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2Button guna2Button12;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private MaterialSkin.Controls.MaterialListView matListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbTitleAutores;
        private System.Windows.Forms.Label lbFiltros;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnAplicar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbLector;
        private System.Windows.Forms.Label lbNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxApellidos;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxNombre;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBoxCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radBtnPersona;
        private System.Windows.Forms.Label lbPersona;
        private System.Windows.Forms.Label lbEntidad;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radBtnEntidad;
    }
}