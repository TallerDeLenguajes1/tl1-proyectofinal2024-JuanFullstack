namespace ProyectoFinalv2.ControlUsurios
{
    partial class Inicio
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonInicioRegistro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.OIG1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(543, 557);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(245, -128);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(917, 760);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // buttonInicioRegistro
            // 
            buttonInicioRegistro.BackColor = Color.Transparent;
            buttonInicioRegistro.BackgroundImage = Properties.Resources.inicio;
            buttonInicioRegistro.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInicioRegistro.FlatAppearance.BorderSize = 0;
            buttonInicioRegistro.FlatStyle = FlatStyle.Flat;
            buttonInicioRegistro.ForeColor = Color.Transparent;
            buttonInicioRegistro.Location = new Point(646, 179);
            buttonInicioRegistro.Name = "buttonInicioRegistro";
            buttonInicioRegistro.Size = new Size(134, 129);
            buttonInicioRegistro.TabIndex = 3;
            buttonInicioRegistro.UseVisualStyleBackColor = false;
            buttonInicioRegistro.Click += buttonInicioRegistro_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 3, 8);
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(buttonInicioRegistro);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Inicio";
            Size = new Size(930, 556);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonInicioRegistro;
    }
}
