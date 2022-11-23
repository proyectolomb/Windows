
namespace LOMB.Views
{
    partial class Devolucion
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
            this.lbDevolucion = new System.Windows.Forms.Label();
            this.lbIntroduce = new System.Windows.Forms.Label();
            this.txtBoxLector = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDevolver = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbDevolucion
            // 
            this.lbDevolucion.AutoSize = true;
            this.lbDevolucion.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbDevolucion.Location = new System.Drawing.Point(440, 80);
            this.lbDevolucion.Name = "lbDevolucion";
            this.lbDevolucion.Size = new System.Drawing.Size(234, 54);
            this.lbDevolucion.TabIndex = 14;
            this.lbDevolucion.Text = "Devolución";
            // 
            // lbIntroduce
            // 
            this.lbIntroduce.AutoSize = true;
            this.lbIntroduce.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntroduce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.lbIntroduce.Location = new System.Drawing.Point(406, 279);
            this.lbIntroduce.Name = "lbIntroduce";
            this.lbIntroduce.Size = new System.Drawing.Size(320, 28);
            this.lbIntroduce.TabIndex = 15;
            this.lbIntroduce.Text = "Introduce el código del ejemplar";
            // 
            // txtBoxLector
            // 
            this.txtBoxLector.BorderRadius = 5;
            this.txtBoxLector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxLector.DefaultText = "";
            this.txtBoxLector.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxLector.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxLector.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxLector.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxLector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxLector.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxLector.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxLector.Location = new System.Drawing.Point(430, 365);
            this.txtBoxLector.Name = "txtBoxLector";
            this.txtBoxLector.PasswordChar = '\0';
            this.txtBoxLector.PlaceholderText = "Código de ejemplar";
            this.txtBoxLector.SelectedText = "";
            this.txtBoxLector.Size = new System.Drawing.Size(254, 32);
            this.txtBoxLector.TabIndex = 16;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BorderRadius = 10;
            this.btnDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDevolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDevolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDevolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDevolver.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(135)))), ((int)(((byte)(71)))));
            this.btnDevolver.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Location = new System.Drawing.Point(493, 449);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(129, 37);
            this.btnDevolver.TabIndex = 17;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1173, 778);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.txtBoxLector);
            this.Controls.Add(this.lbIntroduce);
            this.Controls.Add(this.lbDevolucion);
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDevolucion;
        private System.Windows.Forms.Label lbIntroduce;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxLector;
        private Guna.UI2.WinForms.Guna2Button btnDevolver;
    }
}