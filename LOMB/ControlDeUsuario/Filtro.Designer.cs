
namespace LOMB.ControlDeUsuario
{
    partial class Filtro
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFiltros = new System.Windows.Forms.Label();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAplicar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbBoxCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbIsbn = new System.Windows.Forms.Label();
            this.txtBoxAutor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxIsbn = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFiltros
            // 
            this.lbFiltros.AutoSize = true;
            this.lbFiltros.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbFiltros.Location = new System.Drawing.Point(20, 13);
            this.lbFiltros.Name = "lbFiltros";
            this.lbFiltros.Size = new System.Drawing.Size(71, 28);
            this.lbFiltros.TabIndex = 84;
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
            this.btnLimpiar.Location = new System.Drawing.Point(296, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 37);
            this.btnLimpiar.TabIndex = 81;
            this.btnLimpiar.Text = "Limpiar";
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
            this.btnAplicar.Location = new System.Drawing.Point(140, 4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(129, 37);
            this.btnAplicar.TabIndex = 82;
            this.btnAplicar.Text = "Aplicar";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.lbNombre);
            this.guna2Panel1.Controls.Add(this.txtBoxNombre);
            this.guna2Panel1.Controls.Add(this.cmbBoxCategoria);
            this.guna2Panel1.Controls.Add(this.lbCategoria);
            this.guna2Panel1.Controls.Add(this.lbAutor);
            this.guna2Panel1.Controls.Add(this.lbIsbn);
            this.guna2Panel1.Controls.Add(this.txtBoxAutor);
            this.guna2Panel1.Controls.Add(this.txtBoxIsbn);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 47);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(666, 113);
            this.guna2Panel1.TabIndex = 83;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbNombre.Location = new System.Drawing.Point(17, 65);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(89, 28);
            this.lbNombre.TabIndex = 33;
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
            this.txtBoxNombre.Location = new System.Drawing.Point(112, 65);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.PasswordChar = '\0';
            this.txtBoxNombre.PlaceholderText = "";
            this.txtBoxNombre.SelectedText = "";
            this.txtBoxNombre.Size = new System.Drawing.Size(190, 32);
            this.txtBoxNombre.TabIndex = 32;
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
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbAutor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbAutor.Location = new System.Drawing.Point(340, 22);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(66, 28);
            this.lbAutor.TabIndex = 8;
            this.lbAutor.Text = "Autor";
            // 
            // lbIsbn
            // 
            this.lbIsbn.AutoSize = true;
            this.lbIsbn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbIsbn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbIsbn.Location = new System.Drawing.Point(39, 23);
            this.lbIsbn.Name = "lbIsbn";
            this.lbIsbn.Size = new System.Drawing.Size(58, 28);
            this.lbIsbn.TabIndex = 8;
            this.lbIsbn.Text = "ISBN";
            // 
            // txtBoxAutor
            // 
            this.txtBoxAutor.BorderRadius = 5;
            this.txtBoxAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxAutor.DefaultText = "";
            this.txtBoxAutor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxAutor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxAutor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAutor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAutor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAutor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAutor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAutor.Location = new System.Drawing.Point(446, 18);
            this.txtBoxAutor.Name = "txtBoxAutor";
            this.txtBoxAutor.PasswordChar = '\0';
            this.txtBoxAutor.PlaceholderText = "";
            this.txtBoxAutor.SelectedText = "";
            this.txtBoxAutor.Size = new System.Drawing.Size(190, 32);
            this.txtBoxAutor.TabIndex = 6;
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
            this.txtBoxIsbn.Location = new System.Drawing.Point(112, 22);
            this.txtBoxIsbn.Name = "txtBoxIsbn";
            this.txtBoxIsbn.PasswordChar = '\0';
            this.txtBoxIsbn.PlaceholderText = "";
            this.txtBoxIsbn.SelectedText = "";
            this.txtBoxIsbn.Size = new System.Drawing.Size(190, 32);
            this.txtBoxIsbn.TabIndex = 6;
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbFiltros);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Filtro";
            this.Size = new System.Drawing.Size(674, 166);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFiltros;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnAplicar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxNombre;
        public Guna.UI2.WinForms.Guna2ComboBox cmbBoxCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbIsbn;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxAutor;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxIsbn;
    }
}
