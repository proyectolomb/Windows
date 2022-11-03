
namespace LOMB.Views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHomePrestamosEnCurso = new System.Windows.Forms.Button();
            this.btnHomeDevolucion = new System.Windows.Forms.Button();
            this.btnHomeNuevoPrestamo = new System.Windows.Forms.Button();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(181)))));
            this.panelHome.Controls.Add(this.btnHomePrestamosEnCurso);
            this.panelHome.Controls.Add(this.btnHomeDevolucion);
            this.panelHome.Controls.Add(this.btnHomeNuevoPrestamo);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.MinimumSize = new System.Drawing.Size(727, 678);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1250, 805);
            this.panelHome.TabIndex = 2;
            // 
            // btnHomePrestamosEnCurso
            // 
            this.btnHomePrestamosEnCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnHomePrestamosEnCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomePrestamosEnCurso.FlatAppearance.BorderSize = 0;
            this.btnHomePrestamosEnCurso.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnHomePrestamosEnCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHomePrestamosEnCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHomePrestamosEnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePrestamosEnCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePrestamosEnCurso.Image")));
            this.btnHomePrestamosEnCurso.Location = new System.Drawing.Point(823, 262);
            this.btnHomePrestamosEnCurso.Name = "btnHomePrestamosEnCurso";
            this.btnHomePrestamosEnCurso.Size = new System.Drawing.Size(236, 241);
            this.btnHomePrestamosEnCurso.TabIndex = 2;
            this.btnHomePrestamosEnCurso.UseVisualStyleBackColor = true;
            this.btnHomePrestamosEnCurso.Click += new System.EventHandler(this.btnHomePrestamosEnCurso_Click);
            // 
            // btnHomeDevolucion
            // 
            this.btnHomeDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnHomeDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeDevolucion.FlatAppearance.BorderSize = 0;
            this.btnHomeDevolucion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnHomeDevolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHomeDevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHomeDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeDevolucion.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeDevolucion.Image")));
            this.btnHomeDevolucion.Location = new System.Drawing.Point(480, 258);
            this.btnHomeDevolucion.Name = "btnHomeDevolucion";
            this.btnHomeDevolucion.Size = new System.Drawing.Size(236, 249);
            this.btnHomeDevolucion.TabIndex = 1;
            this.btnHomeDevolucion.UseVisualStyleBackColor = true;
            this.btnHomeDevolucion.Click += new System.EventHandler(this.btnHomeDevolucion_Click);
            // 
            // btnHomeNuevoPrestamo
            // 
            this.btnHomeNuevoPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnHomeNuevoPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeNuevoPrestamo.FlatAppearance.BorderSize = 0;
            this.btnHomeNuevoPrestamo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnHomeNuevoPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHomeNuevoPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHomeNuevoPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeNuevoPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeNuevoPrestamo.Image")));
            this.btnHomeNuevoPrestamo.Location = new System.Drawing.Point(142, 254);
            this.btnHomeNuevoPrestamo.Name = "btnHomeNuevoPrestamo";
            this.btnHomeNuevoPrestamo.Size = new System.Drawing.Size(236, 256);
            this.btnHomeNuevoPrestamo.TabIndex = 0;
            this.btnHomeNuevoPrestamo.UseVisualStyleBackColor = true;
            this.btnHomeNuevoPrestamo.Click += new System.EventHandler(this.btnHomeNuevoPrestamo_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1250, 805);
            this.Controls.Add(this.panelHome);
            this.Name = "Home";
            this.Text = "Home";
            this.panelHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnHomePrestamosEnCurso;
        private System.Windows.Forms.Button btnHomeDevolucion;
        private System.Windows.Forms.Button btnHomeNuevoPrestamo;
    }
}