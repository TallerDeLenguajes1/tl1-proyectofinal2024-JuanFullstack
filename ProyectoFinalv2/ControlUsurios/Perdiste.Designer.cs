namespace ProyectoFinalv2.ControlUsurios
{
    partial class Perdiste
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
            labelNombrejugador = new Label();
            labelPuntaje = new Label();
            label1 = new Label();
            button1 = new Button();
            VerPuntaje = new Button();
            buttonVolverCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(178, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(513, 266);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelNombrejugador
            // 
            labelNombrejugador.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelNombrejugador.Location = new Point(215, 338);
            labelNombrejugador.Name = "labelNombrejugador";
            labelNombrejugador.Size = new Size(165, 57);
            labelNombrejugador.TabIndex = 6;
            labelNombrejugador.Text = "label1";
            // 
            // labelPuntaje
            // 
            labelPuntaje.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelPuntaje.Location = new Point(470, 338);
            labelPuntaje.Name = "labelPuntaje";
            labelPuntaje.Size = new Size(126, 57);
            labelPuntaje.TabIndex = 6;
            labelPuntaje.Text = "label1";
            labelPuntaje.Click += labelPuntaje_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(611, 338);
            label1.Name = "label1";
            label1.Size = new Size(172, 58);
            label1.TabIndex = 6;
            label1.Text = "Puntos";
            label1.Click += labelPuntaje_Click;
            // 
            // button1
            // 
            button1.Location = new Point(118, 408);
            button1.Name = "button1";
            button1.Size = new Size(164, 46);
            button1.TabIndex = 7;
            button1.Text = "Volver a Jugar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VerPuntaje
            // 
            VerPuntaje.Location = new Point(358, 408);
            VerPuntaje.Name = "VerPuntaje";
            VerPuntaje.Size = new Size(167, 46);
            VerPuntaje.TabIndex = 8;
            VerPuntaje.Text = "Ver Puntaje";
            VerPuntaje.UseVisualStyleBackColor = true;
            VerPuntaje.Click += VerPuntaje_Click;
            // 
            // buttonVolverCategoria
            // 
            buttonVolverCategoria.Location = new Point(597, 408);
            buttonVolverCategoria.Name = "buttonVolverCategoria";
            buttonVolverCategoria.Size = new Size(150, 46);
            buttonVolverCategoria.TabIndex = 9;
            buttonVolverCategoria.Text = "Cambiar Categoria";
            buttonVolverCategoria.UseVisualStyleBackColor = true;
            buttonVolverCategoria.Click += buttonVolverCategoria_Click;
            // 
            // Perdiste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonVolverCategoria);
            Controls.Add(VerPuntaje);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(labelNombrejugador);
            Controls.Add(label1);
            Controls.Add(labelPuntaje);
            Name = "Perdiste";
            Size = new Size(912, 510);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelNombrejugador;
        private Label labelPuntaje;
        private Label label1;
        private Button button1;
        private Button VerPuntaje;
        private Button buttonVolverCategoria;
    }
}
