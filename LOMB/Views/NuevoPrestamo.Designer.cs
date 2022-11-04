
namespace LOMB.Views
{
    partial class NuevoPrestamo
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
            this.cmbBoxEjemplar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbTitleNuevoPrestamo = new System.Windows.Forms.Label();
            this.lbEjemplar = new System.Windows.Forms.Label();
            this.lbLibro = new System.Windows.Forms.Label();
            this.txtBoxLibro = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.cmbBoxLector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBoxOutput = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbLector = new System.Windows.Forms.Label();
            this.listViewResultado = new MaterialSkin.Controls.MaterialListView();
            this.lbFechaDevolucion = new System.Windows.Forms.Label();
            this.lbFechaDate = new System.Windows.Forms.Label();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAniadir = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cmbBoxEjemplar
            // 
            this.cmbBoxEjemplar.BackColor = System.Drawing.Color.Transparent;
            this.cmbBoxEjemplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxEjemplar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBoxEjemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxEjemplar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxEjemplar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxEjemplar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBoxEjemplar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBoxEjemplar.ItemHeight = 30;
            this.cmbBoxEjemplar.Location = new System.Drawing.Point(824, 173);
            this.cmbBoxEjemplar.Name = "cmbBoxEjemplar";
            this.cmbBoxEjemplar.Size = new System.Drawing.Size(243, 36);
            this.cmbBoxEjemplar.TabIndex = 20;
            this.cmbBoxEjemplar.SelectedIndexChanged += new System.EventHandler(this.cmbBoxEjemplar_SelectedIndexChanged);
            // 
            // lbTitleNuevoPrestamo
            // 
            this.lbTitleNuevoPrestamo.AutoSize = true;
            this.lbTitleNuevoPrestamo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleNuevoPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbTitleNuevoPrestamo.Location = new System.Drawing.Point(423, 54);
            this.lbTitleNuevoPrestamo.Name = "lbTitleNuevoPrestamo";
            this.lbTitleNuevoPrestamo.Size = new System.Drawing.Size(338, 54);
            this.lbTitleNuevoPrestamo.TabIndex = 19;
            this.lbTitleNuevoPrestamo.Text = "Nuevo préstamo";
            // 
            // lbEjemplar
            // 
            this.lbEjemplar.AutoSize = true;
            this.lbEjemplar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEjemplar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbEjemplar.Location = new System.Drawing.Point(714, 173);
            this.lbEjemplar.Name = "lbEjemplar";
            this.lbEjemplar.Size = new System.Drawing.Size(95, 28);
            this.lbEjemplar.TabIndex = 17;
            this.lbEjemplar.Text = "Ejemplar";
            // 
            // lbLibro
            // 
            this.lbLibro.AutoSize = true;
            this.lbLibro.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbLibro.Location = new System.Drawing.Point(167, 173);
            this.lbLibro.Name = "lbLibro";
            this.lbLibro.Size = new System.Drawing.Size(60, 28);
            this.lbLibro.TabIndex = 18;
            this.lbLibro.Text = "Libro";
            // 
            // txtBoxLibro
            // 
            this.txtBoxLibro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxLibro.DefaultText = "";
            this.txtBoxLibro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxLibro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxLibro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxLibro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxLibro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxLibro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxLibro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxLibro.Location = new System.Drawing.Point(236, 169);
            this.txtBoxLibro.Name = "txtBoxLibro";
            this.txtBoxLibro.PasswordChar = '\0';
            this.txtBoxLibro.PlaceholderText = "";
            this.txtBoxLibro.SelectedText = "";
            this.txtBoxLibro.Size = new System.Drawing.Size(190, 32);
            this.txtBoxLibro.TabIndex = 16;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbResultado.Location = new System.Drawing.Point(156, 415);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(106, 28);
            this.lbResultado.TabIndex = 18;
            this.lbResultado.Text = "Resultado";
            // 
            // cmbBoxLector
            // 
            this.cmbBoxLector.BackColor = System.Drawing.Color.Transparent;
            this.cmbBoxLector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxLector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBoxLector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxLector.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxLector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxLector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBoxLector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBoxLector.ItemHeight = 30;
            this.cmbBoxLector.Location = new System.Drawing.Point(236, 266);
            this.cmbBoxLector.Name = "cmbBoxLector";
            this.cmbBoxLector.Size = new System.Drawing.Size(161, 36);
            this.cmbBoxLector.TabIndex = 20;
            this.cmbBoxLector.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLector_SelectedIndexChanged);
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxOutput.DefaultText = "USUARIO_LLAMADA_API";
            this.txtBoxOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxOutput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxOutput.Location = new System.Drawing.Point(447, 270);
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.PasswordChar = '\0';
            this.txtBoxOutput.PlaceholderText = "";
            this.txtBoxOutput.SelectedText = "";
            this.txtBoxOutput.Size = new System.Drawing.Size(374, 32);
            this.txtBoxOutput.TabIndex = 16;
            // 
            // lbLector
            // 
            this.lbLector.AutoSize = true;
            this.lbLector.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbLector.Location = new System.Drawing.Point(156, 270);
            this.lbLector.Name = "lbLector";
            this.lbLector.Size = new System.Drawing.Size(71, 28);
            this.lbLector.TabIndex = 18;
            this.lbLector.Text = "Lector";
            // 
            // listViewResultado
            // 
            this.listViewResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewResultado.Depth = 0;
            this.listViewResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewResultado.FullRowSelect = true;
            this.listViewResultado.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewResultado.HideSelection = false;
            this.listViewResultado.Location = new System.Drawing.Point(306, 415);
            this.listViewResultado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewResultado.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewResultado.Name = "listViewResultado";
            this.listViewResultado.OwnerDraw = true;
            this.listViewResultado.Size = new System.Drawing.Size(572, 190);
            this.listViewResultado.TabIndex = 21;
            this.listViewResultado.UseCompatibleStateImageBehavior = false;
            this.listViewResultado.View = System.Windows.Forms.View.Details;
            // 
            // lbFechaDevolucion
            // 
            this.lbFechaDevolucion.AutoSize = true;
            this.lbFechaDevolucion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbFechaDevolucion.Location = new System.Drawing.Point(366, 628);
            this.lbFechaDevolucion.Name = "lbFechaDevolucion";
            this.lbFechaDevolucion.Size = new System.Drawing.Size(210, 28);
            this.lbFechaDevolucion.TabIndex = 18;
            this.lbFechaDevolucion.Text = "Fecha de devolución:";
            // 
            // lbFechaDate
            // 
            this.lbFechaDate.AutoSize = true;
            this.lbFechaDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbFechaDate.Location = new System.Drawing.Point(591, 628);
            this.lbFechaDate.Name = "lbFechaDate";
            this.lbFechaDate.Size = new System.Drawing.Size(206, 28);
            this.lbFechaDate.TabIndex = 18;
            this.lbFechaDate.Text = "FECHA_LLAMADA_API";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnLimpiar.BorderRadius = 10;
            this.btnLimpiar.BorderThickness = 2;
            this.btnLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnLimpiar.Location = new System.Drawing.Point(596, 698);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(153, 44);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            // 
            // btnAniadir
            // 
            this.btnAniadir.BorderRadius = 10;
            this.btnAniadir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAniadir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAniadir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAniadir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAniadir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.btnAniadir.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAniadir.ForeColor = System.Drawing.Color.White;
            this.btnAniadir.Location = new System.Drawing.Point(397, 698);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(161, 44);
            this.btnAniadir.TabIndex = 23;
            this.btnAniadir.Text = "Añadir";
            // 
            // NuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1234, 766);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.listViewResultado);
            this.Controls.Add(this.cmbBoxLector);
            this.Controls.Add(this.cmbBoxEjemplar);
            this.Controls.Add(this.lbTitleNuevoPrestamo);
            this.Controls.Add(this.lbEjemplar);
            this.Controls.Add(this.lbLector);
            this.Controls.Add(this.lbFechaDevolucion);
            this.Controls.Add(this.lbFechaDate);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbLibro);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.txtBoxLibro);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "NuevoPrestamo";
            this.Text = "NuevoPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbBoxEjemplar;
        private System.Windows.Forms.Label lbTitleNuevoPrestamo;
        private System.Windows.Forms.Label lbEjemplar;
        private System.Windows.Forms.Label lbLibro;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxLibro;
        private System.Windows.Forms.Label lbResultado;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBoxLector;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxOutput;
        private System.Windows.Forms.Label lbLector;
        private MaterialSkin.Controls.MaterialListView listViewResultado;
        private System.Windows.Forms.Label lbFechaDevolucion;
        private System.Windows.Forms.Label lbFechaDate;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnAniadir;
    }
}