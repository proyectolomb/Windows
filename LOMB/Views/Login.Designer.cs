
namespace LOMB.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtBoxUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbContra = new System.Windows.Forms.Label();
            this.txtBoxContra = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIniciarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.btnVerLibros = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbUsuario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbUsuario.Location = new System.Drawing.Point(712, 265);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(84, 28);
            this.lbUsuario.TabIndex = 10;
            this.lbUsuario.Text = "Usuario";
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.BorderRadius = 5;
            this.txtBoxUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxUsuario.DefaultText = "";
            this.txtBoxUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUsuario.Location = new System.Drawing.Point(707, 306);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.PasswordChar = '\0';
            this.txtBoxUsuario.PlaceholderText = "Nombre de usuario...";
            this.txtBoxUsuario.SelectedText = "";
            this.txtBoxUsuario.Size = new System.Drawing.Size(239, 32);
            this.txtBoxUsuario.TabIndex = 9;
            // 
            // lbContra
            // 
            this.lbContra.AutoSize = true;
            this.lbContra.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbContra.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbContra.Location = new System.Drawing.Point(712, 375);
            this.lbContra.Name = "lbContra";
            this.lbContra.Size = new System.Drawing.Size(118, 28);
            this.lbContra.TabIndex = 12;
            this.lbContra.Text = "Contraseña";
            // 
            // txtBoxContra
            // 
            this.txtBoxContra.BorderRadius = 5;
            this.txtBoxContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxContra.DefaultText = "";
            this.txtBoxContra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxContra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxContra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxContra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxContra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxContra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxContra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxContra.Location = new System.Drawing.Point(707, 406);
            this.txtBoxContra.Name = "txtBoxContra";
            this.txtBoxContra.PasswordChar = '\0';
            this.txtBoxContra.PlaceholderText = "Nombre de usuario...";
            this.txtBoxContra.SelectedText = "";
            this.txtBoxContra.Size = new System.Drawing.Size(239, 32);
            this.txtBoxContra.TabIndex = 11;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BorderRadius = 10;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIniciarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIniciarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(737, 471);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(185, 38);
            this.btnIniciarSesion.TabIndex = 31;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            // 
            // btnVerLibros
            // 
            this.btnVerLibros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnVerLibros.BorderRadius = 20;
            this.btnVerLibros.BorderThickness = 2;
            this.btnVerLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerLibros.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerLibros.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerLibros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerLibros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerLibros.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.btnVerLibros.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnVerLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnVerLibros.Location = new System.Drawing.Point(144, 551);
            this.btnVerLibros.Name = "btnVerLibros";
            this.btnVerLibros.Size = new System.Drawing.Size(214, 44);
            this.btnVerLibros.TabIndex = 41;
            this.btnVerLibros.Text = "Ver todos los libros";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.guna2VSeparator1.FillThickness = 3;
            this.guna2VSeparator1.Location = new System.Drawing.Point(482, 7);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(8, 769);
            this.guna2VSeparator1.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 258);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1173, 778);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.btnVerLibros);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lbContra);
            this.Controls.Add(this.txtBoxContra);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txtBoxUsuario);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxUsuario;
        private System.Windows.Forms.Label lbContra;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxContra;
        private Guna.UI2.WinForms.Guna2Button btnIniciarSesion;
        private Guna.UI2.WinForms.Guna2Button btnVerLibros;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}