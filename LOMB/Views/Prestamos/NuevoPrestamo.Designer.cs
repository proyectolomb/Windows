
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
            this.cmbBoxLector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbLector = new System.Windows.Forms.Label();
            this.lbFechaDevolucion = new System.Windows.Forms.Label();
            this.lbFechaDate = new System.Windows.Forms.Label();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAniadir = new Guna.UI2.WinForms.Guna2Button();
            this.cmbBoxLibro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // cmbBoxEjemplar
            // 
            this.cmbBoxEjemplar.BackColor = System.Drawing.Color.Transparent;
            this.cmbBoxEjemplar.BorderRadius = 5;
            this.cmbBoxEjemplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxEjemplar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBoxEjemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxEjemplar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxEjemplar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxEjemplar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBoxEjemplar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBoxEjemplar.ItemHeight = 30;
            this.cmbBoxEjemplar.Location = new System.Drawing.Point(794, 230);
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
            this.lbTitleNuevoPrestamo.Location = new System.Drawing.Point(399, 73);
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
            this.lbEjemplar.Location = new System.Drawing.Point(684, 230);
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
            this.lbLibro.Location = new System.Drawing.Point(195, 230);
            this.lbLibro.Name = "lbLibro";
            this.lbLibro.Size = new System.Drawing.Size(60, 28);
            this.lbLibro.TabIndex = 18;
            this.lbLibro.Text = "Libro";
            // 
            // cmbBoxLector
            // 
            this.cmbBoxLector.BackColor = System.Drawing.Color.Transparent;
            this.cmbBoxLector.BorderRadius = 5;
            this.cmbBoxLector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxLector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBoxLector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxLector.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxLector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxLector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBoxLector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBoxLector.ItemHeight = 30;
            this.cmbBoxLector.Location = new System.Drawing.Point(264, 323);
            this.cmbBoxLector.Name = "cmbBoxLector";
            this.cmbBoxLector.Size = new System.Drawing.Size(313, 36);
            this.cmbBoxLector.TabIndex = 20;
            this.cmbBoxLector.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLector_SelectedIndexChanged);
            // 
            // lbLector
            // 
            this.lbLector.AutoSize = true;
            this.lbLector.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbLector.Location = new System.Drawing.Point(184, 327);
            this.lbLector.Name = "lbLector";
            this.lbLector.Size = new System.Drawing.Size(71, 28);
            this.lbLector.TabIndex = 18;
            this.lbLector.Text = "Lector";
            // 
            // lbFechaDevolucion
            // 
            this.lbFechaDevolucion.AutoSize = true;
            this.lbFechaDevolucion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbFechaDevolucion.Location = new System.Drawing.Point(403, 498);
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
            this.lbFechaDate.Location = new System.Drawing.Point(628, 498);
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
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnLimpiar.Location = new System.Drawing.Point(598, 650);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(153, 44);
            this.btnLimpiar.TabIndex = 22;
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
            this.btnAniadir.Location = new System.Drawing.Point(399, 650);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(161, 44);
            this.btnAniadir.TabIndex = 23;
            this.btnAniadir.Text = "Añadir";
            // 
            // cmbBoxLibro
            // 
            this.cmbBoxLibro.BackColor = System.Drawing.Color.Transparent;
            this.cmbBoxLibro.BorderRadius = 5;
            this.cmbBoxLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxLibro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBoxLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxLibro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxLibro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxLibro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBoxLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBoxLibro.ItemHeight = 30;
            this.cmbBoxLibro.Location = new System.Drawing.Point(264, 230);
            this.cmbBoxLibro.Name = "cmbBoxLibro";
            this.cmbBoxLibro.Size = new System.Drawing.Size(313, 36);
            this.cmbBoxLibro.TabIndex = 24;
            this.cmbBoxLibro.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLibro_SelectedIndexChanged);
            // 
            // NuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1234, 766);
            this.Controls.Add(this.cmbBoxLibro);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.cmbBoxLector);
            this.Controls.Add(this.cmbBoxEjemplar);
            this.Controls.Add(this.lbTitleNuevoPrestamo);
            this.Controls.Add(this.lbEjemplar);
            this.Controls.Add(this.lbLector);
            this.Controls.Add(this.lbFechaDevolucion);
            this.Controls.Add(this.lbFechaDate);
            this.Controls.Add(this.lbLibro);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "NuevoPrestamo";
            this.Text = "NuevoPrestamo";
            this.Load += new System.EventHandler(this.NuevoPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbBoxEjemplar;
        private System.Windows.Forms.Label lbTitleNuevoPrestamo;
        private System.Windows.Forms.Label lbEjemplar;
        private System.Windows.Forms.Label lbLibro;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBoxLector;
        private System.Windows.Forms.Label lbLector;
        private System.Windows.Forms.Label lbFechaDevolucion;
        private System.Windows.Forms.Label lbFechaDate;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnAniadir;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBoxLibro;
    }
}