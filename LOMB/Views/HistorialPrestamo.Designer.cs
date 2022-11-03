
namespace LOMB.Views
{
    partial class HistorialPrestamo
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
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAplicar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbEjemplar = new System.Windows.Forms.Label();
            this.lbLector = new System.Windows.Forms.Label();
            this.lbLibro = new System.Windows.Forms.Label();
            this.txtBoxCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxLector = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxEjemplar = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxLibro = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbFiltros = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(89, 238);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1014, 516);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ejemplar";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lector";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha de préstamo";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha de devolución";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 300;
            // 
            // btnAplicar
            // 
            this.btnAplicar.BorderRadius = 10;
            this.btnAplicar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAplicar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAplicar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAplicar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAplicar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.btnAplicar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.Location = new System.Drawing.Point(225, 76);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(129, 37);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.Text = "Aplicar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BorderRadius = 10;
            this.btnLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnLimpiar.Location = new System.Drawing.Point(381, 76);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 37);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.lbEjemplar);
            this.guna2Panel1.Controls.Add(this.lbCorreo);
            this.guna2Panel1.Controls.Add(this.lbLector);
            this.guna2Panel1.Controls.Add(this.lbLibro);
            this.guna2Panel1.Controls.Add(this.txtBoxCorreo);
            this.guna2Panel1.Controls.Add(this.txtBoxLector);
            this.guna2Panel1.Controls.Add(this.txtBoxEjemplar);
            this.guna2Panel1.Controls.Add(this.txtBoxLibro);
            this.guna2Panel1.Location = new System.Drawing.Point(89, 119);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(666, 113);
            this.guna2Panel1.TabIndex = 7;
            // 
            // lbEjemplar
            // 
            this.lbEjemplar.AutoSize = true;
            this.lbEjemplar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEjemplar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbEjemplar.Location = new System.Drawing.Point(16, 66);
            this.lbEjemplar.Name = "lbEjemplar";
            this.lbEjemplar.Size = new System.Drawing.Size(95, 28);
            this.lbEjemplar.TabIndex = 8;
            this.lbEjemplar.Text = "Ejemplar";
            // 
            // lbLector
            // 
            this.lbLector.AutoSize = true;
            this.lbLector.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbLector.Location = new System.Drawing.Point(365, 22);
            this.lbLector.Name = "lbLector";
            this.lbLector.Size = new System.Drawing.Size(71, 28);
            this.lbLector.TabIndex = 8;
            this.lbLector.Text = "Lector";
            // 
            // lbLibro
            // 
            this.lbLibro.AutoSize = true;
            this.lbLibro.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbLibro.Location = new System.Drawing.Point(51, 22);
            this.lbLibro.Name = "lbLibro";
            this.lbLibro.Size = new System.Drawing.Size(60, 28);
            this.lbLibro.TabIndex = 8;
            this.lbLibro.Text = "Libro";
            // 
            // txtBoxCorreo
            // 
            this.txtBoxCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxCorreo.DefaultText = "";
            this.txtBoxCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxCorreo.Location = new System.Drawing.Point(446, 66);
            this.txtBoxCorreo.Name = "txtBoxCorreo";
            this.txtBoxCorreo.PasswordChar = '\0';
            this.txtBoxCorreo.PlaceholderText = "";
            this.txtBoxCorreo.SelectedText = "";
            this.txtBoxCorreo.Size = new System.Drawing.Size(190, 32);
            this.txtBoxCorreo.TabIndex = 6;
            // 
            // txtBoxLector
            // 
            this.txtBoxLector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxLector.DefaultText = "";
            this.txtBoxLector.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxLector.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxLector.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxLector.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxLector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxLector.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxLector.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxLector.Location = new System.Drawing.Point(446, 18);
            this.txtBoxLector.Name = "txtBoxLector";
            this.txtBoxLector.PasswordChar = '\0';
            this.txtBoxLector.PlaceholderText = "";
            this.txtBoxLector.SelectedText = "";
            this.txtBoxLector.Size = new System.Drawing.Size(190, 32);
            this.txtBoxLector.TabIndex = 6;
            // 
            // txtBoxEjemplar
            // 
            this.txtBoxEjemplar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEjemplar.DefaultText = "";
            this.txtBoxEjemplar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEjemplar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEjemplar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEjemplar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEjemplar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEjemplar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxEjemplar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEjemplar.Location = new System.Drawing.Point(120, 66);
            this.txtBoxEjemplar.Name = "txtBoxEjemplar";
            this.txtBoxEjemplar.PasswordChar = '\0';
            this.txtBoxEjemplar.PlaceholderText = "";
            this.txtBoxEjemplar.SelectedText = "";
            this.txtBoxEjemplar.Size = new System.Drawing.Size(190, 32);
            this.txtBoxEjemplar.TabIndex = 6;
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
            this.txtBoxLibro.Location = new System.Drawing.Point(120, 18);
            this.txtBoxLibro.Name = "txtBoxLibro";
            this.txtBoxLibro.PasswordChar = '\0';
            this.txtBoxLibro.PlaceholderText = "";
            this.txtBoxLibro.SelectedText = "";
            this.txtBoxLibro.Size = new System.Drawing.Size(190, 32);
            this.txtBoxLibro.TabIndex = 6;
            // 
            // lbFiltros
            // 
            this.lbFiltros.AutoSize = true;
            this.lbFiltros.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbFiltros.Location = new System.Drawing.Point(105, 85);
            this.lbFiltros.Name = "lbFiltros";
            this.lbFiltros.Size = new System.Drawing.Size(71, 28);
            this.lbFiltros.TabIndex = 8;
            this.lbFiltros.Text = "Filtros";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbCorreo.Location = new System.Drawing.Point(361, 66);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(75, 28);
            this.lbCorreo.TabIndex = 8;
            this.lbCorreo.Text = "Correo";
            // 
            // HistorialPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1234, 766);
            this.Controls.Add(this.lbFiltros);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.materialListView1);
            this.Name = "HistorialPrestamo";
            this.Text = "HistorialPrestamo";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2Button btnAplicar;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxCorreo;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxLector;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEjemplar;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxLibro;
        private System.Windows.Forms.Label lbFiltros;
        private System.Windows.Forms.Label lbEjemplar;
        private System.Windows.Forms.Label lbLector;
        private System.Windows.Forms.Label lbLibro;
        private System.Windows.Forms.Label lbCorreo;
    }
}